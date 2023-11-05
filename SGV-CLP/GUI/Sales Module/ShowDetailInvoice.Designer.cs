namespace SGV_CLP.GUI.Módulo_Ventas
{
    partial class ShowDetailInvoice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDetailInvoice));
            siticoneDataGridView1 = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            CC = new DataGridViewTextBoxColumn();
            Contras = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            CodNotaVentaLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            TotalLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            nameLabel = new Label();
            ccLabel = new Label();
            phoneLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // siticoneDataGridView1
            // 
            siticoneDataGridView1.AllowUserToResizeColumns = false;
            siticoneDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            siticoneDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            siticoneDataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            siticoneDataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            siticoneDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            siticoneDataGridView1.ColumnHeadersHeight = 50;
            siticoneDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.Columns.AddRange(new DataGridViewColumn[] { CC, Contras, Nombre });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            siticoneDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            siticoneDataGridView1.GridColor = Color.White;
            siticoneDataGridView1.Location = new Point(0, 232);
            siticoneDataGridView1.Name = "siticoneDataGridView1";
            siticoneDataGridView1.RowHeadersVisible = false;
            siticoneDataGridView1.RowHeadersWidth = 51;
            siticoneDataGridView1.RowTemplate.Height = 25;
            siticoneDataGridView1.Size = new Size(564, 445);
            siticoneDataGridView1.TabIndex = 55;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            siticoneDataGridView1.ThemeStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.GridColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.DimGray;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            siticoneDataGridView1.ThemeStyle.HeaderStyle.Height = 50;
            siticoneDataGridView1.ThemeStyle.ReadOnly = false;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            siticoneDataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            siticoneDataGridView1.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            siticoneDataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            siticoneDataGridView1.ThemeStyle.RowsStyle.Height = 25;
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            siticoneDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // CC
            // 
            CC.HeaderText = "Nombre Producto";
            CC.MinimumWidth = 6;
            CC.Name = "CC";
            // 
            // Contras
            // 
            Contras.HeaderText = "Cantidad";
            Contras.MinimumWidth = 6;
            Contras.Name = "Contras";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Subtotal";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // CodNotaVentaLabel
            // 
            CodNotaVentaLabel.AutoSize = false;
            CodNotaVentaLabel.BackColor = Color.FromArgb(64, 64, 64);
            CodNotaVentaLabel.Dock = DockStyle.Top;
            CodNotaVentaLabel.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            CodNotaVentaLabel.ForeColor = Color.White;
            CodNotaVentaLabel.Location = new Point(0, 0);
            CodNotaVentaLabel.Name = "CodNotaVentaLabel";
            CodNotaVentaLabel.Size = new Size(564, 67);
            CodNotaVentaLabel.TabIndex = 56;
            CodNotaVentaLabel.Text = "Title";
            CodNotaVentaLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = false;
            TotalLabel.BackColor = Color.FromArgb(64, 64, 64);
            TotalLabel.Dock = DockStyle.Bottom;
            TotalLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.ForeColor = Color.White;
            TotalLabel.Location = new Point(0, 683);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(564, 72);
            TotalLabel.TabIndex = 57;
            TotalLabel.Text = "Total: $X.XX";
            TotalLabel.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(284, 120);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(168, 19);
            nameLabel.TabIndex = 58;
            nameLabel.Text = "label1";
            // 
            // ccLabel
            // 
            ccLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ccLabel.Location = new Point(284, 91);
            ccLabel.Name = "ccLabel";
            ccLabel.Size = new Size(168, 19);
            ccLabel.TabIndex = 59;
            ccLabel.Text = "label1";
            // 
            // phoneLabel
            // 
            phoneLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(284, 149);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(168, 19);
            phoneLabel.TabIndex = 60;
            phoneLabel.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 91);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 61;
            label1.Text = "CC:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(152, 120);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 62;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(152, 149);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 63;
            label3.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(152, 180);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 65;
            label4.Text = "Fecha:";
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(284, 180);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(168, 19);
            dateLabel.TabIndex = 64;
            dateLabel.Text = "label2";
            // 
            // ShowDetailInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 755);
            Controls.Add(label4);
            Controls.Add(dateLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneLabel);
            Controls.Add(ccLabel);
            Controls.Add(nameLabel);
            Controls.Add(TotalLabel);
            Controls.Add(CodNotaVentaLabel);
            Controls.Add(siticoneDataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowDetailInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)siticoneDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView siticoneDataGridView1;
        private DataGridViewTextBoxColumn CC;
        private DataGridViewTextBoxColumn Contras;
        private DataGridViewTextBoxColumn Nombre;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel CodNotaVentaLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel TotalLabel;
        private Label nameLabel;
        private Label ccLabel;
        private Label phoneLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label dateLabel;
    }
}