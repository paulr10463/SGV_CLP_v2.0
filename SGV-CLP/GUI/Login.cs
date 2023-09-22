using SGV_CLP.Classes;
using SGV_CLP.Classes.Módulo_Administración;
using System.Media;

namespace SGV_CLP
{
    public partial class Login : Form
    {
        public static Usuario user1;
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click_1(object sender, EventArgs e)
        {
            var user = UsuarioMapper.getUser(siticoneTextBox1.Text, siticoneTextBox2.Text);
            if (user != null)
            {
                this.Hide();
                MainMenu ventana = new MainMenu(user);
                ventana.Owner = this;
                ventana.ShowDialog();
                this.Dispose();

            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Credenciales erróneas. Intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

    }
}
