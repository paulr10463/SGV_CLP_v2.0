using SGV_CLP.Classes;
using SGV_CLP.Classes.Módulo_Administración;
using SGV_CLP.Classes.Products_module;
using Siticone.Desktop.UI.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGV_CLP.GUI.Módulo_Administración
{
    public partial class Editar_Parametro_Por_Unidad : Form
    {
        List<string> NombresProductosRegistrados = ProductMapper.GetProductsNames();
        string idParam;

        // ###### PARAMETRO ######

        bool is_valid_BaseValue = false;
        bool is_valid_ExtraValue = false;
        bool product_name_Selected = false;

        public Editar_Parametro_Por_Unidad(string idParam)
        {
            InitializeComponent();

            this.idParam = idParam;
            LlenarComboBoxesProductos();
            llenarCampos();

            SBAceptar.Enabled = false;
            validateFieldsCounter_Param();
            validacionInicial();

            this.label_SinNombProd.Enabled = false;
            this.label_SinUnidadBase.Enabled = false;
            this.label_SinUnidadExtra.Enabled = false;
        }

        public void validacionInicial()
        {
            if (this.numUpDown_UnidadBase.Value > 0)
            {
                is_valid_BaseValue = true;
                label_SinUnidadBase.Hide();
            }
            else
            {
                is_valid_BaseValue = false;
                label_SinUnidadBase.Show();
            }

            if (this.numUpDown_UnidadExtra.Value > 0)
            {
                is_valid_ExtraValue = true;
                label_SinUnidadExtra.Hide();
            }
            else
            {
                is_valid_ExtraValue = false;
                label_SinUnidadExtra.Show();
            }

            if (this.cBox_ProductosParam.SelectedIndex > 0)
            {
                label_SinNombProd.Hide();
                product_name_Selected = true;
            }
            else if (cBox_ProductosParam.SelectedIndex == 0)
            {
                label_SinNombProd.Show();
                product_name_Selected = false;
            }

        }
        public void LlenarComboBoxesProductos()
        {
            if (NombresProductosRegistrados != null)
            {
                cBox_ProductosParam.Items.Clear();
                NombresProductosRegistrados = ProductMapper.GetProductsNames();
                cBox_ProductosParam.Items.Add("Seleccionar...");
                foreach (string nombreProd in NombresProductosRegistrados)
                {
                    cBox_ProductosParam.Items.Add(nombreProd);
                }
            }
        }

        public void llenarCampos()
        {

            this.numUpDown_UnidadBase.Value = int.Parse(ParametroMapper.ConsultarAtributoParametro(this.idParam, "unidadBase"));
            this.numUpDown_UnidadExtra.Value = int.Parse(ParametroMapper.ConsultarAtributoParametro(this.idParam, "unidadExtra"));
            string prod = ParametroMapper.ConsultarAtributoParametro(this.idParam, "nombre_Producto");

            prod = prod.Trim();
            this.cBox_ProductosParam.SelectedItem = prod;
        }

        private void SBAceptar_Click(object sender, EventArgs e)
        {
            ParametroMapper.EditarParametro(
                this.idParam, numUpDown_UnidadBase.Value.ToString(), numUpDown_UnidadExtra.Value.ToString(), cBox_ProductosParam.SelectedItem.ToString()
                );

            SystemSounds.Beep.Play();
            MessageBox.Show("Parámetro editado con éxito", "Editar Parámetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void SBCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void numUpDown_UnidadBase_ValueChanged(object sender, EventArgs e)
        {
            if (this.numUpDown_UnidadBase.Value > 0)
            {
                is_valid_BaseValue = true;
                label_SinUnidadBase.Hide();
            }
            else
            {
                is_valid_BaseValue = false;
                label_SinUnidadBase.Show();
            }
            validateFieldsCounter_Param();
        }

        private void numUpDown_UnidadExtra_ValueChanged(object sender, EventArgs e)
        {
            if (this.numUpDown_UnidadExtra.Value > 0)
            {
                is_valid_ExtraValue = true;
                label_SinUnidadExtra.Hide();
            }
            else
            {
                is_valid_ExtraValue = false;
                label_SinUnidadExtra.Show();
            }
            validateFieldsCounter_Param();
        }

        private void cBox_ProductosParam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cBox_ProductosParam.SelectedIndex > 0)
            {
                label_SinNombProd.Hide();
                product_name_Selected = true;
            }
            else if (cBox_ProductosParam.SelectedIndex == 0)
            {
                label_SinNombProd.Show();
                product_name_Selected = false;
            }
            validateFieldsCounter_Param();
        }

        private void validateFieldsCounter_Param()
        {
            SBAceptar.Enabled = is_valid_BaseValue && is_valid_ExtraValue && product_name_Selected;
        }
    }
}
