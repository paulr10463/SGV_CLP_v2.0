
using SGV_CLP.GUI;

namespace SGV_CLP
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            siticoneButton3 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton4 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton6 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(components);
            siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            uC_Clientes1 = new UC_Customers();
            uC_Ventas1 = new UC_Ventas();
            uC_Productos1 = new UC_Products();
            uC_Settings1 = new UC_Settings();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            siticoneCustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.BackColor = Color.FromArgb(64, 64, 64);
            siticonePanel1.Controls.Add(pictureBox1);
            siticonePanel1.Controls.Add(flowLayoutPanel1);
            siticonePanel1.Dock = DockStyle.Left;
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.Size = new Size(68, 749);
            siticonePanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_cafeteria;
            pictureBox1.Location = new Point(6, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(siticoneButton3);
            flowLayoutPanel1.Controls.Add(siticoneButton4);
            flowLayoutPanel1.Controls.Add(siticoneButton6);
            flowLayoutPanel1.Controls.Add(siticoneButton1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 178);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(61, 324);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // siticoneButton3
            // 
            siticoneButton3.Animated = true;
            siticoneButton3.BorderColor = Color.FromArgb(0, 192, 0);
            siticoneButton3.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton3.CheckedState.CustomBorderColor = Color.Green;
            siticoneButton3.CustomBorderColor = Color.DimGray;
            siticoneButton3.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton3.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton3.FillColor = Color.White;
            siticoneButton3.FocusedColor = Color.Green;
            siticoneButton3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton3.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneButton3.Image = Properties.Resources.Market;
            siticoneButton3.ImageAlign = HorizontalAlignment.Left;
            siticoneButton3.ImageSize = new Size(40, 40);
            siticoneButton3.Location = new Point(3, 3);
            siticoneButton3.Name = "siticoneButton3";
            siticoneButton3.PressedColor = Color.Green;
            siticoneButton3.PressedDepth = 0;
            siticoneButton3.Size = new Size(54, 71);
            siticoneButton3.TabIndex = 8;
            siticoneButton3.TextAlign = HorizontalAlignment.Left;
            siticoneButton3.CheckedChanged += SiticoneButton3_CheckedChanged_1;
            // 
            // siticoneButton4
            // 
            siticoneButton4.Animated = true;
            siticoneButton4.BackColor = Color.Orange;
            siticoneButton4.BorderColor = Color.FromArgb(0, 192, 0);
            siticoneButton4.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton4.CheckedState.CustomBorderColor = Color.Green;
            siticoneButton4.CustomBorderColor = Color.DimGray;
            siticoneButton4.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton4.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton4.FillColor = Color.White;
            siticoneButton4.FocusedColor = Color.Green;
            siticoneButton4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton4.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneButton4.Image = Properties.Resources.Customer;
            siticoneButton4.ImageAlign = HorizontalAlignment.Left;
            siticoneButton4.ImageSize = new Size(45, 45);
            siticoneButton4.Location = new Point(3, 80);
            siticoneButton4.Name = "siticoneButton4";
            siticoneButton4.PressedColor = Color.Green;
            siticoneButton4.PressedDepth = 0;
            siticoneButton4.RightToLeft = RightToLeft.No;
            siticoneButton4.Size = new Size(54, 68);
            siticoneButton4.TabIndex = 9;
            siticoneButton4.TextAlign = HorizontalAlignment.Left;
            siticoneButton4.TextOffset = new Point(10, 0);
            siticoneButton4.CheckedChanged += siticoneButton4_CheckedChanged_1;
            // 
            // siticoneButton6
            // 
            siticoneButton6.Animated = true;
            siticoneButton6.BorderColor = Color.FromArgb(0, 192, 0);
            siticoneButton6.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton6.CheckedState.CustomBorderColor = Color.Green;
            siticoneButton6.CustomBorderColor = Color.DimGray;
            siticoneButton6.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton6.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton6.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton6.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton6.FillColor = Color.White;
            siticoneButton6.FocusedColor = Color.Green;
            siticoneButton6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton6.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneButton6.Image = Properties.Resources.Products;
            siticoneButton6.ImageAlign = HorizontalAlignment.Left;
            siticoneButton6.ImageSize = new Size(45, 45);
            siticoneButton6.Location = new Point(3, 154);
            siticoneButton6.Name = "siticoneButton6";
            siticoneButton6.PressedColor = Color.Green;
            siticoneButton6.PressedDepth = 0;
            siticoneButton6.Size = new Size(54, 78);
            siticoneButton6.TabIndex = 11;
            siticoneButton6.TextAlign = HorizontalAlignment.Left;
            siticoneButton6.TextOffset = new Point(10, 0);
            siticoneButton6.CheckedChanged += siticoneButton6_CheckedChanged_1;
            // 
            // siticoneButton1
            // 
            siticoneButton1.Animated = true;
            siticoneButton1.BorderColor = Color.FromArgb(0, 192, 0);
            siticoneButton1.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            siticoneButton1.CheckedState.CustomBorderColor = Color.Green;
            siticoneButton1.CustomBorderColor = Color.DimGray;
            siticoneButton1.CustomBorderThickness = new Padding(5, 0, 0, 0);
            siticoneButton1.DisabledState.BorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            siticoneButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            siticoneButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            siticoneButton1.FillColor = Color.White;
            siticoneButton1.FocusedColor = Color.Green;
            siticoneButton1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneButton1.ForeColor = Color.FromArgb(64, 64, 64);
            siticoneButton1.Image = Properties.Resources.setting;
            siticoneButton1.ImageAlign = HorizontalAlignment.Left;
            siticoneButton1.ImageSize = new Size(40, 40);
            siticoneButton1.Location = new Point(3, 238);
            siticoneButton1.Name = "siticoneButton1";
            siticoneButton1.PressedColor = Color.Green;
            siticoneButton1.PressedDepth = 0;
            siticoneButton1.Size = new Size(54, 78);
            siticoneButton1.TabIndex = 12;
            siticoneButton1.TextAlign = HorizontalAlignment.Left;
            siticoneButton1.TextOffset = new Point(10, 0);
            siticoneButton1.CheckedChanged += siticoneButton1_CheckedChanged;
            // 
            // siticoneDragControl1
            // 
            siticoneDragControl1.DockIndicatorTransparencyValue = 0.6D;
            siticoneDragControl1.UseTransparentDrag = true;
            // 
            // siticoneCustomGradientPanel1
            // 
            siticoneCustomGradientPanel1.Controls.Add(uC_Clientes1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Ventas1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Productos1);
            siticoneCustomGradientPanel1.Controls.Add(uC_Settings1);
            siticoneCustomGradientPanel1.Dock = DockStyle.Fill;
            siticoneCustomGradientPanel1.Location = new Point(68, 0);
            siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            siticoneCustomGradientPanel1.Size = new Size(960, 749);
            siticoneCustomGradientPanel1.TabIndex = 4;
            // 
            // uC_Clientes1
            // 
            uC_Clientes1.Dock = DockStyle.Fill;
            uC_Clientes1.Location = new Point(0, 0);
            uC_Clientes1.Margin = new Padding(3, 4, 3, 4);
            uC_Clientes1.Name = "uC_Clientes1";
            uC_Clientes1.Size = new Size(960, 749);
            uC_Clientes1.TabIndex = 5;
            // 
            // uC_Ventas1
            // 
            uC_Ventas1.BackColor = SystemColors.AppWorkspace;
            uC_Ventas1.Dock = DockStyle.Fill;
            uC_Ventas1.Location = new Point(0, 0);
            uC_Ventas1.Margin = new Padding(3, 4, 3, 4);
            uC_Ventas1.Name = "uC_Ventas1";
            uC_Ventas1.Size = new Size(960, 749);
            uC_Ventas1.TabIndex = 4;
            // 
            // uC_Productos1
            // 
            uC_Productos1.Dock = DockStyle.Fill;
            uC_Productos1.Location = new Point(0, 0);
            uC_Productos1.Margin = new Padding(3, 4, 3, 4);
            uC_Productos1.Name = "uC_Productos1";
            uC_Productos1.Size = new Size(960, 749);
            uC_Productos1.TabIndex = 2;
            // 
            // uC_Settings1
            // 
            uC_Settings1.BackColor = SystemColors.AppWorkspace;
            uC_Settings1.Dock = DockStyle.Fill;
            uC_Settings1.Location = new Point(0, 0);
            uC_Settings1.Margin = new Padding(3, 4, 3, 4);
            uC_Settings1.Name = "uC_Settings1";
            uC_Settings1.Size = new Size(960, 749);
            uC_Settings1.TabIndex = 1;
            // 
            // MainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1028, 749);
            Controls.Add(siticoneCustomGradientPanel1);
            Controls.Add(siticonePanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafetería La Prosperidad";
            WindowState = FormWindowState.Maximized;
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            siticoneCustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton4;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton3;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private GUI.UC_Customers uC_Clientes1;
        private GUI.UC_Products uC_Productos1;
        private UC_Ventas uC_Ventas1;
        private UC_Settings uC_Settings1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton6;
        private PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
    }
}