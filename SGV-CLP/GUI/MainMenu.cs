using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI;
using Siticone.Desktop.UI.WinForms;
using System.Media;

namespace SGV_CLP
{
    public partial class MainMenu : Form
    {
        public static UC_Ventas? uc_ventas;
        public static UC_Settings? uc_settings;
        public MainMenu()
        {
            InitializeComponent();
            uc_ventas = uC_Ventas1;
            uc_settings = uC_Settings1;
            siticoneButton3.Checked = true;
        }

        private async void SiticoneButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Ventas1.BringToFront();
            //To show Last Orders
            uC_Ventas1.ShowLastOrders(UC_Settings.LastOrdersEnabled);
            List<Invoice> registeredInvoices = await InvoiceMapper.GetAllInvoices("");
            uC_Ventas1.FillSalesTable(registeredInvoices);
        }

        private void siticoneButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Clientes1.BringToFront();
        }

        private void siticoneButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Productos1.BringToFront();
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            uC_Settings1.BringToFront();
        }
    }
}
