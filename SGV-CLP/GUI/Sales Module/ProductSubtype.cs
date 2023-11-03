using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.Classes.Sales_Module;
using SGV_CLP.Classes.Sales_Module;
using Siticone.Desktop.UI.AnimatorNS;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{

    public partial class ProductSubtype : Form
    {
        public static List<UC_Item> productosUI = new List<UC_Item>();
        public ProductSubtype(List<Product> productsSubtypeList)
        {
            InitializeComponent();
            showProducts(productsSubtypeList, subtypesFlowPanel);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void showProducts(List<Product> productCategoryItems, FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            if (productCategoryItems.Count > 0)
            {
                List<UC_Item> productCategoryItemsUI = new List<UC_Item>();
                productCategoryItems.ForEach(producto => productCategoryItemsUI.Add(new UC_Item(producto)));
                productCategoryItemsUI.ForEach(item => flowLayoutPanel.Controls.Add(item));
                productCategoryItemsUI.ForEach(item => productosUI.Add(item));
            }

        }

    }
}
