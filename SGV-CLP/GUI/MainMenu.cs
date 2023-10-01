using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI;
using System.Media;

namespace SGV_CLP
{
    public partial class MainMenu : Form
    {
        public static UC_Ventas uc_ventas;
        public MainMenu()
        {
            InitializeComponent();

            uc_ventas = uC_Ventas1;
            /*
            if (user.cargo.Equals("Administrador"))
            {
                uC_Compras1.BringToFront();
                siticoneButton4.Visible = false;
                siticoneButton3.Visible = false;
                siticoneButton6.Visible = false;
            }
            if (user.cargo.Equals("Cajero"))
            {
                uC_Clientes1.BringToFront();
                siticoneButton1.Visible = false;
                siticoneButton5.Visible = false;
                siticoneButton2.Visible = false;

            }*/
        }

        private async void SiticoneButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Ventas1.BringToFront();
            List<Invoice> registeredInvoices = await InvoiceMapper.GetAllInvoices("");
            uC_Ventas1.FillSalesTable(registeredInvoices);
            //uC_Ventas1.LoadProducts();
        }

        private void siticoneButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Clientes1.BringToFront();
        }

        private void siticoneButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Productos1.BringToFront();
        }
    }
}
