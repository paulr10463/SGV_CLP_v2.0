using SGV_CLP.Classes;
using SGV_CLP.Classes.Módulo_Administración;
using SGV_CLP.GUI.Módulo_Administración;
using SGV_CLP.GUI.Customers_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Customers_Module;

namespace SGV_CLP.GUI
{
    public partial class UC_Administracion : UserControl
    {
        List<Usuario> UsuariosRegistrados = new List<Usuario>();
        List<ParametroPorUnidad> ParamsPURegistrados = new List<ParametroPorUnidad>();
        List<string> NombresProductosRegistrados = ProductMapper.GetProductsNames();

        int count_correct_fields = 0, num_atributos = 6;

        // ###### USUARIO ######

        // Nombre de usuario
        int min_long_nombre_user = 5, max_long_nombre_user = 30;
        bool control_nombre_user = true;

        // CC de usuario
        int max_long_cc = 10;
        bool control_cc = true;

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

        // Validar que el username es único
        bool is_Unique_Username = false;

        // Validar que la cc es única
        bool is_Unique_cc_User = false;

        // ###### PARAMETRO ######

        bool is_valid_BaseValue = false;
        bool is_valid_ExtraValue = false;
        bool product_name_Selected = false;

        public UC_Administracion()
        {
            InitializeComponent();

            siticoneHtmlLabel_correct_length_nombreuser.Hide();
            siticoneHtmlLabel_ccUser_valida.Hide();
            siticoneHtmlLabel_ccUser_correct_length.Hide();
            siticoneHtmlLabel_correct_length_contra.Hide();

            txtAniadirUsername.MaxLength = max_long_nombre_user;
            txtAniadirCCUsuario.MaxLength = max_long_cc;
            txtAniadirContraseniaUsuario.MaxLength = max_long_contra;
            txtAniadirNombre1Usuario.MaxLength = max_long_nombres;
            txtAniadirApellido1Usuario.MaxLength = max_long_apellidos;

            Button_aniadirUsuario.Enabled = false;
            Button_aniadirParamUnid.Enabled = false;

            llenarTablaUsuario();
            llenarTablaParamUnidad();
            LlenarComboBoxesProductos();

            siticoneComboBox_aniadirCargoUsuario.SelectedIndex = 0;
            cBoxProductos_Param.SelectedIndex = 0;

            label_notuniqueUsername.Show();
            label_uniqueUsername.Hide();

            label_notuniqueCC.Show();
            label_uniqueCC.Hide();

            // ----

            is_valid_BaseValue = false;
            is_valid_ExtraValue = false;
            product_name_Selected = false;

            numUpDown_UnidadBase.Value = 0;
            numUpDown_UnidadExtra.Value = 0;

            txt_FiltrarUsuarios.Enabled = false;
            txt_filtrarParametros.Enabled = false;

            label_SinSeleccionFiltroUser.Show();
            label_SinSeleccionFiltroParam.Show();

            // Inicializa Cbox
            this.cBox_OpcionesFiltroUser.SelectedIndex = 0;
            this.cBox_OpcionesFiltrarParam.SelectedIndex = 0;
        }

        public void vaciarCampos()
        {
            txtAniadirUsername.Text = string.Empty;
            txtAniadirCCUsuario.Text = string.Empty;
            txtAniadirContraseniaUsuario.Text = string.Empty;
            txtAniadirNombre1Usuario.Text = string.Empty;
            txtAniadirApellido1Usuario.Text = string.Empty;
            siticoneComboBox_aniadirCargoUsuario.SelectedIndex = 0;
            cBoxProductos_Param.SelectedIndex = 0;

            label_notuniqueUsername.Show();
            label_uniqueUsername.Hide();

            label_notuniqueCC.Show();
            label_uniqueCC.Hide();

            is_Unique_Username = false;
            is_Unique_cc_User = false;

            count_correct_fields = 0;

            numUpDown_UnidadBase.Value = 0;
            numUpDown_UnidadExtra.Value = 0;

            this.cBox_OpcionesFiltroUser.SelectedIndex = 0;
            this.cBox_OpcionesFiltrarParam.SelectedIndex = 0;

            LlenarComboBoxesProductos();

            validateFieldsCounter_Usuario();
            validateFieldsCounter_Param();
        }

