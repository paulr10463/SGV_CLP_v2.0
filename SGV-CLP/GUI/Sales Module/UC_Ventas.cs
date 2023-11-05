using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.GUI.Módulo_Ventas;
using SGV_CLP.Properties;
using Siticone.Desktop.UI.WinForms;
using System.Media;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class UC_Ventas : UserControl
    {
        Dictionary<string, List<Product>> productsCategorized = new();
        public static Invoice? invoice;
        public static SiticoneDataGridView? dineInDataGridView;
        public static SiticoneDataGridView? toGoDataGridView;
        public static Label? totalVenta;
        public static List<UC_Item> productosUI = new();
        public string Categoria = string.Empty;
        public static bool ToGo = false;
        public static Splitter? splitterToGoDineIn;
        private bool _areLastOrdersShowing = false;
        private bool _scrollInDetailsVisible = false;
        public UC_Ventas()
        {
            invoice = new Invoice();

            InitializeComponent();
            ToEatButton.Width = ServiceTypePanel.Width / 2;
            ToGoButton.Width = ServiceTypePanel.Width / 2;
            ToEatButton.Checked = true;

            dineInDataGridView = DineInDataGridView;
            toGoDataGridView = ToGoDataGridView;
            totalVenta = siticoneHtmlLabel11;
            splitterToGoDineIn = splitter1;
            dateTimePickerConsultarVenta.Visible = false;
            txtConsultarVenta.Enabled = false;
            ComboBox_ConsultarVentaPor.SelectedIndex = 0;
            LoadProducts();
            ShowLastOrders(UC_Settings.LastOrdersEnabled);
        }

        public void ShowLastOrders(bool lastOrdersEnabled)
        {
            if (lastOrdersEnabled)
            {
                TableNameLabel.Visible = true;
                flowLayoutPanel2.Visible = true;
                ChargeLastOrders();
                if (!_areLastOrdersShowing)
                {
                    productsFlowLayoutPanel.Height -= 95;
                    productsFlowLayoutPanel.Refresh();
                    _areLastOrdersShowing = true;
                }
            }
            else
            {
                TableNameLabel.Visible = false;
                flowLayoutPanel2.Visible = false;
                if (_areLastOrdersShowing)
                {
                    productsFlowLayoutPanel.Height += 95;
                    productsFlowLayoutPanel.Refresh();
                    _areLastOrdersShowing = false;
                }
            }
        }
        public void ChargeLastOrders()
        {
            List<Invoice> lastOrders = InvoiceMapper.GetLastInvoicesByDate(DateTime.Now.ToString("dd-MM-yyyy"));
            List<UC_Order> orders = new();
            flowLayoutPanel2.Controls.Clear();
            lastOrders.ForEach(order => orders.Add(new UC_Order(order)));
            orders.ForEach(order =>
            {
                flowLayoutPanel2.Controls.Add(order);
                Console.WriteLine(flowLayoutPanel2.Width);
                order.Width = flowLayoutPanel2.Width / 5 - 6;
            });
            //flowLayoutPanel2.Refresh();
        }

        public void LoadProducts()
        {
            productsFlowLayoutPanel.Controls.Clear();
            productsCategorized.Clear();
            List<Product> products = ProductMapper.GetAllProduct();
            products.ForEach(product =>
            {
                if (!productsCategorized.ContainsKey(product.categoryName))
                {
                    productsCategorized.Add(product.categoryName, new List<Product>());
                }
                productsCategorized[product.categoryName].Add(product);
            });


            //List<Category> categoriesAvailable = CategoryMapper.GetAllCategories();
            foreach (var item in productsCategorized)
            {
                FlowLayoutPanel? flowLayoutPanel = new()
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    AutoSize = true,
                    Dock = DockStyle.Top,
                    Margin = new Padding(0, 0, 0, 2),
                };
                SiticoneButton? categoryButton = new SiticoneButton
                {
                    Animated = true,
                    BackColor = Color.Orange,
                    BorderColor = Color.FromArgb(0, 192, 0),
                    AutoSize = true,
                };
                categoryButton.CheckedState.CustomBorderColor = Color.Green;
                categoryButton.CustomBorderColor = Color.Green;
                categoryButton.CustomBorderThickness = new Padding(4, 0, 0, 1);
                categoryButton.Dock = DockStyle.Top;
                categoryButton.FillColor = Color.White;
                categoryButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
                categoryButton.ForeColor = Color.FromArgb(64, 64, 64);
                categoryButton.Text = item.Key;
                categoryButton.PressedDepth = 0;
                categoryButton.RightToLeft = RightToLeft.No;
                categoryButton.Image = Resources.minus;
                categoryButton.ImageOffset = new Point(10, 0);
                categoryButton.ImageSize = new Size(15, 15);
                categoryButton.ImageAlign = HorizontalAlignment.Left;
                //categoryButton.Size = new Size(417, 53);
                categoryButton.TextAlign = HorizontalAlignment.Left;
                categoryButton.TextOffset = new Point(10, 0);

                categoryButton.Click += (s, e) =>
                {
                    flowLayoutPanel.Visible = !flowLayoutPanel.Visible;
                    if (flowLayoutPanel.Visible)
                    {

                        categoryButton.Image = Resources.minus;
                        //categoryButton.Text = categoryButton.Text.Replace("+", "-");
                    }
                    else
                    {
                        categoryButton.Image = Resources.plus;
                        //categoryButton.Text = categoryButton.Text.Replace("-", "+");
                    }

                };
                productsFlowLayoutPanel.Controls.Add(categoryButton);
                productsFlowLayoutPanel.Controls.Add(flowLayoutPanel);
                ShowProducts(item.Value, flowLayoutPanel);
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
                productCategoryItemsUI.ForEach(flowLayoutPanel.Controls.Add);
                productCategoryItemsUI.ForEach(productosUI.Add);
            }

        }

        //Vacia siticoneDataGridView2 para una nueva compra
        public void ResetValues()
        {
            DineInDataGridView.Rows.Clear();
            ToGoDataGridView.Rows.Clear();
            siticoneHtmlLabel11.Visible = false;
            //Return the selection toEat in UC_Ventas   
            ToEatButton.Checked = true;
            ToEatButton_Click(null, null);
            //Delete splitter
            splitterToGoDineIn.Visible = false;
            //Return DineInTableToDefaultValue
            DineInDataGridView.Height = 41;
            ToGoDataGridView.Height = 10;
        }

        public static void ResetNumPickersForNewOrder()
        {
            productosUI.ForEach(item => item.ResetComponentsForNewOrder());
        }
        public static void ResetNumPickersByModalityChange()
        {
            productosUI.ForEach(item => item.BlankQuantity());
        }

        private async void TxtConsultarVenta_TextChanged(object sender, EventArgs e)
        {
            List<Invoice> invoices = new List<Invoice>();
            switch (ComboBox_ConsultarVentaPor.SelectedIndex)
            {
                case 1:
                    if (!txtConsultarVenta.Text.Equals(string.Empty))
                        invoices = await InvoiceMapper.GetAllInvoicesByCode(Convert.ToInt32(txtConsultarVenta.Text));
                    break;

                case 2:
                    txtConsultarVenta.MaxLength = Constants.LIMIT_CC_LENGTH;
                    invoices = await InvoiceMapper.GetAllInvoices(txtConsultarVenta.Text);
                    break;

                case >= 3 and <= 5:
                    invoices = await InvoiceMapper.GetAllInvoices(Categoria, txtConsultarVenta.Text);
                    break;

            }
            FillSalesTable(invoices);
        }

        public void FillSalesTable(List<Invoice> notasVenta)
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

        private void SiticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7 && siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                {
                    int InvoiceCodeSelected = Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    Invoice invoiceToShow = new Invoice(
                        );

                    /*ShowDetailInvoice showDetailInvoice = new ShowDetailInvoice(
                        InvoiceDetailMapper.GetAllInvoiceDetails(InvoiceCodeSelected),
                        cc: siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        name: siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                        phone: siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        date: siticoneDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                        total: Convert.ToDouble(siticoneDataGridView1.Rows[e.RowIndex].Cells[5].Value),
                        codNotaVenta: InvoiceCodeSelected
                   );
                    showDetailInvoice.BringToFront();
                    showDetailInvoice.Visible = true;*/
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
                if (DineInDataGridView.Columns[e.ColumnIndex].Name == "EliminarDetalle")
                {
                    if (e.RowIndex >= 0 && DineInDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        DataGridViewRow row = DineInDataGridView.Rows[e.RowIndex];
                        invoice.DeleteDineInDetailbyProductName(row.Cells[0].Value.ToString());
                        DineInDataGridView.Rows.RemoveAt(e.RowIndex);
                        totalVenta.Text = "Total : $" + $"{invoice.CalculateTotalSales():0.00}".Replace(',', '.');
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
                Console.WriteLine(ex.Message);
            }
        }

        private void ComboBox_ConsultarVentaPor_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                case 1: Categoria = "orderID"; TxtConsultarVenta_TextChanged(null, null); break;
                case 2: Categoria = "ccCustomer"; TxtConsultarVenta_TextChanged(null, null); break;
                case 3: Categoria = "name"; TxtConsultarVenta_TextChanged(null, null); break;
                case 4: Categoria = "lastName"; TxtConsultarVenta_TextChanged(null, null); break;
                case 5: Categoria = "phone"; TxtConsultarVenta_TextChanged(null, null); break;
                case 6:
                    Categoria = "issueDate";
                    dateTimePickerConsultarVenta.Visible = true;
                    dateTimePickerConsultarVenta.Value = DateTime.Now;
                    //DateTimePickerConsultarVenta_ValueChanged(null, null);
                    break;
            }

            txtConsultarVenta.Text = string.Empty;
        }

        private void ButtonDoPayment_Click(object sender, EventArgs e)
        {
            if (DineInDataGridView.RowCount > 0 || ToGoDataGridView.RowCount > 0)
            {
                Checkout ventana = new(DineInDataGridView, ToGoDataGridView);
                ventana.ShowDialog();
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Debe elegir al menos un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void DateTimePickerConsultarVenta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                List<Invoice> invoices = await InvoiceMapper.GetAllInvoicesByDate(dateTimePickerConsultarVenta.Text);
                FillSalesTable(invoices);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void SiticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneTabControl1.SelectedIndex == 1)
            {
                //Actualiza las ventas al ingresar a la pestaña de consulta de ventas
                List<Invoice> registeredInvoices = await InvoiceMapper.GetAllInvoices("");
                MainMenu.uc_ventas.FillSalesTable(registeredInvoices);
            }
        }

        private void ServiceTypePanel_Resize(object sender, EventArgs e)
        {
            ToEatButton.Width = ServiceTypePanel.Width / 2;
            ToGoButton.Width = ServiceTypePanel.Width / 2;
        }

        private void ToGoButton_Click(object sender, EventArgs e)
        {
            ToGo = true;
            ResetNumPickersByModalityChange();
        }

        private void ToEatButton_Click(object sender, EventArgs e)
        {
            ToGo = false;
            ResetNumPickersByModalityChange();
        }



        private const int rowHeight = 33;
        private void DineInDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DineInDataGridView.Height += rowHeight;
            CheckOrderDetailScroll();
        }
        private void DineInDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DineInDataGridView.Height -= rowHeight;
            CheckOrderDetailScroll();
        }
        private void ToGoDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ToGoDataGridView.Height += rowHeight;
            CheckOrderDetailScroll();
        }
        private void ToGoDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ToGoDataGridView.Height -= rowHeight;
            CheckOrderDetailScroll();
        }
        private void CheckOrderDetailScroll()
        {
            if (orderDetailPanel.VerticalScroll.Visible)
            {
                if (!_scrollInDetailsVisible)
                {
                    siticoneGradientPanel1.Width += Constants.SCROLL_WIDTH;
                    productsFlowLayoutPanel.Width -= Constants.SCROLL_WIDTH;
                    _scrollInDetailsVisible = true;
                }
            }
            if (!orderDetailPanel.VerticalScroll.Visible)
            {
                if (_scrollInDetailsVisible)
                {
                    siticoneGradientPanel1.Width -= Constants.SCROLL_WIDTH;
                    productsFlowLayoutPanel.Width += Constants.SCROLL_WIDTH;
                    _scrollInDetailsVisible = false;
                }
            }
        }
        private void ToGoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ToGoDataGridView.Columns[e.ColumnIndex].Name == "DeleteToGoDetail")
                {
                    if (e.RowIndex >= 0 && ToGoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        DataGridViewRow row = ToGoDataGridView.Rows[e.RowIndex];
                        invoice.DeleteToGoDetailbyProductName(row.Cells[0].Value.ToString());
                        ToGoDataGridView.Rows.RemoveAt(e.RowIndex);
                        if (ToGoDataGridView.Rows.Count == 0)
                            splitter1.Visible = false;
                        totalVenta.Text = "Total : $" + $"{invoice.CalculateTotalSales():0.00}".Replace(',', '.');
                    }
                }
                if (invoice.toGoDetailList?.Count < 1)
                {
                    ToGoDataGridView.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Esa fila está vacía, no puede hacer acciones sobre ella!!");
                Console.WriteLine(ex.Message);
            }
        }

        private void orderDetailPanel_SizeChanged(object sender, EventArgs e)
        {
            CheckOrderDetailScroll();
        }

        private void flowLayoutPanel2_SizeChanged(object sender, EventArgs e)
        {
            ChargeLastOrders();
        }

    }
}
