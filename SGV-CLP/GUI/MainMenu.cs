using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI;
using Siticone.Desktop.UI.WinForms;
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
            siticoneButton3.Checked = true;
        }

        private async void SiticoneButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            uC_Ventas1.BringToFront();
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
    }
}
