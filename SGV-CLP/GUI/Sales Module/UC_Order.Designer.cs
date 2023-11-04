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
            showDetailDialogButton = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = false;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Dock = DockStyle.Bottom;
            nameLabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.White;
            nameLabel.Location = new Point(0, 34);
            nameLabel.Margin = new Padding(3, 4, 3, 4);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(173, 25);
            nameLabel.TabIndex = 43;
            nameLabel.Text = "Pedro Perez";
            nameLabel.TextAlignment = ContentAlignment.TopCenter;
            // 
            // showDetailDialogButton
            // 
            showDetailDialogButton.DisabledState.BorderColor = Color.DarkGray;
            showDetailDialogButton.DisabledState.CustomBorderColor = Color.DarkGray;
            showDetailDialogButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            showDetailDialogButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            showDetailDialogButton.Dock = DockStyle.Top;
            showDetailDialogButton.FillColor = Color.Black;
            showDetailDialogButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            showDetailDialogButton.ForeColor = Color.White;
            showDetailDialogButton.Location = new Point(0, 0);
            showDetailDialogButton.Margin = new Padding(4);
            showDetailDialogButton.Name = "showDetailDialogButton";
            showDetailDialogButton.Size = new Size(173, 31);
            showDetailDialogButton.TabIndex = 47;
            showDetailDialogButton.Text = "Mesa N°";
            showDetailDialogButton.Click += showDetailDialogButton_Click;
            // 
            // UC_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(showDetailDialogButton);
            Controls.Add(nameLabel);
            Name = "UC_Order";
            Size = new Size(173, 59);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel nameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton showDetailDialogButton;
    }
}
