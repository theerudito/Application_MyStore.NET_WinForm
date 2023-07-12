namespace Store.Presentador.Auth
{
    partial class frmAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuth));
            panelLogin = new Panel();
            btnCloseLogin = new PictureBox();
            textPasswordLogin = new TextBox();
            textUserLogin = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            labelGoRegister = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelRegister = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            textPasswordRegister = new TextBox();
            textEmailRegister = new TextBox();
            textUserRegister = new TextBox();
            btnRegister = new Button();
            labelGoLogin = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnCloseRegister = new PictureBox();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseLogin).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelRegister.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseRegister).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(51, 62, 80);
            panelLogin.Controls.Add(btnCloseLogin);
            panelLogin.Controls.Add(textPasswordLogin);
            panelLogin.Controls.Add(textUserLogin);
            panelLogin.Controls.Add(panel2);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(labelGoRegister);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(label3);
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(422, 224);
            panelLogin.TabIndex = 1;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.Cursor = Cursors.Hand;
            btnCloseLogin.Image = Properties.Resources.btnCloseOne;
            btnCloseLogin.Location = new Point(396, 5);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(20, 20);
            btnCloseLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseLogin.TabIndex = 12;
            btnCloseLogin.TabStop = false;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // textPasswordLogin
            // 
            textPasswordLogin.Location = new Point(215, 110);
            textPasswordLogin.Name = "textPasswordLogin";
            textPasswordLogin.PasswordChar = '*';
            textPasswordLogin.PlaceholderText = "Password";
            textPasswordLogin.Size = new Size(184, 23);
            textPasswordLogin.TabIndex = 22;
            textPasswordLogin.KeyDown += textPasswordLogin_KeyDown;
            // 
            // textUserLogin
            // 
            textUserLogin.Location = new Point(215, 78);
            textUserLogin.Name = "textUserLogin";
            textUserLogin.PlaceholderText = "Usuario";
            textUserLogin.Size = new Size(184, 23);
            textUserLogin.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(121, 224);
            panel2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.database;
            pictureBox1.Location = new Point(32, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.GreenYellow;
            label13.Location = new Point(10, 5);
            label13.Name = "label13";
            label13.Size = new Size(75, 28);
            label13.TabIndex = 16;
            label13.Text = "Ilusion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.GreenYellow;
            label6.Location = new Point(21, 33);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 17;
            label6.Text = "Software";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.cart;
            pictureBox4.Location = new Point(10, 134);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 79);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.YellowGreen;
            label1.Location = new Point(215, 8);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 14;
            label1.Text = "Iniciar Sesion";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuHighlight;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(215, 160);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(184, 23);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelGoRegister
            // 
            labelGoRegister.AutoSize = true;
            labelGoRegister.Cursor = Cursors.Hand;
            labelGoRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGoRegister.ForeColor = Color.YellowGreen;
            labelGoRegister.Location = new Point(271, 200);
            labelGoRegister.Name = "labelGoRegister";
            labelGoRegister.Size = new Size(70, 15);
            labelGoRegister.TabIndex = 19;
            labelGoRegister.Text = "Registrarse";
            labelGoRegister.Visible = false;
            labelGoRegister.Click += labelGoRegister_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(130, 200);
            label5.Name = "label5";
            label5.Size = new Size(140, 15);
            label5.TabIndex = 18;
            label5.Text = "Sino tienes cuenta click:";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(133, 118);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 17;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(133, 86);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 16;
            label3.Text = "Usuario:";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(51, 62, 80);
            panelRegister.Controls.Add(panel4);
            panelRegister.Controls.Add(textPasswordRegister);
            panelRegister.Controls.Add(textEmailRegister);
            panelRegister.Controls.Add(textUserRegister);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(labelGoLogin);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(label9);
            panelRegister.Controls.Add(label10);
            panelRegister.Controls.Add(label11);
            panelRegister.Controls.Add(btnCloseRegister);
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(422, 224);
            panelRegister.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox2);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(121, 224);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.GreenYellow;
            label12.Location = new Point(21, 33);
            label12.Name = "label12";
            label12.Size = new Size(97, 28);
            label12.TabIndex = 13;
            label12.Text = "Software";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.GreenYellow;
            label2.Location = new Point(10, 5);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 12;
            label2.Text = "Ilusion";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(10, 134);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // textPasswordRegister
            // 
            textPasswordRegister.Location = new Point(215, 126);
            textPasswordRegister.Name = "textPasswordRegister";
            textPasswordRegister.PasswordChar = '*';
            textPasswordRegister.Size = new Size(184, 23);
            textPasswordRegister.TabIndex = 11;
            textPasswordRegister.KeyDown += textPasswordRegister_KeyDown;
            // 
            // textEmailRegister
            // 
            textEmailRegister.Location = new Point(215, 94);
            textEmailRegister.Name = "textEmailRegister";
            textEmailRegister.Size = new Size(184, 23);
            textEmailRegister.TabIndex = 10;
            // 
            // textUserRegister
            // 
            textUserRegister.Location = new Point(215, 62);
            textUserRegister.Name = "textUserRegister";
            textUserRegister.Size = new Size(184, 23);
            textUserRegister.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.MenuHighlight;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(215, 160);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(184, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // labelGoLogin
            // 
            labelGoLogin.AutoSize = true;
            labelGoLogin.Cursor = Cursors.Hand;
            labelGoLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelGoLogin.ForeColor = Color.YellowGreen;
            labelGoLogin.Location = new Point(258, 200);
            labelGoLogin.Name = "labelGoLogin";
            labelGoLogin.Size = new Size(87, 15);
            labelGoLogin.TabIndex = 7;
            labelGoLogin.Text = "Iniciar Seccion";
            labelGoLogin.Click += labelGoLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(130, 200);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 6;
            label7.Text = "Si tienes cuenta click:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(133, 134);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 5;
            label8.Text = "Contraseña:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(133, 102);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 4;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(133, 70);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 3;
            label10.Text = "Nombre:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.YellowGreen;
            label11.Location = new Point(215, 8);
            label11.Name = "label11";
            label11.Size = new Size(102, 25);
            label11.TabIndex = 2;
            label11.Text = "Registarse";
            // 
            // btnCloseRegister
            // 
            btnCloseRegister.Cursor = Cursors.Hand;
            btnCloseRegister.Image = (Image)resources.GetObject("btnCloseRegister.Image");
            btnCloseRegister.Location = new Point(396, 5);
            btnCloseRegister.Name = "btnCloseRegister";
            btnCloseRegister.Size = new Size(20, 20);
            btnCloseRegister.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCloseRegister.TabIndex = 1;
            btnCloseRegister.TabStop = false;
            btnCloseRegister.Click += btnCloseRegister_Click;
            // 
            // frmAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 223);
            Controls.Add(panelLogin);
            Controls.Add(panelRegister);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAuth";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auth";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCloseLogin).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseRegister).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private TextBox textPasswordLogin;
        private TextBox textUserLogin;
        private Panel panel2;
        private Label label1;
        private Button btnLogin;
        private Label labelGoRegister;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panelRegister;
        private Panel panel4;
        private Label label2;
        private PictureBox pictureBox2;
        private TextBox textPasswordRegister;
        private TextBox textEmailRegister;
        private TextBox textUserRegister;
        private Button btnRegister;
        private Label labelGoLogin;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox btnCloseRegister;
        private PictureBox btnCloseLogin;
        private PictureBox pictureBox3;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label6;
        private PictureBox pictureBox4;
    }
}