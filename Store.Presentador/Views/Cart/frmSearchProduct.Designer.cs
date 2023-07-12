namespace Store.Presentador.Cart
{
    partial class frmSearchProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchProducts));
            dataGridViewProducts = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceUnitaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productsBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textSearchDescription = new TextBox();
            textSearchBrand = new TextBox();
            textSearchName = new TextBox();
            btnClose = new PictureBox();
            labelCodeProduct = new Label();
            panel1 = new Panel();
            labelD = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.BackgroundColor = Color.FromArgb(51, 62, 80);
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, codeProductDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, Category, descriptionDataGridViewTextBoxColumn, priceUnitaryDataGridViewTextBoxColumn, idProductDataGridViewTextBoxColumn });
            dataGridViewProducts.DataSource = productsBindingSource;
            dataGridViewProducts.GridColor = Color.FromArgb(51, 62, 80);
            dataGridViewProducts.Location = new Point(12, 82);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowTemplate.Height = 25;
            dataGridViewProducts.Size = new Size(776, 376);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellDoubleClick += dataGridViewProducts_CellDoubleClick;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeProductDataGridViewTextBoxColumn
            // 
            codeProductDataGridViewTextBoxColumn.DataPropertyName = "CodeProduct";
            codeProductDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codeProductDataGridViewTextBoxColumn.Name = "codeProductDataGridViewTextBoxColumn";
            codeProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameProductDataGridViewTextBoxColumn
            // 
            nameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct";
            nameProductDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameProductDataGridViewTextBoxColumn.Name = "nameProductDataGridViewTextBoxColumn";
            nameProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Marca";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Categoria";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceUnitaryDataGridViewTextBoxColumn
            // 
            priceUnitaryDataGridViewTextBoxColumn.DataPropertyName = "PriceUnitary";
            priceUnitaryDataGridViewTextBoxColumn.HeaderText = "P Unitario";
            priceUnitaryDataGridViewTextBoxColumn.Name = "priceUnitaryDataGridViewTextBoxColumn";
            priceUnitaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            idProductDataGridViewTextBoxColumn.HeaderText = "IdProduct";
            idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            idProductDataGridViewTextBoxColumn.ReadOnly = true;
            idProductDataGridViewTextBoxColumn.Visible = false;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Models.MProducts);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(255, 30);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textSearchDescription);
            groupBox1.Controls.Add(textSearchBrand);
            groupBox1.Controls.Add(textSearchName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 55);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Productos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(493, 29);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Descripcion:";
            // 
            // textSearchDescription
            // 
            textSearchDescription.Location = new Point(578, 21);
            textSearchDescription.Name = "textSearchDescription";
            textSearchDescription.Size = new Size(169, 23);
            textSearchDescription.TabIndex = 6;
            textSearchDescription.TextChanged += textDescription_TextChanged;
            // 
            // textSearchBrand
            // 
            textSearchBrand.Location = new Point(311, 21);
            textSearchBrand.Name = "textSearchBrand";
            textSearchBrand.Size = new Size(169, 23);
            textSearchBrand.TabIndex = 5;
            textSearchBrand.TextChanged += textBrand_TextChanged;
            // 
            // textSearchName
            // 
            textSearchName.Location = new Point(73, 21);
            textSearchName.Name = "textSearchName";
            textSearchName.Size = new Size(169, 23);
            textSearchName.TabIndex = 4;
            textSearchName.TextChanged += textName_TextChanged;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btnCloseOne;
            btnClose.Location = new Point(771, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // labelCodeProduct
            // 
            labelCodeProduct.AutoSize = true;
            labelCodeProduct.ForeColor = Color.DeepSkyBlue;
            labelCodeProduct.Location = new Point(83, 461);
            labelCodeProduct.Name = "labelCodeProduct";
            labelCodeProduct.Size = new Size(46, 15);
            labelCodeProduct.TabIndex = 6;
            labelCodeProduct.Text = "Codigo";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(labelCodeProduct);
            panel1.Controls.Add(labelD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 485);
            panel1.TabIndex = 7;
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.ForeColor = Color.DeepSkyBlue;
            labelD.Location = new Point(10, 461);
            labelD.Name = "labelD";
            labelD.Size = new Size(17, 15);
            labelD.TabIndex = 8;
            labelD.Text = "Id";
            // 
            // frmSearchProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 485);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSearchProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busqueda de Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private BindingSource productsBindingSource;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textSearchDescription;
        private TextBox textSearchBrand;
        private TextBox textSearchName;
        private PictureBox btnClose;
        private Label labelCodeProduct;
        private Panel panel1;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private Label labelD;
    }
}