using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGV_CLP.GUI
{
    public partial class EditProduct : Form
    {
        string productCode;
        List<Product> parentProducts;
        bool productNameIsValid, categoryIsValid, salesPriceToThePubicIsValid, imagePathIsValid, parentIsValid; // Para validar los campos de Producto
        Product? productToEdit;
        public EditProduct(string productCode)
        {
            InitializeComponent();

            this.productCode = productCode;

            productNameIsValid = false;
            categoryIsValid = false;
            salesPriceToThePubicIsValid = false;
            imagePathIsValid = false;
            parentIsValid = false;

            //Cargar info del producto 
            productToEdit = ProductMapper.GetProductByID(productCode);

            //Mostrar en los recuadros la información del producto 
            if (productToEdit?.salePrice != null)
            {
                tbSalesPriceToThePublic.Text = productToEdit?.salePrice?.ToString().Replace(',', '.');
            }
            else
            {
                isParentCheckBox.Checked = true;
            }

            if (productToEdit?.parentCode != null)
            {
                isSubproductCheckBox.Checked = true;
                parentProducts = ProductMapper.GetAllParentProducts();
                List<String> parentCodes = parentProducts.Select(p => p.productCode).ToList();
                parentComboBox.DataSource = parentCodes;
                foreach (var item in parentCodes)
                {
                    if (item == productToEdit.parentCode)
                    {
                        parentComboBox.SelectedIndex = parentCodes.IndexOf(item);
                    }
                };
            }



            tbImagePath.Text = productToEdit?.imagePath;
            tbProductName.Text = productToEdit?.productName;


            tbSalesPriceToThePublic.SelectionStart = tbSalesPriceToThePublic.Text.Length;
            tbImagePath.SelectionStart = tbImagePath.Text.Length;

            foreach (var item in cbCategory.Items)
            {
                if (item.ToString() == ProductMapper.GetProductField(productCode, "category"))
                {
                    cbCategory.SelectedIndex = cbCategory.Items.IndexOf(item.ToString());
                }
            };

            tbImagePath.MaxLength = Constants.LIMIT_RUTAIMAGEN_LENGTH;

            buttonEditProduct.Enabled = false;
        }

        private void ButtonEditProduct_Click(object sender, EventArgs e)
        {
            var product = new Product(
                productToEdit?.productCode,
                tbProductName.Text,
                isParentCheckBox.Checked ? null : Convert.ToDouble(tbSalesPriceToThePublic.Text, CultureInfo.InvariantCulture),
                cbCategory.Text,
                tbImagePath.Text,
                isSubproductCheckBox.Checked ? parentProducts[parentComboBox.SelectedIndex].productCode : null
            );
            SystemSounds.Beep.Play();
            ProductMapper.EditProduct(product);
            MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Validaciones de atributos
        private void ValidateProductFields()
        {
            bool fieldAreValid = false;
            if (isParentCheckBox.Checked)
            {
                fieldAreValid =  productNameIsValid && categoryIsValid && imagePathIsValid;
            }
            else if (isSubproductCheckBox.Checked)
            {
                //Se debe tomar en cuenta el checkbox de padre
                fieldAreValid =  productNameIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid && parentIsValid;
            }
            else
            {
                fieldAreValid = productNameIsValid && salesPriceToThePubicIsValid && categoryIsValid && imagePathIsValid;
            }
            buttonEditProduct.Enabled = fieldAreValid;
        }

        private void TbSalesPriceToThePublic_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressDoubleValidation(e);
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

        private void tbImagePath_TextChanged(object sender, EventArgs e)
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

        private void SBExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                tbImagePath.Text = fileName;
            }
        }

        private void tbSalesPriceToThePublic_TextChanged(object sender, EventArgs e)
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

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex > 0)
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

        private void tbProductName_TextChanged(object sender, EventArgs e)
        {
            // Valida que el campo no esté vacío
            if (tbProductName.Text.Length > 0)
            {
                productNameIsValid = true;
            }
            else
            {
                productNameIsValid = false;
            }
            ValidateProductFields();
        }
    }
}
