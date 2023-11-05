namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class ProductSubtype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSubtype));
            siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            subtypesFlowPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // siticoneButton2
            // 
            siticoneButton2.Anchor = AnchorStyles.None;
            siticoneButton2.BorderRadius = 20;
            siticoneButton2.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton2.FillColor = Color.FromArgb(64, 64, 64);
            siticoneButton2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton2.ForeColor = Color.White;
            siticoneButton2.Location = new Point(261, 658);
            siticoneButton2.Name = "siticoneButton2";
            siticoneButton2.Size = new Size(180, 45);
            siticoneButton2.TabIndex = 51;
            siticoneButton2.Text = "Cerrar";
            siticoneButton2.Click += siticoneButton2_Click;
            // 
            // subtypesFlowPanel
            // 
            subtypesFlowPanel.Dock = DockStyle.Top;
            subtypesFlowPanel.Location = new Point(0, 0);
            subtypesFlowPanel.Name = "subtypesFlowPanel";
            subtypesFlowPanel.Size = new Size(739, 566);
            subtypesFlowPanel.TabIndex = 52;
            // 
            // ProductSubtype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 773);
            Controls.Add(subtypesFlowPanel);
            Controls.Add(siticoneButton2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductSubtype";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago";
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel siticoneHtmlLabel8;
        private FlowLayoutPanel subtypesFlowPanel;
    }
}