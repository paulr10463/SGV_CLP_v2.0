namespace SGV_CLP.Classes.Products_module
{
    public class Product
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string imagePath { get; set; }
        public string categoryName { get; set; }
        public int categoryID { get; set; }
        public double? salePrice { get; set; } // sales price to the public = S.P.P
        public string? parentCode { get; set; }

        // Para crear un producto nuevo
        public Product(string productName, string imagePath)
        {
            this.productName = productName;
            this.imagePath = imagePath;
        }

        public Product(string productCode, string productName, double? salePrice, string category, string imagePath)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.salePrice = salePrice;
            this.categoryName = category;
            this.imagePath = imagePath;
            
        }

        // Para obtener de base de datos
        public Product(string productCode, string productName, double? salePrice, string imagePath, string? parentCode, string categoryName)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.salePrice = salePrice;
            this.categoryName = categoryName;
            this.imagePath = imagePath;
            this.parentCode = parentCode;
        }

        // Para obtener de base de datos
        public Product(string productCode, string productName, double? salePrice, string imagePath, string? parentCode, int categoryID)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.salePrice = salePrice;
            this.categoryID = categoryID;
            this.imagePath = imagePath;
            this.parentCode = parentCode;
        }
    }
}
