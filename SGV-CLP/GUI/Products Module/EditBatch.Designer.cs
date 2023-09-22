namespace SGV_CLP.GUI.Products_Module
{
    partial class EditBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBatch));
            SBCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            buttonEditBatch = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            labelManufactureDateNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            GBFechaHoraElab = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            dtpManufactureHour = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            SRBFechaActual = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            rbChooseDate = new Siticone.Desktop.UI.WinForms.SiticoneRadioButton();
            dtpManufactureDate = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            tbQuantity = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel4 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            GBFechaHoraElab.SuspendLayout();
            SuspendLayout();
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
            SBCancelar.Location = new Point(336, 424);
            SBCancelar.Margin = new Padding(3, 4, 3, 4);
            SBCancelar.Name = "SBCancelar";
            SBCancelar.Size = new Size(206, 60);
            SBCancelar.TabIndex = 72;
            SBCancelar.Text = "Cancelar";
            SBCancelar.Click += ButtonCancel_Click;
            // 
            // buttonEditBatch
            // 
            buttonEditBatch.Anchor = AnchorStyles.None;
            buttonEditBatch.BorderRadius = 20;
            buttonEditBatch.DisabledState.BorderColor = Color.DarkGray;
            buttonEditBatch.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditBatch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditBatch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditBatch.FillColor = Color.Black;
            buttonEditBatch.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditBatch.ForeColor = Color.White;
            buttonEditBatch.Location = new Point(79, 424);
            buttonEditBatch.Margin = new Padding(3, 4, 3, 4);
            buttonEditBatch.Name = "buttonEditBatch";
            buttonEditBatch.Size = new Size(206, 60);
            buttonEditBatch.TabIndex = 71;
            buttonEditBatch.Text = "Aceptar";
            buttonEditBatch.Click += ButtonEditBatch_Click;
            // 
            // labelManufactureDateNotChosen
            // 
            labelManufactureDateNotChosen.Anchor = AnchorStyles.None;
            labelManufactureDateNotChosen.BackColor = Color.Transparent;
            labelManufactureDateNotChosen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelManufactureDateNotChosen.ForeColor = Color.Red;
            labelManufactureDateNotChosen.Location = new Point(189, 349);
            labelManufactureDateNotChosen.Margin = new Padding(3, 4, 3, 4);
            labelManufactureDateNotChosen.Name = "labelManufactureDateNotChosen";
            labelManufactureDateNotChosen.Size = new Size(240, 22);
            labelManufactureDateNotChosen.TabIndex = 76;
            labelManufactureDateNotChosen.Text = "Debe tener una fecha y hora válidas";
            labelManufactureDateNotChosen.Visible = false;
            // 
            // GBFechaHoraElab
            // 
            GBFechaHoraElab.Anchor = AnchorStyles.None;
            GBFechaHoraElab.BackColor = Color.Transparent;
            GBFechaHoraElab.BorderColor = Color.Black;
            GBFechaHoraElab.BorderRadius = 20;
            GBFechaHoraElab.Controls.Add(dtpManufactureHour);
            GBFechaHoraElab.Controls.Add(SRBFechaActual);
            GBFechaHoraElab.Controls.Add(rbChooseDate);
            GBFechaHoraElab.Controls.Add(dtpManufactureDate);
            GBFechaHoraElab.CustomBorderColor = Color.Black;
            GBFechaHoraElab.FillColor = Color.Transparent;
            GBFechaHoraElab.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GBFechaHoraElab.ForeColor = Color.White;
            GBFechaHoraElab.Location = new Point(59, 132);
            GBFechaHoraElab.Margin = new Padding(3, 4, 3, 4);
            GBFechaHoraElab.Name = "GBFechaHoraElab";
            GBFechaHoraElab.Size = new Size(504, 209);
            GBFechaHoraElab.TabIndex = 75;
            GBFechaHoraElab.Text = "Fecha y Hora";
            GBFechaHoraElab.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // dtpManufactureHour
            // 
            dtpManufactureHour.Anchor = AnchorStyles.None;
            dtpManufactureHour.BorderRadius = 10;
            dtpManufactureHour.Checked = true;
            dtpManufactureHour.CustomFormat = "HH:mm:ss";
            dtpManufactureHour.FillColor = Color.Black;
            dtpManufactureHour.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpManufactureHour.Format = DateTimePickerFormat.Time;
            dtpManufactureHour.Location = new Point(361, 112);
            dtpManufactureHour.Margin = new Padding(3, 4, 3, 4);
            dtpManufactureHour.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpManufactureHour.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpManufactureHour.Name = "dtpManufactureHour";
            dtpManufactureHour.ShowUpDown = true;
            dtpManufactureHour.Size = new Size(123, 37);
            dtpManufactureHour.TabIndex = 59;
            dtpManufactureHour.TextOffset = new Point(5, 0);
            dtpManufactureHour.Value = new DateTime(2023, 2, 6, 1, 19, 20, 716);
            dtpManufactureHour.Visible = false;
            dtpManufactureHour.ValueChanged += DtpManufactureHour_ValueChanged;
            // 
            // SRBFechaActual
            // 
            SRBFechaActual.Anchor = AnchorStyles.None;
            SRBFechaActual.AutoSize = true;
            SRBFechaActual.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.BorderThickness = 0;
            SRBFechaActual.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            SRBFechaActual.CheckedState.InnerColor = Color.White;
            SRBFechaActual.CheckedState.InnerOffset = -4;
            SRBFechaActual.ForeColor = Color.Black;
            SRBFechaActual.Location = new Point(21, 67);
            SRBFechaActual.Margin = new Padding(3, 4, 3, 4);
            SRBFechaActual.Name = "SRBFechaActual";
            SRBFechaActual.Size = new Size(112, 34);
            SRBFechaActual.TabIndex = 56;
            SRBFechaActual.Text = "Actual";
            SRBFechaActual.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            SRBFechaActual.UncheckedState.BorderThickness = 2;
            SRBFechaActual.UncheckedState.FillColor = Color.Transparent;
            SRBFechaActual.UncheckedState.InnerColor = Color.Transparent;
            SRBFechaActual.CheckedChanged += RbCurrentDate_CheckedChanged;
            // 
            // rbChooseDate
            // 
            rbChooseDate.Anchor = AnchorStyles.None;
            rbChooseDate.AutoSize = true;
            rbChooseDate.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rbChooseDate.CheckedState.BorderThickness = 0;
            rbChooseDate.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rbChooseDate.CheckedState.InnerColor = Color.White;
            rbChooseDate.CheckedState.InnerOffset = -4;
            rbChooseDate.ForeColor = Color.Black;
            rbChooseDate.Location = new Point(165, 67);
            rbChooseDate.Margin = new Padding(3, 4, 3, 4);
            rbChooseDate.Name = "rbChooseDate";
            rbChooseDate.Size = new Size(98, 34);
            rbChooseDate.TabIndex = 57;
            rbChooseDate.Text = "Elegir";
            rbChooseDate.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rbChooseDate.UncheckedState.BorderThickness = 2;
            rbChooseDate.UncheckedState.FillColor = Color.Transparent;
            rbChooseDate.UncheckedState.InnerColor = Color.Transparent;
            rbChooseDate.CheckedChanged += RbChooseDate_CheckedChanged;
            // 
            // dtpManufactureDate
            // 
            dtpManufactureDate.Anchor = AnchorStyles.None;
            dtpManufactureDate.BorderRadius = 10;
            dtpManufactureDate.Checked = true;
            dtpManufactureDate.CustomFormat = "yyyy-MM-dd";
            dtpManufactureDate.FillColor = Color.Black;
            dtpManufactureDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpManufactureDate.Format = DateTimePickerFormat.Custom;
            dtpManufactureDate.Location = new Point(165, 112);
            dtpManufactureDate.Margin = new Padding(3, 4, 3, 4);
            dtpManufactureDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpManufactureDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpManufactureDate.Name = "dtpManufactureDate";
            dtpManufactureDate.Size = new Size(180, 37);
            dtpManufactureDate.TabIndex = 58;
            dtpManufactureDate.TextOffset = new Point(5, 0);
            dtpManufactureDate.Value = new DateTime(2023, 3, 10, 0, 0, 0, 0);
            dtpManufactureDate.Visible = false;
            dtpManufactureDate.ValueChanged += DtpManufactureDate_ValueChanged;
            // 
            // tbQuantity
            // 
            tbQuantity.Anchor = AnchorStyles.None;
            tbQuantity.BorderRadius = 20;
            tbQuantity.DefaultText = "";
            tbQuantity.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbQuantity.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbQuantity.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbQuantity.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbQuantity.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbQuantity.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbQuantity.Location = new Point(334, 38);
            tbQuantity.Margin = new Padding(3, 7, 3, 7);
            tbQuantity.Name = "tbQuantity";
            tbQuantity.PasswordChar = '\0';
            tbQuantity.PlaceholderText = "";
            tbQuantity.SelectedText = "";
            tbQuantity.Size = new Size(229, 55);
            tbQuantity.TabIndex = 74;
            tbQuantity.TextOffset = new Point(5, 0);
            tbQuantity.TextChanged += TbQuantity_TextChanged;
            tbQuantity.KeyPress += TbQuantity_KeyPress;
            // 
            // siticoneHtmlLabel4
            // 
            siticoneHtmlLabel4.Anchor = AnchorStyles.None;
            siticoneHtmlLabel4.BackColor = Color.Transparent;
            siticoneHtmlLabel4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel4.Location = new Point(59, 38);
            siticoneHtmlLabel4.Margin = new Padding(3, 5, 3, 5);
            siticoneHtmlLabel4.Name = "siticoneHtmlLabel4";
            siticoneHtmlLabel4.Size = new Size(126, 34);
            siticoneHtmlLabel4.TabIndex = 73;
            siticoneHtmlLabel4.Text = "Cantidad";
            // 
            // EditBatch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(608, 546);
            Controls.Add(SBCancelar);
            Controls.Add(buttonEditBatch);
            Controls.Add(labelManufactureDateNotChosen);
            Controls.Add(GBFechaHoraElab);
            Controls.Add(tbQuantity);
            Controls.Add(siticoneHtmlLabel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditBatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Lote";
            GBFechaHoraElab.ResumeLayout(false);
            GBFechaHoraElab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditBatch;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelManufactureDateNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox GBFechaHoraElab;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureHour;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton SRBFechaActual;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton rbChooseDate;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureDate;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbQuantity;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
    }
}