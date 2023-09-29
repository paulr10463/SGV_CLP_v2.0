namespace SGV_CLP.GUI
{
    partial class EditCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCategory));
            buttonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            editCategoryUsedLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            editCategoryTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            editCategoryButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BorderRadius = 20;
            buttonCancel.DisabledState.BorderColor = Color.DarkGray;
            buttonCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCancel.FillColor = Color.Black;
            buttonCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(399, 295);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(180, 45);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Cancelar";
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // editCategoryUsedLabel
            // 
            editCategoryUsedLabel.Anchor = AnchorStyles.None;
            editCategoryUsedLabel.BackColor = Color.Transparent;
            editCategoryUsedLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCategoryUsedLabel.ForeColor = Color.Red;
            editCategoryUsedLabel.Location = new Point(364, 187);
            editCategoryUsedLabel.Name = "editCategoryUsedLabel";
            editCategoryUsedLabel.Size = new Size(298, 22);
            editCategoryUsedLabel.TabIndex = 62;
            editCategoryUsedLabel.Text = "Ya existe una categoría con ese nombre";
            editCategoryUsedLabel.Visible = false;
            // 
            // editCategoryTextBox
            // 
            editCategoryTextBox.Anchor = AnchorStyles.None;
            editCategoryTextBox.BorderRadius = 20;
            editCategoryTextBox.DefaultText = "";
            editCategoryTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            editCategoryTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            editCategoryTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            editCategoryTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            editCategoryTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            editCategoryTextBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCategoryTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            editCategoryTextBox.Location = new Point(381, 130);
            editCategoryTextBox.Margin = new Padding(5, 9, 5, 9);
            editCategoryTextBox.Name = "editCategoryTextBox";
            editCategoryTextBox.PasswordChar = '\0';
            editCategoryTextBox.PlaceholderText = "";
            editCategoryTextBox.SelectedText = "";
            editCategoryTextBox.Size = new Size(249, 45);
            editCategoryTextBox.TabIndex = 60;
            editCategoryTextBox.TextOffset = new Point(5, 0);
            editCategoryTextBox.TextChanged += editCategoryTextBox_TextChanged;
            editCategoryTextBox.KeyPress += editCategoryTextBox_KeyPress;
            // 
            // editCategoryButton
            // 
            editCategoryButton.Anchor = AnchorStyles.None;
            editCategoryButton.BorderRadius = 20;
            editCategoryButton.DisabledState.BorderColor = Color.DarkGray;
            editCategoryButton.DisabledState.CustomBorderColor = Color.DarkGray;
            editCategoryButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            editCategoryButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            editCategoryButton.Enabled = false;
            editCategoryButton.FillColor = Color.Black;
            editCategoryButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            editCategoryButton.ForeColor = Color.White;
            editCategoryButton.Location = new Point(172, 295);
            editCategoryButton.Margin = new Padding(3, 4, 3, 4);
            editCategoryButton.Name = "editCategoryButton";
            editCategoryButton.Size = new Size(180, 45);
            editCategoryButton.TabIndex = 59;
            editCategoryButton.Text = "Aceptar";
            editCategoryButton.Click += EditCategoryButton_Click;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(112, 140);
            siticoneHtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(181, 26);
            siticoneHtmlLabel3.TabIndex = 61;
            siticoneHtmlLabel3.Text = "Nueva categoría";
            // 
            // EditCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(757, 416);
            Controls.Add(editCategoryUsedLabel);
            Controls.Add(siticoneHtmlLabel3);
            Controls.Add(editCategoryTextBox);
            Controls.Add(editCategoryButton);
            Controls.Add(buttonCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Categoría";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel editCategoryUsedLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox editCategoryTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton editCategoryButton;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
    }
}