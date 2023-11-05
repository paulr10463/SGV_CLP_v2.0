namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class UC_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            siticonePictureBox1 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            lessButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            plusButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            quantityField = new TextBox();
            label1 = new Label();
            openSubproductsButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.ImageRotate = 0F;
            siticonePictureBox1.InitialImage = (Image)resources.GetObject("siticonePictureBox1.InitialImage");
            siticonePictureBox1.Location = new Point(7, 43);
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.Size = new Size(94, 78);
            siticonePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            siticonePictureBox1.TabIndex = 4;
            siticonePictureBox1.TabStop = false;
            // 
            // lessButton
            // 
            lessButton.BackColor = Color.Transparent;
            lessButton.BorderRadius = 20;
            lessButton.DisabledState.BorderColor = Color.DarkGray;
            lessButton.DisabledState.CustomBorderColor = Color.DarkGray;
            lessButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            lessButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            lessButton.FillColor = Color.Transparent;
            lessButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lessButton.ForeColor = Color.White;
            lessButton.Image = Properties.Resources.minus_circle_3185617_26850011;
            lessButton.ImageSize = new Size(28, 28);
            lessButton.Location = new Point(4, 127);
            lessButton.Name = "lessButton";
            lessButton.Size = new Size(34, 30);
            lessButton.TabIndex = 8;
            lessButton.MouseDown += LessButton_MouseDown;
            // 
            // plusButton
            // 
            plusButton.BorderRadius = 20;
            plusButton.DisabledState.BorderColor = Color.DarkGray;
            plusButton.DisabledState.CustomBorderColor = Color.DarkGray;
            plusButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            plusButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            plusButton.FillColor = Color.Transparent;
            plusButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            plusButton.ForeColor = Color.White;
            plusButton.Image = Properties.Resources.plus_circle_icon_256x256_9hl8pb45;
            plusButton.ImageSize = new Size(30, 30);
            plusButton.Location = new Point(73, 127);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(34, 30);
            plusButton.TabIndex = 9;
            plusButton.MouseDown += PlusButton_MouseDown;
            // 
            // quantityField
            // 
            quantityField.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            quantityField.Location = new Point(37, 128);
            quantityField.Name = "quantityField";
            quantityField.PlaceholderText = "0";
            quantityField.Size = new Size(35, 29);
            quantityField.TabIndex = 11;
            quantityField.TextAlign = HorizontalAlignment.Center;
            quantityField.TextChanged += QuantityField_TextChanged;
            quantityField.KeyPress += quantityField_KeyPress;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 12;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openSubproductsButton
            // 
            openSubproductsButton.BorderRadius = 10;
            openSubproductsButton.DisabledState.BorderColor = Color.DarkGray;
            openSubproductsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            openSubproductsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            openSubproductsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            openSubproductsButton.FillColor = Color.FromArgb(64, 64, 64);
            openSubproductsButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            openSubproductsButton.ForeColor = Color.White;
            openSubproductsButton.Location = new Point(8, 127);
            openSubproductsButton.Name = "openSubproductsButton";
            openSubproductsButton.Size = new Size(96, 31);
            openSubproductsButton.TabIndex = 13;
            openSubproductsButton.Text = "Seleccionar";
            openSubproductsButton.Visible = false;
            openSubproductsButton.Click += openSubproductsButton_Click;
            // 
            // UC_Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(openSubproductsButton);
            Controls.Add(label1);
            Controls.Add(quantityField);
            Controls.Add(plusButton);
            Controls.Add(lessButton);
            Controls.Add(siticonePictureBox1);
            Name = "UC_Item";
            Size = new Size(110, 162);
            ((System.ComponentModel.ISupportInitialize)siticonePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton lessButton;
        private Siticone.Desktop.UI.WinForms.SiticoneButton plusButton;
        private TextBox quantityField;
        private Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton openSubproductsButton;
    }
}
