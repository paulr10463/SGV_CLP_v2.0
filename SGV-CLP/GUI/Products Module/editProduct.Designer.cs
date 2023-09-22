namespace SGV_CLP.GUI
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            buttonEditProduct = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            buttonCancel = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            parentErrorLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            parentLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            isSubproductCheckBox = new CheckBox();
            parentComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            isParentCheckBox = new CheckBox();
            labelInvalidImagePath = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCategoryNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelProductNameNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            SBExaminar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tbImagePath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SuspendLayout();
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Anchor = AnchorStyles.None;
            buttonEditProduct.BorderRadius = 20;
            buttonEditProduct.DisabledState.BorderColor = Color.DarkGray;
            buttonEditProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditProduct.FillColor = Color.Black;
            buttonEditProduct.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditProduct.ForeColor = Color.White;
            buttonEditProduct.Location = new Point(282, 653);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(180, 45);
            buttonEditProduct.TabIndex = 40;
            buttonEditProduct.Text = "Aceptar";
            buttonEditProduct.Click += ButtonEditProduct_Click;
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
            buttonCancel.Location = new Point(563, 653);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(180, 45);
            buttonCancel.TabIndex = 41;
            buttonCancel.Text = "Cancelar";
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // parentErrorLabel
            // 
            parentErrorLabel.Anchor = AnchorStyles.None;
            parentErrorLabel.BackColor = Color.Transparent;
            parentErrorLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            parentErrorLabel.ForeColor = Color.Red;
            parentErrorLabel.Location = new Point(463, 543);
            parentErrorLabel.Name = "parentErrorLabel";
            parentErrorLabel.Size = new Size(396, 22);
            parentErrorLabel.TabIndex = 86;
            parentErrorLabel.Text = "Seleccione el producto del que deriva este elemento";
            parentErrorLabel.Visible = false;
            // 
            // parentLabel
            // 
            parentLabel.Anchor = AnchorStyles.None;
            parentLabel.BackColor = Color.Transparent;
            parentLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            parentLabel.Location = new Point(418, 501);
            parentLabel.Margin = new Padding(3, 4, 3, 4);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new Size(68, 26);
            parentLabel.TabIndex = 85;
            parentLabel.Text = "Padre:";
            parentLabel.Visible = false;
            // 
            // isSubproductCheckBox
            // 
            isSubproductCheckBox.Anchor = AnchorStyles.None;
            isSubproductCheckBox.AutoSize = true;
            isSubproductCheckBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            isSubproductCheckBox.Location = new Point(100, 501);
            isSubproductCheckBox.Name = "isSubproductCheckBox";
            isSubproductCheckBox.Size = new Size(210, 26);
            isSubproductCheckBox.TabIndex = 84;
            isSubproductCheckBox.Text = "Es un subproducto?";
            isSubproductCheckBox.UseVisualStyleBackColor = true;
            isSubproductCheckBox.CheckedChanged += isSubproductCheckBox_CheckedChanged;
            // 
            // parentComboBox
            // 
            parentComboBox.Anchor = AnchorStyles.None;
            parentComboBox.BackColor = Color.Transparent;
            parentComboBox.BorderRadius = 20;
            parentComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            parentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            parentComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            parentComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            parentComboBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            parentComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            parentComboBox.ItemHeight = 39;
            parentComboBox.Location = new Point(502, 491);
            parentComboBox.Margin = new Padding(3, 4, 3, 4);
            parentComboBox.Name = "parentComboBox";
            parentComboBox.Size = new Size(316, 45);
            parentComboBox.TabIndex = 83;
            parentComboBox.TextOffset = new Point(5, 0);
            parentComboBox.Visible = false;
            parentComboBox.SelectedIndexChanged += parentComboBox_SelectedIndexChanged;
            // 
            // isParentCheckBox
            // 
            isParentCheckBox.Anchor = AnchorStyles.None;
            isParentCheckBox.AutoSize = true;
            isParentCheckBox.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            isParentCheckBox.Location = new Point(100, 438);
            isParentCheckBox.Name = "isParentCheckBox";
            isParentCheckBox.Size = new Size(223, 26);
            isParentCheckBox.TabIndex = 82;
            isParentCheckBox.Text = "Tiene subproductos? ";
            isParentCheckBox.UseVisualStyleBackColor = true;
            isParentCheckBox.CheckedChanged += isParentCheckBox_CheckedChanged;
            // 
            // labelInvalidImagePath
            // 
            labelInvalidImagePath.Anchor = AnchorStyles.None;
            labelInvalidImagePath.BackColor = Color.Transparent;
            labelInvalidImagePath.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidImagePath.ForeColor = Color.Red;
            labelInvalidImagePath.Location = new Point(950, 260);
            labelInvalidImagePath.Name = "labelInvalidImagePath";
            labelInvalidImagePath.Size = new Size(98, 22);
            labelInvalidImagePath.TabIndex = 81;
            labelInvalidImagePath.Text = "Ruta inválida";
            labelInvalidImagePath.Visible = false;
            // 
            // labelInvalidSalesPriceToThePublic
            // 
            labelInvalidSalesPriceToThePublic.Anchor = AnchorStyles.None;
            labelInvalidSalesPriceToThePublic.BackColor = Color.Transparent;
            labelInvalidSalesPriceToThePublic.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidSalesPriceToThePublic.ForeColor = Color.Red;
            labelInvalidSalesPriceToThePublic.Location = new Point(573, 347);
            labelInvalidSalesPriceToThePublic.Name = "labelInvalidSalesPriceToThePublic";
            labelInvalidSalesPriceToThePublic.Size = new Size(130, 22);
            labelInvalidSalesPriceToThePublic.TabIndex = 80;
            labelInvalidSalesPriceToThePublic.Text = "Máx. 2 decimales";
            labelInvalidSalesPriceToThePublic.Visible = false;
            // 
            // labelCategoryNotChosen
            // 
            labelCategoryNotChosen.Anchor = AnchorStyles.None;
            labelCategoryNotChosen.BackColor = Color.Transparent;
            labelCategoryNotChosen.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosen.ForeColor = Color.Red;
            labelCategoryNotChosen.Location = new Point(575, 191);
            labelCategoryNotChosen.Name = "labelCategoryNotChosen";
            labelCategoryNotChosen.Size = new Size(305, 22);
            labelCategoryNotChosen.TabIndex = 79;
            labelCategoryNotChosen.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosen.Visible = false;
            // 
            // labelProductNameNotUnique
            // 
            labelProductNameNotUnique.Anchor = AnchorStyles.None;
            labelProductNameNotUnique.BackColor = Color.Transparent;
            labelProductNameNotUnique.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductNameNotUnique.ForeColor = Color.Red;
            labelProductNameNotUnique.Location = new Point(575, 115);
            labelProductNameNotUnique.Name = "labelProductNameNotUnique";
            labelProductNameNotUnique.Size = new Size(284, 22);
            labelProductNameNotUnique.TabIndex = 78;
            labelProductNameNotUnique.Text = "Ya existe un producto con ese nombre";
            labelProductNameNotUnique.Visible = false;
            // 
            // SBExaminar
            // 
            SBExaminar.Anchor = AnchorStyles.None;
            SBExaminar.BorderRadius = 20;
            SBExaminar.DisabledState.BorderColor = Color.DarkGray;
            SBExaminar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBExaminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBExaminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBExaminar.FillColor = Color.Black;
            SBExaminar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SBExaminar.ForeColor = Color.White;
            SBExaminar.Location = new Point(761, 250);
            SBExaminar.Name = "SBExaminar";
            SBExaminar.Size = new Size(180, 45);
            SBExaminar.TabIndex = 77;
            SBExaminar.Text = "Examinar...";
            SBExaminar.Click += SBExaminar_Click;
            // 
            // tbImagePath
            // 
            tbImagePath.Anchor = AnchorStyles.None;
            tbImagePath.BorderRadius = 20;
            tbImagePath.DefaultText = "";
            tbImagePath.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbImagePath.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbImagePath.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbImagePath.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbImagePath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Location = new Point(311, 250);
            tbImagePath.Margin = new Padding(5, 7, 5, 7);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.PasswordChar = '\0';
            tbImagePath.PlaceholderText = "";
            tbImagePath.SelectedText = "";
            tbImagePath.Size = new Size(442, 45);
            tbImagePath.TabIndex = 76;
            tbImagePath.TextOffset = new Point(5, 0);
            tbImagePath.TextChanged += tbImagePath_TextChanged;
            // 
            // siticoneHtmlLabel11
            // 
            siticoneHtmlLabel11.Anchor = AnchorStyles.None;
            siticoneHtmlLabel11.BackColor = Color.Transparent;
            siticoneHtmlLabel11.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel11.Location = new Point(102, 260);
            siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            siticoneHtmlLabel11.Size = new Size(135, 26);
            siticoneHtmlLabel11.TabIndex = 75;
            siticoneHtmlLabel11.Text = "Ruta imagen";
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.None;
            cbCategory.BackColor = Color.Transparent;
            cbCategory.BorderRadius = 20;
            cbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCategory.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 39;
            cbCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas Frías", "Bebidas Calientes", "Empanadas" });
            cbCategory.Location = new Point(313, 181);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(249, 45);
            cbCategory.StartIndex = 0;
            cbCategory.TabIndex = 74;
            cbCategory.TextOffset = new Point(5, 0);
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel6
            // 
            siticoneHtmlLabel6.Anchor = AnchorStyles.None;
            siticoneHtmlLabel6.BackColor = Color.Transparent;
            siticoneHtmlLabel6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel6.Location = new Point(104, 187);
            siticoneHtmlLabel6.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            siticoneHtmlLabel6.Size = new Size(108, 26);
            siticoneHtmlLabel6.TabIndex = 73;
            siticoneHtmlLabel6.Text = "Categoría";
            // 
            // tbSalesPriceToThePublic
            // 
            tbSalesPriceToThePublic.Anchor = AnchorStyles.None;
            tbSalesPriceToThePublic.BorderRadius = 20;
            tbSalesPriceToThePublic.DefaultText = "";
            tbSalesPriceToThePublic.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSalesPriceToThePublic.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSalesPriceToThePublic.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSalesPriceToThePublic.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSalesPriceToThePublic.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Location = new Point(311, 333);
            tbSalesPriceToThePublic.Margin = new Padding(5, 9, 5, 9);
            tbSalesPriceToThePublic.Name = "tbSalesPriceToThePublic";
            tbSalesPriceToThePublic.PasswordChar = '\0';
            tbSalesPriceToThePublic.PlaceholderText = "";
            tbSalesPriceToThePublic.SelectedText = "";
            tbSalesPriceToThePublic.Size = new Size(249, 45);
            tbSalesPriceToThePublic.TabIndex = 72;
            tbSalesPriceToThePublic.TextOffset = new Point(5, 0);
            tbSalesPriceToThePublic.TextChanged += tbSalesPriceToThePublic_TextChanged;
            // 
            // siticoneHtmlLabel8
            // 
            siticoneHtmlLabel8.Anchor = AnchorStyles.None;
            siticoneHtmlLabel8.BackColor = Color.Transparent;
            siticoneHtmlLabel8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel8.Location = new Point(102, 341);
            siticoneHtmlLabel8.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            siticoneHtmlLabel8.Size = new Size(57, 26);
            siticoneHtmlLabel8.TabIndex = 71;
            siticoneHtmlLabel8.Text = "P.V.P.";
            // 
            // siticoneHtmlLabel5
            // 
            siticoneHtmlLabel5.Anchor = AnchorStyles.None;
            siticoneHtmlLabel5.BackColor = Color.Transparent;
            siticoneHtmlLabel5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel5.Location = new Point(104, 109);
            siticoneHtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            siticoneHtmlLabel5.Size = new Size(188, 26);
            siticoneHtmlLabel5.TabIndex = 70;
            siticoneHtmlLabel5.Text = "Nombre Producto";
            // 
            // tbProductName
            // 
            tbProductName.Anchor = AnchorStyles.None;
            tbProductName.BorderRadius = 20;
            tbProductName.DefaultText = "";
            tbProductName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductName.Location = new Point(313, 105);
            tbProductName.Margin = new Padding(5, 9, 5, 9);
            tbProductName.Name = "tbProductName";
            tbProductName.PasswordChar = '\0';
            tbProductName.PlaceholderText = "";
            tbProductName.SelectedText = "";
            tbProductName.Size = new Size(249, 45);
            tbProductName.TabIndex = 69;
            tbProductName.TextOffset = new Point(5, 0);
            tbProductName.TextChanged += tbProductName_TextChanged;
            // 
            // EditProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1060, 770);
            Controls.Add(parentErrorLabel);
            Controls.Add(parentLabel);
            Controls.Add(isSubproductCheckBox);
            Controls.Add(parentComboBox);
            Controls.Add(isParentCheckBox);
            Controls.Add(labelInvalidImagePath);
            Controls.Add(labelInvalidSalesPriceToThePublic);
            Controls.Add(labelCategoryNotChosen);
            Controls.Add(labelProductNameNotUnique);
            Controls.Add(SBExaminar);
            Controls.Add(tbImagePath);
            Controls.Add(siticoneHtmlLabel11);
            Controls.Add(cbCategory);
            Controls.Add(siticoneHtmlLabel6);
            Controls.Add(tbSalesPriceToThePublic);
            Controls.Add(siticoneHtmlLabel8);
            Controls.Add(siticoneHtmlLabel5);
            Controls.Add(tbProductName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEditProduct);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditProduct;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonCancel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel parentErrorLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel parentLabel;
        private CheckBox isSubproductCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox parentComboBox;
        private CheckBox isParentCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductNameNotUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBExaminar;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductName;
    }
}