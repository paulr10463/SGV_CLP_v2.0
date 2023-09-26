using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI.Módulo_Ventas;
using Siticone.Desktop.UI.WinForms;
using System.Media;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        List<Product> products;
        List<Product> specialties;
        List<Product> hotDrinks;
        List<Product> coldDrinks;
        List<Product> empanadas;
        public static Invoice invoice;
        public static SiticoneDataGridView detalleVentaTabla;
        public static SiticoneHtmlLabel totalVenta;
        public static List<UC_Item> productosUI = new List<UC_Item>();
        public string Categoria = string.Empty;
        public UC_Ventas()
        {
            invoice = new Invoice();

            InitializeComponent();
            detalleVentaTabla = siticoneDataGridView2;
            totalVenta = siticoneHtmlLabel11;
            dateTimePickerConsultarVenta.Visible = false;
            txtConsultarVenta.Enabled = false;
            ComboBox_ConsultarVentaPor.SelectedIndex = 0;
            loadProducts();

        }


        public void loadProducts()
        {
            products = ProductMapper.GetAllProduct();
            specialties = new List<Product>();
            hotDrinks = new List<Product>();
            coldDrinks = new List<Product>();
            empanadas = new List<Product>();
            ClassifyProducts();
            ShowProducts(specialties, flowLayoutPanel1);
            ShowProducts(hotDrinks, flowLayoutPanel2);
            ShowProducts(coldDrinks, flowLayoutPanel4);
            ShowProducts(empanadas, flowLayoutPanel5);

        }

        private void ClassifyProducts()
        {
            //Add in each Product category the products
            foreach (Product producto in products)
            {
                if (producto.category.Equals("Bebidas Calientes"))
                {
                    hotDrinks.Add(producto);
                    hotDrinksHtmlLabel.Visible = true;
                }
                if (producto.category.Equals("Especialidades"))
                {
                    specialties.Add(producto);
                    specialtiesHtmlLabel.Visible = true;
                }
                if (producto.category.Equals("Bebidas Frías"))
                {
                    coldDrinks.Add(producto);
                    coldDrinksHtmlLabel.Visible = true;
                }
                if (producto.category.Equals("Empanadas"))
                {
                    empanadas.Add(producto);
                    empanadasHtmlLabel.Visible = true;
                }
            }
        }
        private void ShowProducts(List<Product> productCategoryItems, FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            if (productCategoryItems.Count > 0)
            {
                List<UC_Item> productCategoryItemsUI = new List<UC_Item>();
                productCategoryItems.ForEach(producto =>
                {
                    if (producto.parentCode == null)
                    {
                        productCategoryItemsUI.Add(new UC_Item(producto));
                    }
                });
                productCategoryItemsUI.ForEach(item => flowLayoutPanel.Controls.Add(item));
                productCategoryItemsUI.ForEach(item => productosUI.Add(item));
            }

        }

        //Vacia siticoneDataGridView2 para una nueva compra
        public void ResetValues()
        {
            siticoneDataGridView2.Rows.Clear();
            siticoneHtmlLabel11.Visible = false;
        }

        public static void resetNumPickers()
        {
            productosUI.ForEach(item => item.resetComponents());
        }

        private void TxtConsultarVenta_TextChanged(object sender, EventArgs e)
        {
            List<Invoice> invoices = new List<Invoice>();
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 1:
                    if (!txtConsultarVenta.Text.Equals(string.Empty))
                        invoices = InvoiceMapper.GetAllInvoicesByCode(Convert.ToInt32(txtConsultarVenta.Text));
                    break;

                case 2:
                    txtConsultarVenta.MaxLength = Constants.LIMIT_CC_LENGTH;
                    invoices = InvoiceMapper.GetAllInvoices(txtConsultarVenta.Text);
                    break;

                case >= 3 and <= 5:
                    invoices = InvoiceMapper.GetAllInvoices(Categoria, txtConsultarVenta.Text);
                    break;

            }
            llenarTablaVenta(invoices);
        }

        public void llenarTablaVenta(List<Invoice> notasVenta)
        {
            if (notasVenta != null)
            {
                siticoneDataGridView1.Rows.Clear();
                notasVenta.ForEach(item => siticoneDataGridView1.Rows.Add(
                    item.invoiceCode,
                    item.customer.customerID,
                    item.customer.firstName,
                    item.customer.firstLastName,
                    item.customer.phoneNumber,
                    item.totalSales,
                    item.issuedDate.Value.ToString("yyyy-MM-dd")));
            }
        }



        private void txtConsultarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                //case 0: "cod_NotaVenta, ccCliente y Telefono"
                case 1 or 2 or 5:
                    ValidationUtils.keyPressDigitsValidation(e);
                    break;
                //case 2: "primer_Nombre y apellido"; 
                case 3 or 4:
                    ValidationUtils.keyPressLetterValidation(e);
                    break;

            }
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7 && siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                {
                    int InvoiceCodeSelected = Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    ShowDetailInvoice showDetailInvoice = new ShowDetailInvoice(
                        InvoiceDetailMapper.GetAllInvoiceDetails(InvoiceCodeSelected),
                        cc: siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        name: siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        phone: siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        date: siticoneDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                        total: Convert.ToDouble(siticoneDataGridView1.Rows[e.RowIndex].Cells[5].Value),
                        codNotaVenta: InvoiceCodeSelected
                   );
                    showDetailInvoice.BringToFront();
                    showDetailInvoice.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }
        }

        private void siticoneDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (siticoneDataGridView2.Columns[e.ColumnIndex].Name == "EliminarDetalle")
                {
                    if (e.RowIndex >= 0 && siticoneDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este detalle de nota de venta?", "Eliminar detalle", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataGridViewRow row = siticoneDataGridView2.Rows[e.RowIndex];
                            invoice.DeleteInvoiceDetailbyProductName(row.Cells[0].Value.ToString());
                            siticoneDataGridView2.Rows.RemoveAt(e.RowIndex);
                            UC_Ventas.totalVenta.Text = "Total: $" + UC_Ventas.invoice.CalculateTotalSales().ToString().Replace(',', '.');
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
            }
        }

        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InvoiceMapper.GetAllInvoices("");
            // txtConsultarVenta.Text = string.Empty;
            if (ComboBox_ConsultarVentaPor.SelectedIndex > 0)
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Hide();
                txtConsultarVenta.Enabled = true;
            }
            else
            {
                siticoneHtmlLabel_buscarCliente_sin_campo.Show();
                txtConsultarVenta.Enabled = false;
            }

            dateTimePickerConsultarVenta.Visible = false;

            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                case 1: Categoria = "cod_NotaVenta"; TxtConsultarVenta_TextChanged(null, null); break;
                case 2: Categoria = "cc_Cliente"; TxtConsultarVenta_TextChanged(null, null); break;
                case 3: Categoria = "primer_Nombre"; TxtConsultarVenta_TextChanged(null, null); break;
                case 4: Categoria = "primer_Apellido"; TxtConsultarVenta_TextChanged(null, null); break;
                case 5: Categoria = "telefono"; TxtConsultarVenta_TextChanged(null, null); break;
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                case 1: Categoria = "orderID"; txtConsultarVenta_TextChanged(null, null); break;
                case 2: Categoria = "ccCustomer"; txtConsultarVenta_TextChanged(null, null); break;
                case 3: Categoria = "name"; txtConsultarVenta_TextChanged(null, null); break;
                case 4: Categoria = "lastName"; txtConsultarVenta_TextChanged(null, null); break;
                case 5: Categoria = "phone"; txtConsultarVenta_TextChanged(null, null); break;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
                case 6:
                    Categoria = "issueDate";
                    dateTimePickerConsultarVenta.Visible = true;
                    DateTimePickerConsultarVenta_ValueChanged(null, null);
                    break;
            }

            txtConsultarVenta.Text = string.Empty;
        }

        private void ButtonDoPayment_Click(object sender, EventArgs e)
        {
            if (siticoneDataGridView2.RowCount == 1)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Debe elegir al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Checkout ventana = new(siticoneDataGridView2);
                ventana.ShowDialog();
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            }
        }

        private void DateTimePickerConsultarVenta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<Invoice> invoices = InvoiceMapper.GetAllInvoicesByDate(dateTimePickerConsultarVenta.Text);
                llenarTablaVenta(invoices);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        private void SiticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneTabControl1.SelectedIndex == 1)
            {
                MessageBox.Show("Ingresa a esta parte del codigo");
                //Actualiza las ventas al ingresar a la pestaña de consulta de ventas
                List<Invoice> registeredInvoices = InvoiceMapper.GetAllInvoices("");
                MainMenu.uc_ventas.llenarTablaVenta(registeredInvoices);
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            }
        }

        private void dateTimePickerConsultarVenta_ValueChanged(object sender, EventArgs e)
        {
            List<Invoice> invoices = InvoiceMapper.GetAllInvoicesByDate(dateTimePickerConsultarVenta.Text);
            llenarTablaVenta(invoices);
        }

        private void SiticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
