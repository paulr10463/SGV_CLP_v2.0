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
                //addProductButton.Visible = false;
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

        /*private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (quantityField.Text != string.Empty && quantityField.Text != "0")
            {
                invoiceDetail.soldQuantity = int.Parse(quantityField.Text);
                invoiceDetail.subTotal = Math.Round((double)(invoiceDetail.soldQuantity * _producto.salePrice), 2);
                if (UC_Ventas.ToGo) 
                {
                    UC_Ventas.invoice.AddOrUpdateToGoList(invoiceDetail);
                    addRowInTable(UC_Ventas.toGoDataGridView, invoiceDetail.soldQuantity, _producto);
                    UC_Ventas.toGoDataGridView.Visible = true;
                }
                else
                {
                    UC_Ventas.invoice.AddOrUpdateDineInList(invoiceDetail);
                    addRowInTable(UC_Ventas.dineInDataGridView, invoiceDetail.soldQuantity, _producto);
                } 
                
                UC_Ventas.totalVenta.Visible = true;
                UC_Ventas.totalVenta.Text = "Total : $" + $"{UC_Ventas.invoice.CalculateTotalSales():0.00}".Replace(',', '.');
                quantityField.Text = string.Empty;
            }
        }*/
        public void addRowInTable(SiticoneDataGridView productDetailTable, int cantidad, Product producto)
        {
            bool flag = false;
            //Recorre la tabla de productos en el módulo de ventas
            foreach (DataGridViewRow rowItem in productDetailTable.Rows)
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
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = producto.productName });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = cantidad });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = invoiceDetail.subTotal.ToString().Replace(',', '.') });
                productDetailTable.Rows.Add(row);
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

        private void PlusButton_MouseDown(object sender, MouseEventArgs e)
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
            UpdateValue();
        }

        private void LessButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (quantityField.Text != string.Empty)
            {
                int currentAmountValue = int.Parse(quantityField.Text);
                if (currentAmountValue > 0)
                {
                    quantityField.Text = (currentAmountValue - 1).ToString();
                }
                UpdateValue();
            }
        }

        private void openSubproductsButton_Click(object sender, EventArgs e)
        {
            List<Product> subProductos = ProductMapper.GetProductByParentCode(_producto.productCode);
            ProductSubtype productSubtypeWindow = new ProductSubtype(subProductos);
            productSubtypeWindow.ShowDialog();

        }

        private void UpdateValue()
        {
            if (quantityField.Text != string.Empty && quantityField.Text != "0")
            {
                invoiceDetail.soldQuantity = int.Parse(quantityField.Text);
                invoiceDetail.subTotal = Math.Round((double)(invoiceDetail.soldQuantity * _producto.salePrice), 2);
                if (UC_Ventas.ToGo)
                {
                    UC_Ventas.invoice.AddOrUpdateToGoList(invoiceDetail);
                    addRowInTable(UC_Ventas.toGoDataGridView, invoiceDetail.soldQuantity, _producto);
                    UC_Ventas.toGoDataGridView.Visible = true;
                }
                else
                {
                    UC_Ventas.invoice.AddOrUpdateDineInList(invoiceDetail);
                    addRowInTable(UC_Ventas.dineInDataGridView, invoiceDetail.soldQuantity, _producto);
                }

                UC_Ventas.totalVenta.Visible = true;
                UC_Ventas.totalVenta.Text = "Total : $" + $"{UC_Ventas.invoice.CalculateTotalSales():0.00}".Replace(',', '.');
            }
        }
        private void quantityField_TextChanged(object sender, EventArgs e)
        {
            UpdateValue();
        }
    }
}
