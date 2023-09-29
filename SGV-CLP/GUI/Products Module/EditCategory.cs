using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
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
    public partial class EditCategory : Form
    {
        string productCode;
        List<Product> parentProducts;
        bool productNameIsValid, categoryIsValid, salesPriceToThePubicIsValid, imagePathIsValid, parentIsValid; // Para validar los campos de Producto
        Product? productToEdit;
        Dictionary<int, string> existingCategories;
        int idToUpdate;
        public EditCategory(Category categoryToUpdate)
        {
            InitializeComponent();
            existingCategories = new Dictionary<int, string>();
            CategoryMapper.GetAllCategories().ForEach(item => existingCategories[item.id] = item.categoryName);
            idToUpdate = categoryToUpdate.id;
            editCategoryTextBox.Text = categoryToUpdate.categoryName;
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void editCategoryTextBox_TextChanged(object sender, EventArgs e)
        {
            List<string> categoryNamesUsed = new List<string>();
            existingCategories.Values.ToList().ForEach(item => categoryNamesUsed.Add(item.ToLower()));
            bool categoryNameAlreadyUsed = categoryNamesUsed.Contains(editCategoryTextBox.Text.ToLower());
            if (editCategoryButton.Text.Equals(string.Empty))
            {
                editCategoryButton.Enabled = false;
                return;
            }
            if (categoryNameAlreadyUsed)
            {
                editCategoryButton.Enabled = false;
                editCategoryUsedLabel.Visible = true;
                return;
            }
            else
            {
                editCategoryUsedLabel.Visible = false;
                editCategoryButton.Enabled = true;
            }
        }

        private void editCategoryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.keyPressAddressValidation(e);
        }

        private async void EditCategoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryToEdit = new Category(idToUpdate, editCategoryTextBox.Text);
                bool editResult = await CategoryMapper.UpdateCategory(categoryToEdit);
                if (editResult)
                {
                    MessageBox.Show("Producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el producto", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar el producto: " + ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
