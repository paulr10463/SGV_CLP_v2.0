using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SGV_CLP.Classes.Sales_Module
{
    public class Invoice
    {
        public List<InvoiceDetail> invoiceDetailList;
        public Customer? customer;
        public double totalSales;
        public DateTime? issuedDate; // Fecha de emisión
        public int invoiceCode;

        public Invoice(int invoiceCode, Customer customer, double totalSales, DateTime issuedDate)
        {
            this.invoiceCode = invoiceCode;
            this.invoiceDetailList = new List<InvoiceDetail>();
            this.customer = customer;
            this.totalSales = totalSales;
            this.issuedDate = issuedDate;
        }

        //Constructor getter BD
        public Invoice(int invoiceCode, string customerID,  double totalSales, DateTime issuedDate)
        {
            this.invoiceCode = invoiceCode;
            this.invoiceDetailList = new List<InvoiceDetail>();
            this.customer = new Customer();
            this.customer.customerID = customerID;
            this.totalSales = totalSales;
            this.issuedDate = issuedDate;
        }

        public Invoice()
        {
            this.invoiceDetailList = new List<InvoiceDetail>();
            totalSales = 0;
        }

        public double? CalculateTotalSales()
        {
            double? total = 0;
            foreach (InvoiceDetail item in invoiceDetailList)
            {
                total += item.subTotal;
            }
            this.totalSales = (double)total;
            return total;
        }
        public void setTotalSales()
        {
            this.totalSales = (double)CalculateTotalSales();
        }
        public void AddOrUpdateInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            bool flag = false;
            int counter = 0;
            foreach (InvoiceDetail item in invoiceDetailList)
            {
                if (item.product != null)
                {
                    if (item.product.productName.Equals(invoiceDetail.product.productName))
                    {
                        invoiceDetailList[counter].soldQuantity = invoiceDetail.soldQuantity;
                        CalculateTotalSales();
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
            if (!flag)
            {
                invoiceDetailList.Add(invoiceDetail);
            }
        }

        public void DeleteInvoiceDetailbyProductName(string productName)
        {
            for(int i = 0; i < invoiceDetailList.Count; i++)
            {
                if (invoiceDetailList[i].product.productName.Equals(productName))
                {
                    invoiceDetailList.RemoveAt(i);
                }
            }
        }
        public void SetInvoiceDetail(int codNotaVenta)
        {
            for(int i = 0; i < invoiceDetailList.Count; i++)
            {
                invoiceDetailList[i].invoiceCode = codNotaVenta;
                invoiceDetailList[i].detailNumber = i+1;
            }
        }
    }
}
