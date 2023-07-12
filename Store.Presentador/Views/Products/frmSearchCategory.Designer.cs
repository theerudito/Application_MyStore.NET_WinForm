namespace Store.Presentador.Products
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            mCategoryBindingSource = new BindingSource(components);
            panel1 = new Panel();
            labelIdCategory = new Label();
            btnAddCategory = new PictureBox();
            dataGridCategory = new DataGridView();
            idCategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnClose = new PictureBox();
            textSearchCategory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)mCategoryBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // mCategoryBindingSource
            // 
            mCategoryBindingSource.DataSource = typeof(Models.MCategory);
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(labelIdCategory);
            panel1.Controls.Add(btnAddCategory);
            panel1.Controls.Add(dataGridCategory);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(textSearchCategory);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 379);
            panel1.TabIndex = 0;
            // 
            // labelIdCategory
            // 
            labelIdCategory.AutoSize = true;
            labelIdCategory.ForeColor = Color.DeepSkyBlue;
            labelIdCategory.Location = new Point(10, 17);
            labelIdCategory.Name = "labelIdCategory";
            labelIdCategory.Size = new Size(18, 15);
            labelIdCategory.TabIndex = 23;
            labelIdCategory.Text = "ID";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Cursor = Cursors.Hand;
       
            btnAddCategory.Location = new Point(259, 44);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(30, 30);
            btnAddCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddCategory.TabIndex = 22;
            btnAddCategory.TabStop = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // dataGridCategory
            // 
            dataGridCategory.AutoGenerateColumns = false;
            dataGridCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCategory.Columns.AddRange(new DataGridViewColumn[] { idCategoryDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn });
            dataGridCategory.DataSource = mCategoryBindingSource;
            dataGridCategory.Location = new Point(6, 80);
            dataGridCategory.Name = "dataGridCategory";
            dataGridCategory.ReadOnly = true;
            dataGridCategory.RowTemplate.Height = 25;
            dataGridCategory.Size = new Size(290, 289);
            dataGridCategory.TabIndex = 21;
            dataGridCategory.CellClick += dataGridCategory_CellClick;
            dataGridCategory.CellDoubleClick += dataGridCategory_CellDoubleClick;
            // 
            // idCategoryDataGridViewTextBoxColumn
            // 
            idCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.HeaderText = "IdCategory";
            idCategoryDataGridViewTextBoxColumn.Name = "idCategoryDataGridViewTextBoxColumn";
            idCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            idCategoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(88, 11);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 20;
            label1.Text = "Buscar Categoria";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btnCloseOne;
            btnClose.Location = new Point(280, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 19;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // textSearchCategory
            // 
            textSearchCategory.Location = new Point(6, 49);
            textSearchCategory.Name = "textSearchCategory";
            textSearchCategory.Size = new Size(247, 23);
            textSearchCategory.TabIndex = 18;
            textSearchCategory.TextChanged += textSearchCategory_TextChanged;
            textSearchCategory.KeyDown += textSearchCategory_KeyDown;
            // 
            // frmAddCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(307, 379);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Categoria";
            ((System.ComponentModel.ISupportInitialize)mCategoryBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource mCategoryBindingSource;
        private Panel panel1;
        private Label labelIdCategory;
        private PictureBox btnAddCategory;
        private DataGridView dataGridCategory;
        private DataGridViewTextBoxColumn idCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private Label label1;
        private PictureBox btnClose;
        private TextBox textSearchCategory;
    }
}