        public void llenarTablaUsuario()
        {
            if (UsuariosRegistrados != null)
            {
                SDGVUsuario.Rows.Clear();
                UsuariosRegistrados = UsuarioMapper.ConsultarUsuarios();
                int index = 0;
                foreach (Usuario usuario in UsuariosRegistrados)
                {
                    SDGVUsuario.Rows.Add(usuario.userName, usuario.cc_Usuario, usuario.primer_Nombre + " " + usuario.segundo_Nombre, usuario.primer_Apellido + " " + usuario.segundo_Apellido, usuario.cargo);
                    if (usuario.userName.Equals("DefaultUser"))
                    {
                        SDGVUsuario.Rows[index].Visible = false;
                    }
                    index++;
                }
            }
        }

        public void llenarTablaParamUnidad()
        {
            if (ParamsPURegistrados != null)
            {
                SDGVParamUnidad.Rows.Clear();
                ParamsPURegistrados = ParametroMapper.ConsultarParametros();
                foreach (ParametroPorUnidad param in ParamsPURegistrados)
                {
                    SDGVParamUnidad.Rows.Add(param.IdParametro, param.UnidadBase, param.UnidadExtra, param.Producto);
                }
            }
        }

        public void LlenarComboBoxesProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                cBoxProductos_Param.Items.Clear();
                NombresProductosRegistrados = ProductMapper.GetProductsNames();
                cBoxProductos_Param.Items.Add("Seleccionar...");
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    cBoxProductos_Param.Items.Add(nombreProd);
                }
            }
        }


        /*private void Button_ModificarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Usuario modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

        /*private void Button_EliminarUsuario_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/

        /*private void Burron_ModificarParamPorc_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro modificado con éxito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_EliminarParam_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (MessageBox.Show("¿Desea continuar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                MessageBox.Show("Parámetro eliminado con éxito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        */

        public void controlCedula()
        {
            if (ValidarCedula(txtAniadirCCUsuario.Text))
            {
                siticoneHtmlLabel_ccUser_invalida.Hide();
                siticoneHtmlLabel_ccUser_valida.Show();
            }
            validateFieldsCounter_Usuario();
        }

        private void Button_aniadirParamUnid_Click(object sender, EventArgs e)
        {
            if (!ParametroMapper.parametroExiste(cBoxProductos_Param.Text))
            {
                ParametroMapper.IngresarParametro(
                    new ParametroPorUnidad(
                        "0",
                        numUpDown_UnidadBase.Value.ToString(),
                        numUpDown_UnidadExtra.Value.ToString(),
                        cBoxProductos_Param.Text
                        )
                    );

                MessageBox.Show("Parámetro añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("¡No se admiten 2 promociones en un mismo producto!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            vaciarCampos();
            llenarTablaParamUnidad();
        }

        private void txt_filtrarParametros_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cBox_OpcionesFiltrarParam.SelectedIndex)
            {
                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    break;
                case 2:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        private void cBox_OpcionesFiltrarParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaParamUnidad();
            txt_filtrarParametros.Text = System.String.Empty;
            if (cBox_OpcionesFiltrarParam.SelectedIndex > 0)
            {
                label_SinSeleccionFiltroParam.Hide();
                txt_filtrarParametros.Enabled = true;
            }
            else
            {
                label_SinSeleccionFiltroParam.Show();
                txt_filtrarParametros.Enabled = false;
            }
        }

        private void txt_FiltrarUsuarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cBox_OpcionesFiltroUser.SelectedIndex)
            {
                case 1:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    break;
                case 2:
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 3:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                case 4:
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                        SystemSounds.Beep.Play();
                        MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    break;
                default:
                    break;
            }
        }

        private void cBox_OpcionesFiltroUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaUsuario();
            txt_FiltrarUsuarios.Text = System.String.Empty;
            if (cBox_OpcionesFiltroUser.SelectedIndex > 0)
            {
                label_SinSeleccionFiltroUser.Hide();
                txt_FiltrarUsuarios.Enabled = true;
            }
            else
            {
                label_SinSeleccionFiltroUser.Show();
                txt_FiltrarUsuarios.Enabled = false;
            }
        }

        private void txt_FiltrarUsuarios_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cBox_OpcionesFiltroUser.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = txt_FiltrarUsuarios.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "Nombre de Usuario")
            {
                foreach (DataGridViewRow row in SDGVUsuario.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[0].Value != null && !row.Cells[0].Value.ToString().Equals("DefaultUser"))
                    {
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "CC")
            {
                foreach (DataGridViewRow row in SDGVUsuario.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null && !row.Cells[1].Value.ToString().Equals("0000000000"))
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Nombres")
            {
                foreach (DataGridViewRow row in SDGVUsuario.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[2].Value != null && !row.Cells[0].Value.ToString().Equals("DefaultUser"))
                    {
                        row.Visible = row.Cells[2].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Apellidos")
            {
                foreach (DataGridViewRow row in SDGVUsuario.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[3].Value != null && !row.Cells[0].Value.ToString().Equals("DefaultUser"))
                    {
                        row.Visible = row.Cells[3].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Cargos")
            {
                foreach (DataGridViewRow row in SDGVUsuario.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[4].Value != null && !row.Cells[0].Value.ToString().Equals("DefaultUser"))
                    {
                        row.Visible = row.Cells[4].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
        }

        private void numUpDown_UnidadExtra_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDown_UnidadExtra.Value > 0)
            {
                is_valid_ExtraValue = true;
                label_SinUnidadExtra.Hide();
            }
            else
            {
                is_valid_ExtraValue = false;
                label_SinUnidadExtra.Show();
            }
            validateFieldsCounter_Param();
        }

        private void numUpDown_UnidadBase_ValueChanged(object sender, EventArgs e)
        {
            if (numUpDown_UnidadBase.Value > 0)
            {
                is_valid_BaseValue = true;
                label_SinUnidadBase.Hide();
            }
            else
            {
                is_valid_BaseValue = false;
                label_SinUnidadBase.Show();
            }
            validateFieldsCounter_Param();
        }

        private void txtAniadirApellido1Usuario_TextChanged(object sender, EventArgs e)
        {
            if (txtAniadirApellido1Usuario.Text.Length > 0 && control_apell1)
            {
                control_apell1 = false;
                count_correct_fields++;
            }
            else if (txtAniadirApellido1Usuario.Text.Length == 0 && !control_apell1)
            {
                control_apell1 = true;
                count_correct_fields--;
            }
            validateFieldsCounter_Usuario();
        }

        private void txtAniadirContraseniaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras, números o caracteres especiales!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void cBoxProductos_Param_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxProductos_Param.SelectedIndex > 0)
            {
                laber_SinNombProd.Hide();
                product_name_Selected = true;
            }
            else if (cBoxProductos_Param.SelectedIndex == 0)
            {
                laber_SinNombProd.Show();
                product_name_Selected = false;
            }
            validateFieldsCounter_Param();
        }

        private void txtAniadirApellido1Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txt_filtrarParametros_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cBox_OpcionesFiltrarParam.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = txt_filtrarParametros.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "Unidad Base")
            {
                foreach (DataGridViewRow row in SDGVParamUnidad.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[0].Value != null)
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Unidad Extra")
            {
                foreach (DataGridViewRow row in SDGVParamUnidad.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[2].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Nombre de producto")
            {
                foreach (DataGridViewRow row in SDGVParamUnidad.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null)
                    {
                        row.Visible = row.Cells[3].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
        }

        private void txtAniadirUsername_TextChanged(object sender, EventArgs e)
        {
            //USERNAME
            if (txtAniadirUsername.Text.Length >= min_long_nombre_user && control_nombre_user)
            {
                control_nombre_user = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_nombreuser.Hide();
                siticoneHtmlLabel_correct_length_nombreuser.Show();
            }
            else if (txtAniadirUsername.Text.Length < min_long_nombre_user && !control_nombre_user)
            {
                control_nombre_user = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_nombreuser.Show();
                siticoneHtmlLabel_correct_length_nombreuser.Hide();
            }

            // Valida que el campo no esté vacío
            if (txtAniadirUsername.Text.Length >= 0)
            {
                // Verifica la existencia del username
                if (UsuarioMapper.UsernameExiste(txtAniadirUsername.Text))
                {
                    label_notuniqueUsername.Show();
                    label_uniqueUsername.Hide();
                    is_Unique_Username = false;
                }
                else
                {
                    label_notuniqueUsername.Hide();
                    label_uniqueUsername.Show();
                    is_Unique_Username = true;
                }
            }
            else
            {
                is_Unique_Username = false;
            }
            validateFieldsCounter_Usuario();
        }

        private void txtAniadirNombre1Usuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente letras o números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void siticoneComboBox_aniadirCargoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneComboBox_aniadirCargoUsuario.SelectedIndex > 0 && control_cargo)
            {
                Label_sinCampoCargoUsuario.Hide();
                control_cargo = false;
                count_correct_fields++;
            }
            else if (siticoneComboBox_aniadirCargoUsuario.SelectedIndex == 0 && !control_cargo)
            {
                Label_sinCampoCargoUsuario.Show();
                control_cargo = true;
                count_correct_fields--;
            }
            validateFieldsCounter_Usuario();
        }

        private void SDGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SDGVUsuario.Columns[e.ColumnIndex].Name == "ColumnaEliminarUsuario")
                {
                    if (e.RowIndex >= 0 && SDGVUsuario.Rows[e.RowIndex].Cells[1].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string cc_Usuario = SDGVUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                            UsuarioMapper.EliminarUsuario(cc_Usuario);
                            MessageBox.Show("Usuario eliminado con éxito", "Eliminar");
                        }
                    }
                }

                if (SDGVUsuario.Columns[e.ColumnIndex].Name == "ColumnaEditarUsuario")
                {
                    if (e.RowIndex >= 0)
                    {
                        string cc_Usuario = SDGVUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Editar_Usuario ventana = new Editar_Usuario(cc_Usuario);
                        ventana.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }

            llenarTablaUsuario();
        }

        private void txtAniadirCCUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            controlCedula();
        }

        private void txtAniadirContraseniaUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtAniadirContraseniaUsuario.Text.Length >= min_long_contra && control_contra)
            {
                control_contra = false;
                count_correct_fields++;
                siticoneHtmlLabel_wrong_length_contra.Hide();
                siticoneHtmlLabel_correct_length_contra.Show();
            }
            else if (txtAniadirContraseniaUsuario.Text.Length < min_long_contra && !control_contra)
            {
                control_contra = true;
                count_correct_fields--;
                siticoneHtmlLabel_wrong_length_contra.Show();
                siticoneHtmlLabel_correct_length_contra.Hide();
            }
            validateFieldsCounter_Usuario();
        }

        private void txtAniadirCCUsuario_TextChanged(object sender, EventArgs e)
        {
            // comprueba que la cc == 10 y muesta mensaje de correcto
            if (txtAniadirCCUsuario.Text.Length == max_long_cc && control_cc)
            {
                control_cc = false;
                count_correct_fields++;
                siticoneHtmlLabel_ccUser_wrong_length.Hide();

                siticoneHtmlLabel_ccUser_correct_length.Show();
            }
            else if (txtAniadirCCUsuario.Text.Length < max_long_cc && !control_cc)
            {
                // Borro 1 char de la cc teniendo ya completos los 10 previamente
                control_cc = true;
                count_correct_fields--;

                siticoneHtmlLabel_ccUser_correct_length.Hide();
                siticoneHtmlLabel_ccUser_wrong_length.Show();

                siticoneHtmlLabel_ccUser_valida.Hide();
                siticoneHtmlLabel_ccUser_invalida.Show();
            }

            if (txtAniadirCCUsuario.Text.Length == max_long_cc)
            {
                // Verifica la existencia del ID
                if (UsuarioMapper.ccUserExiste(txtAniadirCCUsuario.Text))
                {
                    label_notuniqueCC.Show();
                    label_uniqueCC.Hide();
                    is_Unique_cc_User = false;
                }
                else
                {
                    label_notuniqueCC.Hide();
                    label_uniqueCC.Show();
                    is_Unique_cc_User = true;
                }
            }
            else
            {
                is_Unique_cc_User = false;
            }

            validateFieldsCounter_Usuario();
        }

        private void SDGVParamUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SDGVParamUnidad.Columns[e.ColumnIndex].Name == "ColumnaEliminarParUn")
                {
                    if (e.RowIndex >= 0 && SDGVParamUnidad.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este parámetro?", "Eliminar parámetro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string idParam = SDGVParamUnidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                            ParametroMapper.EliminarParametro(idParam);
                            MessageBox.Show("Parámetro eliminado con éxito", "Eliminar");
                        }
                    }
                }

                if (SDGVParamUnidad.Columns[e.ColumnIndex].Name == "ColumnaEditarParUn")
                {
                    if (e.RowIndex >= 0)
                    {
                        string idParam = SDGVParamUnidad.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Editar_Parametro_Por_Unidad ventana = new Editar_Parametro_Por_Unidad(idParam);
                        ventana.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }

            llenarTablaParamUnidad();
        }

        private void txtAniadirCCUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Ingrese únicamente números!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Button_aniadirUsuario_Click(object sender, EventArgs e)
        {
            UsuarioMapper.IngresarUsuario(new Usuario(txtAniadirCCUsuario.Text,
            txtAniadirUsername.Text,
            txtAniadirContraseniaUsuario.Text,
            txtAniadirNombre1Usuario.Text,
            txtAniadirApellido1Usuario.Text,
            siticoneComboBox_aniadirCargoUsuario.Text));

            MessageBox.Show("Usuario añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            vaciarCampos();
            llenarTablaUsuario();
        }

        private void validateFieldsCounter_Usuario()
        {
            Button_aniadirUsuario.Enabled = count_correct_fields >= num_atributos && ValidarCedula(txtAniadirCCUsuario.Text) && is_Unique_Username == true && is_Unique_cc_User == true;
        }

        private void validateFieldsCounter_Param()
        {
            Button_aniadirParamUnid.Enabled = is_valid_BaseValue && is_valid_ExtraValue && product_name_Selected;
        }

        public static bool ValidarCedula(string cedula)
        {
            // Verificar que la cédula tenga 10 dígitos
            if (cedula.Length != 10)
            {
                return false;
            }

            int tercerDigito = int.Parse(cedula[2].ToString());

            // Verificar que el tercer dígito sea entre 0 y 5
            if (tercerDigito < 0 || tercerDigito > 5)
            {
                return false;
            }

            // Verificar el último dígito de la cédula
            int ultimoDigito = int.Parse(cedula[9].ToString());

            int suma = 0;

            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(cedula[i].ToString());

                if (i % 2 == 0)
                {
                    digito *= 2;

                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }

                suma += digito;
            }

            int digitoVerificador = 10 - (suma % 10);

            if (digitoVerificador == 10)
            {
                digitoVerificador = 0;
            }

            return ultimoDigito == digitoVerificador;
        }
    }
}
