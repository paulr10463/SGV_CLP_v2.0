using System.Windows.Forms;

namespace SGV_CLP.GUI
{
    partial class UC_Products
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Products));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            Añadir = new TabPage();
            parentErrorLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            parentLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            isSubproductCheckBox = new CheckBox();
            parentComboBox = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            isParentCheckBox = new CheckBox();
            labelInvalidImagePath = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCategoryNotChosen = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelProductNameNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelProductCodeNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductCode = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            SBExaminar = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            tbImagePath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel11 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buttonAddProduct = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            cbCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbSalesPriceToThePublic = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel8 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel5 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbProductName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            Editar = new TabPage();
            labelCategoryNotChosenInTheSearchProductTab = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchProductByCategory = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            labelSearchProductWithoutField = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchProdutBy = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            tbSearchProductBy = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            ProductDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CodProd = new DataGridViewTextBoxColumn();
            NombreProd = new DataGridViewTextBoxColumn();
            PrecioVentaPub = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            ImagePath = new DataGridViewTextBoxColumn();
            parentCode = new DataGridViewTextBoxColumn();
            ColumnaEditarProducto = new DataGridViewImageColumn();
            ColumnaEliminarProducto = new DataGridViewImageColumn();
            AddCategory = new TabPage();
            categoryUsedLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            addCategoryTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            addCategoryButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            EditDeleteCategory = new TabPage();
            categoryDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            updateCategoryColumn = new DataGridViewImageColumn();
            deleteCategoryColumn = new DataGridViewImageColumn();
            siticoneTabControl1.SuspendLayout();
            Añadir.SuspendLayout();
            Editar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            AddCategory.SuspendLayout();
            EditDeleteCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Controls.Add(Añadir);
            siticoneTabControl1.Controls.Add(Editar);
            siticoneTabControl1.Controls.Add(AddCategory);
            siticoneTabControl1.Controls.Add(EditDeleteCategory);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.ItemSize = new Size(200, 40);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1200, 720);
            siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonHoverState.FillColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabButtonHoverState.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonHoverState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonIdleState.FillColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabButtonIdleState.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            siticoneTabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabButtonSelectedState.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            siticoneTabControl1.TabButtonSize = new Size(200, 40);
            siticoneTabControl1.TabIndex = 2;
            siticoneTabControl1.TabMenuBackColor = Color.FromArgb(64, 64, 64);
            siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            siticoneTabControl1.SelectedIndexChanged += SiticoneTabControl1_SelectedIndexChanged;
            // 
            // Añadir
            // 
            Añadir.BackColor = Color.White;
            Añadir.Controls.Add(parentErrorLabel);
            Añadir.Controls.Add(parentLabel);
            Añadir.Controls.Add(isSubproductCheckBox);
            Añadir.Controls.Add(parentComboBox);
            Añadir.Controls.Add(isParentCheckBox);
            Añadir.Controls.Add(labelInvalidImagePath);
            Añadir.Controls.Add(labelInvalidSalesPriceToThePublic);
            Añadir.Controls.Add(labelCategoryNotChosen);
            Añadir.Controls.Add(labelProductNameNotUnique);
            Añadir.Controls.Add(labelProductCodeNotUnique);
            Añadir.Controls.Add(siticoneHtmlLabel1);
            Añadir.Controls.Add(tbProductCode);
            Añadir.Controls.Add(SBExaminar);
            Añadir.Controls.Add(tbImagePath);
            Añadir.Controls.Add(siticoneHtmlLabel11);
            Añadir.Controls.Add(buttonAddProduct);
            Añadir.Controls.Add(cbCategory);
            Añadir.Controls.Add(siticoneHtmlLabel6);
            Añadir.Controls.Add(tbSalesPriceToThePublic);
            Añadir.Controls.Add(siticoneHtmlLabel8);
            Añadir.Controls.Add(siticoneHtmlLabel5);
            Añadir.Controls.Add(tbProductName);
            Añadir.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Añadir.Location = new Point(4, 44);
            Añadir.Margin = new Padding(3, 4, 3, 4);
            Añadir.Name = "Añadir";
            Añadir.Padding = new Padding(3, 4, 3, 4);
            Añadir.Size = new Size(1192, 672);
            Añadir.TabIndex = 0;
            Añadir.Text = "Añadir Producto";
            // 
            // parentErrorLabel
            // 
            parentErrorLabel.Anchor = AnchorStyles.None;
            parentErrorLabel.BackColor = Color.Transparent;
            parentErrorLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            parentErrorLabel.ForeColor = Color.Red;
            parentErrorLabel.Location = new Point(553, 522);
            parentErrorLabel.Name = "parentErrorLabel";
            parentErrorLabel.Size = new Size(396, 22);
            parentErrorLabel.TabIndex = 68;
            parentErrorLabel.Text = "Seleccione el producto del que deriva este elemento";
            parentErrorLabel.Visible = false;
            // 
            // parentLabel
            // 
            parentLabel.Anchor = AnchorStyles.None;
            parentLabel.BackColor = Color.Transparent;
            parentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            parentLabel.Location = new Point(541, 480);
            parentLabel.Margin = new Padding(3, 4, 3, 4);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new Size(53, 23);
            parentLabel.TabIndex = 67;
            parentLabel.Text = "Padre:";
            parentLabel.Visible = false;
            // 
            // isSubproductCheckBox
            // 
            isSubproductCheckBox.Anchor = AnchorStyles.None;
            isSubproductCheckBox.AutoSize = true;
            isSubproductCheckBox.Location = new Point(223, 480);
            isSubproductCheckBox.Name = "isSubproductCheckBox";
            isSubproductCheckBox.Size = new Size(182, 25);
            isSubproductCheckBox.TabIndex = 66;
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
            parentComboBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            parentComboBox.ForeColor = Color.FromArgb(68, 88, 112);
            parentComboBox.ItemHeight = 39;
            parentComboBox.Location = new Point(625, 470);
            parentComboBox.Margin = new Padding(3, 4, 3, 4);
            parentComboBox.Name = "parentComboBox";
            parentComboBox.Size = new Size(316, 45);
            parentComboBox.TabIndex = 65;
            parentComboBox.TextOffset = new Point(5, 0);
            parentComboBox.Visible = false;
            parentComboBox.SelectedIndexChanged += parentComboBox_SelectedIndexChanged;
            // 
            // isParentCheckBox
            // 
            isParentCheckBox.Anchor = AnchorStyles.None;
            isParentCheckBox.AutoSize = true;
            isParentCheckBox.Location = new Point(223, 440);
            isParentCheckBox.Name = "isParentCheckBox";
            isParentCheckBox.Size = new Size(194, 25);
            isParentCheckBox.TabIndex = 64;
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
            labelInvalidImagePath.Location = new Point(1039, 297);
            labelInvalidImagePath.Name = "labelInvalidImagePath";
            labelInvalidImagePath.Size = new Size(98, 22);
            labelInvalidImagePath.TabIndex = 63;
            labelInvalidImagePath.Text = "Ruta inválida";
            labelInvalidImagePath.Visible = false;
            // 
            // labelInvalidSalesPriceToThePublic
            // 
            labelInvalidSalesPriceToThePublic.Anchor = AnchorStyles.None;
            labelInvalidSalesPriceToThePublic.BackColor = Color.Transparent;
            labelInvalidSalesPriceToThePublic.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidSalesPriceToThePublic.ForeColor = Color.Red;
            labelInvalidSalesPriceToThePublic.Location = new Point(698, 361);
            labelInvalidSalesPriceToThePublic.Name = "labelInvalidSalesPriceToThePublic";
            labelInvalidSalesPriceToThePublic.Size = new Size(130, 22);
            labelInvalidSalesPriceToThePublic.TabIndex = 59;
            labelInvalidSalesPriceToThePublic.Text = "Máx. 2 decimales";
            labelInvalidSalesPriceToThePublic.Visible = false;
            // 
            // labelCategoryNotChosen
            // 
            labelCategoryNotChosen.Anchor = AnchorStyles.None;
            labelCategoryNotChosen.BackColor = Color.Transparent;
            labelCategoryNotChosen.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosen.ForeColor = Color.Red;
            labelCategoryNotChosen.Location = new Point(700, 237);
            labelCategoryNotChosen.Name = "labelCategoryNotChosen";
            labelCategoryNotChosen.Size = new Size(305, 22);
            labelCategoryNotChosen.TabIndex = 57;
            labelCategoryNotChosen.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosen.Visible = false;
            // 
            // labelProductNameNotUnique
            // 
            labelProductNameNotUnique.Anchor = AnchorStyles.None;
            labelProductNameNotUnique.BackColor = Color.Transparent;
            labelProductNameNotUnique.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductNameNotUnique.ForeColor = Color.Red;
            labelProductNameNotUnique.Location = new Point(700, 177);
            labelProductNameNotUnique.Name = "labelProductNameNotUnique";
            labelProductNameNotUnique.Size = new Size(284, 22);
            labelProductNameNotUnique.TabIndex = 56;
            labelProductNameNotUnique.Text = "Ya existe un producto con ese nombre";
            labelProductNameNotUnique.Visible = false;
            // 
            // labelProductCodeNotUnique
            // 
            labelProductCodeNotUnique.Anchor = AnchorStyles.None;
            labelProductCodeNotUnique.BackColor = Color.Transparent;
            labelProductCodeNotUnique.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductCodeNotUnique.ForeColor = Color.Red;
            labelProductCodeNotUnique.Location = new Point(698, 113);
            labelProductCodeNotUnique.Name = "labelProductCodeNotUnique";
            labelProductCodeNotUnique.Size = new Size(243, 22);
            labelProductCodeNotUnique.TabIndex = 55;
            labelProductCodeNotUnique.Text = "Ya existe un producto con ese ID";
            labelProductCodeNotUnique.Visible = false;
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(227, 111);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(96, 23);
            siticoneHtmlLabel1.TabIndex = 52;
            siticoneHtmlLabel1.Text = "ID Producto";
            // 
            // tbProductCode
            // 
            tbProductCode.Anchor = AnchorStyles.None;
            tbProductCode.BorderRadius = 20;
            tbProductCode.DefaultText = "";
            tbProductCode.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbProductCode.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbProductCode.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbProductCode.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbProductCode.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductCode.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductCode.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductCode.Location = new Point(436, 104);
            tbProductCode.Margin = new Padding(5, 9, 5, 9);
            tbProductCode.Name = "tbProductCode";
            tbProductCode.PasswordChar = '\0';
            tbProductCode.PlaceholderText = "";
            tbProductCode.SelectedText = "";
            tbProductCode.Size = new Size(249, 45);
            tbProductCode.TabIndex = 51;
            tbProductCode.TextOffset = new Point(5, 0);
            tbProductCode.TextChanged += TbProductCode_TextChanged;
            tbProductCode.KeyPress += TbProductCode_KeyPress;
            // 
            // SBExaminar
            // 
            SBExaminar.Anchor = AnchorStyles.None;
            SBExaminar.BorderRadius = 20;
            SBExaminar.DisabledState.BorderColor = Color.DarkGray;
            SBExaminar.DisabledState.CustomBorderColor = Color.DarkGray;
            SBExaminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SBExaminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SBExaminar.FillColor = Color.FromArgb(64, 64, 64);
            SBExaminar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SBExaminar.ForeColor = Color.White;
            SBExaminar.Location = new Point(886, 285);
            SBExaminar.Name = "SBExaminar";
            SBExaminar.Size = new Size(134, 45);
            SBExaminar.TabIndex = 50;
            SBExaminar.Text = "Examinar...";
            SBExaminar.Click += ButtonBrowse_Click;
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
            tbImagePath.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbImagePath.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbImagePath.Location = new Point(436, 285);
            tbImagePath.Margin = new Padding(5, 7, 5, 7);
            tbImagePath.Name = "tbImagePath";
            tbImagePath.PasswordChar = '\0';
            tbImagePath.PlaceholderText = "";
            tbImagePath.SelectedText = "";
            tbImagePath.Size = new Size(442, 45);
            tbImagePath.TabIndex = 49;
            tbImagePath.TextOffset = new Point(5, 0);
            tbImagePath.TextChanged += TbImagePath_TextChanged;
            // 
            // siticoneHtmlLabel11
            // 
            siticoneHtmlLabel11.Anchor = AnchorStyles.None;
            siticoneHtmlLabel11.BackColor = Color.Transparent;
            siticoneHtmlLabel11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel11.Location = new Point(227, 297);
            siticoneHtmlLabel11.Name = "siticoneHtmlLabel11";
            siticoneHtmlLabel11.Size = new Size(105, 23);
            siticoneHtmlLabel11.TabIndex = 48;
            siticoneHtmlLabel11.Text = "Ruta imagen";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Anchor = AnchorStyles.None;
            buttonAddProduct.BorderRadius = 20;
            buttonAddProduct.DisabledState.BorderColor = Color.DarkGray;
            buttonAddProduct.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAddProduct.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAddProduct.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAddProduct.Enabled = false;
            buttonAddProduct.FillColor = Color.FromArgb(64, 64, 64);
            buttonAddProduct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.White;
            buttonAddProduct.Location = new Point(516, 581);
            buttonAddProduct.Margin = new Padding(3, 4, 3, 4);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(180, 45);
            buttonAddProduct.TabIndex = 45;
            buttonAddProduct.Text = "Añadir";
            buttonAddProduct.Click += ButtonAddProduct_Click;
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
            cbCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbCategory.ItemHeight = 39;
            cbCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas Frías", "Bebidas Calientes", "Empanadas" });
            cbCategory.Location = new Point(438, 227);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(249, 45);
            cbCategory.StartIndex = 0;
            cbCategory.TabIndex = 44;
            cbCategory.TextOffset = new Point(5, 0);
            cbCategory.SelectedIndexChanged += CbCategory_SelectedIndexChanged;
            // 
            // siticoneHtmlLabel6
            // 
            siticoneHtmlLabel6.Anchor = AnchorStyles.None;
            siticoneHtmlLabel6.BackColor = Color.Transparent;
            siticoneHtmlLabel6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel6.Location = new Point(227, 235);
            siticoneHtmlLabel6.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            siticoneHtmlLabel6.Size = new Size(84, 23);
            siticoneHtmlLabel6.TabIndex = 43;
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
            tbSalesPriceToThePublic.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSalesPriceToThePublic.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSalesPriceToThePublic.Location = new Point(436, 349);
            tbSalesPriceToThePublic.Margin = new Padding(5, 9, 5, 9);
            tbSalesPriceToThePublic.Name = "tbSalesPriceToThePublic";
            tbSalesPriceToThePublic.PasswordChar = '\0';
            tbSalesPriceToThePublic.PlaceholderText = "";
            tbSalesPriceToThePublic.SelectedText = "";
            tbSalesPriceToThePublic.Size = new Size(249, 45);
            tbSalesPriceToThePublic.TabIndex = 42;
            tbSalesPriceToThePublic.TextOffset = new Point(5, 0);
            tbSalesPriceToThePublic.TextChanged += TbSalesPriceToThePublic_TextChanged;
            tbSalesPriceToThePublic.KeyPress += TbSalesPriceToThePublic_KeyPress;
            // 
            // siticoneHtmlLabel8
            // 
            siticoneHtmlLabel8.Anchor = AnchorStyles.None;
            siticoneHtmlLabel8.BackColor = Color.Transparent;
            siticoneHtmlLabel8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel8.Location = new Point(227, 359);
            siticoneHtmlLabel8.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel8.Name = "siticoneHtmlLabel8";
            siticoneHtmlLabel8.Size = new Size(44, 23);
            siticoneHtmlLabel8.TabIndex = 41;
            siticoneHtmlLabel8.Text = "P.V.P.";
            // 
            // siticoneHtmlLabel5
            // 
            siticoneHtmlLabel5.Anchor = AnchorStyles.None;
            siticoneHtmlLabel5.BackColor = Color.Transparent;
            siticoneHtmlLabel5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel5.Location = new Point(227, 173);
            siticoneHtmlLabel5.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel5.Name = "siticoneHtmlLabel5";
            siticoneHtmlLabel5.Size = new Size(142, 23);
            siticoneHtmlLabel5.TabIndex = 28;
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
            tbProductName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbProductName.Location = new Point(438, 167);
            tbProductName.Margin = new Padding(5, 9, 5, 9);
            tbProductName.Name = "tbProductName";
            tbProductName.PasswordChar = '\0';
            tbProductName.PlaceholderText = "";
            tbProductName.SelectedText = "";
            tbProductName.Size = new Size(249, 45);
            tbProductName.TabIndex = 27;
            tbProductName.TextOffset = new Point(5, 0);
            tbProductName.TextChanged += TbProductName_TextChanged;
            tbProductName.KeyPress += TbProductName_KeyPress;
            // 
            // Editar
            // 
            Editar.BackColor = Color.White;
            Editar.Controls.Add(labelCategoryNotChosenInTheSearchProductTab);
            Editar.Controls.Add(cbSearchProductByCategory);
            Editar.Controls.Add(labelSearchProductWithoutField);
            Editar.Controls.Add(cbSearchProdutBy);
            Editar.Controls.Add(tbSearchProductBy);
            Editar.Controls.Add(siticonePanel1);
            Editar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Editar.Location = new Point(4, 44);
            Editar.Name = "Editar";
            Editar.Padding = new Padding(3, 4, 3, 4);
            Editar.Size = new Size(1192, 672);
            Editar.TabIndex = 1;
            Editar.Text = "Editar Producto";
            // 
            // labelCategoryNotChosenInTheSearchProductTab
            // 
            labelCategoryNotChosenInTheSearchProductTab.Anchor = AnchorStyles.None;
            labelCategoryNotChosenInTheSearchProductTab.BackColor = Color.Transparent;
            labelCategoryNotChosenInTheSearchProductTab.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCategoryNotChosenInTheSearchProductTab.ForeColor = Color.Red;
            labelCategoryNotChosenInTheSearchProductTab.Location = new Point(643, 54);
            labelCategoryNotChosenInTheSearchProductTab.Name = "labelCategoryNotChosenInTheSearchProductTab";
            labelCategoryNotChosenInTheSearchProductTab.Size = new Size(305, 22);
            labelCategoryNotChosenInTheSearchProductTab.TabIndex = 59;
            labelCategoryNotChosenInTheSearchProductTab.Text = "Debe pertenecer a una categoría válida";
            labelCategoryNotChosenInTheSearchProductTab.Visible = false;
            // 
            // cbSearchProductByCategory
            // 
            cbSearchProductByCategory.Anchor = AnchorStyles.None;
            cbSearchProductByCategory.BackColor = Color.Transparent;
            cbSearchProductByCategory.BorderRadius = 20;
            cbSearchProductByCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchProductByCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchProductByCategory.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchProductByCategory.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchProductByCategory.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchProductByCategory.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchProductByCategory.ItemHeight = 39;
            cbSearchProductByCategory.Items.AddRange(new object[] { "Seleccione...", "Especialidades", "Bebidas Frías", "Bebidas Calientes", "Empanadas" });
            cbSearchProductByCategory.Location = new Point(308, 91);
            cbSearchProductByCategory.Margin = new Padding(3, 4, 3, 4);
            cbSearchProductByCategory.Name = "cbSearchProductByCategory";
            cbSearchProductByCategory.Size = new Size(303, 45);
            cbSearchProductByCategory.TabIndex = 58;
            cbSearchProductByCategory.TextOffset = new Point(5, 0);
            cbSearchProductByCategory.Visible = false;
            cbSearchProductByCategory.SelectedIndexChanged += CbSearchProductByCategory_SelectedIndexChanged;
            // 
            // labelSearchProductWithoutField
            // 
            labelSearchProductWithoutField.Anchor = AnchorStyles.None;
            labelSearchProductWithoutField.BackColor = Color.Transparent;
            labelSearchProductWithoutField.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchProductWithoutField.ForeColor = Color.Red;
            labelSearchProductWithoutField.Location = new Point(308, 54);
            labelSearchProductWithoutField.Name = "labelSearchProductWithoutField";
            labelSearchProductWithoutField.Size = new Size(290, 22);
            labelSearchProductWithoutField.TabIndex = 25;
            labelSearchProductWithoutField.Text = "¡Seleccione un parámetro para buscar!";
            // 
            // cbSearchProdutBy
            // 
            cbSearchProdutBy.Anchor = AnchorStyles.None;
            cbSearchProdutBy.AutoCompleteCustomSource.AddRange(new string[] { "Código", "Nombre", "Categoría" });
            cbSearchProdutBy.BackColor = Color.Transparent;
            cbSearchProdutBy.BorderRadius = 20;
            cbSearchProdutBy.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchProdutBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchProdutBy.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchProdutBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchProdutBy.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchProdutBy.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchProdutBy.ItemHeight = 39;
            cbSearchProdutBy.Items.AddRange(new object[] { "Seleccione...", "Código", "Nombre", "Categoría" });
            cbSearchProdutBy.Location = new Point(643, 91);
            cbSearchProdutBy.Name = "cbSearchProdutBy";
            cbSearchProdutBy.Size = new Size(303, 45);
            cbSearchProdutBy.StartIndex = 0;
            cbSearchProdutBy.TabIndex = 20;
            cbSearchProdutBy.TextOffset = new Point(5, 0);
            cbSearchProdutBy.SelectedIndexChanged += CbSearchProductBy_SelectedIndexChanged;
            // 
            // tbSearchProductBy
            // 
            tbSearchProductBy.Anchor = AnchorStyles.None;
            tbSearchProductBy.BorderRadius = 20;
            tbSearchProductBy.DefaultText = "";
            tbSearchProductBy.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchProductBy.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchProductBy.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchProductBy.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchProductBy.Enabled = false;
            tbSearchProductBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchProductBy.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchProductBy.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchProductBy.Location = new Point(308, 91);
            tbSearchProductBy.Margin = new Padding(5, 6, 5, 6);
            tbSearchProductBy.Name = "tbSearchProductBy";
            tbSearchProductBy.PasswordChar = '\0';
            tbSearchProductBy.PlaceholderText = "Buscar...";
            tbSearchProductBy.SelectedText = "";
            tbSearchProductBy.Size = new Size(288, 45);
            tbSearchProductBy.TabIndex = 19;
            tbSearchProductBy.TextChanged += TbSearchProductBy_TextChanged;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(ProductDataGridView);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 168);
            siticonePanel1.Margin = new Padding(3, 4, 3, 4);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1186, 500);
            siticonePanel1.TabIndex = 1;
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductDataGridView.ColumnHeadersHeight = 75;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductDataGridView.Columns.AddRange(new DataGridViewColumn[] { CodProd, NombreProd, PrecioVentaPub, Categoria, ImagePath, parentCode, ColumnaEditarProducto, ColumnaEliminarProducto });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ProductDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            ProductDataGridView.Dock = DockStyle.Fill;
            ProductDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.Location = new Point(0, 0);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.RowHeadersVisible = false;
            ProductDataGridView.RowHeadersWidth = 50;
            ProductDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            ProductDataGridView.RowTemplate.Height = 50;
            ProductDataGridView.Size = new Size(1186, 500);
            ProductDataGridView.TabIndex = 0;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ProductDataGridView.ThemeStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            ProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ProductDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ProductDataGridView.ThemeStyle.HeaderStyle.Height = 75;
            ProductDataGridView.ThemeStyle.ReadOnly = false;
            ProductDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            ProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ProductDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ProductDataGridView.ThemeStyle.RowsStyle.Height = 50;
            ProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ProductDataGridView.CellClick += ProductDataGridView_CellClick;
            // 
            // CodProd
            // 
            CodProd.FillWeight = 77.11364F;
            CodProd.HeaderText = "Código";
            CodProd.MinimumWidth = 6;
            CodProd.Name = "CodProd";
            CodProd.ReadOnly = true;
            CodProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NombreProd
            // 
            NombreProd.FillWeight = 154.22728F;
            NombreProd.HeaderText = "Nombre";
            NombreProd.MinimumWidth = 6;
            NombreProd.Name = "NombreProd";
            NombreProd.ReadOnly = true;
            NombreProd.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PrecioVentaPub
            // 
            PrecioVentaPub.FillWeight = 51.4090919F;
            PrecioVentaPub.HeaderText = "P.V.P";
            PrecioVentaPub.MinimumWidth = 6;
            PrecioVentaPub.Name = "PrecioVentaPub";
            PrecioVentaPub.ReadOnly = true;
            PrecioVentaPub.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 154.22728F;
            Categoria.HeaderText = "Categoría";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ImagePath
            // 
            ImagePath.FillWeight = 102.818184F;
            ImagePath.HeaderText = "Ruta de Imagen";
            ImagePath.Name = "ImagePath";
            // 
            // parentCode
            // 
            parentCode.FillWeight = 102.818184F;
            parentCode.HeaderText = "Padre";
            parentCode.Name = "parentCode";
            // 
            // ColumnaEditarProducto
            // 
            ColumnaEditarProducto.FillWeight = 82.38636F;
            ColumnaEditarProducto.HeaderText = "";
            ColumnaEditarProducto.Image = (Image)resources.GetObject("ColumnaEditarProducto.Image");
            ColumnaEditarProducto.MinimumWidth = 20;
            ColumnaEditarProducto.Name = "ColumnaEditarProducto";
            ColumnaEditarProducto.ReadOnly = true;
            ColumnaEditarProducto.Resizable = DataGridViewTriState.False;
            // 
            // ColumnaEliminarProducto
            // 
            ColumnaEliminarProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaEliminarProducto.HeaderText = "";
            ColumnaEliminarProducto.Image = (Image)resources.GetObject("ColumnaEliminarProducto.Image");
            ColumnaEliminarProducto.MinimumWidth = 20;
            ColumnaEliminarProducto.Name = "ColumnaEliminarProducto";
            ColumnaEliminarProducto.ReadOnly = true;
            ColumnaEliminarProducto.Resizable = DataGridViewTriState.False;
            ColumnaEliminarProducto.Width = 20;
            // 
            // AddCategory
            // 
            AddCategory.Controls.Add(categoryUsedLabel);
            AddCategory.Controls.Add(siticoneHtmlLabel3);
            AddCategory.Controls.Add(addCategoryTextBox);
            AddCategory.Controls.Add(addCategoryButton);
            AddCategory.Location = new Point(4, 44);
            AddCategory.Name = "AddCategory";
            AddCategory.Padding = new Padding(3);
            AddCategory.Size = new Size(1192, 672);
            AddCategory.TabIndex = 2;
            AddCategory.Text = "Añadir Categoría";
            AddCategory.UseVisualStyleBackColor = true;
            // 
            // categoryUsedLabel
            // 
            categoryUsedLabel.Anchor = AnchorStyles.None;
            categoryUsedLabel.BackColor = Color.Transparent;
            categoryUsedLabel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            categoryUsedLabel.ForeColor = Color.Red;
            categoryUsedLabel.Location = new Point(599, 292);
            categoryUsedLabel.Name = "categoryUsedLabel";
            categoryUsedLabel.Size = new Size(298, 22);
            categoryUsedLabel.TabIndex = 58;
            categoryUsedLabel.Text = "Ya existe una categoría con ese nombre";
            categoryUsedLabel.Visible = false;
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(347, 245);
            siticoneHtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(138, 23);
            siticoneHtmlLabel3.TabIndex = 57;
            siticoneHtmlLabel3.Text = "Nueva categoría";
            // 
            // addCategoryTextBox
            // 
            addCategoryTextBox.Anchor = AnchorStyles.None;
            addCategoryTextBox.BorderRadius = 20;
            addCategoryTextBox.DefaultText = "";
            addCategoryTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            addCategoryTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            addCategoryTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            addCategoryTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            addCategoryTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            addCategoryTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            addCategoryTextBox.Location = new Point(616, 235);
            addCategoryTextBox.Margin = new Padding(5, 9, 5, 9);
            addCategoryTextBox.Name = "addCategoryTextBox";
            addCategoryTextBox.PasswordChar = '\0';
            addCategoryTextBox.PlaceholderText = "";
            addCategoryTextBox.SelectedText = "";
            addCategoryTextBox.Size = new Size(249, 45);
            addCategoryTextBox.TabIndex = 56;
            addCategoryTextBox.TextOffset = new Point(5, 0);
            addCategoryTextBox.TextChanged += addCategoryTextBox_TextChanged;
            addCategoryTextBox.KeyPress += addCategoryTextBox_KeyPress;
            // 
            // addCategoryButton
            // 
            addCategoryButton.Anchor = AnchorStyles.None;
            addCategoryButton.BorderRadius = 20;
            addCategoryButton.DisabledState.BorderColor = Color.DarkGray;
            addCategoryButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addCategoryButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addCategoryButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addCategoryButton.Enabled = false;
            addCategoryButton.FillColor = Color.FromArgb(64, 64, 64);
            addCategoryButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addCategoryButton.ForeColor = Color.White;
            addCategoryButton.Location = new Point(515, 500);
            addCategoryButton.Margin = new Padding(3, 4, 3, 4);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(180, 45);
            addCategoryButton.TabIndex = 46;
            addCategoryButton.Text = "Añadir";
            addCategoryButton.Click += AddCategoryButton_Click;
            // 
            // EditDeleteCategory
            // 
            EditDeleteCategory.Controls.Add(categoryDataGridView);
            EditDeleteCategory.Location = new Point(4, 44);
            EditDeleteCategory.Name = "EditDeleteCategory";
            EditDeleteCategory.Padding = new Padding(3);
            EditDeleteCategory.Size = new Size(1192, 672);
            EditDeleteCategory.TabIndex = 3;
            EditDeleteCategory.Text = "Editar Categoría";
            EditDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // categoryDataGridView
            // 
            categoryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            categoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            categoryDataGridView.ColumnHeadersHeight = 75;
            categoryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categoryDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, updateCategoryColumn, deleteCategoryColumn });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            categoryDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            categoryDataGridView.Dock = DockStyle.Fill;
            categoryDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            categoryDataGridView.Location = new Point(3, 3);
            categoryDataGridView.Name = "categoryDataGridView";
            categoryDataGridView.RowHeadersVisible = false;
            categoryDataGridView.RowHeadersWidth = 50;
            categoryDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            categoryDataGridView.RowTemplate.Height = 50;
            categoryDataGridView.Size = new Size(1186, 666);
            categoryDataGridView.TabIndex = 1;
            categoryDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            categoryDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            categoryDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            categoryDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            categoryDataGridView.ThemeStyle.BackColor = Color.White;
            categoryDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            categoryDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            categoryDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            categoryDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            categoryDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            categoryDataGridView.ThemeStyle.HeaderStyle.Height = 75;
            categoryDataGridView.ThemeStyle.ReadOnly = false;
            categoryDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            categoryDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            categoryDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            categoryDataGridView.ThemeStyle.RowsStyle.Height = 50;
            categoryDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            categoryDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            categoryDataGridView.CellClick += CategoryDataGridView_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 75F;
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 150F;
            dataGridViewTextBoxColumn2.HeaderText = "Categoría";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // updateCategoryColumn
            // 
            updateCategoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            updateCategoryColumn.HeaderText = "";
            updateCategoryColumn.Image = (Image)resources.GetObject("updateCategoryColumn.Image");
            updateCategoryColumn.MinimumWidth = 6;
            updateCategoryColumn.Name = "updateCategoryColumn";
            updateCategoryColumn.ReadOnly = true;
            updateCategoryColumn.Resizable = DataGridViewTriState.False;
            updateCategoryColumn.Width = 182;
            // 
            // deleteCategoryColumn
            // 
            deleteCategoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            deleteCategoryColumn.HeaderText = "";
            deleteCategoryColumn.Image = (Image)resources.GetObject("deleteCategoryColumn.Image");
            deleteCategoryColumn.MinimumWidth = 6;
            deleteCategoryColumn.Name = "deleteCategoryColumn";
            deleteCategoryColumn.ReadOnly = true;
            deleteCategoryColumn.Resizable = DataGridViewTriState.False;
            deleteCategoryColumn.Width = 182;
            // 
            // UC_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Name = "UC_Products";
            Size = new Size(1200, 720);
            siticoneTabControl1.ResumeLayout(false);
            Añadir.ResumeLayout(false);
            Añadir.PerformLayout();
            Editar.ResumeLayout(false);
            Editar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            AddCategory.ResumeLayout(false);
            AddCategory.PerformLayout();
            EditDeleteCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)categoryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage Añadir;
        private TabPage Editar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView ProductDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchProdutBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearchProductBy;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView BatchDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchBatchBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearchBatchByBatchCode;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddProduct;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel6;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel5;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductName;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddBatch;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbBatchProductName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbQuantity;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel4;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureDate;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton rbChooseDate;
        private Siticone.Desktop.UI.WinForms.SiticoneRadioButton rbCurrentDate;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox GBFechaHoraElab;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel11;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SBExaminar;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbProductCode;
        private DataGridViewTextBoxColumn ColumnaCodLote;
        private DataGridViewTextBoxColumn ColumnaCodProd;
        private DataGridViewTextBoxColumn ColunmaCantidad;
        private DataGridViewTextBoxColumn ColumnaFechayHora;
        private DataGridViewImageColumn ColumnaEditarLote;
        private DataGridViewImageColumn ColumnaEliminarLote;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductCodeNotUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductNameNotUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidSalesPriceToThePublic;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidImagePath;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelSearchProductWithoutField;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpSearchBatchByDate;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelBatchProductNameNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelManufactureDateNotChosen;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpManufactureHour;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel_buscarLote_sin_campo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchBatchByProductCode;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelProductCodeNotChosenInTheSearchBatchTab;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCategoryNotChosenInTheSearchProductTab;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchProductByCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox parentComboBox;
        private CheckBox isParentCheckBox;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel parentErrorLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel parentLabel;
        private CheckBox isSubproductCheckBox;
        private TabPage AddCategory;
        private TabPage EditDeleteCategory;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel categoryUsedLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addCategoryTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneButton addCategoryButton;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView categoryDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn updateCategoryColumn;
        private DataGridViewImageColumn deleteCategoryColumn;
        private DataGridViewTextBoxColumn CodProd;
        private DataGridViewTextBoxColumn NombreProd;
        private DataGridViewTextBoxColumn PrecioVentaPub;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn ImagePath;
        private DataGridViewTextBoxColumn parentCode;
        private DataGridViewImageColumn ColumnaEditarProducto;
        private DataGridViewImageColumn ColumnaEliminarProducto;
    }
}
