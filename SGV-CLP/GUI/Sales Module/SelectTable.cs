using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
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
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Ventas
{

    public partial class SelectTable : Form
    {
        public int TableNumber = 0;
        public SelectTable()
        {
            InitializeComponent();
        }




        private void SiticoneButton1_Click(object sender, EventArgs e)
        {
            TableNumber = Int32.Parse(TableSelectorTextField.Text);
            this.Dispose();
        }

        private void SiticoneButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "1";
        }
        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "2";
        }
        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "3";
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "4";
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "5";
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "6";
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "7";
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "8";
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            TableSelectorTextField.Text += "9";
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            if (TableSelectorTextField.Text != string.Empty)
                TableSelectorTextField.Text += "0";
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            if(TableSelectorTextField.Text.Length > 0)
            TableSelectorTextField.Text = TableSelectorTextField.Text.Substring(0, TableSelectorTextField.Text.Length - 1);
        }
    }
}
