namespace SGV_CLP.GUI
{
    partial class UC_Customers
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Customers));
            siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            TabRegistrar = new TabPage();
            labelCustomerIDUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCustomerIDNotUnique = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelValidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelWrongEMail = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbEMail = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelCorrectPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbFirstName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelWrongPhoneNumberLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelCorrectCustomerIDLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buttonAddCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            labelValidCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            labelInvalidCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbHomeAddress = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            labelWrongCustomerIDLength = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbCustomerID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            tbPhoneNumber = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel16 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            tbFirstLastName = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticoneHtmlLabel17 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            siticoneHtmlLabel7 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TabEditar = new TabPage();
            labelSearchCustomerWithoutField = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            cbSearchCustomerBy = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            tbSearchCustomerBy = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            CustomerDataGridView = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            ColumnaCedula = new DataGridViewTextBoxColumn();
            ColumnaNombres = new DataGridViewTextBoxColumn();
            ColumnaApellidos = new DataGridViewTextBoxColumn();
            ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaTelefono = new DataGridViewTextBoxColumn();
            ColumnaCorreo = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewImageColumn();
            ColumnaEliminar = new DataGridViewImageColumn();
            siticoneTabControl1.SuspendLayout();
            TabRegistrar.SuspendLayout();
            TabEditar.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            siticoneTabControl1.Controls.Add(TabRegistrar);
            siticoneTabControl1.Controls.Add(TabEditar);
            siticoneTabControl1.Dock = DockStyle.Fill;
            siticoneTabControl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.ItemSize = new Size(120, 40);
            siticoneTabControl1.Location = new Point(0, 0);
            siticoneTabControl1.Name = "siticoneTabControl1";
            siticoneTabControl1.SelectedIndex = 0;
            siticoneTabControl1.Size = new Size(1446, 845);
            siticoneTabControl1.TabButtonHoverState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonHoverState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonHoverState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonHoverState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonHoverState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonIdleState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonIdleState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(156, 160, 167);
            siticoneTabControl1.TabButtonIdleState.InnerColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.BorderColor = Color.Empty;
            siticoneTabControl1.TabButtonSelectedState.FillColor = Color.Black;
            siticoneTabControl1.TabButtonSelectedState.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneTabControl1.TabButtonSelectedState.ForeColor = Color.White;
            siticoneTabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(76, 132, 255);
            siticoneTabControl1.TabButtonSize = new Size(120, 40);
            siticoneTabControl1.TabIndex = 2;
            siticoneTabControl1.TabMenuBackColor = Color.Black;
            siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            siticoneTabControl1.SelectedIndexChanged += siticoneTabControl1_SelectedIndexChanged;
            // 
            // TabRegistrar
            // 
            TabRegistrar.Controls.Add(labelCustomerIDUnique);
            TabRegistrar.Controls.Add(labelCustomerIDNotUnique);
            TabRegistrar.Controls.Add(labelValidPhoneNumber);
            TabRegistrar.Controls.Add(labelInvalidPhoneNumber);
            TabRegistrar.Controls.Add(labelCorrectEMail);
            TabRegistrar.Controls.Add(labelWrongEMail);
            TabRegistrar.Controls.Add(siticoneHtmlLabel2);
            TabRegistrar.Controls.Add(tbEMail);
            TabRegistrar.Controls.Add(labelCorrectPhoneNumberLength);
            TabRegistrar.Controls.Add(tbFirstName);
            TabRegistrar.Controls.Add(labelWrongPhoneNumberLength);
            TabRegistrar.Controls.Add(labelCorrectCustomerIDLength);
            TabRegistrar.Controls.Add(buttonAddCustomer);
            TabRegistrar.Controls.Add(labelValidCustomerID);
            TabRegistrar.Controls.Add(siticoneHtmlLabel3);
            TabRegistrar.Controls.Add(labelInvalidCustomerID);
            TabRegistrar.Controls.Add(tbHomeAddress);
            TabRegistrar.Controls.Add(labelWrongCustomerIDLength);
            TabRegistrar.Controls.Add(tbCustomerID);
            TabRegistrar.Controls.Add(tbPhoneNumber);
            TabRegistrar.Controls.Add(siticoneHtmlLabel16);
            TabRegistrar.Controls.Add(siticoneHtmlLabel1);
            TabRegistrar.Controls.Add(tbFirstLastName);
            TabRegistrar.Controls.Add(siticoneHtmlLabel17);
            TabRegistrar.Controls.Add(siticoneHtmlLabel7);
            TabRegistrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabRegistrar.Location = new Point(4, 44);
            TabRegistrar.Margin = new Padding(3, 4, 3, 4);
            TabRegistrar.Name = "TabRegistrar";
            TabRegistrar.Padding = new Padding(3, 4, 3, 4);
            TabRegistrar.Size = new Size(1438, 797);
            TabRegistrar.TabIndex = 0;
            TabRegistrar.Text = "Añadir";
            TabRegistrar.UseVisualStyleBackColor = true;
            // 
            // labelCustomerIDUnique
            // 
            labelCustomerIDUnique.Anchor = AnchorStyles.None;
            labelCustomerIDUnique.BackColor = Color.Transparent;
            labelCustomerIDUnique.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomerIDUnique.ForeColor = Color.Turquoise;
            labelCustomerIDUnique.Location = new Point(767, 178);
            labelCustomerIDUnique.Margin = new Padding(3, 2, 3, 2);
            labelCustomerIDUnique.Name = "labelCustomerIDUnique";
            labelCustomerIDUnique.Size = new Size(110, 22);
            labelCustomerIDUnique.TabIndex = 89;
            labelCustomerIDUnique.Text = "¡Cédula única!";
            // 
            // labelCustomerIDNotUnique
            // 
            labelCustomerIDNotUnique.Anchor = AnchorStyles.None;
            labelCustomerIDNotUnique.BackColor = Color.Transparent;
            labelCustomerIDNotUnique.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomerIDNotUnique.ForeColor = Color.Red;
            labelCustomerIDNotUnique.Location = new Point(767, 178);
            labelCustomerIDNotUnique.Margin = new Padding(3, 2, 3, 2);
            labelCustomerIDNotUnique.Name = "labelCustomerIDNotUnique";
            labelCustomerIDNotUnique.Size = new Size(165, 22);
            labelCustomerIDNotUnique.TabIndex = 88;
            labelCustomerIDNotUnique.Text = "¡Cédula ya registrada!";
            // 
            // labelValidPhoneNumber
            // 
            labelValidPhoneNumber.Anchor = AnchorStyles.None;
            labelValidPhoneNumber.BackColor = Color.Transparent;
            labelValidPhoneNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidPhoneNumber.ForeColor = Color.Turquoise;
            labelValidPhoneNumber.Location = new Point(852, 485);
            labelValidPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            labelValidPhoneNumber.Name = "labelValidPhoneNumber";
            labelValidPhoneNumber.Size = new Size(123, 22);
            labelValidPhoneNumber.TabIndex = 87;
            labelValidPhoneNumber.Text = "¡Teléfono válido!";
            labelValidPhoneNumber.Visible = false;
            // 
            // labelInvalidPhoneNumber
            // 
            labelInvalidPhoneNumber.Anchor = AnchorStyles.None;
            labelInvalidPhoneNumber.BackColor = Color.Transparent;
            labelInvalidPhoneNumber.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidPhoneNumber.ForeColor = Color.Red;
            labelInvalidPhoneNumber.Location = new Point(852, 485);
            labelInvalidPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            labelInvalidPhoneNumber.Name = "labelInvalidPhoneNumber";
            labelInvalidPhoneNumber.Size = new Size(135, 22);
            labelInvalidPhoneNumber.TabIndex = 86;
            labelInvalidPhoneNumber.Text = "¡Teléfono inválido!";
            // 
            // labelCorrectEMail
            // 
            labelCorrectEMail.Anchor = AnchorStyles.None;
            labelCorrectEMail.BackColor = Color.Transparent;
            labelCorrectEMail.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectEMail.ForeColor = Color.Turquoise;
            labelCorrectEMail.Location = new Point(937, 411);
            labelCorrectEMail.Name = "labelCorrectEMail";
            labelCorrectEMail.Size = new Size(98, 22);
            labelCorrectEMail.TabIndex = 85;
            labelCorrectEMail.Text = "¡Email válido!";
            // 
            // labelWrongEMail
            // 
            labelWrongEMail.Anchor = AnchorStyles.None;
            labelWrongEMail.BackColor = Color.Transparent;
            labelWrongEMail.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongEMail.ForeColor = Color.Red;
            labelWrongEMail.Location = new Point(937, 411);
            labelWrongEMail.Name = "labelWrongEMail";
            labelWrongEMail.Size = new Size(110, 22);
            labelWrongEMail.TabIndex = 84;
            labelWrongEMail.Text = "¡Email inválido!";
            // 
            // siticoneHtmlLabel2
            // 
            siticoneHtmlLabel2.Anchor = AnchorStyles.None;
            siticoneHtmlLabel2.BackColor = Color.Transparent;
            siticoneHtmlLabel2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel2.Location = new Point(385, 409);
            siticoneHtmlLabel2.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            siticoneHtmlLabel2.Size = new Size(58, 26);
            siticoneHtmlLabel2.TabIndex = 62;
            siticoneHtmlLabel2.Text = "eMail";
            // 
            // tbEMail
            // 
            tbEMail.Anchor = AnchorStyles.None;
            tbEMail.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbEMail.BorderRadius = 20;
            tbEMail.DefaultText = "";
            tbEMail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbEMail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbEMail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbEMail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEMail.ForeColor = Color.Black;
            tbEMail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbEMail.Location = new Point(526, 400);
            tbEMail.Margin = new Padding(5, 9, 5, 9);
            tbEMail.Name = "tbEMail";
            tbEMail.PasswordChar = '\0';
            tbEMail.PlaceholderText = "";
            tbEMail.SelectedText = "";
            tbEMail.Size = new Size(384, 45);
            tbEMail.TabIndex = 61;
            tbEMail.TextOffset = new Point(5, 0);
            tbEMail.TextChanged += TbEMail_TextChanged;
            tbEMail.KeyPress += tbEMail_KeyPress;
            // 
            // labelCorrectPhoneNumberLength
            // 
            labelCorrectPhoneNumberLength.Anchor = AnchorStyles.None;
            labelCorrectPhoneNumberLength.BackColor = Color.Transparent;
            labelCorrectPhoneNumberLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectPhoneNumberLength.ForeColor = Color.Turquoise;
            labelCorrectPhoneNumberLength.Location = new Point(852, 460);
            labelCorrectPhoneNumberLength.Margin = new Padding(3, 4, 3, 4);
            labelCorrectPhoneNumberLength.Name = "labelCorrectPhoneNumberLength";
            labelCorrectPhoneNumberLength.Size = new Size(143, 22);
            labelCorrectPhoneNumberLength.TabIndex = 60;
            labelCorrectPhoneNumberLength.Text = "¡Longitud correcta!";
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.None;
            tbFirstName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbFirstName.BorderRadius = 20;
            tbFirstName.DefaultText = "";
            tbFirstName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFirstName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFirstName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFirstName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstName.ForeColor = Color.Black;
            tbFirstName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstName.Location = new Point(526, 211);
            tbFirstName.Margin = new Padding(0);
            tbFirstName.MaxLength = 50;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PasswordChar = '\0';
            tbFirstName.PlaceholderText = "";
            tbFirstName.SelectedText = "";
            tbFirstName.Size = new Size(278, 45);
            tbFirstName.TabIndex = 44;
            tbFirstName.TextOffset = new Point(5, 0);
            tbFirstName.TextChanged += TbFirstName_TextChanged;
            tbFirstName.KeyPress += tbFirstName_KeyPress;
            // 
            // labelWrongPhoneNumberLength
            // 
            labelWrongPhoneNumberLength.Anchor = AnchorStyles.None;
            labelWrongPhoneNumberLength.BackColor = Color.Transparent;
            labelWrongPhoneNumberLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongPhoneNumberLength.ForeColor = Color.Red;
            labelWrongPhoneNumberLength.Location = new Point(852, 460);
            labelWrongPhoneNumberLength.Margin = new Padding(3, 4, 3, 4);
            labelWrongPhoneNumberLength.Name = "labelWrongPhoneNumberLength";
            labelWrongPhoneNumberLength.Size = new Size(182, 22);
            labelWrongPhoneNumberLength.TabIndex = 59;
            labelWrongPhoneNumberLength.Text = "¡Se necesitan 10 caract.!";
            // 
            // labelCorrectCustomerIDLength
            // 
            labelCorrectCustomerIDLength.Anchor = AnchorStyles.None;
            labelCorrectCustomerIDLength.BackColor = Color.Transparent;
            labelCorrectCustomerIDLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorrectCustomerIDLength.ForeColor = Color.Turquoise;
            labelCorrectCustomerIDLength.Location = new Point(767, 153);
            labelCorrectCustomerIDLength.Name = "labelCorrectCustomerIDLength";
            labelCorrectCustomerIDLength.Size = new Size(143, 22);
            labelCorrectCustomerIDLength.TabIndex = 57;
            labelCorrectCustomerIDLength.Text = "¡Longitud correcta!";
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Anchor = AnchorStyles.Bottom;
            buttonAddCustomer.BorderRadius = 20;
            buttonAddCustomer.DisabledState.BorderColor = Color.DarkGray;
            buttonAddCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonAddCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonAddCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonAddCustomer.FillColor = Color.Black;
            buttonAddCustomer.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustomer.ForeColor = Color.White;
            buttonAddCustomer.Location = new Point(635, 617);
            buttonAddCustomer.Margin = new Padding(3, 4, 3, 4);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(180, 45);
            buttonAddCustomer.TabIndex = 39;
            buttonAddCustomer.Text = "Añadir";
            buttonAddCustomer.Click += ButtonAddCustomer_Click;
            // 
            // labelValidCustomerID
            // 
            labelValidCustomerID.Anchor = AnchorStyles.None;
            labelValidCustomerID.BackColor = Color.Transparent;
            labelValidCustomerID.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelValidCustomerID.ForeColor = Color.Turquoise;
            labelValidCustomerID.Location = new Point(767, 129);
            labelValidCustomerID.Name = "labelValidCustomerID";
            labelValidCustomerID.Size = new Size(115, 22);
            labelValidCustomerID.TabIndex = 56;
            labelValidCustomerID.Text = "¡Cédula válida!";
            // 
            // siticoneHtmlLabel3
            // 
            siticoneHtmlLabel3.Anchor = AnchorStyles.None;
            siticoneHtmlLabel3.BackColor = Color.Transparent;
            siticoneHtmlLabel3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel3.Location = new Point(385, 157);
            siticoneHtmlLabel3.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            siticoneHtmlLabel3.Size = new Size(95, 26);
            siticoneHtmlLabel3.TabIndex = 24;
            siticoneHtmlLabel3.Text = "Cédula *";
            // 
            // labelInvalidCustomerID
            // 
            labelInvalidCustomerID.Anchor = AnchorStyles.None;
            labelInvalidCustomerID.BackColor = Color.Transparent;
            labelInvalidCustomerID.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvalidCustomerID.ForeColor = Color.Red;
            labelInvalidCustomerID.Location = new Point(767, 129);
            labelInvalidCustomerID.Name = "labelInvalidCustomerID";
            labelInvalidCustomerID.Size = new Size(127, 22);
            labelInvalidCustomerID.TabIndex = 55;
            labelInvalidCustomerID.Text = "¡Cédula inválida!";
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
            tbHomeAddress.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbHomeAddress.ForeColor = Color.Black;
            tbHomeAddress.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbHomeAddress.Location = new Point(526, 337);
            tbHomeAddress.Margin = new Padding(5, 9, 5, 9);
            tbHomeAddress.Name = "tbHomeAddress";
            tbHomeAddress.PasswordChar = '\0';
            tbHomeAddress.PlaceholderText = "";
            tbHomeAddress.SelectedText = "";
            tbHomeAddress.Size = new Size(390, 45);
            tbHomeAddress.TabIndex = 42;
            tbHomeAddress.TextOffset = new Point(5, 0);
            tbHomeAddress.TextChanged += TbHomeAddress_TextChanged;
            tbHomeAddress.KeyPress += tbHomeAddress_KeyPress;
            // 
            // labelWrongCustomerIDLength
            // 
            labelWrongCustomerIDLength.Anchor = AnchorStyles.None;
            labelWrongCustomerIDLength.BackColor = Color.Transparent;
            labelWrongCustomerIDLength.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWrongCustomerIDLength.ForeColor = Color.Red;
            labelWrongCustomerIDLength.Location = new Point(765, 153);
            labelWrongCustomerIDLength.Name = "labelWrongCustomerIDLength";
            labelWrongCustomerIDLength.Size = new Size(182, 22);
            labelWrongCustomerIDLength.TabIndex = 54;
            labelWrongCustomerIDLength.Text = "¡Se necesitan 10 caract.!";
            // 
            // tbCustomerID
            // 
            tbCustomerID.Anchor = AnchorStyles.None;
            tbCustomerID.BorderRadius = 20;
            tbCustomerID.DefaultText = "";
            tbCustomerID.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbCustomerID.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbCustomerID.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbCustomerID.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbCustomerID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCustomerID.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbCustomerID.ForeColor = Color.Black;
            tbCustomerID.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbCustomerID.Location = new Point(526, 148);
            tbCustomerID.Margin = new Padding(8, 7, 8, 7);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.PasswordChar = '\0';
            tbCustomerID.PlaceholderText = "";
            tbCustomerID.SelectedText = "";
            tbCustomerID.Size = new Size(200, 45);
            tbCustomerID.TabIndex = 40;
            tbCustomerID.TextOffset = new Point(5, 0);
            tbCustomerID.TextChanged += tbCustomerID_TextChanged;
            tbCustomerID.KeyPress += tbCustomerID_KeyPress;
            tbCustomerID.KeyUp += tbCustomerID_KeyUp;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Anchor = AnchorStyles.None;
            tbPhoneNumber.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbPhoneNumber.BorderRadius = 20;
            tbPhoneNumber.DefaultText = "";
            tbPhoneNumber.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbPhoneNumber.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbPhoneNumber.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbPhoneNumber.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.ForeColor = Color.Black;
            tbPhoneNumber.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbPhoneNumber.Location = new Point(524, 463);
            tbPhoneNumber.Margin = new Padding(5, 9, 5, 9);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.PasswordChar = '\0';
            tbPhoneNumber.PlaceholderText = "";
            tbPhoneNumber.SelectedText = "";
            tbPhoneNumber.Size = new Size(305, 45);
            tbPhoneNumber.TabIndex = 43;
            tbPhoneNumber.TextOffset = new Point(5, 0);
            tbPhoneNumber.TextChanged += TbPhoneNumber_TextChanged;
            tbPhoneNumber.KeyPress += tbPhoneNumber_KeyPress;
            // 
            // siticoneHtmlLabel16
            // 
            siticoneHtmlLabel16.Anchor = AnchorStyles.None;
            siticoneHtmlLabel16.BackColor = Color.Transparent;
            siticoneHtmlLabel16.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel16.Location = new Point(385, 283);
            siticoneHtmlLabel16.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel16.Name = "siticoneHtmlLabel16";
            siticoneHtmlLabel16.Size = new Size(102, 26);
            siticoneHtmlLabel16.TabIndex = 47;
            siticoneHtmlLabel16.Text = "Apellido *";
            // 
            // siticoneHtmlLabel1
            // 
            siticoneHtmlLabel1.Anchor = AnchorStyles.None;
            siticoneHtmlLabel1.BackColor = Color.Transparent;
            siticoneHtmlLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel1.Location = new Point(385, 346);
            siticoneHtmlLabel1.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            siticoneHtmlLabel1.Size = new Size(100, 26);
            siticoneHtmlLabel1.TabIndex = 41;
            siticoneHtmlLabel1.Text = "Dirección";
            // 
            // tbFirstLastName
            // 
            tbFirstLastName.Anchor = AnchorStyles.None;
            tbFirstLastName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tbFirstLastName.BorderRadius = 20;
            tbFirstLastName.DefaultText = "";
            tbFirstLastName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbFirstLastName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbFirstLastName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbFirstLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbFirstLastName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstLastName.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbFirstLastName.ForeColor = Color.Black;
            tbFirstLastName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbFirstLastName.Location = new Point(526, 274);
            tbFirstLastName.Margin = new Padding(5, 9, 5, 9);
            tbFirstLastName.MinimumSize = new Size(0, 45);
            tbFirstLastName.Name = "tbFirstLastName";
            tbFirstLastName.PasswordChar = '\0';
            tbFirstLastName.PlaceholderText = "";
            tbFirstLastName.SelectedText = "";
            tbFirstLastName.Size = new Size(278, 45);
            tbFirstLastName.TabIndex = 46;
            tbFirstLastName.TextOffset = new Point(5, 0);
            tbFirstLastName.TextChanged += tbFirstLastName_TextChanged;
            tbFirstLastName.KeyPress += tbFirstLastName_KeyPress;
            // 
            // siticoneHtmlLabel17
            // 
            siticoneHtmlLabel17.Anchor = AnchorStyles.None;
            siticoneHtmlLabel17.BackColor = Color.Transparent;
            siticoneHtmlLabel17.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel17.Location = new Point(385, 220);
            siticoneHtmlLabel17.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel17.Name = "siticoneHtmlLabel17";
            siticoneHtmlLabel17.Size = new Size(103, 26);
            siticoneHtmlLabel17.TabIndex = 45;
            siticoneHtmlLabel17.Text = "Nombre *";
            // 
            // siticoneHtmlLabel7
            // 
            siticoneHtmlLabel7.Anchor = AnchorStyles.None;
            siticoneHtmlLabel7.BackColor = Color.Transparent;
            siticoneHtmlLabel7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneHtmlLabel7.Location = new Point(383, 472);
            siticoneHtmlLabel7.Margin = new Padding(3, 4, 3, 4);
            siticoneHtmlLabel7.Name = "siticoneHtmlLabel7";
            siticoneHtmlLabel7.Size = new Size(92, 26);
            siticoneHtmlLabel7.TabIndex = 31;
            siticoneHtmlLabel7.Text = "Teléfono";
            // 
            // TabEditar
            // 
            TabEditar.Controls.Add(labelSearchCustomerWithoutField);
            TabEditar.Controls.Add(cbSearchCustomerBy);
            TabEditar.Controls.Add(tbSearchCustomerBy);
            TabEditar.Controls.Add(siticonePanel1);
            TabEditar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabEditar.Location = new Point(4, 44);
            TabEditar.Margin = new Padding(3, 4, 3, 4);
            TabEditar.Name = "TabEditar";
            TabEditar.Padding = new Padding(3, 4, 3, 4);
            TabEditar.Size = new Size(1438, 797);
            TabEditar.TabIndex = 1;
            TabEditar.Text = "Buscar";
            TabEditar.UseVisualStyleBackColor = true;
            // 
            // labelSearchCustomerWithoutField
            // 
            labelSearchCustomerWithoutField.Anchor = AnchorStyles.None;
            labelSearchCustomerWithoutField.BackColor = Color.Transparent;
            labelSearchCustomerWithoutField.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearchCustomerWithoutField.ForeColor = Color.Red;
            labelSearchCustomerWithoutField.Location = new Point(328, 109);
            labelSearchCustomerWithoutField.Name = "labelSearchCustomerWithoutField";
            labelSearchCustomerWithoutField.Size = new Size(363, 24);
            labelSearchCustomerWithoutField.TabIndex = 19;
            labelSearchCustomerWithoutField.Text = "¡Seleccione un parámetro para buscar!";
            // 
            // cbSearchCustomerBy
            // 
            cbSearchCustomerBy.Anchor = AnchorStyles.None;
            cbSearchCustomerBy.BackColor = Color.Transparent;
            cbSearchCustomerBy.BorderRadius = 20;
            cbSearchCustomerBy.DrawMode = DrawMode.OwnerDrawFixed;
            cbSearchCustomerBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchCustomerBy.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSearchCustomerBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSearchCustomerBy.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbSearchCustomerBy.ForeColor = Color.FromArgb(68, 88, 112);
            cbSearchCustomerBy.ItemHeight = 40;
            cbSearchCustomerBy.Items.AddRange(new object[] { "Seleccionar...", "CI", "Nombres", "Apellidos", "Teléfono" });
            cbSearchCustomerBy.Location = new Point(714, 143);
            cbSearchCustomerBy.Margin = new Padding(3, 4, 3, 4);
            cbSearchCustomerBy.MinimumSize = new Size(200, 0);
            cbSearchCustomerBy.Name = "cbSearchCustomerBy";
            cbSearchCustomerBy.Size = new Size(342, 46);
            cbSearchCustomerBy.TabIndex = 16;
            cbSearchCustomerBy.TextOffset = new Point(5, 0);
            cbSearchCustomerBy.SelectedIndexChanged += cbSearchCustomerBy_SelectedIndexChanged;
            // 
            // tbSearchCustomerBy
            // 
            tbSearchCustomerBy.Anchor = AnchorStyles.None;
            tbSearchCustomerBy.BorderRadius = 20;
            tbSearchCustomerBy.DefaultText = "";
            tbSearchCustomerBy.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearchCustomerBy.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearchCustomerBy.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearchCustomerBy.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearchCustomerBy.Enabled = false;
            tbSearchCustomerBy.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchCustomerBy.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchCustomerBy.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearchCustomerBy.Location = new Point(328, 144);
            tbSearchCustomerBy.Margin = new Padding(5, 8, 5, 8);
            tbSearchCustomerBy.Name = "tbSearchCustomerBy";
            tbSearchCustomerBy.PasswordChar = '\0';
            tbSearchCustomerBy.PlaceholderText = "Buscar...";
            tbSearchCustomerBy.SelectedText = "";
            tbSearchCustomerBy.Size = new Size(363, 45);
            tbSearchCustomerBy.TabIndex = 15;
            tbSearchCustomerBy.TextOffset = new Point(5, 0);
            tbSearchCustomerBy.TextChanged += tbSearchCustomerBy_TextChanged;
            tbSearchCustomerBy.KeyPress += tbSearchCustomerBy_KeyPress;
            // 
            // siticonePanel1
            // 
            siticonePanel1.Controls.Add(CustomerDataGridView);
            siticonePanel1.Dock = DockStyle.Bottom;
            siticonePanel1.Location = new Point(3, 293);
            siticonePanel1.Margin = new Padding(3, 4, 3, 4);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(1432, 500);
            siticonePanel1.TabIndex = 1;
            // 
            // CustomerDataGridView
            // 
            dataGridViewCellStyle5.BackColor = Color.White;
            CustomerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            CustomerDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CustomerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CustomerDataGridView.ColumnHeadersHeight = 60;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerDataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnaCedula, ColumnaNombres, ColumnaApellidos, ColumnaDireccion, ColumnaTelefono, ColumnaCorreo, ColumnaEditar, ColumnaEliminar });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            CustomerDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            CustomerDataGridView.Dock = DockStyle.Fill;
            CustomerDataGridView.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.Location = new Point(0, 0);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            CustomerDataGridView.RowHeadersVisible = false;
            CustomerDataGridView.RowHeadersWidth = 50;
            CustomerDataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            CustomerDataGridView.RowTemplate.Height = 50;
            CustomerDataGridView.Size = new Size(1432, 500);
            CustomerDataGridView.TabIndex = 0;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomerDataGridView.ThemeStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomerDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomerDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomerDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerDataGridView.ThemeStyle.HeaderStyle.Height = 60;
            CustomerDataGridView.ThemeStyle.ReadOnly = false;
            CustomerDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomerDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerDataGridView.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomerDataGridView.ThemeStyle.RowsStyle.Height = 50;
            CustomerDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomerDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomerDataGridView.CellClick += CustomerDataGridView_CellClick;
            // 
            // ColumnaCedula
            // 
            ColumnaCedula.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaCedula.HeaderText = "CI";
            ColumnaCedula.MinimumWidth = 6;
            ColumnaCedula.Name = "ColumnaCedula";
            ColumnaCedula.ReadOnly = true;
            ColumnaCedula.Resizable = DataGridViewTriState.False;
            ColumnaCedula.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnaCedula.Width = 53;
            // 
            // ColumnaNombres
            // 
            ColumnaNombres.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaNombres.HeaderText = "Nombres";
            ColumnaNombres.MinimumWidth = 6;
            ColumnaNombres.Name = "ColumnaNombres";
            ColumnaNombres.ReadOnly = true;
            ColumnaNombres.Resizable = DataGridViewTriState.False;
            ColumnaNombres.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnaNombres.Width = 114;
            // 
            // ColumnaApellidos
            // 
            ColumnaApellidos.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaApellidos.HeaderText = "Apellidos";
            ColumnaApellidos.MinimumWidth = 6;
            ColumnaApellidos.Name = "ColumnaApellidos";
            ColumnaApellidos.ReadOnly = true;
            ColumnaApellidos.Resizable = DataGridViewTriState.False;
            ColumnaApellidos.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnaApellidos.Width = 114;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaDireccion.HeaderText = "Dirección";
            ColumnaDireccion.MinimumWidth = 6;
            ColumnaDireccion.Name = "ColumnaDireccion";
            ColumnaDireccion.ReadOnly = true;
            ColumnaDireccion.Resizable = DataGridViewTriState.False;
            ColumnaDireccion.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnaDireccion.Width = 119;
            // 
            // ColumnaTelefono
            // 
            ColumnaTelefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnaTelefono.HeaderText = "Teléfono";
            ColumnaTelefono.MinimumWidth = 6;
            ColumnaTelefono.Name = "ColumnaTelefono";
            ColumnaTelefono.ReadOnly = true;
            ColumnaTelefono.Resizable = DataGridViewTriState.False;
            ColumnaTelefono.SortMode = DataGridViewColumnSortMode.Programmatic;
            ColumnaTelefono.Width = 110;
            // 
            // ColumnaCorreo
            // 
            ColumnaCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnaCorreo.HeaderText = "Correo Electrónico";
            ColumnaCorreo.MinimumWidth = 6;
            ColumnaCorreo.Name = "ColumnaCorreo";
            ColumnaCorreo.Resizable = DataGridViewTriState.False;
            ColumnaCorreo.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // ColumnaEditar
            // 
            ColumnaEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.Padding = new Padding(5);
            ColumnaEditar.DefaultCellStyle = dataGridViewCellStyle7;
            ColumnaEditar.HeaderText = "";
            ColumnaEditar.Image = (Image)resources.GetObject("ColumnaEditar.Image");
            ColumnaEditar.MinimumWidth = 50;
            ColumnaEditar.Name = "ColumnaEditar";
            ColumnaEditar.Resizable = DataGridViewTriState.False;
            ColumnaEditar.Width = 50;
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColumnaEliminar.HeaderText = "";
            ColumnaEliminar.Image = (Image)resources.GetObject("ColumnaEliminar.Image");
            ColumnaEliminar.MinimumWidth = 50;
            ColumnaEliminar.Name = "ColumnaEliminar";
            ColumnaEliminar.Resizable = DataGridViewTriState.False;
            ColumnaEliminar.Width = 50;
            // 
            // UC_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneTabControl1);
            Name = "UC_Customers";
            Size = new Size(1446, 845);
            siticoneTabControl1.ResumeLayout(false);
            TabRegistrar.ResumeLayout(false);
            TabRegistrar.PerformLayout();
            TabEditar.ResumeLayout(false);
            TabEditar.PerformLayout();
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private TabPage TabRegistrar;
        private TabPage TabEditar;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView CustomerDataGridView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbHomeAddress;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonAddCustomer;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbSearchCustomerBy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbSearchCustomerBy;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel16;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbFirstLastName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel17;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbFirstName;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectCustomerIDLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidCustomerID;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongCustomerIDLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectPhoneNumberLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongPhoneNumberLength;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelSearchCustomerWithoutField;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCorrectEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelWrongEMail;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelValidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelInvalidPhoneNumber;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCustomerIDUnique;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel labelCustomerIDNotUnique;
        private DataGridViewTextBoxColumn ColumnaCedula;
        private DataGridViewTextBoxColumn ColumnaNombres;
        private DataGridViewTextBoxColumn ColumnaApellidos;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaTelefono;
        private DataGridViewTextBoxColumn ColumnaCorreo;
        private DataGridViewImageColumn ColumnaEditar;
        private DataGridViewImageColumn ColumnaEliminar;
    }
}
