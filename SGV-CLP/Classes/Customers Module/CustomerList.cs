using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Customers_Module
{
    public static class CustomerList
    {
        public static List<Customer> customers { get; set; }

        static CustomerList() { 
            customers= new List<Customer>();
        }

        //retorna 0 si se encontro el cliente en la lista
        //retorna 1 si se cambio algun atributo del cliente
        //retorna -1 si no se encontró
        public static int FindExistentCustomer(List<Customer> customerList ,Customer customer)
        {
            foreach(Customer item in customerList)
            {
                if (item.IsEqual(customer))
                   return 0;
                if (item.customerID.Equals(customer.customerID))
                    return 1;  
            }
            return -1;
        }
    }
}
