using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class ShowDetailInvoice : Form
    {
        public ShowDetailInvoice(Invoice invoice)
        {
            InitializeComponent();
            ccLabel.Text = invoice.customer?.customerID;
            phoneLabel.Text = invoice.customer?.phoneNumber;
            nameLabel.Text = invoice.customer?.firstName + " " + invoice.customer?.firstLastName;
            dateLabel.Text = invoice.issuedDate.ToString();
            CodNotaVentaLabel.Text = "Nota de venta N°: " + invoice.invoiceCode.ToString();
            TotalLabel.Text = "Total: $" + invoice.totalSales.ToString();
            //Show every Detail Product in table
            var totalDetailList = InvoiceDetailMapper.GetAllInvoiceDetails(invoice.invoiceCode);

            foreach (InvoiceDetail invoiceDetail in totalDetailList)
            {
                DataGridViewRow row = (DataGridViewRow)siticoneDataGridView1.Rows[0].Clone();
                row.Cells[0].Value = invoiceDetail.isToGo ? "LL-" + invoiceDetail.product?.productName : invoiceDetail.product?.productName;
                row.Cells[1].Value = invoiceDetail.soldQuantity;
                row.Cells[2].Value = Math.Round((decimal)invoiceDetail.subTotal, 2).ToString().Replace(',', '.');
                siticoneDataGridView1.Rows.Add(row);
            }
        }
    }
}
