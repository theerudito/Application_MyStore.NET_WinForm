namespace Store.Presentador.Cart
{
    partial class frmProforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProforma));
            panel1 = new Panel();
            labelTotalOneCart = new Label();
            dataGridCart = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Code = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            labelTotalTwoCart = new Label();
            labelIvaCart = new Label();
            label26 = new Label();
            btnSaveCart = new Button();
            labelSubTotalTwelveCart = new Label();
            sad = new Label();
            label23 = new Label();
            labelSubTotalZeroCart = new Label();
            label19 = new Label();
            labelDescuentCart = new Label();
            label15 = new Label();
            labelSubTotalCart = new Label();
            label12 = new Label();
            groupBox3 = new GroupBox();
            btnAddProductToCart = new PictureBox();
            textPriceTotalCart = new TextBox();
            textPriceUnitaryCart = new TextBox();
            textDescuentProduct = new TextBox();
            textQuantityCart = new TextBox();
            textDescriptionCart = new TextBox();
            textCodeCart = new TextBox();
            groupBox2 = new GroupBox();
            labelHour = new Label();
            dateTimePicker = new DateTimePicker();
            textSerieTwoCart = new TextBox();
            textSerieOneCart = new TextBox();
            textNumDocumentCart = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            idClient = new Label();
            btnResetFieldClient = new PictureBox();
            btnSearchClientOnCart = new PictureBox();
            btnAddClientOnCart = new PictureBox();
            textEmailCart = new TextBox();
            textAddressCart = new TextBox();
            textLastNameCart = new TextBox();
            textFirstNameCart = new TextBox();
            textPhoneCart = new TextBox();
            textDNICart = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCart).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddProductToCart).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnResetFieldClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchClientOnCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddClientOnCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Controls.Add(labelTotalOneCart);
            panel1.Location = new Point(625, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 108);
            panel1.TabIndex = 12;
            // 
            // labelTotalOneCart
            // 
            labelTotalOneCart.AutoSize = true;
            labelTotalOneCart.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalOneCart.Location = new Point(16, 28);
            labelTotalOneCart.Name = "labelTotalOneCart";
            labelTotalOneCart.Size = new Size(126, 54);
            labelTotalOneCart.TabIndex = 23;
            labelTotalOneCart.Text = "20.00";
            labelTotalOneCart.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridCart
            // 
            dataGridCart.BackgroundColor = Color.FromArgb(51, 62, 80);
            dataGridCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCart.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Code, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, IdProducto });
            dataGridCart.GridColor = Color.FromArgb(51, 62, 80);
            dataGridCart.Location = new Point(12, 215);
            dataGridCart.Name = "dataGridCart";
            dataGridCart.ReadOnly = true;
            dataGridCart.RowTemplate.Height = 25;
            dataGridCart.Size = new Size(570, 223);
            dataGridCart.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Code
            // 
            Code.HeaderText = "Codigo";
            Code.Name = "Code";
            Code.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Marca";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "P Unitario";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Descuento";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "P Total";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "Id";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelTotalTwoCart);
            groupBox4.Controls.Add(labelIvaCart);
            groupBox4.Controls.Add(label26);
            groupBox4.Controls.Add(btnSaveCart);
            groupBox4.Controls.Add(labelSubTotalTwelveCart);
            groupBox4.Controls.Add(sad);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(labelSubTotalZeroCart);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(labelDescuentCart);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(labelSubTotalCart);
            groupBox4.Controls.Add(label12);
            groupBox4.ForeColor = Color.DeepSkyBlue;
            groupBox4.Location = new Point(588, 208);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 230);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion Totales";
            // 
            // labelTotalTwoCart
            // 
            labelTotalTwoCart.AutoSize = true;
            labelTotalTwoCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotalTwoCart.ForeColor = Color.DeepSkyBlue;
            labelTotalTwoCart.Location = new Point(129, 162);
            labelTotalTwoCart.Name = "labelTotalTwoCart";
            labelTotalTwoCart.Size = new Size(50, 21);
            labelTotalTwoCart.TabIndex = 26;
            labelTotalTwoCart.Text = "20.00";
            labelTotalTwoCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelIvaCart
            // 
            labelIvaCart.AutoSize = true;
            labelIvaCart.ForeColor = Color.DeepSkyBlue;
            labelIvaCart.Location = new Point(151, 133);
            labelIvaCart.Name = "labelIvaCart";
            labelIvaCart.Size = new Size(28, 15);
            labelIvaCart.TabIndex = 25;
            labelIvaCart.Text = "1.80";
            labelIvaCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.DeepSkyBlue;
            label26.Location = new Point(10, 162);
            label26.Name = "label26";
            label26.Size = new Size(60, 21);
            label26.TabIndex = 24;
            label26.Text = "TOTAL:";
            // 
            // btnSaveCart
            // 
            btnSaveCart.BackColor = Color.GreenYellow;
            btnSaveCart.Cursor = Cursors.Hand;
            btnSaveCart.FlatAppearance.BorderSize = 0;
            btnSaveCart.FlatStyle = FlatStyle.Flat;
            btnSaveCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCart.ForeColor = Color.Black;
            btnSaveCart.Location = new Point(36, 188);
            btnSaveCart.Name = "btnSaveCart";
            btnSaveCart.Size = new Size(131, 35);
            btnSaveCart.TabIndex = 23;
            btnSaveCart.Text = "GUARDAR";
            btnSaveCart.UseVisualStyleBackColor = false;
            // 
            // labelSubTotalTwelveCart
            // 
            labelSubTotalTwelveCart.AutoSize = true;
            labelSubTotalTwelveCart.ForeColor = Color.DeepSkyBlue;
            labelSubTotalTwelveCart.Location = new Point(145, 106);
            labelSubTotalTwelveCart.Name = "labelSubTotalTwelveCart";
            labelSubTotalTwelveCart.Size = new Size(34, 15);
            labelSubTotalTwelveCart.TabIndex = 22;
            labelSubTotalTwelveCart.Text = "18.20";
            labelSubTotalTwelveCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // sad
            // 
            sad.AutoSize = true;
            sad.ForeColor = Color.DeepSkyBlue;
            sad.Location = new Point(10, 133);
            sad.Name = "sad";
            sad.Size = new Size(24, 15);
            sad.TabIndex = 21;
            sad.Text = "IVA";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.DeepSkyBlue;
            label23.Location = new Point(10, 106);
            label23.Name = "label23";
            label23.Size = new Size(74, 15);
            label23.TabIndex = 19;
            label23.Text = "SubTotal12%";
            // 
            // labelSubTotalZeroCart
            // 
            labelSubTotalZeroCart.AutoSize = true;
            labelSubTotalZeroCart.ForeColor = Color.DeepSkyBlue;
            labelSubTotalZeroCart.Location = new Point(151, 78);
            labelSubTotalZeroCart.Name = "labelSubTotalZeroCart";
            labelSubTotalZeroCart.Size = new Size(28, 15);
            labelSubTotalZeroCart.TabIndex = 16;
            labelSubTotalZeroCart.Text = "0.00";
            labelSubTotalZeroCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.DeepSkyBlue;
            label19.Location = new Point(10, 78);
            label19.Name = "label19";
            label19.Size = new Size(68, 15);
            label19.TabIndex = 15;
            label19.Text = "SubTotal0%";
            // 
            // labelDescuentCart
            // 
            labelDescuentCart.AutoSize = true;
            labelDescuentCart.ForeColor = Color.DeepSkyBlue;
            labelDescuentCart.Location = new Point(151, 54);
            labelDescuentCart.Name = "labelDescuentCart";
            labelDescuentCart.Size = new Size(28, 15);
            labelDescuentCart.TabIndex = 14;
            labelDescuentCart.Text = "0.00";
            labelDescuentCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.DeepSkyBlue;
            label15.Location = new Point(10, 54);
            label15.Name = "label15";
            label15.Size = new Size(35, 15);
            label15.TabIndex = 13;
            label15.Text = "Desc:";
            // 
            // labelSubTotalCart
            // 
            labelSubTotalCart.AutoSize = true;
            labelSubTotalCart.ForeColor = Color.DeepSkyBlue;
            labelSubTotalCart.Location = new Point(145, 29);
            labelSubTotalCart.Name = "labelSubTotalCart";
            labelSubTotalCart.Size = new Size(34, 15);
            labelSubTotalCart.TabIndex = 12;
            labelSubTotalCart.Text = "20.00";
            labelSubTotalCart.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DeepSkyBlue;
            label12.Location = new Point(10, 29);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 11;
            label12.Text = "SubTotal:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnAddProductToCart);
            groupBox3.Controls.Add(textPriceTotalCart);
            groupBox3.Controls.Add(textPriceUnitaryCart);
            groupBox3.Controls.Add(textDescuentProduct);
            groupBox3.Controls.Add(textQuantityCart);
            groupBox3.Controls.Add(textDescriptionCart);
            groupBox3.Controls.Add(textCodeCart);
            groupBox3.ForeColor = Color.DeepSkyBlue;
            groupBox3.Location = new Point(12, 143);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 61);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Producto Precione F2";
            // 
            // btnAddProductToCart
            // 
            btnAddProductToCart.Cursor = Cursors.Hand;
            btnAddProductToCart.Image = (Image)resources.GetObject("btnAddProductToCart.Image");
            btnAddProductToCart.Location = new Point(738, 18);
            btnAddProductToCart.Name = "btnAddProductToCart";
            btnAddProductToCart.Size = new Size(32, 32);
            btnAddProductToCart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddProductToCart.TabIndex = 13;
            btnAddProductToCart.TabStop = false;
            // 
            // textPriceTotalCart
            // 
            textPriceTotalCart.Location = new Point(650, 22);
            textPriceTotalCart.Name = "textPriceTotalCart";
            textPriceTotalCart.PlaceholderText = "PVP";
            textPriceTotalCart.Size = new Size(78, 23);
            textPriceTotalCart.TabIndex = 17;
            // 
            // textPriceUnitaryCart
            // 
            textPriceUnitaryCart.Location = new Point(476, 22);
            textPriceUnitaryCart.Name = "textPriceUnitaryCart";
            textPriceUnitaryCart.PlaceholderText = "P Unitario";
            textPriceUnitaryCart.Size = new Size(78, 23);
            textPriceUnitaryCart.TabIndex = 16;
            // 
            // textDescuentProduct
            // 
            textDescuentProduct.Location = new Point(563, 22);
            textDescuentProduct.Name = "textDescuentProduct";
            textDescuentProduct.PlaceholderText = "Descuento";
            textDescuentProduct.Size = new Size(78, 23);
            textDescuentProduct.TabIndex = 15;
            // 
            // textQuantityCart
            // 
            textQuantityCart.Location = new Point(389, 22);
            textQuantityCart.Name = "textQuantityCart";
            textQuantityCart.PlaceholderText = "Cantidad";
            textQuantityCart.Size = new Size(78, 23);
            textQuantityCart.TabIndex = 14;
            // 
            // textDescriptionCart
            // 
            textDescriptionCart.Location = new Point(116, 22);
            textDescriptionCart.Name = "textDescriptionCart";
            textDescriptionCart.PlaceholderText = "Descripcion Producto";
            textDescriptionCart.Size = new Size(260, 23);
            textDescriptionCart.TabIndex = 13;
            // 
            // textCodeCart
            // 
            textCodeCart.Location = new Point(6, 22);
            textCodeCart.Name = "textCodeCart";
            textCodeCart.PlaceholderText = "Codigo";
            textCodeCart.Size = new Size(100, 23);
            textCodeCart.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelHour);
            groupBox2.Controls.Add(dateTimePicker);
            groupBox2.Controls.Add(textSerieTwoCart);
            groupBox2.Controls.Add(textSerieOneCart);
            groupBox2.Controls.Add(textNumDocumentCart);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(393, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 117);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Fecha";
            // 
            // labelHour
            // 
            labelHour.AutoSize = true;
            labelHour.ForeColor = Color.DeepSkyBlue;
            labelHour.Location = new Point(186, 26);
            labelHour.Name = "labelHour";
            labelHour.Size = new Size(34, 15);
            labelHour.TabIndex = 22;
            labelHour.Text = "11:00";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(48, 20);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(105, 23);
            dateTimePicker.TabIndex = 21;
            // 
            // textSerieTwoCart
            // 
            textSerieTwoCart.Location = new Point(156, 77);
            textSerieTwoCart.Name = "textSerieTwoCart";
            textSerieTwoCart.Size = new Size(62, 23);
            textSerieTwoCart.TabIndex = 20;
            // 
            // textSerieOneCart
            // 
            textSerieOneCart.Location = new Point(50, 78);
            textSerieOneCart.Name = "textSerieOneCart";
            textSerieOneCart.Size = new Size(62, 23);
            textSerieOneCart.TabIndex = 19;
            // 
            // textNumDocumentCart
            // 
            textNumDocumentCart.Location = new Point(73, 48);
            textNumDocumentCart.Name = "textNumDocumentCart";
            textNumDocumentCart.Size = new Size(100, 23);
            textNumDocumentCart.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(112, 86);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 10;
            label11.Text = "Serie2:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DeepSkyBlue;
            label10.Location = new Point(6, 86);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 9;
            label10.Text = "Serie1:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(6, 55);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 8;
            label9.Text = "#Numero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(154, 26);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 7;
            label8.Text = "Hora:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(6, 24);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idClient);
            groupBox1.Controls.Add(btnResetFieldClient);
            groupBox1.Controls.Add(btnSearchClientOnCart);
            groupBox1.Controls.Add(btnAddClientOnCart);
            groupBox1.Controls.Add(textEmailCart);
            groupBox1.Controls.Add(textAddressCart);
            groupBox1.Controls.Add(textLastNameCart);
            groupBox1.Controls.Add(textFirstNameCart);
            groupBox1.Controls.Add(textPhoneCart);
            groupBox1.Controls.Add(textDNICart);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 117);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Cliente";
            // 
            // idClient
            // 
            idClient.AutoSize = true;
            idClient.ForeColor = Color.DeepSkyBlue;
            idClient.Location = new Point(36, 27);
            idClient.Name = "idClient";
            idClient.Size = new Size(18, 15);
            idClient.TabIndex = 15;
            idClient.Text = "ID";
            // 
            // btnResetFieldClient
            // 
            btnResetFieldClient.Cursor = Cursors.Hand;
            btnResetFieldClient.Image = Properties.Resources.btnCloseOne;
            btnResetFieldClient.Location = new Point(342, 76);
            btnResetFieldClient.Name = "btnResetFieldClient";
            btnResetFieldClient.Size = new Size(29, 24);
            btnResetFieldClient.SizeMode = PictureBoxSizeMode.StretchImage;
            btnResetFieldClient.TabIndex = 14;
            btnResetFieldClient.TabStop = false;
            // 
            // btnSearchClientOnCart
            // 
            btnSearchClientOnCart.Cursor = Cursors.Hand;
            btnSearchClientOnCart.Image = Properties.Resources.lupa;
            btnSearchClientOnCart.Location = new Point(342, 15);
            btnSearchClientOnCart.Name = "btnSearchClientOnCart";
            btnSearchClientOnCart.Size = new Size(29, 24);
            btnSearchClientOnCart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSearchClientOnCart.TabIndex = 13;
            btnSearchClientOnCart.TabStop = false;
            // 
            // btnAddClientOnCart
            // 
            btnAddClientOnCart.Cursor = Cursors.Hand;
            btnAddClientOnCart.Image = (Image)resources.GetObject("btnAddClientOnCart.Image");
            btnAddClientOnCart.Location = new Point(342, 47);
            btnAddClientOnCart.Name = "btnAddClientOnCart";
            btnAddClientOnCart.Size = new Size(29, 24);
            btnAddClientOnCart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddClientOnCart.TabIndex = 12;
            btnAddClientOnCart.TabStop = false;
            // 
            // textEmailCart
            // 
            textEmailCart.Location = new Point(235, 77);
            textEmailCart.Name = "textEmailCart";
            textEmailCart.Size = new Size(100, 23);
            textEmailCart.TabIndex = 11;
            // 
            // textAddressCart
            // 
            textAddressCart.Location = new Point(70, 76);
            textAddressCart.Name = "textAddressCart";
            textAddressCart.Size = new Size(100, 23);
            textAddressCart.TabIndex = 10;
            // 
            // textLastNameCart
            // 
            textLastNameCart.Location = new Point(237, 47);
            textLastNameCart.Name = "textLastNameCart";
            textLastNameCart.Size = new Size(100, 23);
            textLastNameCart.TabIndex = 9;
            // 
            // textFirstNameCart
            // 
            textFirstNameCart.Location = new Point(70, 47);
            textFirstNameCart.Name = "textFirstNameCart";
            textFirstNameCart.Size = new Size(100, 23);
            textFirstNameCart.TabIndex = 8;
            // 
            // textPhoneCart
            // 
            textPhoneCart.Location = new Point(237, 16);
            textPhoneCart.Name = "textPhoneCart";
            textPhoneCart.Size = new Size(100, 23);
            textPhoneCart.TabIndex = 7;
            // 
            // textDNICart
            // 
            textDNICart.Location = new Point(70, 18);
            textDNICart.Name = "textDNICart";
            textDNICart.Size = new Size(100, 23);
            textDNICart.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(176, 85);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(9, 84);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 4;
            label5.Text = "Direccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(176, 55);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(9, 55);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(176, 24);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(9, 26);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "CI:";
            // 
            // frmProforma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridCart);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProforma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proforma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCart).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddProductToCart).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnResetFieldClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearchClientOnCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddClientOnCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTotalOneCart;
        private DataGridView dataGridCart;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn IdProducto;
        private GroupBox groupBox4;
        private Label labelTotalTwoCart;
        private Label labelIvaCart;
        private Label label26;
        private Button btnSaveCart;
        private Label labelSubTotalTwelveCart;
        private Label sad;
        private Label label23;
        private Label labelSubTotalZeroCart;
        private Label label19;
        private Label labelDescuentCart;
        private Label label15;
        private Label labelSubTotalCart;
        private Label label12;
        private GroupBox groupBox3;
        private PictureBox btnAddProductToCart;
        private TextBox textPriceTotalCart;
        private TextBox textPriceUnitaryCart;
        private TextBox textDescuentProduct;
        private TextBox textQuantityCart;
        private TextBox textDescriptionCart;
        private TextBox textCodeCart;
        private GroupBox groupBox2;
        private Label labelHour;
        private DateTimePicker dateTimePicker;
        private TextBox textSerieTwoCart;
        private TextBox textSerieOneCart;
        private TextBox textNumDocumentCart;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Label idClient;
        private PictureBox btnResetFieldClient;
        private PictureBox btnSearchClientOnCart;
        private PictureBox btnAddClientOnCart;
        private TextBox textEmailCart;
        private TextBox textAddressCart;
        private TextBox textLastNameCart;
        private TextBox textFirstNameCart;
        private TextBox textPhoneCart;
        private TextBox textDNICart;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}