using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SGV_CLP.Classes.Sales_Module
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }

        public Category(int id, string categoryName)
        {
            this.id = id;
            this.categoryName = categoryName;
        }

    }
}
