using SGV_CLP.Classes;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Products_module;
using Siticone.Desktop.UI.WinForms;

namespace SGV_CLP.GUI.Módulo_Ventas
{
    public partial class UC_Item : UserControl
    {
        public InvoiceDetail invoiceDetail;
        Product _producto;
        public UC_Item(Product producto)
        {
            invoiceDetail = new InvoiceDetail
            {
                product = producto
            };
            _producto = producto;
            InitializeComponent();

            if (_producto.salePrice == null)
            {
                lessButton.Visible = false;
                quantityField.Visible = false;
                plusButton.Visible = false;
                addProductButton.Visible = false;
                openSubproductsButton.Visible = true;
            }


            //En caso de coger la imagen a través de una ruta en la compu
            try
            {
                Image myImage = Image.FromFile(Path.Combine(Application.StartupPath, producto.imagePath));
                this.siticonePictureBox1.Image = myImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            this.label1.Text = producto.productName;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (quantityField.Text != string.Empty && quantityField.Text != "0")
            {
                invoiceDetail.soldQuantity = int.Parse(quantityField.Text);
                invoiceDetail.subTotal = Math.Round((double)(invoiceDetail.soldQuantity * _producto.salePrice), 2);
                UC_Ventas.invoice.AddOrUpdateInvoiceDetail(invoiceDetail);
                addRowInTable(invoiceDetail.soldQuantity, _producto);
                UC_Ventas.totalVenta.Visible = true;
                UC_Ventas.totalVenta.Text = "Total: $" + (Math.Round((decimal)UC_Ventas.invoice.CalculateTotalSales(), 2)).ToString().Replace(',', '.');
            }
        }
        public void addRowInTable(int cantidad, Product producto)
        {
            bool flag = false;
            //Recorre la tabla de productos en el módulo de ventas
            foreach (DataGridViewRow rowItem in UC_Ventas.detalleVentaTabla.Rows)
            {
                //Verifica que ya exista una fila con ese producto
                if (rowItem.Cells[0].Value != null)
                {
                    //Encuentra la fila del producto que se está modificando 
                    if (rowItem.Cells[0].Value.Equals(producto.productName))
                    {
                        //Actualizar la cantidad del producto
                        rowItem.Cells[1].Value = cantidad;
                        rowItem.Cells[2].Value = invoiceDetail.subTotal.ToString().Replace(',', '.');
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
            }
            //En caso de no existir la fila del producto, la crea
            if (!flag)
            {
                DataGridViewRow row = (DataGridViewRow)UC_Ventas.detalleVentaTabla.Rows[0].Clone();
                row.Cells[0].Value = producto.productName;
                row.Cells[1].Value = cantidad;
                row.Cells[2].Value = invoiceDetail.subTotal.ToString().Replace(',', '.');
                UC_Ventas.detalleVentaTabla.Rows.Add(row);
            }

        }

        public void resetComponents()
        {
            quantityField.Text = string.Empty;
            invoiceDetail.soldQuantity = 0;
        }
        private void quantityField_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDigitsValidation(e);
        }

        private void plusButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (quantityField.Text == string.Empty)
            {
                quantityField.Text = "1";
            }
            else
            {
                try
                {
                    quantityField.Text = (int.Parse(quantityField.Text) + 1).ToString();
                }
                catch (Exception exception)
                {
                    string message = exception.Message;
                    Console.WriteLine(message);
                }
            }
        }

        private void lessButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (quantityField.Text != string.Empty)
            {
                int currentAmountValue = int.Parse(quantityField.Text);
                if (currentAmountValue > 0)
                {
                    quantityField.Text = (currentAmountValue - 1).ToString();
                }
            }
        }

        private void openSubproductsButton_Click(object sender, EventArgs e)
        {
            List <Product> subProductos = ProductMapper.GetProductByParentCode(_producto.productCode);
            ProductSubtype productSubtypeWindow = new ProductSubtype(subProductos);
            productSubtypeWindow.ShowDialog();

        }
    }
}
