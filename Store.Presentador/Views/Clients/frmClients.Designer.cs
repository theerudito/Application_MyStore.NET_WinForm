namespace Store.Presentador.Clients
{
    partial class frmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClients));
            clientsBindingSource = new BindingSource(components);
            dataGridClients = new DataGridView();
            IdClient = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fisrtNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            btnUpdateClient = new Button();
            btnSaveClient = new Button();
            btnDeleteClient = new Button();
            groupBox2 = new GroupBox();
            btnGetClient = new PictureBox();
            label7 = new Label();
            textGetClient = new TextBox();
            groupBox1 = new GroupBox();
            labelIdCity = new Label();
            labelStatus = new Label();
            label9 = new Label();
            btnAddCity = new PictureBox();
            comboBoxCity = new ComboBox();
            labelIdClient = new Label();
            label8 = new Label();
            pictureClient = new PictureBox();
            textEmailClient = new TextBox();
            textPhoneClient = new TextBox();
            textDirectionClient = new TextBox();
            textLastNameClient = new TextBox();
            textFirstNameClient = new TextBox();
            textDNIClient = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetClient).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureClient).BeginInit();
            SuspendLayout();
            // 
            // clientsBindingSource
            // 
            clientsBindingSource.DataSource = typeof(Models.MClients);
            // 
            // dataGridClients
            // 
            dataGridClients.AutoGenerateColumns = false;
            dataGridClients.BackgroundColor = Color.FromArgb(51, 62, 80);
            dataGridClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClients.Columns.AddRange(new DataGridViewColumn[] { IdClient, dNIDataGridViewTextBoxColumn, fisrtNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, directionDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn, Status });
            dataGridClients.DataSource = clientsBindingSource;
            dataGridClients.GridColor = Color.FromArgb(51, 62, 80);
            dataGridClients.Location = new Point(303, 96);
            dataGridClients.Name = "dataGridClients";
            dataGridClients.ReadOnly = true;
            dataGridClients.RowTemplate.Height = 25;
            dataGridClients.Size = new Size(490, 346);
            dataGridClients.TabIndex = 25;
            dataGridClients.CellDoubleClick += dataGridClients_CellDoubleClick;
            // 
            // IdClient
            // 
            IdClient.DataPropertyName = "IdClient";
            IdClient.HeaderText = "Id";
            IdClient.Name = "IdClient";
            IdClient.ReadOnly = true;
            IdClient.Visible = false;
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
            directionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            directionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Telefono";
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
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnUpdateClient);
            groupBox3.Controls.Add(btnSaveClient);
            groupBox3.Controls.Add(btnDeleteClient);
            groupBox3.ForeColor = Color.DeepSkyBlue;
            groupBox3.Location = new Point(8, 375);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 59);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Controles";
            // 
            // btnUpdateClient
            // 
            btnUpdateClient.BackColor = SystemColors.MenuHighlight;
            btnUpdateClient.Cursor = Cursors.Hand;
            btnUpdateClient.FlatAppearance.BorderSize = 0;
            btnUpdateClient.FlatStyle = FlatStyle.Flat;
            btnUpdateClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateClient.ForeColor = Color.White;
            btnUpdateClient.Location = new Point(111, 22);
            btnUpdateClient.Name = "btnUpdateClient";
            btnUpdateClient.Size = new Size(75, 23);
            btnUpdateClient.TabIndex = 1;
            btnUpdateClient.Text = "Actualizar";
            btnUpdateClient.UseVisualStyleBackColor = false;
            btnUpdateClient.Click += btnUpdateClient_Click;
            // 
            // btnSaveClient
            // 
            btnSaveClient.BackColor = Color.GreenYellow;
            btnSaveClient.Cursor = Cursors.Hand;
            btnSaveClient.FlatAppearance.BorderSize = 0;
            btnSaveClient.FlatStyle = FlatStyle.Flat;
            btnSaveClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveClient.ForeColor = Color.Black;
            btnSaveClient.Location = new Point(11, 22);
            btnSaveClient.Name = "btnSaveClient";
            btnSaveClient.Size = new Size(75, 23);
            btnSaveClient.TabIndex = 0;
            btnSaveClient.Text = "Guardar";
            btnSaveClient.UseVisualStyleBackColor = false;
            btnSaveClient.Click += btnSaveClient_Click_1;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = Color.Red;
            btnDeleteClient.Cursor = Cursors.Hand;
            btnDeleteClient.FlatAppearance.BorderSize = 0;
            btnDeleteClient.FlatStyle = FlatStyle.Flat;
            btnDeleteClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteClient.ForeColor = Color.White;
            btnDeleteClient.Location = new Point(208, 22);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(75, 23);
            btnDeleteClient.TabIndex = 2;
            btnDeleteClient.Text = "Activar";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGetClient);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textGetClient);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(303, 8);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 67);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda de Cliente";
            // 
            // btnGetClient
            // 
            btnGetClient.Image = (Image)resources.GetObject("btnGetClient.Image");
            btnGetClient.Location = new Point(425, 22);
            btnGetClient.Name = "btnGetClient";
            btnGetClient.Size = new Size(30, 30);
            btnGetClient.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGetClient.TabIndex = 15;
            btnGetClient.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(23, 34);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 13;
            label7.Text = "Buscar:";
            // 
            // textGetClient
            // 
            textGetClient.Location = new Point(74, 26);
            textGetClient.Name = "textGetClient";
            textGetClient.Size = new Size(345, 23);
            textGetClient.TabIndex = 14;
            textGetClient.TextChanged += textGetClient_TextChanged;
            textGetClient.KeyDown += textGetClient_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelIdCity);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnAddCity);
            groupBox1.Controls.Add(comboBoxCity);
            groupBox1.Controls.Add(labelIdClient);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureClient);
            groupBox1.Controls.Add(textEmailClient);
            groupBox1.Controls.Add(textPhoneClient);
            groupBox1.Controls.Add(textDirectionClient);
            groupBox1.Controls.Add(textLastNameClient);
            groupBox1.Controls.Add(textFirstNameClient);
            groupBox1.Controls.Add(textDNIClient);
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
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion Clientes";
            // 
            // labelIdCity
            // 
            labelIdCity.AutoSize = true;
            labelIdCity.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdCity.Location = new Point(261, 323);
            labelIdCity.Name = "labelIdCity";
            labelIdCity.Size = new Size(14, 12);
            labelIdCity.TabIndex = 34;
            labelIdCity.Text = "IC";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(226, 73);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 15);
            labelStatus.TabIndex = 33;
            labelStatus.Text = "Activo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(226, 52);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 31;
            label9.Text = "Estado:";
            // 
            // btnAddCity
            // 
            btnAddCity.Cursor = Cursors.Hand;
            btnAddCity.Location = new Point(237, 317);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(20, 20);
            btnAddCity.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddCity.TabIndex = 30;
            btnAddCity.TabStop = false;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(86, 315);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(145, 23);
            comboBoxCity.TabIndex = 29;
            comboBoxCity.MouseDown += comboBoxCity_MouseDown;
            // 
            // labelIdClient
            // 
            labelIdClient.AutoSize = true;
            labelIdClient.Location = new Point(11, 99);
            labelIdClient.Name = "labelIdClient";
            labelIdClient.Size = new Size(18, 15);
            labelIdClient.TabIndex = 15;
            labelIdClient.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(10, 321);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "Ciudad:";
            // 
            // pictureClient
            // 
            pictureClient.Location = new Point(95, 22);
            pictureClient.Name = "pictureClient";
            pictureClient.Size = new Size(100, 80);
            pictureClient.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClient.TabIndex = 12;
            pictureClient.TabStop = false;
            // 
            // textEmailClient
            // 
            textEmailClient.Location = new Point(86, 283);
            textEmailClient.Name = "textEmailClient";
            textEmailClient.Size = new Size(145, 23);
            textEmailClient.TabIndex = 11;
            // 
            // textPhoneClient
            // 
            textPhoneClient.Location = new Point(86, 251);
            textPhoneClient.Name = "textPhoneClient";
            textPhoneClient.Size = new Size(145, 23);
            textPhoneClient.TabIndex = 10;
            textPhoneClient.KeyPress += textPhoneClient_KeyPress;
            // 
            // textDirectionClient
            // 
            textDirectionClient.Location = new Point(86, 219);
            textDirectionClient.Name = "textDirectionClient";
            textDirectionClient.Size = new Size(145, 23);
            textDirectionClient.TabIndex = 9;
            // 
            // textLastNameClient
            // 
            textLastNameClient.Location = new Point(86, 187);
            textLastNameClient.Name = "textLastNameClient";
            textLastNameClient.Size = new Size(145, 23);
            textLastNameClient.TabIndex = 8;
            // 
            // textFirstNameClient
            // 
            textFirstNameClient.Location = new Point(86, 155);
            textFirstNameClient.Name = "textFirstNameClient";
            textFirstNameClient.Size = new Size(145, 23);
            textFirstNameClient.TabIndex = 7;
            // 
            // textDNIClient
            // 
            textDNIClient.Location = new Point(86, 123);
            textDNIClient.Name = "textDNIClient";
            textDNIClient.Size = new Size(145, 23);
            textDNIClient.TabIndex = 6;
            textDNIClient.KeyPress += textDNIClient_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(10, 291);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(10, 260);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(11, 228);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(11, 195);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(11, 163);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(11, 131);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "CI:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Checked = true;
            checkBoxActive.CheckState = CheckState.Checked;
            checkBoxActive.Cursor = Cursors.Hand;
            checkBoxActive.ForeColor = Color.DeepSkyBlue;
            checkBoxActive.Location = new Point(733, 77);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(65, 19);
            checkBoxActive.TabIndex = 16;
            checkBoxActive.Text = "Activos";
            checkBoxActive.UseVisualStyleBackColor = true;
            checkBoxActive.CheckedChanged += checkBoxActive_CheckedChanged;
            // 
            // frmClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridClients);
            Controls.Add(groupBox3);
            Controls.Add(checkBoxActive);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridClients).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetClient).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource clientsBindingSource;
        private DataGridView dataGridClients;
        private GroupBox groupBox3;
        private Button btnUpdateClient;
        private Button btnSaveClient;
        private Button btnDeleteClient;
        private GroupBox groupBox2;
        private Label label7;
        private TextBox textGetClient;
        private GroupBox groupBox1;
        private Label label8;
        private PictureBox pictureClient;
        private TextBox textEmailClient;
        private TextBox textPhoneClient;
        private TextBox textDirectionClient;
        private TextBox textLastNameClient;
        private TextBox textFirstNameClient;
        private TextBox textDNIClient;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox btnGetClient;
        private Label labelIdClient;
        private CheckBox checkBoxActive;
        private PictureBox btnAddCity;
        private ComboBox comboBoxCity;
        private Label labelStatus;
        private Label label9;
        private DataGridViewTextBoxColumn IdClient;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fisrtNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Status;
        private Label labelIdCity;
    }
}