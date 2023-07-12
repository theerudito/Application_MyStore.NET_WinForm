namespace Store.Presentador.Cart
{
    partial class frmSearchClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchClient));
            dataGridSearchClient = new DataGridView();
            idClientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fisrtNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            mClientsBindingSource = new BindingSource(components);
            btnClose = new PictureBox();
            textSearchClient = new TextBox();
            label2 = new Label();
            labelIdClient = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            labelDNI = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridSearchClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mClientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridSearchClient
            // 
            dataGridSearchClient.AutoGenerateColumns = false;
            dataGridSearchClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSearchClient.Columns.AddRange(new DataGridViewColumn[] { idClientDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, fisrtNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, directionDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn });
            dataGridSearchClient.DataSource = mClientsBindingSource;
            dataGridSearchClient.Location = new Point(12, 72);
            dataGridSearchClient.Name = "dataGridSearchClient";
            dataGridSearchClient.ReadOnly = true;
            dataGridSearchClient.RowTemplate.Height = 25;
            dataGridSearchClient.Size = new Size(501, 244);
            dataGridSearchClient.TabIndex = 9;
            dataGridSearchClient.CellDoubleClick += dataGridSearchClient_CellDoubleClick;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            idClientDataGridViewTextBoxColumn.ReadOnly = true;
            idClientDataGridViewTextBoxColumn.Visible = false;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "CI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fisrtNameDataGridViewTextBoxColumn
            // 
            fisrtNameDataGridViewTextBoxColumn.DataPropertyName = "FisrtName";
            fisrtNameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            fisrtNameDataGridViewTextBoxColumn.Name = "fisrtNameDataGridViewTextBoxColumn";
            fisrtNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Apellido";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directionDataGridViewTextBoxColumn
            // 
            directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            directionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            directionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            statusDataGridViewCheckBoxColumn.ReadOnly = true;
            statusDataGridViewCheckBoxColumn.Visible = false;
            // 
            // mClientsBindingSource
            // 
            mClientsBindingSource.DataSource = typeof(Models.MClients);
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btnCloseOne;
            btnClose.Location = new Point(497, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 7;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // textSearchClient
            // 
            textSearchClient.Location = new Point(63, 22);
            textSearchClient.Name = "textSearchClient";
            textSearchClient.Size = new Size(343, 23);
            textSearchClient.TabIndex = 6;
            textSearchClient.TextChanged += textSearchClient_TextChanged;
            textSearchClient.KeyDown += textSearchClient_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 10;
            label2.Text = "Cliente:";
            // 
            // labelIdClient
            // 
            labelIdClient.AutoSize = true;
            labelIdClient.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdClient.ForeColor = Color.DeepSkyBlue;
            labelIdClient.Location = new Point(412, 19);
            labelIdClient.Name = "labelIdClient";
            labelIdClient.Size = new Size(15, 12);
            labelIdClient.TabIndex = 11;
            labelIdClient.Text = "ID";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 328);
            panel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelDNI);
            groupBox1.Controls.Add(labelIdClient);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textSearchClient);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(10, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Cliente";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelDNI.ForeColor = Color.DeepSkyBlue;
            labelDNI.Location = new Point(412, 34);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(22, 12);
            labelDNI.TabIndex = 12;
            labelDNI.Text = "DNI";
            // 
            // frmSearchClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(525, 328);
            Controls.Add(dataGridSearchClient);
            Controls.Add(btnClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSearchClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSearchClient";
            ((System.ComponentModel.ISupportInitialize)dataGridSearchClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)mClientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSearchClient;
        private PictureBox btnClose;
        private TextBox textSearchClient;
        private Label label2;
        private Label labelIdClient;
        private Panel panel1;
        private GroupBox groupBox1;
        private BindingSource mClientsBindingSource;
        private DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fisrtNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private Label labelDNI;
    }
}