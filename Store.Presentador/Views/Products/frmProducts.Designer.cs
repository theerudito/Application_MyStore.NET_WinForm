namespace Store.Presentador.Products
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            productsBindingSource = new BindingSource(components);
            dataGridProduct = new DataGridView();
            groupBox3 = new GroupBox();
            btnUpdateProduct = new Button();
            btnSaveProduct = new Button();
            btnDeleteProduct = new Button();
            groupBox2 = new GroupBox();
            btnGetProduct = new PictureBox();
            label7 = new Label();
            textGetProduct = new TextBox();
            groupBox1 = new GroupBox();
            checkBoxIva = new CheckBox();
            label11 = new Label();
            label10 = new Label();
            labelStatus = new Label();
            label9 = new Label();
            btnAddCategory = new PictureBox();
            comboBoxCategory = new ComboBox();
            comboBoxBrand = new ComboBox();
            label8 = new Label();
            btnAddBrand = new PictureBox();
            labelIdProduct = new Label();
            pictureProduct = new PictureBox();
            textQuantityProduct = new TextBox();
            textPriceProduct = new TextBox();
            textDescriptionProduct = new TextBox();
            textCodeProduct = new TextBox();
            textNameProduct = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxActive = new CheckBox();
            IdProducto = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameProductDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceUnitaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Iva = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddBrand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            SuspendLayout();
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataSource = typeof(Models.MProducts);
            // 
            // dataGridProduct
            // 
            dataGridProduct.AutoGenerateColumns = false;
            dataGridProduct.BackgroundColor = Color.FromArgb(51, 62, 80);
            dataGridProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProduct.Columns.AddRange(new DataGridViewColumn[] { IdProducto, quantityDataGridViewTextBoxColumn, codeProductDataGridViewTextBoxColumn, nameProductDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, Category, descriptionDataGridViewTextBoxColumn, priceUnitaryDataGridViewTextBoxColumn, Status, Iva });
            dataGridProduct.DataSource = productsBindingSource;
            dataGridProduct.GridColor = Color.FromArgb(51, 62, 80);
            dataGridProduct.Location = new Point(303, 96);
            dataGridProduct.Name = "dataGridProduct";
            dataGridProduct.ReadOnly = true;
            dataGridProduct.RowTemplate.Height = 25;
            dataGridProduct.Size = new Size(490, 346);
            dataGridProduct.TabIndex = 21;
            dataGridProduct.CellDoubleClick += dataGridProduct_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUpdateProduct);
            groupBox3.Controls.Add(btnSaveProduct);
            groupBox3.Controls.Add(btnDeleteProduct);
            groupBox3.ForeColor = Color.DeepSkyBlue;
            groupBox3.Location = new Point(8, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 59);
            groupBox3.TabIndex = 20;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = SystemColors.MenuHighlight;
            btnUpdateProduct.Cursor = Cursors.Hand;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatStyle = FlatStyle.Flat;
            btnUpdateProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(111, 22);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(75, 23);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Actualizar";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = Color.GreenYellow;
            btnSaveProduct.Cursor = Cursors.Hand;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveProduct.ForeColor = Color.Black;
            btnSaveProduct.Location = new Point(11, 22);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(75, 23);
            btnSaveProduct.TabIndex = 0;
            btnSaveProduct.Text = "Guardar";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.Red;
            btnDeleteProduct.Cursor = Cursors.Hand;
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(208, 22);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 2;
            btnDeleteProduct.Text = "Activo";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGetProduct);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textGetProduct);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(303, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 67);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda de Producto";
            // 
            // btnGetProduct
            // 
            btnGetProduct.Image = (Image)resources.GetObject("btnGetProduct.Image");
            btnGetProduct.Location = new Point(453, 22);
            btnGetProduct.Name = "btnGetProduct";
            btnGetProduct.Size = new Size(30, 30);
            btnGetProduct.TabIndex = 15;
            btnGetProduct.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 34);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Buscar:";
            // 
            // textGetProduct
            // 
            textGetProduct.Location = new Point(74, 26);
            textGetProduct.Name = "textGetProduct";
            textGetProduct.Size = new Size(373, 23);
            textGetProduct.TabIndex = 14;
            textGetProduct.TextChanged += textGetProduct_TextChanged;
            textGetProduct.KeyDown += textGetProduct_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxIva);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnAddCategory);
            groupBox1.Controls.Add(comboBoxCategory);
            groupBox1.Controls.Add(comboBoxBrand);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAddBrand);
            groupBox1.Controls.Add(labelIdProduct);
            groupBox1.Controls.Add(pictureProduct);
            groupBox1.Controls.Add(textQuantityProduct);
            groupBox1.Controls.Add(textPriceProduct);
            groupBox1.Controls.Add(textDescriptionProduct);
            groupBox1.Controls.Add(textCodeProduct);
            groupBox1.Controls.Add(textNameProduct);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 361);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Productos";
            // 
            // checkBoxIva
            // 
            checkBoxIva.AutoSize = true;
            checkBoxIva.Checked = true;
            checkBoxIva.CheckState = CheckState.Checked;
            checkBoxIva.Location = new Point(237, 290);
            checkBoxIva.Name = "checkBoxIva";
            checkBoxIva.Size = new Size(41, 19);
            checkBoxIva.TabIndex = 34;
            checkBoxIva.Text = "Iva";
            checkBoxIva.UseVisualStyleBackColor = true;
            checkBoxIva.CheckedChanged += checkBoxIva_CheckedChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(263, 226);
            label11.Name = "label11";
            label11.Size = new Size(18, 15);
            label11.TabIndex = 32;
            label11.Text = "IC";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(263, 196);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 31;
            label10.Text = "IM";
            label10.Visible = false;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(219, 70);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 15);
            labelStatus.TabIndex = 30;
            labelStatus.Text = "Activo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 52);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 29;
            label9.Text = "Estado:";
            // 
            // btnAddCategory
            // 
            btnAddCategory.Cursor = Cursors.Hand;
         
            btnAddCategory.Location = new Point(237, 223);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(20, 20);
            btnAddCategory.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddCategory.TabIndex = 28;
            btnAddCategory.TabStop = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(86, 222);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(145, 23);
            comboBoxCategory.TabIndex = 27;
            comboBoxCategory.MouseDown += comboBoxCategory_MouseDown;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(86, 189);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(145, 23);
            comboBoxBrand.TabIndex = 26;
            comboBoxBrand.MouseDown += comboBoxBrand_MouseDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 230);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 24;
            label8.Text = "Categoria";
            // 
            // btnAddBrand
            // 
            btnAddBrand.Cursor = Cursors.Hand;
     
            btnAddBrand.Location = new Point(237, 191);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(20, 20);
            btnAddBrand.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddBrand.TabIndex = 23;
            btnAddBrand.TabStop = false;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // labelIdProduct
            // 
            labelIdProduct.AutoSize = true;
            labelIdProduct.Location = new Point(6, 87);
            labelIdProduct.Name = "labelIdProduct";
            labelIdProduct.Size = new Size(18, 15);
            labelIdProduct.TabIndex = 13;
            labelIdProduct.Text = "ID";
            labelIdProduct.Visible = false;
            // 
            // pictureProduct
            // 
  
            pictureProduct.Location = new Point(97, 22);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(100, 80);
            pictureProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureProduct.TabIndex = 12;
            pictureProduct.TabStop = false;
            // 
            // textQuantityProduct
            // 
            textQuantityProduct.Location = new Point(86, 321);
            textQuantityProduct.Name = "textQuantityProduct";
            textQuantityProduct.Size = new Size(145, 23);
            textQuantityProduct.TabIndex = 11;
            textQuantityProduct.KeyPress += textQuantityProduct_KeyPress;
            // 
            // textPriceProduct
            // 
            textPriceProduct.Location = new Point(86, 288);
            textPriceProduct.Name = "textPriceProduct";
            textPriceProduct.Size = new Size(145, 23);
            textPriceProduct.TabIndex = 10;
            textPriceProduct.KeyPress += textPriceProduct_KeyPress;
            // 
            // textDescriptionProduct
            // 
            textDescriptionProduct.Location = new Point(86, 255);
            textDescriptionProduct.Name = "textDescriptionProduct";
            textDescriptionProduct.Size = new Size(145, 23);
            textDescriptionProduct.TabIndex = 9;
            // 
            // textCodeProduct
            // 
            textCodeProduct.Location = new Point(86, 156);
            textCodeProduct.Name = "textCodeProduct";
            textCodeProduct.Size = new Size(145, 23);
            textCodeProduct.TabIndex = 7;
            textCodeProduct.KeyPress += textCodeProduct_KeyPress;
            // 
            // textNameProduct
            // 
            textNameProduct.Location = new Point(86, 123);
            textNameProduct.Name = "textNameProduct";
            textNameProduct.Size = new Size(145, 23);
            textNameProduct.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 329);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 296);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 263);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 197);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 164);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 131);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Checked = true;
            checkBoxActive.CheckState = CheckState.Checked;
            checkBoxActive.Cursor = Cursors.Hand;
            checkBoxActive.ForeColor = Color.DeepSkyBlue;
            checkBoxActive.Location = new Point(732, 78);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(65, 19);
            checkBoxActive.TabIndex = 22;
            checkBoxActive.Text = "Activos";
            checkBoxActive.UseVisualStyleBackColor = true;
            checkBoxActive.CheckedChanged += checkBoxActive_CheckedChanged;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProduct";
            IdProducto.HeaderText = "Id";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
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
            priceUnitaryDataGridViewTextBoxColumn.HeaderText = "Precio";
            priceUnitaryDataGridViewTextBoxColumn.Name = "priceUnitaryDataGridViewTextBoxColumn";
            priceUnitaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            // 
            // Iva
            // 
            Iva.DataPropertyName = "Iva";
            Iva.HeaderText = "Iva";
            Iva.Name = "Iva";
            Iva.ReadOnly = true;
            Iva.Visible = false;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridProduct);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(checkBoxActive);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridProduct).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddBrand).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource productsBindingSource;
        private DataGridView dataGridProduct;
        private GroupBox groupBox3;
        private Button btnUpdateProduct;
        private Button btnSaveProduct;
        private Button btnDeleteProduct;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textGetProduct;
        private GroupBox groupBox1;
        private PictureBox pictureProduct;
        private TextBox textQuantityProduct;
        private TextBox textPriceProduct;
        private TextBox textDescriptionProduct;
        private TextBox textCodeProduct;
        private TextBox textNameProduct;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btnGetProduct;
        private Label labelIdProduct;
        private CheckBox checkBoxActive;
        private PictureBox btnAddCategory;
        private ComboBox comboBoxCategory;
        private ComboBox comboBoxBrand;
        private Label label8;
        private PictureBox btnAddBrand;
        private Label labelStatus;
        private Label label9;
        private Label label11;
        private Label label10;
        private CheckBox checkBoxIva;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceUnitaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Iva;
    }
}