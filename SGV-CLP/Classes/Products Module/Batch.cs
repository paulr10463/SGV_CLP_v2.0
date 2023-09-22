using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Products_module
{
    public class Batch
    {
        public string? batchCode { get; set; }
        public string? productCode { get; set; }
        public int? quantity { get; set; }
        public DateTime? manufactureDate { get; set; }

        public Batch(string batchCode, string productCode, int quantity, DateTime manufactureDate)
        {
            this.batchCode = batchCode;
            this.productCode = productCode;
            this.quantity = quantity;
            this.manufactureDate = manufactureDate;
        }
    }
}