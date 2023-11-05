namespace SGV_CLP.GUI.Customers_Module
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            buttonCancelar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            buttonEditCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel20 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbHomeAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbEMail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelCorrectEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelWrongEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelValidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelWrongPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BorderRadius = 20;
            buttonCancelar.DisabledState.BorderColor = Color.DarkGray;
            buttonCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancelar.FillColor = Color.FromArgb(64, 64, 64);
            buttonCancelar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(574, 407);
            buttonCancelar.Margin = new Padding(4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(231, 60);
            buttonCancelar.TabIndex = 47;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Anchor = AnchorStyles.None;
            buttonEditCustomer.BorderRadius = 20;
            buttonEditCustomer.DisabledState.BorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditCustomer.FillColor = Color.FromArgb(64, 64, 64);
            buttonEditCustomer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditCustomer.ForeColor = Color.White;
            buttonEditCustomer.Location = new Point(293, 407);
            buttonEditCustomer.Margin = new Padding(4);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(231, 60);
            buttonEditCustomer.TabIndex = 46;
            buttonEditCustomer.Text = "Aceptar";
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // siticoneHtmlLabel20
            // 
            siticoneHtmlLabel20.Anchor = AnchorStyles.None;
            siticoneHtmlLabel20.BackColor = Color.Transparent;
            siticoneHtmlLabel20.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel20.Location = new Point(222, 124);
            siticoneHtmlLabel20.Margin = new Padding(4);
            siticoneHtmlLabel20.Name = "siticoneHtmlLabel20";
            siticoneHtmlLabel20.Size = new Size(100, 26);
            siticoneHtmlLabel20.TabIndex = 49;
            siticoneHtmlLabel20.Text = "Dirección";
            // 
            // tbHomeAddress
            // 
            tbHomeAddress.Anchor = AnchorStyles.None;
            tbHomeAddress.BorderRadius = 20;
            tbHomeAddress.DefaultText = "";
            tbHomeAddress.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbHomeAddress.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbHomeAddress.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbHomeAddress.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbHomeAddress.ForeColor = Color.FromArgb(64, 64, 64);
            tbHomeAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Location = new Point(350, 124);
            tbHomeAddress.Margin = new Padding(5, 8, 5, 8);
            tbHomeAddress.Name = "tbHomeAddress";
            tbHomeAddress.PasswordChar = '\0';
            tbHomeAddress.PlaceholderText = "";
            tbHomeAddress.SelectedText = "";
            tbHomeAddress.Size = new Size(440, 45);
            tbHomeAddress.TabIndex = 48;
            tbHomeAddress.TextOffset = new Point(5, 0);
            tbHomeAddress.TextChanged += tbHomeAddress_TextChanged;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(222, 309);
            siticoneHtmlLabel1.Margin = new Padding(4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(92, 26);
            siticoneHtmlLabel1.TabIndex = 51;
            siticoneHtmlLabel1.Text = "Teléfono";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Anchor = AnchorStyles.None;
            tbPhoneNumber.BorderRadius = 20;
            tbPhoneNumber.DefaultText = "";
            tbPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.ForeColor = Color.FromArgb(64, 64, 64);
            tbPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Location = new Point(349, 307);
            tbPhoneNumber.Margin = new Padding(5, 8, 5, 8);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PasswordChar = '\0';
            tbPhoneNumber.PlaceholderText = "";
            tbPhoneNumber.SelectedText = "";
            tbPhoneNumber.Size = new Size(300, 45);
            tbPhoneNumber.TabIndex = 50;
            tbPhoneNumber.TextOffset = new Point(5, 0);
            tbPhoneNumber.TextChanged += tbPhoneNumber_TextChanged;
            tbPhoneNumber.KeyPress += tbPhoneNumber_KeyPress;
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(222, 212);
            siticoneHtmlLabel2.Margin = new Padding(4);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(58, 26);
            siticoneHtmlLabel2.TabIndex = 53;
            siticoneHtmlLabel2.Text = "eMail";
            // 
            // tbEMail
            // 
            tbEMail.Anchor = AnchorStyles.None;
            tbEMail.BorderRadius = 20;
            tbEMail.DefaultText = "";
            tbEMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEMail.ForeColor = Color.FromArgb(64, 64, 64);
            tbEMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Location = new Point(350, 208);
            tbEMail.Margin = new Padding(5, 8, 5, 8);
            tbEMail.Name = "tbEMail";
            tbEMail.PasswordChar = '\0';
            tbEMail.PlaceholderText = "";
            tbEMail.SelectedText = "";
            tbEMail.Size = new Size(440, 45);
            tbEMail.TabIndex = 52;
            tbEMail.TextOffset = new Point(5, 0);
            tbEMail.TextChanged += tbEMail_TextChanged;
            tbEMail.KeyPress += tbEMail_KeyPress;
            // 
            // labelCorrectEMail
            // 
            labelCorrectEMail.Anchor = AnchorStyles.None;
            labelCorrectEMail.BackColor = Color.Transparent;
            labelCorrectEMail.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectEMail.ForeColor = Color.Turquoise;
            labelCorrectEMail.Location = new Point(810, 216);
            labelCorrectEMail.Margin = new Padding(4);
            labelCorrectEMail.Name = "labelCorrectEMail";
            labelCorrectEMail.Size = new Size(98, 22);
            labelCorrectEMail.TabIndex = 87;
            labelCorrectEMail.Text = "¡Email válido!";
            // 
            // labelWrongEMail
            // 
            labelWrongEMail.Anchor = AnchorStyles.None;
            labelWrongEMail.BackColor = Color.Transparent;
            labelWrongEMail.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongEMail.ForeColor = Color.Red;
            labelWrongEMail.Location = new Point(810, 216);
            labelWrongEMail.Margin = new Padding(4);
            labelWrongEMail.Name = "labelWrongEMail";
            labelWrongEMail.Size = new Size(110, 22);
            labelWrongEMail.TabIndex = 86;
            labelWrongEMail.Text = "¡Email inválido!";
            // 
            // labelValidPhoneNumber
            // 
            labelValidPhoneNumber.Anchor = AnchorStyles.None;
            labelValidPhoneNumber.BackColor = Color.Transparent;
            labelValidPhoneNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidPhoneNumber.ForeColor = Color.Turquoise;
            labelValidPhoneNumber.Location = new Point(662, 330);
            labelValidPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            labelValidPhoneNumber.Name = "labelValidPhoneNumber";
            labelValidPhoneNumber.Size = new Size(177, 22);
            labelValidPhoneNumber.TabIndex = 91;
            labelValidPhoneNumber.Text = "¡Teléfono celular válido!";
            labelValidPhoneNumber.Visible = false;
            // 
            // labelInvalidPhoneNumber
            // 
            labelInvalidPhoneNumber.Anchor = AnchorStyles.None;
            labelInvalidPhoneNumber.BackColor = Color.Transparent;
            labelInvalidPhoneNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidPhoneNumber.ForeColor = Color.Red;
            labelInvalidPhoneNumber.Location = new Point(662, 330);
            labelInvalidPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            labelInvalidPhoneNumber.Name = "labelInvalidPhoneNumber";
            labelInvalidPhoneNumber.Size = new Size(189, 22);
            labelInvalidPhoneNumber.TabIndex = 90;
            labelInvalidPhoneNumber.Text = "¡Teléfono celular inválido!";
            // 
            // labelCorrectPhoneNumberLength
            // 
            labelCorrectPhoneNumberLength.Anchor = AnchorStyles.None;
            labelCorrectPhoneNumberLength.BackColor = Color.Transparent;
            labelCorrectPhoneNumberLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectPhoneNumberLength.ForeColor = Color.Turquoise;
            labelCorrectPhoneNumberLength.Location = new Point(662, 300);
            labelCorrectPhoneNumberLength.Margin = new Padding(4, 5, 4, 5);
            labelCorrectPhoneNumberLength.Name = "labelCorrectPhoneNumberLength";
            labelCorrectPhoneNumberLength.Size = new Size(143, 22);
            labelCorrectPhoneNumberLength.TabIndex = 89;
            labelCorrectPhoneNumberLength.Text = "¡Longitud correcta!";
            // 
            // labelWrongPhoneNumberLength
            // 
            labelWrongPhoneNumberLength.Anchor = AnchorStyles.None;
            labelWrongPhoneNumberLength.BackColor = Color.Transparent;
            labelWrongPhoneNumberLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongPhoneNumberLength.ForeColor = Color.Red;
            labelWrongPhoneNumberLength.Location = new Point(662, 300);
            labelWrongPhoneNumberLength.Margin = new Padding(4, 5, 4, 5);
            labelWrongPhoneNumberLength.Name = "labelWrongPhoneNumberLength";
            labelWrongPhoneNumberLength.Size = new Size(182, 22);
            labelWrongPhoneNumberLength.TabIndex = 88;
            labelWrongPhoneNumberLength.Text = "¡Se necesitan 10 caract.!";
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 544);
            Controls.Add(labelValidPhoneNumber);
            Controls.Add(labelInvalidPhoneNumber);
            Controls.Add(labelCorrectPhoneNumberLength);
            Controls.Add(labelWrongPhoneNumberLength);
            Controls.Add(labelCorrectEMail);
            Controls.Add(labelWrongEMail);
            Controls.Add(siticoneHtmlLabel2);
            Controls.Add(tbEMail);
            Controls.Add(siticoneHtmlLabel1);
            Controls.Add(tbPhoneNumber);
            Controls.Add(siticoneHtmlLabel20);
            Controls.Add(tbHomeAddress);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditCustomer);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonCancelar;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel20;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbHomeAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectPhoneNumberLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongPhoneNumberLength;
    }
}