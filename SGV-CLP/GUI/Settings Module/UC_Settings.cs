using SGV_CLP.Classes;
using SGV_CLP.Classes.Customers_Module;
using SGV_CLP.Classes.Products_module;
using SGV_CLP.GUI.Customers_Module;
using System;
using System.Media;


namespace SGV_CLP.GUI
{
    public partial class UC_Settings : UserControl
    {
        public static bool TableChoiceEnabled = SettingsMapper.GetSettingValue(Constants.TABLE_NUMBER_SETTING);
        public static bool LastOrdersEnabled = SettingsMapper.GetSettingValue(Constants.LAST_ORDERS_SETTING);
        public UC_Settings()
        {
            LastOrdersEnabled.ToString();
            TableChoiceEnabled.ToString();

            InitializeComponent();
            TableNumberChoice.Checked = TableChoiceEnabled;
            siticoneCheckBox1.Checked = LastOrdersEnabled;
            TableNumberChoice.CheckedChanged += TableNumberChoice_CheckedChanged;
            siticoneCheckBox1.CheckedChanged += siticoneCheckBox1_CheckedChanged;
        }

        private void TableNumberChoice_CheckedChanged(object sender, EventArgs e)
        {
            TableChoiceEnabled = !TableChoiceEnabled;
            SettingsMapper.EditSetting(Constants.TABLE_NUMBER_SETTING, TableChoiceEnabled);
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            LastOrdersEnabled = !LastOrdersEnabled;
            SettingsMapper.EditSetting(Constants.LAST_ORDERS_SETTING, LastOrdersEnabled);
        }
    }
}