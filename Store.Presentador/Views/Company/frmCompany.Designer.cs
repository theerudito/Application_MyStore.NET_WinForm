namespace Store.Presentador.Company
{
    partial class frmCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompany));
            groupBox5 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnSaveCompany = new Button();
            btnAdmin = new Button();
            textCodeCompany = new TextBox();
            groupBox4 = new GroupBox();
            comboBoxDocuments = new ComboBox();
            comboBoxIva = new ComboBox();
            comboBoxDataBase = new ComboBox();
            comboBoxCoin = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox3 = new GroupBox();
            textSerieOneCompany = new TextBox();
            textNumberDocumentCompany = new TextBox();
            label9 = new Label();
            textSerieTwoCompany = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            textPhoneCompany = new TextBox();
            textEmailCompany = new TextBox();
            textDirectionCompany = new TextBox();
            textOwnerCompany = new TextBox();
            textRUCCompany = new TextBox();
            textNameCompany = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(pictureBox1);
            groupBox5.Controls.Add(btnSaveCompany);
            groupBox5.Controls.Add(btnAdmin);
            groupBox5.Controls.Add(textCodeCompany);
            groupBox5.ForeColor = Color.DeepSkyBlue;
            groupBox5.Location = new Point(557, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(231, 426);
            groupBox5.TabIndex = 34;
            groupBox5.TabStop = false;
            groupBox5.Text = "Informacion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cart;
            pictureBox1.Location = new Point(67, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnSaveCompany
            // 
            btnSaveCompany.BackColor = Color.GreenYellow;
            btnSaveCompany.Cursor = Cursors.Hand;
            btnSaveCompany.FlatAppearance.BorderSize = 0;
            btnSaveCompany.FlatStyle = FlatStyle.Flat;
            btnSaveCompany.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCompany.ForeColor = SystemColors.Desktop;
            btnSaveCompany.Location = new Point(17, 366);
            btnSaveCompany.Name = "btnSaveCompany";
            btnSaveCompany.Size = new Size(199, 36);
            btnSaveCompany.TabIndex = 21;
            btnSaveCompany.Text = "GUARDAR";
            btnSaveCompany.UseVisualStyleBackColor = false;
            btnSaveCompany.Click += btnSaveCompany_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.Orange;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Location = new Point(123, 325);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(93, 23);
            btnAdmin.TabIndex = 20;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // textCodeCompany
            // 
            textCodeCompany.Location = new Point(17, 326);
            textCodeCompany.Name = "textCodeCompany";
            textCodeCompany.PasswordChar = '*';
            textCodeCompany.Size = new Size(93, 23);
            textCodeCompany.TabIndex = 19;
            textCodeCompany.KeyDown += textCodeCompany_KeyDown;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBoxDocuments);
            groupBox4.Controls.Add(comboBoxIva);
            groupBox4.Controls.Add(comboBoxDataBase);
            groupBox4.Controls.Add(comboBoxCoin);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.ForeColor = Color.DeepSkyBlue;
            groupBox4.Location = new Point(12, 338);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(527, 100);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Informacion Data";
            // 
            // comboBoxDocuments
            // 
            comboBoxDocuments.FormattingEnabled = true;
            comboBoxDocuments.Items.AddRange(new object[] { "FACTURA" });
            comboBoxDocuments.Location = new Point(335, 32);
            comboBoxDocuments.Name = "comboBoxDocuments";
            comboBoxDocuments.Size = new Size(121, 23);
            comboBoxDocuments.TabIndex = 25;
            // 
            // comboBoxIva
            // 
            comboBoxIva.FormattingEnabled = true;
            comboBoxIva.Items.AddRange(new object[] { "0.10", "0.11", "0.12", "0.13", "0.14", "0.15", "0.16", "0.17", "0.18", "0.19", "0.20" });
            comboBoxIva.Location = new Point(85, 64);
            comboBoxIva.Name = "comboBoxIva";
            comboBoxIva.Size = new Size(121, 23);
            comboBoxIva.TabIndex = 24;
            // 
            // comboBoxDataBase
            // 
            comboBoxDataBase.FormattingEnabled = true;
            comboBoxDataBase.Items.AddRange(new object[] { "WEB", "SQLITE", "LOCAL" });
            comboBoxDataBase.Location = new Point(85, 32);
            comboBoxDataBase.Name = "comboBoxDataBase";
            comboBoxDataBase.Size = new Size(121, 23);
            comboBoxDataBase.TabIndex = 23;
            // 
            // comboBoxCoin
            // 
            comboBoxCoin.FormattingEnabled = true;
            comboBoxCoin.Items.AddRange(new object[] { "USD", "COP", "EURO", "SOL" });
            comboBoxCoin.Location = new Point(335, 64);
            comboBoxCoin.Name = "comboBoxCoin";
            comboBoxCoin.Size = new Size(121, 23);
            comboBoxCoin.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.DeepSkyBlue;
            label13.Location = new Point(244, 72);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 12;
            label13.Text = "Moneda:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.DeepSkyBlue;
            label12.Location = new Point(239, 40);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 11;
            label12.Text = "Documento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.DeepSkyBlue;
            label11.Location = new Point(21, 72);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 10;
            label11.Text = "Iva:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.DeepSkyBlue;
            label10.Location = new Point(21, 40);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 9;
            label10.Text = "Database:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textSerieOneCompany);
            groupBox3.Controls.Add(textNumberDocumentCompany);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textSerieTwoCompany);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.ForeColor = Color.DeepSkyBlue;
            groupBox3.Location = new Point(12, 247);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(527, 57);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Documentos";
            // 
            // textSerieOneCompany
            // 
            textSerieOneCompany.Location = new Point(255, 22);
            textSerieOneCompany.Name = "textSerieOneCompany";
            textSerieOneCompany.Size = new Size(100, 23);
            textSerieOneCompany.TabIndex = 13;
            // 
            // textNumberDocumentCompany
            // 
            textNumberDocumentCompany.Location = new Point(92, 22);
            textNumberDocumentCompany.Name = "textNumberDocumentCompany";
            textNumberDocumentCompany.Size = new Size(100, 23);
            textNumberDocumentCompany.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.DeepSkyBlue;
            label9.Location = new Point(374, 30);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "Serie2";
            // 
            // textSerieTwoCompany
            // 
            textSerieTwoCompany.Location = new Point(421, 22);
            textSerieTwoCompany.Name = "textSerieTwoCompany";
            textSerieTwoCompany.Size = new Size(100, 23);
            textSerieTwoCompany.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.DeepSkyBlue;
            label8.Location = new Point(211, 30);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "Serie1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(9, 30);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 6;
            label7.Text = "#Documento:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textPhoneCompany);
            groupBox2.Controls.Add(textEmailCompany);
            groupBox2.Controls.Add(textDirectionCompany);
            groupBox2.Controls.Add(textOwnerCompany);
            groupBox2.Controls.Add(textRUCCompany);
            groupBox2.Controls.Add(textNameCompany);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(527, 196);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informacion Propietario";
            // 
            // textPhoneCompany
            // 
            textPhoneCompany.Location = new Point(396, 148);
            textPhoneCompany.Name = "textPhoneCompany";
            textPhoneCompany.Size = new Size(125, 23);
            textPhoneCompany.TabIndex = 11;
            // 
            // textEmailCompany
            // 
            textEmailCompany.Location = new Point(97, 148);
            textEmailCompany.Name = "textEmailCompany";
            textEmailCompany.Size = new Size(180, 23);
            textEmailCompany.TabIndex = 10;
            // 
            // textDirectionCompany
            // 
            textDirectionCompany.Location = new Point(97, 106);
            textDirectionCompany.Name = "textDirectionCompany";
            textDirectionCompany.Size = new Size(180, 23);
            textDirectionCompany.TabIndex = 10;
            // 
            // textOwnerCompany
            // 
            textOwnerCompany.Location = new Point(97, 66);
            textOwnerCompany.Name = "textOwnerCompany";
            textOwnerCompany.Size = new Size(424, 23);
            textOwnerCompany.TabIndex = 9;
            // 
            // textRUCCompany
            // 
            textRUCCompany.Location = new Point(396, 106);
            textRUCCompany.Name = "textRUCCompany";
            textRUCCompany.Size = new Size(125, 23);
            textRUCCompany.TabIndex = 7;
            // 
            // textNameCompany
            // 
            textNameCompany.Location = new Point(97, 27);
            textNameCompany.Name = "textNameCompany";
            textNameCompany.Size = new Size(424, 23);
            textNameCompany.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(335, 156);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefono:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(335, 114);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "RUC:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(15, 114);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(15, 156);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Propietario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Razon Social:";
            // 
            // frmCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comfiguracion";
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private PictureBox pictureBox1;
        private Button btnSaveCompany;
        private Button btnAdmin;
        private TextBox textCodeCompany;
        private GroupBox groupBox4;
        private TextBox textCurrentCompany;
        private TextBox textDocumentCompany;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private GroupBox groupBox3;
        private TextBox textSerieOneCompany;
        private TextBox textNumberDocumentCompany;
        private Label label9;
        private TextBox textSerieTwoCompany;
        private Label label8;
        private Label label7;
        private GroupBox groupBox2;
        private TextBox textPhoneCompany;
        private TextBox textEmailCompany;
        private TextBox textDirectionCompany;
        private TextBox textOwnerCompany;
        private TextBox textRUCCompany;
        private TextBox textNameCompany;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBoxCoin;
        private ComboBox comboBoxDocuments;
        private ComboBox comboBoxIva;
        private ComboBox comboBoxDataBase;
    }
}