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
            buttonEditCustomer.Text = "Mesa N° 2";
            nameLabel.Text = invoice.customer?.firstName;
            _invoice = invoice;
        }

        private void openSubproductsButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Diste CLICK");
                ShowDetailInvoice showDetailInvoice = new ShowDetailInvoice(
                InvoiceDetailMapper.GetAllInvoiceDetails(_invoice.invoiceCode),
                _invoice.customer.customerID,
                _invoice.customer.firstName + " " + _invoice.customer.firstLastName,
                _invoice.customer.phoneNumber,
                _invoice.issuedDate.Value.ToString("dd-MM-yyyy"),
                _invoice.totalSales,
                _invoice.invoiceCode
                );
                showDetailInvoice.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDetailInvoice showDetailInvoice = new ShowDetailInvoice(
                InvoiceDetailMapper.GetAllInvoiceDetails(_invoice.invoiceCode),
                _invoice.customer.customerID,
                _invoice.customer.firstName + " " + _invoice.customer.firstLastName,
                _invoice.customer.phoneNumber,
                _invoice.issuedDate.Value.ToString("dd-MM-yyyy"),
                _invoice.totalSales,
                _invoice.invoiceCode
                );
                showDetailInvoice.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
