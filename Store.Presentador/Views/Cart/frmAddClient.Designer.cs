namespace Store.Presentador.Cart
{
    partial class fmAddClientCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAddClientCart));
            btnSaveClient = new Button();
            groupBox1 = new GroupBox();
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
            btnClose = new PictureBox();
            panel1 = new Panel();
            labelDNI = new Label();
            labelIdClient = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // btnSaveClient
            // 
            btnSaveClient.BackColor = Color.GreenYellow;
            btnSaveClient.Cursor = Cursors.Hand;
            btnSaveClient.FlatAppearance.BorderSize = 0;
            btnSaveClient.FlatStyle = FlatStyle.Flat;
            btnSaveClient.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveClient.ForeColor = Color.Black;
            btnSaveClient.Location = new Point(118, 235);
            btnSaveClient.Name = "btnSaveClient";
            btnSaveClient.Size = new Size(258, 39);
            btnSaveClient.TabIndex = 0;
            btnSaveClient.Text = "Guardar";
            btnSaveClient.UseVisualStyleBackColor = false;
            btnSaveClient.Click += btnSaveClient_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(0, 0, 0, 24);
            groupBox1.Controls.Add(labelDNI);
            groupBox1.Controls.Add(labelIdClient);
            groupBox1.Controls.Add(btnSaveClient);
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
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 286);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Añadir Cliente";
            // 
            // pictureClient
            // 
            pictureClient.BackColor = Color.Transparent;
 
            pictureClient.Location = new Point(76, 22);
            pictureClient.Name = "pictureClient";
            pictureClient.Size = new Size(100, 80);
            pictureClient.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureClient.TabIndex = 12;
            pictureClient.TabStop = false;
            // 
            // textEmailClient
            // 
            textEmailClient.Location = new Point(320, 181);
            textEmailClient.Name = "textEmailClient";
            textEmailClient.Size = new Size(169, 23);
            textEmailClient.TabIndex = 11;
            // 
            // textPhoneClient
            // 
            textPhoneClient.Location = new Point(320, 123);
            textPhoneClient.Name = "textPhoneClient";
            textPhoneClient.Size = new Size(169, 23);
            textPhoneClient.TabIndex = 10;
            textPhoneClient.KeyPress += textPhoneClient_KeyPress;
            // 
            // textDirectionClient
            // 
            textDirectionClient.Location = new Point(76, 181);
            textDirectionClient.Name = "textDirectionClient";
            textDirectionClient.Size = new Size(169, 23);
            textDirectionClient.TabIndex = 9;
            // 
            // textLastNameClient
            // 
            textLastNameClient.Location = new Point(320, 152);
            textLastNameClient.Name = "textLastNameClient";
            textLastNameClient.Size = new Size(169, 23);
            textLastNameClient.TabIndex = 8;
            // 
            // textFirstNameClient
            // 
            textFirstNameClient.Location = new Point(76, 152);
            textFirstNameClient.Name = "textFirstNameClient";
            textFirstNameClient.Size = new Size(169, 23);
            textFirstNameClient.TabIndex = 7;
            // 
            // textDNIClient
            // 
            textDNIClient.Location = new Point(76, 123);
            textDNIClient.Name = "textDNIClient";
            textDNIClient.Size = new Size(169, 23);
            textDNIClient.TabIndex = 6;
            textDNIClient.KeyPress += textDNIClient_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(275, 189);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(259, 131);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(11, 189);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(260, 163);
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
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;

            btnClose.Location = new Point(498, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 13;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 328);
            panel1.TabIndex = 26;
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelDNI.ForeColor = Color.DeepSkyBlue;
            labelDNI.Location = new Point(381, 34);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(22, 12);
            labelDNI.TabIndex = 14;
            labelDNI.Text = "DNI";
            // 
            // labelIdClient
            // 
            labelIdClient.AutoSize = true;
            labelIdClient.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            labelIdClient.ForeColor = Color.DeepSkyBlue;
            labelIdClient.Location = new Point(381, 19);
            labelIdClient.Name = "labelIdClient";
            labelIdClient.Size = new Size(15, 12);
            labelIdClient.TabIndex = 13;
            labelIdClient.Text = "ID";
            // 
            // fmAddClientCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(525, 328);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "fmAddClientCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Añadir Cliente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSaveClient;
        private GroupBox groupBox1;
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
        private PictureBox btnClose;
        private Panel panel1;
        private Label labelDNI;
        private Label labelIdClient;
    }
}