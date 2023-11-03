namespace SGV_CLP.GUI
{
    partial class UC_Settings
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
            panel1 = new Panel();
            TableNameLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TableNumberChoice = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            siticoneCheckBox1 = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(siticoneCheckBox1);
            panel1.Controls.Add(TableNameLabel);
            panel1.Controls.Add(TableNumberChoice);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 604);
            panel1.TabIndex = 0;
            // 
            // TableNameLabel
            // 
            TableNameLabel.AutoSize = false;
            TableNameLabel.BackColor = Color.Transparent;
            TableNameLabel.Dock = DockStyle.Top;
            TableNameLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TableNameLabel.Location = new Point(0, 0);
            TableNameLabel.Name = "TableNameLabel";
            TableNameLabel.Size = new Size(1040, 55);
            TableNameLabel.TabIndex = 101;
            TableNameLabel.Text = "Configuración";
            TableNameLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TableNumberChoice
            // 
            TableNumberChoice.Anchor = AnchorStyles.None;
            TableNumberChoice.AutoSize = true;
            TableNumberChoice.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            TableNumberChoice.CheckedState.BorderRadius = 0;
            TableNumberChoice.CheckedState.BorderThickness = 0;
            TableNumberChoice.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            TableNumberChoice.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TableNumberChoice.Location = new Point(379, 154);
            TableNumberChoice.Name = "TableNumberChoice";
            TableNumberChoice.Size = new Size(277, 25);
            TableNumberChoice.TabIndex = 88;
            TableNumberChoice.Text = "Seleccionar el Número de Mesa ";
            TableNumberChoice.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            TableNumberChoice.UncheckedState.BorderRadius = 0;
            TableNumberChoice.UncheckedState.BorderThickness = 0;
            TableNumberChoice.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // siticoneCheckBox1
            // 
            siticoneCheckBox1.Anchor = AnchorStyles.None;
            siticoneCheckBox1.AutoSize = true;
            siticoneCheckBox1.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.CheckedState.BorderRadius = 0;
            siticoneCheckBox1.CheckedState.BorderThickness = 0;
            siticoneCheckBox1.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            siticoneCheckBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneCheckBox1.Location = new Point(379, 207);
            siticoneCheckBox1.Name = "siticoneCheckBox1";
            siticoneCheckBox1.Size = new Size(235, 25);
            siticoneCheckBox1.TabIndex = 102;
            siticoneCheckBox1.Text = "Mostrar los últimos pedidos";
            siticoneCheckBox1.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            siticoneCheckBox1.UncheckedState.BorderRadius = 0;
            siticoneCheckBox1.UncheckedState.BorderThickness = 0;
            siticoneCheckBox1.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Settings";
            Size = new Size(1040, 604);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox TableNumberChoice;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel TableNameLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox siticoneCheckBox1;
    }
}
