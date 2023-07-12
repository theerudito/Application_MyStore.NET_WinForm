namespace Store.Presentador.Products
{
    partial class frmAddBrand
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBrand));
            mBrandBindingSource = new BindingSource(components);
            panel1 = new Panel();
            labelIdBrand = new Label();
            btnAddBrand = new PictureBox();
            dataGridBrand = new DataGridView();
            idBrandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnClose = new PictureBox();
            textSearchBrand = new TextBox();
            ((System.ComponentModel.ISupportInitialize)mBrandBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // mBrandBindingSource
            // 
            mBrandBindingSource.DataSource = typeof(Models.MBrand);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelIdBrand);
            panel1.Controls.Add(btnAddBrand);
            panel1.Controls.Add(dataGridBrand);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(textSearchBrand);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 379);
            panel1.TabIndex = 0;
            // 
            // labelIdBrand
            // 
            labelIdBrand.AutoSize = true;
            labelIdBrand.ForeColor = Color.DeepSkyBlue;
            labelIdBrand.Location = new Point(21, 16);
            labelIdBrand.Name = "labelIdBrand";
            labelIdBrand.Size = new Size(18, 15);
            labelIdBrand.TabIndex = 29;
            labelIdBrand.Text = "ID";
            // 
            // btnAddBrand
            // 
            btnAddBrand.Cursor = Cursors.Hand;
   
            btnAddBrand.Location = new Point(259, 44);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(30, 30);
            btnAddBrand.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddBrand.TabIndex = 28;
            btnAddBrand.TabStop = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // dataGridBrand
            // 
            dataGridBrand.AutoGenerateColumns = false;
            dataGridBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBrand.Columns.AddRange(new DataGridViewColumn[] { idBrandDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn });
            dataGridBrand.DataSource = mBrandBindingSource;
            dataGridBrand.Location = new Point(6, 80);
            dataGridBrand.Name = "dataGridBrand";
            dataGridBrand.ReadOnly = true;
            dataGridBrand.RowTemplate.Height = 25;
            dataGridBrand.Size = new Size(290, 289);
            dataGridBrand.TabIndex = 27;
            dataGridBrand.CellClick += dataGridBrand_CellClick;
            dataGridBrand.CellDoubleClick += dataGridBrand_CellDoubleClick;
            // 
            // idBrandDataGridViewTextBoxColumn
            // 
            idBrandDataGridViewTextBoxColumn.DataPropertyName = "IdBrand";
            idBrandDataGridViewTextBoxColumn.HeaderText = "IdBrand";
            idBrandDataGridViewTextBoxColumn.Name = "idBrandDataGridViewTextBoxColumn";
            idBrandDataGridViewTextBoxColumn.ReadOnly = true;
            idBrandDataGridViewTextBoxColumn.Visible = false;
            idBrandDataGridViewTextBoxColumn.Width = 20;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Marca";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            brandDataGridViewTextBoxColumn.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(88, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 26;
            label1.Text = "Buscar Marca";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btnCloseOne;
            btnClose.Location = new Point(280, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 25;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // textSearchBrand
            // 
            textSearchBrand.Location = new Point(6, 49);
            textSearchBrand.Name = "textSearchBrand";
            textSearchBrand.Size = new Size(247, 23);
            textSearchBrand.TabIndex = 24;
            textSearchBrand.TextChanged += textSearchBrand_TextChanged;
            textSearchBrand.KeyDown += textSearchBrand_KeyDown;
            // 
            // frmAddBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(307, 379);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddBrand";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Marca";
            ((System.ComponentModel.ISupportInitialize)mBrandBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource mBrandBindingSource;
        private Panel panel1;
        private Label labelIdBrand;
        private PictureBox btnAddBrand;
        private DataGridView dataGridBrand;
        private DataGridViewTextBoxColumn idBrandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private Label label1;
        private PictureBox btnClose;
        private TextBox textSearchBrand;
    }
}