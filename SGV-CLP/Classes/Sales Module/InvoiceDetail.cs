using SGV_CLP.Classes.Products_module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Sales_Module
{
    public class InvoiceDetail
    {
        public int? detailNumber { get; set; }
        public int? invoiceCode { get; set; }
        public int soldQuantity { get; set; }
        public double? subTotal { get; set; }
        public Product? product  { get; set; }

        public InvoiceDetail(int? detailNumber, int? invoiceCode, Product? product)
        {
            this.detailNumber = detailNumber;
            this.invoiceCode = invoiceCode;
            this.soldQuantity = soldQuantity;
            this.subTotal = subTotal;
            this.product = product;
        }

        public InvoiceDetail(string productName, int soldQuantity, double subTotal)
        {
            this.soldQuantity = soldQuantity;
            this.subTotal = subTotal;
            this.product = new Product(productName , string.Empty);
        }

        public InvoiceDetail()
        {
            this.soldQuantity = 0;
            this.subTotal = 0;
        }

    }
}
