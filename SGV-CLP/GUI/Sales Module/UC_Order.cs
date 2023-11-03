using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Products_module;
using Siticone.Desktop.UI.WinForms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class UC_Order : UserControl
    {
        public Invoice _invoice;
        public UC_Order(Invoice invoice)
        {
            InitializeComponent();

            showDetailDialogButton.Text = "Orden:" + invoice.invoiceCode.ToString();
            nameLabel.Text = invoice.customer?.firstName + " " + invoice.customer?.firstLastName;
            _invoice = invoice;
        }
        private void showDetailDialogButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDetailInvoice showDetailInvoice = new(_invoice);
                showDetailInvoice.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
