using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using System.Globalization;
using System.Media;


namespace SGV_CLP.GUI
{
    public partial class UC_Products : UserControl
    {
        List<Product> registeredProducts;
        List<Product> parentProducts;
        Dictionary<int, string> existingCategories;

        bool productCodeIsValid, productNameIsValid, categoryIsValid, salesPriceToThePubicIsValid, imagePathIsValid, parentIsValid; // Para validar los campos de Producto

        public UC_Products()
        {
            InitializeComponent();

            registeredProducts = ProductMapper.GetAllProduct();
            existingCategories = new Dictionary<int, string>();
            CategoryMapper.GetAllCategories().ForEach(item => existingCategories[item.id] = item.categoryName);

            productCodeIsValid = false;
            productNameIsValid = false;
            categoryIsValid = false;
            salesPriceToThePubicIsValid = false;
            imagePathIsValid = false;
            parentIsValid = false;

            FillProductDataGridView();


            cbCategory.SelectedIndex = 0;
            cbCategory.DataSource = existingCategories.Values.ToArray();
            cbCategory.SelectedIndex = -1;
            cbSearchProdutBy.SelectedIndex = 0;

            tbProductCode.MaxLength = Constants.LIMIT_IDPROD_LENGTH;
            tbProductName.MaxLength = Constants.LIMIT_NOMBREPROD_LENGTH;
            tbImagePath.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;

            labelCategoryNotChosen.Show();
        }

