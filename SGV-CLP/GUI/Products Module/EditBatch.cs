using SGV_CLP.Classes;
using SGV_CLP.Classes.Products_module;
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

namespace SGV_CLP.GUI.Products_Module
{
    public partial class EditBatch : Form
    {
        string batchCode, manufactureDate, manufactureHour;

        bool quantityIsValid, manufactureDateIsValid; // Para validar los campos de Lote

        public EditBatch(string batchCode)
        {
            InitializeComponent();

            this.batchCode = batchCode;
            SeparateDateAndTime(); // Aquí se inicializan manufactureDate y manufactureHour

            quantityIsValid = false;
            manufactureDateIsValid = false;

            tbQuantity.Text = BatchMapper.GetBatchField(batchCode, "cantidad");
            dtpManufactureDate.Value = DateTime.ParseExact(manufactureDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            dtpManufactureHour.Value = DateTime.ParseExact(manufactureHour, "HH:mm:ss", CultureInfo.InvariantCulture);

            tbQuantity.SelectionStart = tbQuantity.Text.Length;

            rbChooseDate.Checked = true;
            buttonEditBatch.Enabled = false;
        }

        private void SeparateDateAndTime()
        {
            string[] manufactureDateAndTime = BatchMapper.GetBatchField(batchCode, "fecha").Split(' ');
            manufactureDate = manufactureDateAndTime[0];
            manufactureHour = manufactureDateAndTime[1];
        }

        private void ValidateBatchFields()
        {
            if (quantityIsValid && manufactureDateIsValid)
            {
                buttonEditBatch.Enabled = true;
            }
            else
            {
                buttonEditBatch.Enabled = false;
            }
        }

        private void ButtonEditBatch_Click(object sender, EventArgs e)
        {
            if (SRBFechaActual.Checked)
            {
                BatchMapper.EditBatch(batchCode, int.Parse(tbQuantity.Text), DateTime.Now);
            }
            else
            {
                BatchMapper.EditBatch(batchCode, int.Parse(tbQuantity.Text), dtpManufactureDate.Value.Date + dtpManufactureHour.Value.TimeOfDay);
            }
            SystemSounds.Beep.Play();
            MessageBox.Show("Lote de producto editado con éxito", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!tbQuantity.Text.Equals(string.Empty))
            {
                quantityIsValid = true;
            }
            else
            {
                quantityIsValid = false;
            }
            ValidateBatchFields();
        }

        private void TbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                MessageBox.Show("Cantidad inválida – solo se permiten caracteres numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void RbCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpManufactureDate.Visible = false;
            dtpManufactureHour.Visible = false;
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }

        private void RbChooseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpManufactureDate.Visible = true;
            dtpManufactureHour.Visible = true;
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }

        private void DtpManufactureDate_ValueChanged(object sender, EventArgs e)
        {
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }

        private void DtpManufactureHour_ValueChanged(object sender, EventArgs e)
        {
            labelManufactureDateNotChosen.Visible = false;
            manufactureDateIsValid = true;
            ValidateBatchFields();
        }
    }
}
