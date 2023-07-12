namespace Store.Presentador.Home
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            panelMenu = new Panel();
            btnMenuConfiguration = new Button();
            btnMenuCart = new Button();
            btnMenuProduct = new Button();
            btnCloseWindowHome = new PictureBox();
            pictureBox1 = new PictureBox();
            btnMenuClient = new Button();
            panelClients = new Panel();
            btnGoReportsClients = new Button();
            btnAddClients = new Button();
            panelProducts = new Panel();
            btnGoReportsProducts = new Button();
            btnAddProduct = new Button();
            panelCart = new Panel();
            btnGoReportsDetails = new Button();
            btnFactura = new Button();
            panelConfiguration = new Panel();
            btnGoReportsUsers = new Button();
            btnGoConfiguration = new Button();
            btnGoUsers = new Button();
            btnCompany = new Button();
            statusLabelHome = new StatusStrip();
            labelUserData = new ToolStripStatusLabel();
            panelTabMenu = new Panel();
            panelTap = new Panel();
            btnCloseTap = new PictureBox();
            label1 = new Label();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseWindowHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelClients.SuspendLayout();
            panelProducts.SuspendLayout();
            panelCart.SuspendLayout();
            panelConfiguration.SuspendLayout();
            statusLabelHome.SuspendLayout();
            panelTabMenu.SuspendLayout();
            panelTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseTap).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 62, 80);
            panelMenu.Controls.Add(btnMenuConfiguration);
            panelMenu.Controls.Add(btnMenuCart);
            panelMenu.Controls.Add(btnMenuProduct);
            panelMenu.Controls.Add(btnCloseWindowHome);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnMenuClient);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(820, 40);
            panelMenu.TabIndex = 0;
            // 
            // btnMenuConfiguration
            // 
            btnMenuConfiguration.BackColor = Color.FromArgb(51, 62, 80);
            btnMenuConfiguration.Cursor = Cursors.Hand;
            btnMenuConfiguration.FlatAppearance.BorderSize = 0;
            btnMenuConfiguration.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenuConfiguration.FlatStyle = FlatStyle.Flat;
            btnMenuConfiguration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuConfiguration.ForeColor = Color.White;
            btnMenuConfiguration.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuConfiguration.Location = new Point(605, 5);
            btnMenuConfiguration.Name = "btnMenuConfiguration";
            btnMenuConfiguration.Size = new Size(140, 30);
            btnMenuConfiguration.TabIndex = 5;
            btnMenuConfiguration.Text = "Configuracion";
            btnMenuConfiguration.UseVisualStyleBackColor = false;
            btnMenuConfiguration.Click += btnMenuConfiguration_Click;
            btnMenuConfiguration.MouseEnter += btnMouseEnter;
            btnMenuConfiguration.MouseLeave += btnMouseLeave;
            // 
            // btnMenuCart
            // 
            btnMenuCart.BackColor = Color.FromArgb(51, 62, 80);
            btnMenuCart.Cursor = Cursors.Hand;
            btnMenuCart.FlatAppearance.BorderSize = 0;
            btnMenuCart.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenuCart.FlatStyle = FlatStyle.Flat;
            btnMenuCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuCart.ForeColor = Color.White;
            btnMenuCart.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuCart.Location = new Point(444, 5);
            btnMenuCart.Name = "btnMenuCart";
            btnMenuCart.Size = new Size(140, 30);
            btnMenuCart.TabIndex = 4;
            btnMenuCart.Text = "Factura";
            btnMenuCart.UseVisualStyleBackColor = false;
            btnMenuCart.Click += btnMenuCart_Click;
            btnMenuCart.MouseEnter += btnMouseEnter;
            btnMenuCart.MouseLeave += btnMouseLeave;
            // 
            // btnMenuProduct
            // 
            btnMenuProduct.BackColor = Color.FromArgb(51, 62, 80);
            btnMenuProduct.Cursor = Cursors.Hand;
            btnMenuProduct.FlatAppearance.BorderSize = 0;
            btnMenuProduct.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenuProduct.FlatStyle = FlatStyle.Flat;
            btnMenuProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuProduct.ForeColor = Color.White;
            btnMenuProduct.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuProduct.Location = new Point(280, 5);
            btnMenuProduct.Name = "btnMenuProduct";
            btnMenuProduct.Size = new Size(140, 30);
            btnMenuProduct.TabIndex = 3;
            btnMenuProduct.Text = "Productos";
            btnMenuProduct.UseVisualStyleBackColor = false;
            btnMenuProduct.Click += btnMenuProduct_Click;
            btnMenuProduct.MouseEnter += btnMouseEnter;
            btnMenuProduct.MouseLeave += btnMouseLeave;
            // 
            // btnCloseWindowHome
            // 
            btnCloseWindowHome.Cursor = Cursors.Hand;
            btnCloseWindowHome.Image = (Image)resources.GetObject("btnCloseWindowHome.Image");
            btnCloseWindowHome.Location = new Point(795, 5);
            btnCloseWindowHome.Name = "btnCloseWindowHome";
            btnCloseWindowHome.Size = new Size(20, 20);
            btnCloseWindowHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseWindowHome.TabIndex = 2;
            btnCloseWindowHome.TabStop = false;
            btnCloseWindowHome.Click += btnCloseWindowHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cart;
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnMenuClient
            // 
            btnMenuClient.BackColor = Color.FromArgb(51, 62, 80);
            btnMenuClient.Cursor = Cursors.Hand;
            btnMenuClient.FlatAppearance.BorderSize = 0;
            btnMenuClient.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMenuClient.FlatStyle = FlatStyle.Flat;
            btnMenuClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuClient.ForeColor = Color.White;
            btnMenuClient.ImageAlign = ContentAlignment.MiddleRight;
            btnMenuClient.Location = new Point(116, 5);
            btnMenuClient.Name = "btnMenuClient";
            btnMenuClient.Size = new Size(140, 30);
            btnMenuClient.TabIndex = 0;
            btnMenuClient.Text = "Clientes";
            btnMenuClient.UseVisualStyleBackColor = false;
            btnMenuClient.Click += btnMenuClient_Click;
            btnMenuClient.MouseEnter += btnMouseEnter;
            btnMenuClient.MouseLeave += btnMouseLeave;
            // 
            // panelClients
            // 
            panelClients.BackColor = Color.FromArgb(51, 62, 80);
            panelClients.Controls.Add(btnGoReportsClients);
            panelClients.Controls.Add(btnAddClients);
            panelClients.Location = new Point(116, 41);
            panelClients.Name = "panelClients";
            panelClients.Size = new Size(140, 100);
            panelClients.TabIndex = 0;
            panelClients.Visible = false;
            // 
            // btnGoReportsClients
            // 
            btnGoReportsClients.BackColor = Color.FromArgb(51, 62, 80);
            btnGoReportsClients.Cursor = Cursors.Hand;
            btnGoReportsClients.FlatAppearance.BorderSize = 0;
            btnGoReportsClients.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoReportsClients.FlatStyle = FlatStyle.Flat;
            btnGoReportsClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoReportsClients.ForeColor = Color.White;
            btnGoReportsClients.ImageAlign = ContentAlignment.MiddleRight;
            btnGoReportsClients.Location = new Point(3, 49);
            btnGoReportsClients.Name = "btnGoReportsClients";
            btnGoReportsClients.Size = new Size(134, 30);
            btnGoReportsClients.TabIndex = 6;
            btnGoReportsClients.Text = "Reportes";
            btnGoReportsClients.UseVisualStyleBackColor = false;
            btnGoReportsClients.Click += btnGoReportsClients_Click;
            // 
            // btnAddClients
            // 
            btnAddClients.BackColor = Color.FromArgb(51, 62, 80);
            btnAddClients.Cursor = Cursors.Hand;
            btnAddClients.FlatAppearance.BorderSize = 0;
            btnAddClients.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnAddClients.FlatStyle = FlatStyle.Flat;
            btnAddClients.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddClients.ForeColor = Color.White;
            btnAddClients.ImageAlign = ContentAlignment.MiddleRight;
            btnAddClients.Location = new Point(3, 13);
            btnAddClients.Name = "btnAddClients";
            btnAddClients.Size = new Size(134, 30);
            btnAddClients.TabIndex = 5;
            btnAddClients.Text = "Añadir Clientes";
            btnAddClients.UseVisualStyleBackColor = false;
            btnAddClients.Click += btnAddClients_Click;
            // 
            // panelProducts
            // 
            panelProducts.BackColor = Color.FromArgb(51, 62, 80);
            panelProducts.Controls.Add(btnGoReportsProducts);
            panelProducts.Controls.Add(btnAddProduct);
            panelProducts.Location = new Point(280, 41);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(140, 100);
            panelProducts.TabIndex = 6;
            panelProducts.Visible = false;
            // 
            // btnGoReportsProducts
            // 
            btnGoReportsProducts.BackColor = Color.FromArgb(51, 62, 80);
            btnGoReportsProducts.Cursor = Cursors.Hand;
            btnGoReportsProducts.FlatAppearance.BorderSize = 0;
            btnGoReportsProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoReportsProducts.FlatStyle = FlatStyle.Flat;
            btnGoReportsProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoReportsProducts.ForeColor = Color.White;
            btnGoReportsProducts.ImageAlign = ContentAlignment.MiddleRight;
            btnGoReportsProducts.Location = new Point(3, 49);
            btnGoReportsProducts.Name = "btnGoReportsProducts";
            btnGoReportsProducts.Size = new Size(134, 30);
            btnGoReportsProducts.TabIndex = 7;
            btnGoReportsProducts.Text = "Reportes";
            btnGoReportsProducts.UseVisualStyleBackColor = false;
            btnGoReportsProducts.Click += btnGoReportsProducts_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(51, 62, 80);
            btnAddProduct.Cursor = Cursors.Hand;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProduct.Location = new Point(3, 13);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(134, 30);
            btnAddProduct.TabIndex = 5;
            btnAddProduct.Text = "Añadir Producto";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // panelCart
            // 
            panelCart.BackColor = Color.FromArgb(51, 62, 80);
            panelCart.Controls.Add(btnGoReportsDetails);
            panelCart.Controls.Add(btnFactura);
            panelCart.Location = new Point(444, 41);
            panelCart.Name = "panelCart";
            panelCart.Size = new Size(140, 100);
            panelCart.TabIndex = 7;
            panelCart.Visible = false;
            // 
            // btnGoReportsDetails
            // 
            btnGoReportsDetails.BackColor = Color.FromArgb(51, 62, 80);
            btnGoReportsDetails.Cursor = Cursors.Hand;
            btnGoReportsDetails.FlatAppearance.BorderSize = 0;
            btnGoReportsDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoReportsDetails.FlatStyle = FlatStyle.Flat;
            btnGoReportsDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoReportsDetails.ForeColor = Color.White;
            btnGoReportsDetails.ImageAlign = ContentAlignment.MiddleRight;
            btnGoReportsDetails.Location = new Point(3, 49);
            btnGoReportsDetails.Name = "btnGoReportsDetails";
            btnGoReportsDetails.Size = new Size(134, 30);
            btnGoReportsDetails.TabIndex = 8;
            btnGoReportsDetails.Text = "Reportes";
            btnGoReportsDetails.UseVisualStyleBackColor = false;
            btnGoReportsDetails.Click += btnGoReportsDetails_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.FromArgb(51, 62, 80);
            btnFactura.Cursor = Cursors.Hand;
            btnFactura.FlatAppearance.BorderSize = 0;
            btnFactura.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnFactura.ForeColor = Color.White;
            btnFactura.ImageAlign = ContentAlignment.MiddleRight;
            btnFactura.Location = new Point(3, 13);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(134, 30);
            btnFactura.TabIndex = 5;
            btnFactura.Text = "Factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // panelConfiguration
            // 
            panelConfiguration.BackColor = Color.FromArgb(51, 62, 80);
            panelConfiguration.Controls.Add(btnGoReportsUsers);
            panelConfiguration.Controls.Add(btnGoConfiguration);
            panelConfiguration.Controls.Add(btnGoUsers);
            panelConfiguration.Controls.Add(btnCompany);
            panelConfiguration.Location = new Point(608, 41);
            panelConfiguration.Name = "panelConfiguration";
            panelConfiguration.Size = new Size(140, 142);
            panelConfiguration.TabIndex = 8;
            panelConfiguration.Visible = false;
            // 
            // btnGoReportsUsers
            // 
            btnGoReportsUsers.BackColor = Color.FromArgb(51, 62, 80);
            btnGoReportsUsers.Cursor = Cursors.Hand;
            btnGoReportsUsers.FlatAppearance.BorderSize = 0;
            btnGoReportsUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoReportsUsers.FlatStyle = FlatStyle.Flat;
            btnGoReportsUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoReportsUsers.ForeColor = Color.White;
            btnGoReportsUsers.ImageAlign = ContentAlignment.MiddleRight;
            btnGoReportsUsers.Location = new Point(3, 73);
            btnGoReportsUsers.Name = "btnGoReportsUsers";
            btnGoReportsUsers.Size = new Size(134, 30);
            btnGoReportsUsers.TabIndex = 11;
            btnGoReportsUsers.Text = "Reportes";
            btnGoReportsUsers.UseVisualStyleBackColor = false;
            btnGoReportsUsers.Click += btnGoReportsUsers_Click;
            // 
            // btnGoConfiguration
            // 
            btnGoConfiguration.BackColor = Color.FromArgb(51, 62, 80);
            btnGoConfiguration.Cursor = Cursors.Hand;
            btnGoConfiguration.FlatAppearance.BorderSize = 0;
            btnGoConfiguration.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoConfiguration.FlatStyle = FlatStyle.Flat;
            btnGoConfiguration.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoConfiguration.ForeColor = Color.White;
            btnGoConfiguration.ImageAlign = ContentAlignment.MiddleRight;
            btnGoConfiguration.Location = new Point(3, 103);
            btnGoConfiguration.Name = "btnGoConfiguration";
            btnGoConfiguration.Size = new Size(134, 30);
            btnGoConfiguration.TabIndex = 10;
            btnGoConfiguration.Text = "Configuracion";
            btnGoConfiguration.UseVisualStyleBackColor = false;
            btnGoConfiguration.Click += btnGoConfiguration_Click;
            // 
            // btnGoUsers
            // 
            btnGoUsers.BackColor = Color.FromArgb(51, 62, 80);
            btnGoUsers.Cursor = Cursors.Hand;
            btnGoUsers.FlatAppearance.BorderSize = 0;
            btnGoUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnGoUsers.FlatStyle = FlatStyle.Flat;
            btnGoUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoUsers.ForeColor = Color.White;
            btnGoUsers.ImageAlign = ContentAlignment.MiddleRight;
            btnGoUsers.Location = new Point(3, 43);
            btnGoUsers.Name = "btnGoUsers";
            btnGoUsers.Size = new Size(134, 30);
            btnGoUsers.TabIndex = 9;
            btnGoUsers.Text = "Usuarios";
            btnGoUsers.UseVisualStyleBackColor = false;
            btnGoUsers.Click += btnGoUsers_Click;
            // 
            // btnCompany
            // 
            btnCompany.BackColor = Color.FromArgb(51, 62, 80);
            btnCompany.Cursor = Cursors.Hand;
            btnCompany.FlatAppearance.BorderSize = 0;
            btnCompany.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, 210, 2);
            btnCompany.FlatStyle = FlatStyle.Flat;
            btnCompany.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompany.ForeColor = Color.White;
            btnCompany.ImageAlign = ContentAlignment.MiddleRight;
            btnCompany.Location = new Point(3, 13);
            btnCompany.Name = "btnCompany";
            btnCompany.Size = new Size(134, 30);
            btnCompany.TabIndex = 5;
            btnCompany.Text = "Empresa";
            btnCompany.UseVisualStyleBackColor = false;
            btnCompany.Click += btnCompany_Click;
            // 
            // statusLabelHome
            // 
            statusLabelHome.Items.AddRange(new ToolStripItem[] { labelUserData });
            statusLabelHome.Location = new Point(0, 558);
            statusLabelHome.Name = "statusLabelHome";
            statusLabelHome.Size = new Size(820, 22);
            statusLabelHome.TabIndex = 14;
            statusLabelHome.Text = "statusStrip1";
            // 
            // labelUserData
            // 
            labelUserData.BackColor = Color.Transparent;
            labelUserData.Name = "labelUserData";
            labelUserData.Size = new Size(50, 17);
            labelUserData.Text = "Usuario:";
            // 
            // panelTabMenu
            // 
            panelTabMenu.BackColor = SystemColors.ControlDark;
            panelTabMenu.Controls.Add(panelTap);
            panelTabMenu.Location = new Point(3, 42);
            panelTabMenu.Name = "panelTabMenu";
            panelTabMenu.Size = new Size(815, 33);
            panelTabMenu.TabIndex = 16;
            // 
            // panelTap
            // 
            panelTap.BackColor = Color.FromArgb(51, 62, 80);
            panelTap.Controls.Add(btnCloseTap);
            panelTap.Controls.Add(label1);
            panelTap.Location = new Point(5, 4);
            panelTap.Name = "panelTap";
            panelTap.Size = new Size(150, 25);
            panelTap.TabIndex = 18;
            // 
            // btnCloseTap
            // 
            btnCloseTap.Cursor = Cursors.Hand;
            btnCloseTap.Dock = DockStyle.Right;
            btnCloseTap.Image = Properties.Resources.closeTabOne;
            btnCloseTap.Location = new Point(124, 0);
            btnCloseTap.Name = "btnCloseTap";
            btnCloseTap.Size = new Size(26, 25);
            btnCloseTap.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCloseTap.TabIndex = 20;
            btnCloseTap.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 5);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 19;
            label1.Text = "Clientes";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(820, 580);
            Controls.Add(panelClients);
            Controls.Add(statusLabelHome);
            Controls.Add(panelMenu);
            Controls.Add(panelConfiguration);
            Controls.Add(panelCart);
            Controls.Add(panelProducts);
            Controls.Add(panelTabMenu);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += frmHome_FormClosing;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnCloseWindowHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelClients.ResumeLayout(false);
            panelProducts.ResumeLayout(false);
            panelCart.ResumeLayout(false);
            panelConfiguration.ResumeLayout(false);
            statusLabelHome.ResumeLayout(false);
            statusLabelHome.PerformLayout();
            panelTabMenu.ResumeLayout(false);
            panelTap.ResumeLayout(false);
            panelTap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseTap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Button btnMenuClient;
        private PictureBox btnCloseWindowHome;
        private PictureBox pictureBox1;
        private Button btnMenuCart;
        private Button btnMenuProduct;
        private Button btnMenuConfiguration;
        private Panel panelClients;
        private Button btnAddClients;
        private Panel panelProducts;
        private Button btnAddProduct;
        private Panel panelCart;
        private Button btnFactura;
        private Panel panelConfiguration;
        private Button btnCompany;
        private Button btnGoReportsClients;
        private Button btnGoReportsProducts;
        private Button btnGoReportsDetails;
        private Button btnGoConfiguration;
        private Button btnGoUsers;
        private StatusStrip statusLabelHome;
        private ToolStripStatusLabel labelUserData;
        private Panel panelTabMenu;
        private Button tabClients;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panelTap;
        private PictureBox btnCloseTap;
        private Label label1;
        private Button btnGoReportsUsers;
    }
}