        private void TbProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressAddressValidation(e);
        }
        private void TbProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressLetterValidation(e);
        }
        private void TbSalesPriceToThePublic_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDoubleValidation(e);
        }
        private void addCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressAddressValidation(e);
        }

        // Métodos de pestaña de Producto
        // Vaciar Campos Producto
        private void ClearProductFields()
        {
            tbProductCode.Text = string.Empty;
            tbProductName.Text = string.Empty;
            tbSalesPriceToThePublic.Text = string.Empty;
            tbImagePath.Text = string.Empty;
            cbCategory.SelectedIndex = -1;
            isSubproductCheckBox.Checked = false;
            isParentCheckBox.Checked = false;

            productCodeIsValid = false;
            productNameIsValid = false;
            categoryIsValid = false;
            salesPriceToThePubicIsValid = false;
            imagePathIsValid = false;

            labelCategoryNotChosen.Show();
            labelInvalidSalesPriceToThePublic.Hide();
            labelInvalidImagePath.Hide();
        }



        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                tbImagePath.Text = fileName;
            }
        }

        // Añadir Producto
        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            var product = new Product(
                tbProductCode.Text.ToUpper(),
                tbProductName.Text,
                isParentCheckBox.Checked ? null : Convert.ToDouble(tbSalesPriceToThePublic.Text, CultureInfo.InvariantCulture),
                tbImagePath.Text,
                isSubproductCheckBox.Checked ? parentProducts[parentComboBox.SelectedIndex].productCode : null,
                cbCategory.SelectedIndex
                );

            try
            {
                ProductMapper.AddProduct(product);
                FillProductDataGridView();
                ClearProductFields();
                MainMenu.uc_ventas.LoadProducts();
                SystemSounds.Beep.Play();
                MessageBox.Show("Producto añadido con éxito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo añadir el producto.\n{ex.Message}", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        // Filtro de busqueda de productos
        private void TbSearchProductBy_TextChanged(object sender, EventArgs e)
        {
            // Obtener el valor del ComboBox
            string selectedItem = cbSearchProdutBy.SelectedItem.ToString();

            // Obtener el valor del TextBox
            string filterValue = tbSearchProductBy.Text;

            // Filtrar los datos del DataGridView en función del valor del ComboBox y del TextBox
            if (selectedItem == "Código")
            {
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro 
                    if (row.Cells[0].Value != null && !row.Cells[0].Value.ToString().Equals("XXX"))
                    {
                        row.Visible = row.Cells[0].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
            else if (selectedItem == "Nombre")
            {
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[1].Value != null && !row.Cells[1].Value.ToString().Equals("Producto X"))
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().Contains(filterValue.ToLower());
                    }
                }
            }
        }

        private void CbSearchProductByCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (cbSearchProductByCategory.SelectedIndex > 0)
            {
                labelCategoryNotChosenInTheSearchProductTab.Hide();
                string filterValue = cbSearchProductByCategory.Text;
                foreach (DataGridViewRow row in ProductDataGridView.Rows)
                {
                    // Ocultar las filas que no cumplan con el filtro
                    if (row.Cells[2].Value != null)
                    {
                        row.Visible = row.Cells[3].Value.ToString().Equals(filterValue);
                    }
                }
            }
            else
            {
                labelCategoryNotChosenInTheSearchProductTab.Show();
            }
        }

        private void CbSearchProductBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillProductDataGridView();
            tbSearchProductBy.Text = string.Empty;
            if (cbSearchProdutBy.SelectedIndex > 0)
            {
                labelSearchProductWithoutField.Hide();
                if (cbSearchProdutBy.SelectedItem.ToString() == "Categoría")
                {
                    tbSearchProductBy.Visible = false;
                    cbSearchProductByCategory.Visible = true;
                    cbSearchProductByCategory.SelectedIndex = 0;
                }
                else
                {
                    tbSearchProductBy.Visible = true;
                    tbSearchProductBy.Enabled = true;
                    cbSearchProductByCategory.Visible = false;
                }
            }
            else
            {
                labelSearchProductWithoutField.Show();
                tbSearchProductBy.Enabled = false;
                cbSearchProductByCategory.Visible = false;
            }
        }

        // Validaciones de Pestaña producto
        private void ValidateProductFields()
        {
            bool fieldAreValid = false;
            if (isParentCheckBox.Checked)
            {
                fieldAreValid = productCodeIsValid && productNameIsValid && categoryIsValid && imagePathIsValid;
            }
            else if (isSubproductCheckBox.Checked)
            {
                //Se debe tomar en cuenta el checkbox de padre
                fieldAreValid = productCodeIsValid && productNameIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid && parentIsValid;
            }
            else
            {
                fieldAreValid = productCodeIsValid && productNameIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid;
            }
            buttonAddProduct.Enabled = fieldAreValid;
        }

        private async void TbProductCode_TextChanged(object sender, EventArgs e)
        {
            // Valida que el campo no esté vacío
            if (tbProductCode.Text.Length > 0)
            {
                // Verifica la existencia del ID
                if (await ProductMapper.ProductExistsByCode(tbProductCode.Text))
                {
                    labelProductCodeNotUnique.Show();
                    productCodeIsValid = false;
                }
                else
                {
                    labelProductCodeNotUnique.Hide();
                    productCodeIsValid = true;
                }
            }
            else
            {
                productCodeIsValid = false;
            }
            ValidateProductFields();
        }


        private void TbProductName_TextChanged(object sender, EventArgs e)
        {
            // Valida que el campo no esté vacío
            if (tbProductName.Text.Length > 0)
            {
                // Verifica la existencia del nombre de producto
                if (ProductMapper.ProductExistsByName(tbProductName.Text))
                {
                    labelProductNameNotUnique.Show();
                    productNameIsValid = false;
                }
                else
                {
                    labelProductNameNotUnique.Hide();
                    productNameIsValid = true;
                }
            }
            else
            {
                productNameIsValid = false;
            }
            ValidateProductFields();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (cbCategory.SelectedIndex > -1)
            {
                labelCategoryNotChosen.Hide();
                categoryIsValid = true;
            }
            else
            {
                labelCategoryNotChosen.Show();
                categoryIsValid = false;
            }
            ValidateProductFields();
        }

        private void TbSalesPriceToThePublic_TextChanged(object sender, EventArgs e)
        {
            // Valida si hay un double en el campo
            if (ValidationUtils.IsValidDouble(tbSalesPriceToThePublic.Text))
            {
                labelInvalidSalesPriceToThePublic.Hide();
                salesPriceToThePubicIsValid = true;
            }
            else
            {
                labelInvalidSalesPriceToThePublic.Show();
                salesPriceToThePubicIsValid = false;
            }
            ValidateProductFields();
        }
        private void TbImagePath_TextChanged(object sender, EventArgs e)
        {
            // Valida si el valor del campo es una ruta válida 
            if (ValidationUtils.IsValidPath(tbImagePath.Text))
            {
                labelInvalidImagePath.Hide();
                imagePathIsValid = true;
            }
            else
            {
                labelInvalidImagePath.Show();
                imagePathIsValid = false;
            }
            ValidateProductFields();
        }

        private void isParentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isParentCheckBox.Checked)
            {
                siticoneHtmlLabel8.Visible = true;
                tbSalesPriceToThePublic.Visible = true;
            }
            else
            {
                isSubproductCheckBox.Checked = false;
                siticoneHtmlLabel8.Visible = false;
                tbSalesPriceToThePublic.Visible = false;
                tbSalesPriceToThePublic.Text = string.Empty;
                labelInvalidSalesPriceToThePublic.Visible = false;
                parentErrorLabel.Visible = false;
            }
            ValidateProductFields();
        }

        private void isSubproductCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isSubproductCheckBox.Checked)
            {
                parentComboBox.Visible = false;
                parentLabel.Visible = false;
                parentErrorLabel.Visible = false;
                parentComboBox.SelectedIndex = -1;
            }
            else
            {
                isParentCheckBox.Checked = false;
                parentComboBox.Visible = true;
                parentComboBox.Visible = true;
                parentLabel.Visible = true;
                parentErrorLabel.Visible = true;
                parentProducts = ProductMapper.GetAllParentProducts();
                if (parentProducts != null && parentProducts.Count > 0)
                {
                    List<String> productNames = new List<String>();
                    parentProducts.ForEach(item => productNames.Add(item.productName));
                    parentComboBox.DataSource = productNames;
                    parentComboBox.SelectedIndex = -1;
                }
            }
            ValidateProductFields();
        }

        private void parentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Valida que el item seleccionado es "> 0"
            if (parentComboBox.SelectedIndex > -1)
            {
                parentErrorLabel.Hide();
                parentIsValid = true;
            }
            else
            {
                parentErrorLabel.Show();
                parentIsValid = false;
            }
            ValidateProductFields();
        }


        private void addCategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            List<string> categoryNamesUsed = new List<string>();
            existingCategories.Values.ToList().ForEach(item => categoryNamesUsed.Add(item.ToLower()));
            bool categoryNameAlreadyUsed = categoryNamesUsed.Contains(addCategoryTextBox.Text.ToLower());
            if (addCategoryTextBox.Text.Equals(string.Empty))
            {
                addCategoryButton.Enabled = false;
                return;
            }
            if (categoryNameAlreadyUsed)
            {
                addCategoryButton.Enabled = false;
                categoryUsedLabel.Visible = true;
                return;
            }
            else
            {
                categoryUsedLabel.Visible = false;
                addCategoryButton.Enabled = true;
            }
        }

        private void SiticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siticoneTabControl1.SelectedIndex == 2 || siticoneTabControl1.SelectedIndex == 0)
            {
                CategoryMapper.GetAllCategories().ForEach(item => existingCategories[item.id] = item.categoryName);
            }
            if (siticoneTabControl1.SelectedIndex == 0)
            {
                cbCategory.SelectedIndex = -1;

            }
            if (siticoneTabControl1.SelectedIndex == 3)
            {
                FillCategoryDataGridView();
            }
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryMapper.AddCategory(addCategoryTextBox.Text);
                MessageBox.Show("Se creó la categoría exitosamente");
                addCategoryTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir la categoría", ex.Message);
            }

        }
        //tables section 
        // Llenar tabla Producto
        public void FillProductDataGridView()
        {
            if (registeredProducts != null)
            {
                ProductDataGridView.Rows.Clear();
                registeredProducts = ProductMapper.GetAllProduct();
                int index = 0;
                foreach (Product product in registeredProducts)
                {
                    ProductDataGridView.Rows.Add(product.productCode, product.productName, product.salePrice, product.categoryName, product.imagePath, product.parentCode);
                    index++;
                }
            }
        }

        public void FillCategoryDataGridView()
        {
            if (existingCategories != null)
            {
                categoryDataGridView.Rows.Clear();
                List<Category> categories = CategoryMapper.GetAllCategories();
                foreach (Category category in categories)
                {
                    categoryDataGridView.Rows.Add(category.id, category.categoryName);
                }
            }
        }
        private void CategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CLICK EN CELDA ELIMINAR PRODUCTO
                if (categoryDataGridView.Columns[e.ColumnIndex].Name == "deleteCategoryColumn")
                {
                    if (e.RowIndex >= 0 && categoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar esta categoría?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int categoryIndex = Int32.Parse(categoryDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                            try
                            {
                                CategoryMapper.DeleteCategory(categoryIndex);
                                MessageBox.Show("Categoría eliminada con éxito");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }

                // CLICK EN CELDA EDITAR CATEGORIA
                if (categoryDataGridView.Columns[e.ColumnIndex].Name == "updateCategoryColumn")
                {
                    if (e.RowIndex >= 0)
                    {
                        int categoryID = (int)categoryDataGridView.Rows[e.RowIndex].Cells[0].Value;
                        string? categoryName = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        EditCategory editCategoryWinForm = new(new Category(categoryID, categoryName));
                        editCategoryWinForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FillCategoryDataGridView();
            MainMenu.uc_ventas.LoadProducts();
        }

        // Editar y eliminar Producto
        private void ProductDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // CLICK EN CELDA ELIMINAR PRODUCTO
                if (ProductDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEliminarProducto")
                {
                    if (e.RowIndex >= 0 && ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString() != null)
                    {
                        if (MessageBox.Show("¿Está seguro de eliminar este producto?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string productCode = ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                            try
                            {
                                ProductMapper.DeleteProduct(productCode);
                                MessageBox.Show("Producto eliminado con éxito");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                }

                // CLICK EN CELDA EDITAR PRODUCTO
                if (ProductDataGridView.Columns[e.ColumnIndex].Name == "ColumnaEditarProducto")
                {
                    if (e.RowIndex >= 0)
                    {
                        string productCode = ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        EditProduct editProductWinForm = new(productCode);
                        editProductWinForm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FillProductDataGridView();
            MainMenu.uc_ventas.LoadProducts();
        }
    }
}
