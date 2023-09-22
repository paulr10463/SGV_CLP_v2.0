namespace SGV_CLP.GUI.Módulo_Administración
{
    partial class Editar_Parametro_Por_Unidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Parametro_Por_Unidad));
            cBox_ProductosParam = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            numUpDown_UnidadBase = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            numUpDown_UnidadExtra = new Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SBAceptar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SBCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            label_SinNombProd = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            label_SinUnidadExtra = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            label_SinUnidadBase = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            ((System.ComponentModel.ISupportInitialize)numUpDown_UnidadBase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_UnidadExtra).BeginInit();
            SuspendLayout();
            // 
            // cBox_ProductosParam
            // 
            cBox_ProductosParam.Anchor = AnchorStyles.None;
            cBox_ProductosParam.BackColor = Color.Transparent;
            cBox_ProductosParam.BorderRadius = 20;
            cBox_ProductosParam.DrawMode = DrawMode.OwnerDrawFixed;
            cBox_ProductosParam.DropDownStyle = ComboBoxStyle.DropDownList;
            cBox_ProductosParam.FocusedColor = Color.FromArgb(94, 148, 255);
            cBox_ProductosParam.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cBox_ProductosParam.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cBox_ProductosParam.ForeColor = Color.FromArgb(68, 88, 112);
            cBox_ProductosParam.ItemHeight = 40;
            cBox_ProductosParam.Items.AddRange(new object[] { "Humitas", "Tamales", "Cafe", "Empanadas" });
            cBox_ProductosParam.Location = new Point(366, 311);
            cBox_ProductosParam.Margin = new Padding(3, 4, 3, 4);
            cBox_ProductosParam.Name = "cBox_ProductosParam";
            cBox_ProductosParam.Size = new Size(261, 46);
            cBox_ProductosParam.TabIndex = 59;
            cBox_ProductosParam.TextOffset = new Point(5, 0);
            cBox_ProductosParam.SelectedIndexChanged += cBox_ProductosParam_SelectedIndexChanged;
            // 
            // numUpDown_UnidadBase
            // 
            numUpDown_UnidadBase.Anchor = AnchorStyles.None;
            numUpDown_UnidadBase.BackColor = Color.White;
            numUpDown_UnidadBase.BorderRadius = 10;
            numUpDown_UnidadBase.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numUpDown_UnidadBase.Location = new Point(366, 53);
            numUpDown_UnidadBase.Margin = new Padding(3, 5, 3, 5);
            numUpDown_UnidadBase.Name = "numUpDown_UnidadBase";
            numUpDown_UnidadBase.Size = new Size(145, 53);
            numUpDown_UnidadBase.TabIndex = 58;
            numUpDown_UnidadBase.TextOffset = new Point(5, 0);
            numUpDown_UnidadBase.UpDownButtonFillColor = Color.Black;
            numUpDown_UnidadBase.UpDownButtonForeColor = Color.White;
            numUpDown_UnidadBase.ValueChanged += numUpDown_UnidadBase_ValueChanged;
            // 
            // numUpDown_UnidadExtra
            // 
            numUpDown_UnidadExtra.Anchor = AnchorStyles.None;
            numUpDown_UnidadExtra.BackColor = Color.White;
            numUpDown_UnidadExtra.BorderRadius = 10;
            numUpDown_UnidadExtra.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numUpDown_UnidadExtra.Location = new Point(366, 172);
            numUpDown_UnidadExtra.Margin = new Padding(3, 5, 3, 5);
            numUpDown_UnidadExtra.Name = "numUpDown_UnidadExtra";
            numUpDown_UnidadExtra.Size = new Size(145, 53);
            numUpDown_UnidadExtra.TabIndex = 57;
            numUpDown_UnidadExtra.TextOffset = new Point(5, 0);
            numUpDown_UnidadExtra.UpDownButtonFillColor = Color.Black;
            numUpDown_UnidadExtra.UpDownButtonForeColor = Color.White;
            numUpDown_UnidadExtra.ValueChanged += numUpDown_UnidadExtra_ValueChanged;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(144, 63);
            siticoneHtmlLabel4.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(163, 34);
            siticoneHtmlLabel4.TabIndex = 56;
            siticoneHtmlLabel4.Text = "Unidad Base";
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(144, 180);
            siticoneHtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(163, 34);
            siticoneHtmlLabel3.TabIndex = 55;
            siticoneHtmlLabel3.Text = "Unidad Extra";
            // 
            // SBAceptar
            // 
            SBAceptar.Anchor = AnchorStyles.None;
            SBAceptar.BorderRadius = 20;
            SBAceptar.DisabledState.BorderColor = Color.DarkGray;
            SBAceptar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBAceptar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBAceptar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBAceptar.FillColor = Color.Black;
            SBAceptar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBAceptar.ForeColor = Color.White;
            SBAceptar.Location = new Point(203, 437);
            SBAceptar.Margin = new Padding(3, 4, 3, 4);
            SBAceptar.Name = "SBAceptar";
            SBAceptar.Size = new Size(206, 60);
            SBAceptar.TabIndex = 60;
            SBAceptar.Text = "Aceptar";
            SBAceptar.Click += SBAceptar_Click;
            // 
            // SBCancelar
            // 
            SBCancelar.Anchor = AnchorStyles.None;
            SBCancelar.BorderRadius = 20;
            SBCancelar.DisabledState.BorderColor = Color.DarkGray;
            SBCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBCancelar.FillColor = Color.Black;
            SBCancelar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBCancelar.ForeColor = Color.White;
            SBCancelar.Location = new Point(435, 437);
            SBCancelar.Margin = new Padding(3, 4, 3, 4);
            SBCancelar.Name = "SBCancelar";
            SBCancelar.Size = new Size(206, 60);
            SBCancelar.TabIndex = 61;
            SBCancelar.Text = "Cancelar";
            SBCancelar.Click += SBCancelar_Click;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(175, 321);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(119, 34);
            siticoneHtmlLabel1.TabIndex = 62;
            siticoneHtmlLabel1.Text = "Producto";
            // 
            // label_SinNombProd
            // 
            label_SinNombProd.Anchor = AnchorStyles.None;
            label_SinNombProd.BackColor = Color.Transparent;
            label_SinNombProd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_SinNombProd.ForeColor = Color.Red;
            label_SinNombProd.Location = new Point(671, 321);
            label_SinNombProd.Margin = new Padding(3, 4, 3, 4);
            label_SinNombProd.Name = "label_SinNombProd";
            label_SinNombProd.Size = new Size(167, 22);
            label_SinNombProd.TabIndex = 73;
            label_SinNombProd.Text = "¡Seleccione un producto!";
            // 
            // label_SinUnidadExtra
            // 
            label_SinUnidadExtra.Anchor = AnchorStyles.None;
            label_SinUnidadExtra.BackColor = Color.Transparent;
            label_SinUnidadExtra.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_SinUnidadExtra.ForeColor = Color.Red;
            label_SinUnidadExtra.Location = new Point(562, 189);
            label_SinUnidadExtra.Margin = new Padding(3, 4, 3, 4);
            label_SinUnidadExtra.Name = "label_SinUnidadExtra";
            label_SinUnidadExtra.Size = new Size(137, 22);
            label_SinUnidadExtra.TabIndex = 72;
            label_SinUnidadExtra.Text = "¡Ingrese una unidad!";
            // 
            // label_SinUnidadBase
            // 
            label_SinUnidadBase.Anchor = AnchorStyles.None;
            label_SinUnidadBase.BackColor = Color.Transparent;
            label_SinUnidadBase.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_SinUnidadBase.ForeColor = Color.Red;
            label_SinUnidadBase.Location = new Point(562, 73);
            label_SinUnidadBase.Margin = new Padding(3, 4, 3, 4);
            label_SinUnidadBase.Name = "label_SinUnidadBase";
            label_SinUnidadBase.Size = new Size(137, 22);
            label_SinUnidadBase.TabIndex = 71;
            label_SinUnidadBase.Text = "¡Ingrese una unidad!";
            // 
            // Editar_Parametro_Por_Unidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 568);
            Controls.Add(label_SinNombProd);
            Controls.Add(label_SinUnidadExtra);
            Controls.Add(label_SinUnidadBase);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(SBCancelar);
            Controls.Add(SBAceptar);
            Controls.Add(cBox_ProductosParam);
            Controls.Add(numUpDown_UnidadBase);
            Controls.Add(numUpDown_UnidadExtra);
            Controls.Add(siticoneHtmlLabel4);
            Controls.Add(siticoneHtmlLabel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editar_Parametro_Por_Unidad";
            Text = "Editar parametro por unidad";
            ((System.ComponentModel.ISupportInitialize)numUpDown_UnidadBase).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDown_UnidadExtra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cBox_ProductosParam;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numUpDown_UnidadBase;
        private Siticone.Desktop.UI.WinForms.SiticoneNumericUpDown numUpDown_UnidadExtra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBAceptar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinNombProd;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinUnidadExtra;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_SinUnidadBase;
    }
}