using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Customers_Module
{
    public class Customer
    {
        public string? customerID { get; set; }
        public string? firstName { get; set; }
        public string? MiddleName { get; set; }
        public string? firstLastName { get; set; }
        public string? secondLastName { get; set; }
        public string? homeAddress { get; set; }
        public string? phoneNumber { get; set; }
        public string? eMail { get; set; }

        public Customer()
        {
        }

        public Customer(string customerID, string firstName, string firstLastName, string homeAddress, string phoneNumber, string eMail)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.firstLastName = firstLastName;
            this.homeAddress = homeAddress;
            this.phoneNumber = phoneNumber;
            this.eMail = eMail;
        }

        public bool IsEqual(Customer cliente)
        {
            return this.customerID == cliente.customerID &&
                   this.firstName == cliente.firstName &&
                   this.MiddleName == cliente.MiddleName &&
                   this.firstLastName == cliente.firstLastName &&
                   this.secondLastName == cliente.secondLastName &&
                   this.homeAddress == cliente.homeAddress &&
                   this.phoneNumber == cliente.phoneNumber &&
                   this.eMail == cliente.eMail;
        }
    }
}