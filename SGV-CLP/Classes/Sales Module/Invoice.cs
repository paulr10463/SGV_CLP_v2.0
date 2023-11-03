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
        public int tableNumber;
        public List<InvoiceDetail> dineInDetailList;
        public List<InvoiceDetail>? toGoDetailList;
        public Customer? customer;
        public double totalSales;
        public DateTime? issuedDate; // Fecha de emisión
        public int invoiceCode;

        public Invoice(int invoiceCode, Customer customer, double totalSales, DateTime issuedDate)
        {
            this.invoiceCode = invoiceCode;
            this.dineInDetailList = new List<InvoiceDetail>();
            this.customer = customer;
            this.totalSales = totalSales;
            this.issuedDate = issuedDate;
        }

        //Constructor getter BD
        public Invoice(int invoiceCode, string customerID, double totalSales, DateTime issuedDate)
        {
            this.invoiceCode = invoiceCode;
            this.dineInDetailList = new List<InvoiceDetail>();
            this.customer = new Customer();
            this.customer.customerID = customerID;
            this.totalSales = totalSales;
            this.issuedDate = issuedDate;
        }
        public Invoice(int tableNumber, List<InvoiceDetail> dineInDetailList, List<InvoiceDetail>? toGoDetailList, Customer? customer, double totalSales, DateTime? issuedDate, int invoiceCode)
        {
            this.tableNumber = tableNumber;
            this.dineInDetailList = dineInDetailList;
            this.toGoDetailList = toGoDetailList;
            this.customer = customer;
            this.totalSales = totalSales;
            this.issuedDate = issuedDate;
            this.invoiceCode = invoiceCode;
        }
        public Invoice()
        {
            dineInDetailList = new List<InvoiceDetail>();
            totalSales = 0;
        }

        public double? CalculateTotalSales()
        {
            double? total = 0;
            foreach (InvoiceDetail item in dineInDetailList)
            {
                total += item.subTotal;
            }
            if (toGoDetailList != null)
            {
                foreach (InvoiceDetail item in toGoDetailList)
                {
                    total += item.subTotal;
                }
            }
            totalSales = Math.Round((double)total, 2);
            return total;
        }

        public void AddOrUpdateDineInList(InvoiceDetail invoiceDetail)
        {
            AddOrUpdateInvoiceDetail(dineInDetailList, invoiceDetail);
        }

        public void AddOrUpdateToGoList(InvoiceDetail invoiceDetail)
        {
            if (toGoDetailList == null)
            {
                toGoDetailList = new List<InvoiceDetail>();
            }
            AddOrUpdateInvoiceDetail(toGoDetailList, invoiceDetail);
        }
        public void AddOrUpdateInvoiceDetail(List<InvoiceDetail> detailList, InvoiceDetail invoiceDetail)
        {
            bool flag = false;
            int counter = 0;
            foreach (InvoiceDetail item in detailList)
            {
                if (item.product != null)
                {
                    if (item.product.productName.Equals(invoiceDetail?.product?.productName))
                    {
                        detailList[counter].soldQuantity = invoiceDetail.soldQuantity;
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
                detailList.Add(invoiceDetail);
            }
        }

        public void DeleteDineInDetailbyProductName(string productName)
        {
            for (int i = 0; i < dineInDetailList.Count; i++)
            {
                if (dineInDetailList[i].product.productName.Equals(productName))
                {
                    dineInDetailList.RemoveAt(i);
                }
            }
        }
        public void DeleteToGoDetailbyProductName(string productName)
        {
            for (int i = 0; i < toGoDetailList?.Count; i++)
            {
                if (toGoDetailList[i].product.productName.Equals(productName))
                {
                    toGoDetailList.RemoveAt(i);
                }
            }
        }

        public void SetInvoiceDetail(int codNotaVenta)
        {
            for (int i = 0; i < dineInDetailList.Count; i++)
            {
                dineInDetailList[i].invoiceCode = codNotaVenta;
                dineInDetailList[i].detailNumber = i + 1;
                dineInDetailList[i].isToGo = false;
            }
            var lastIndex = dineInDetailList.Count;
            for (int i = 0; i < toGoDetailList?.Count; i++)
            {
                toGoDetailList[i].detailNumber = i + lastIndex + 1;
                toGoDetailList[i].invoiceCode = codNotaVenta;
                toGoDetailList[i].isToGo = true;
            }
        }
    }
}
