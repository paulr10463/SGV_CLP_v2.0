namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class UC_Order
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
            nameLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            buttonEditCustomer = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = false;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Dock = DockStyle.Bottom;
            nameLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(0, 41);
            nameLabel.Margin = new Padding(3, 4, 3, 4);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(160, 28);
            nameLabel.TabIndex = 43;
            nameLabel.Text = "Pedro Perez";
            nameLabel.TextAlignment = ContentAlignment.TopCenter;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.DisabledState.BorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonEditCustomer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonEditCustomer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonEditCustomer.Dock = DockStyle.Top;
            buttonEditCustomer.FillColor = Color.Black;
            buttonEditCustomer.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditCustomer.ForeColor = Color.White;
            buttonEditCustomer.Location = new Point(0, 0);
            buttonEditCustomer.Margin = new Padding(4);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Size = new Size(160, 36);
            buttonEditCustomer.TabIndex = 47;
            buttonEditCustomer.Text = "Mesa N°";
            buttonEditCustomer.Click += buttonEditCustomer_Click;
            // 
            // UC_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonEditCustomer);
            Controls.Add(nameLabel);
            Name = "UC_Order";
            Size = new Size(160, 69);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton buttonEditCustomer;
    }
}
