using SGV_CLP.Classes;
using System.Media;

namespace SGV_CLP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            MainMenu ventana = new()
            {
                Owner = this
            };
            ventana.ShowDialog();
            this.Dispose();
        }
    }
}
