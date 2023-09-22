using SGV_CLP.Classes.Módulo_Administración;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Administración
{
    public partial class Editar_Usuario : Form
    {

        int count_correct_fields = 0, num_atributos = 4;
        string cc_Usuario;

        // Nombre de usuario
        int min_long_nombre_user = 5, max_long_nombre_user = 30;
        bool control_nombre_user = true;

        // Contraseña
        int min_long_contra = 10, max_long_contra = 30;
        bool control_contra = true;

        // Nombres
        int max_long_nombres = 50;
        bool control_nombre1 = true, control_nombre2 = true;

        // Apellidos
        int max_long_apellidos = 50;
        bool control_apell1 = true, control_apell2 = true;

        // Cargo
        bool control_cargo = true;

        public Editar_Usuario(string cc_Usuario)
        {
            InitializeComponent();

            this.cc_Usuario = cc_Usuario;
            llenarCampos();

            txt_editarUsername.SelectionStart = txt_editarUsername.Text.Length;
            txt_EditarPassword.SelectionStart = txt_EditarPassword.Text.Length;
            txt_EditarNombre1.SelectionStart = txt_EditarNombre1.Text.Length;
            txt_EditarApell1.SelectionStart = txt_EditarApell1.Text.Length;

            SBAceptar.Enabled = false;

            txt_editarUsername.MaxLength = max_long_nombre_user;
            txt_EditarPassword.MaxLength = max_long_contra;
            txt_EditarNombre1.MaxLength = max_long_nombres;
            txt_EditarApell1.MaxLength = max_long_apellidos;

            siticoneHtmlLabel_wrong_length_nombreuser.Hide();
            siticoneHtmlLabel_correct_length_nombreuser.Show();
            siticoneHtmlLabel_wrong_length_contra.Hide();
            siticoneHtmlLabel_correct_length_contra.Show();

            validacionInicial();
        }

        public void validacionInicial()
        {
            if (txt_editarUsername.Text.Length >= min_long_nombre_user && control_nombre_user)
            {
                control_nombre_user = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_nombreuser.Hide();
                siticoneHtmlLabel_correct_length_nombreuser.Show();
            }
            else if (txt_editarUsername.Text.Length < min_long_nombre_user && !control_nombre_user)
            {
                control_nombre_user = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_nombreuser.Show();
                siticoneHtmlLabel_correct_length_nombreuser.Hide();
            }

            //

            if (txt_EditarPassword.Text.Length >= min_long_contra && control_contra)
            {
                control_contra = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_contra.Hide();
                siticoneHtmlLabel_correct_length_contra.Show();
            }
            else if (txt_EditarPassword.Text.Length < min_long_contra && !control_contra)
            {
                control_contra = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_contra.Show();
                siticoneHtmlLabel_correct_length_contra.Hide();
            }
            //

            if (txt_EditarNombre1.Text.Length > 0 && control_nombre1)
            {
                control_nombre1 = false;
                count_correct_fields++;
            }
            else if (txt_EditarNombre1.Text.Length == 0 && !control_nombre1)
            {
                control_nombre1 = true;
                count_correct_fields--;
            }

            //

            if (txt_EditarApell1.Text.Length > 0 && control_apell1)
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txt_EditarApell1.Text.Length == 0 && !control_apell1)
            {
                control_apell1 = true;
                count_correct_fields--;
            }

            validateFieldsCounter_Usuario();
        }

        public void llenarCampos()
        {
            this.txt_editarUsername.Text = UsuarioMapper.ConsultarAtributoUsuario(cc_Usuario, "userName");
            this.txt_EditarPassword.Text = UsuarioMapper.ConsultarAtributoUsuario(cc_Usuario, "contrasenia");
            this.txt_EditarNombre1.Text = UsuarioMapper.ConsultarAtributoUsuario(cc_Usuario, "primer_Nombre");
            this.txt_EditarApell1.Text = UsuarioMapper.ConsultarAtributoUsuario(cc_Usuario, "primer_Apellido");
            string cargo = UsuarioMapper.ConsultarAtributoUsuario(cc_Usuario, "cargo");
            cargo = cargo.Trim();
            this.cBox_EditarCargo.SelectedItem = cargo;
        }

        private void SBAceptar_Click(object sender, EventArgs e)
        {
            UsuarioMapper.EditarUsuario(this.cc_Usuario, this.txt_editarUsername.Text, this.txt_EditarPassword.Text, this.txt_EditarNombre1.Text,
            this.txt_EditarApell1.Text, this.cBox_EditarCargo.SelectedItem.ToString());
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario editado con éxito", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.count_correct_fields = 0;
            this.Dispose();
        }

        private void txt_EditarApell1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txt_EditarNombre1_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditarNombre1.Text.Length > 0 && control_nombre1)
            {
                control_nombre1 = false;
                count_correct_fields++;
            }
            else if (txt_EditarNombre1.Text.Length == 0 && !control_nombre1)
            {
                control_nombre1 = true;
                count_correct_fields--;
            }
        }

        private void txt_EditarNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txt_EditarPassword_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditarPassword.Text.Length >= min_long_contra && control_contra)
            {
                control_contra = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_contra.Hide();
                siticoneHtmlLabel_correct_length_contra.Show();
            }
            else if (txt_EditarPassword.Text.Length < min_long_contra && !control_contra)
            {
                control_contra = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_contra.Show();
                siticoneHtmlLabel_correct_length_contra.Hide();
            }
            validateFieldsCounter_Usuario();
        }

        private void txt_EditarApell1_TextChanged(object sender, EventArgs e)
        {
            if (txt_EditarApell1.Text.Length > 0 && control_apell1)
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txt_EditarApell1.Text.Length == 0 && !control_apell1)
            {
                control_apell1 = true;
                count_correct_fields--;
            }
            validateFieldsCounter_Usuario();
        }

        private void txt_EditarPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números o caracteres especiales!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txt_editarUsername_TextChanged(object sender, EventArgs e)
        {
            //USERNAME

            if (txt_editarUsername.Text.Length >= min_long_nombre_user && control_nombre_user)
            {
                control_nombre_user = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_nombreuser.Hide();
                siticoneHtmlLabel_correct_length_nombreuser.Show();
            }
            else if (txt_editarUsername.Text.Length < min_long_nombre_user && !control_nombre_user)
            {
                control_nombre_user = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_nombreuser.Show();
                siticoneHtmlLabel_correct_length_nombreuser.Hide();
            }

            validateFieldsCounter_Usuario();
        }

        private void txt_editarUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void SBCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void validateFieldsCounter_Usuario()
        {
            SBAceptar.Enabled = count_correct_fields >= num_atributos;
        }
    }
}
