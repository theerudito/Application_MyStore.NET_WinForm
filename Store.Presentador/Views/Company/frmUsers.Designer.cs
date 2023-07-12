namespace Store.Presentador.Company
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            dataGridUser = new DataGridView();
            idAuthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            mAuthBindingSource = new BindingSource(components);
            btnAdd = new Button();
            textNameUser = new TextBox();
            textUserName = new TextBox();
            textEmailUser = new TextBox();
            textPasswordUser = new TextBox();
            pictureBox1 = new PictureBox();
            comboRoleUser = new ComboBox();
            btnUpdate = new Button();
            btnEnable = new Button();
            textSearchUser = new TextBox();
            labelIdUser = new Label();
            groupBox1 = new GroupBox();
            btnGetClient = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            labelStatus = new Label();
            label8 = new Label();
            label7 = new Label();
            textDirectionUser = new TextBox();
            label6 = new Label();
            textPhoneUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBoxActive = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mAuthBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetClient).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridUser
            // 
            dataGridUser.AutoGenerateColumns = false;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Columns.AddRange(new DataGridViewColumn[] { idAuthDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, directionDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, Status });
            dataGridUser.DataSource = mAuthBindingSource;
            dataGridUser.Location = new Point(337, 85);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridUser.RowTemplate.Height = 25;
            dataGridUser.Size = new Size(451, 353);
            dataGridUser.TabIndex = 9;
            dataGridUser.CellDoubleClick += dataGridUser_CellDoubleClick;
            // 
            // idAuthDataGridViewTextBoxColumn
            // 
            idAuthDataGridViewTextBoxColumn.DataPropertyName = "IdAuth";
            idAuthDataGridViewTextBoxColumn.HeaderText = "IdAuth";
            idAuthDataGridViewTextBoxColumn.Name = "idAuthDataGridViewTextBoxColumn";
            idAuthDataGridViewTextBoxColumn.ReadOnly = true;
            idAuthDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "Nombre";
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directionDataGridViewTextBoxColumn
            // 
            directionDataGridViewTextBoxColumn.DataPropertyName = "Direction";
            directionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            directionDataGridViewTextBoxColumn.Name = "directionDataGridViewTextBoxColumn";
            directionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Rol";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Estado";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Visible = false;
            // 
            // mAuthBindingSource
            // 
            mAuthBindingSource.DataSource = typeof(Models.MAuth);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(15, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 22);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Guardar";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textNameUser
            // 
            textNameUser.Location = new Point(87, 101);
            textNameUser.Name = "textNameUser";
            textNameUser.Size = new Size(186, 23);
            textNameUser.TabIndex = 5;
            // 
            // textUserName
            // 
            textUserName.Location = new Point(87, 136);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(186, 23);
            textUserName.TabIndex = 10;
            // 
            // textEmailUser
            // 
            textEmailUser.Location = new Point(87, 171);
            textEmailUser.Name = "textEmailUser";
            textEmailUser.Size = new Size(186, 23);
            textEmailUser.TabIndex = 11;
            // 
            // textPasswordUser
            // 
            textPasswordUser.Location = new Point(87, 206);
            textPasswordUser.Name = "textPasswordUser";
            textPasswordUser.PasswordChar = '*';
            textPasswordUser.Size = new Size(186, 23);
            textPasswordUser.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(101, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // comboRoleUser
            // 
            comboRoleUser.FormattingEnabled = true;
            comboRoleUser.Items.AddRange(new object[] { "Administrador", "Empleado" });
            comboRoleUser.Location = new Point(87, 311);
            comboRoleUser.Name = "comboRoleUser";
            comboRoleUser.Size = new Size(186, 23);
            comboRoleUser.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(116, 18);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 22);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnEnable
            // 
            btnEnable.BackColor = Color.Red;
            btnEnable.FlatAppearance.BorderSize = 0;
            btnEnable.FlatStyle = FlatStyle.Flat;
            btnEnable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnable.ForeColor = Color.White;
            btnEnable.Location = new Point(217, 18);
            btnEnable.Name = "btnEnable";
            btnEnable.Size = new Size(80, 22);
            btnEnable.TabIndex = 16;
            btnEnable.Text = "Activo";
            btnEnable.UseVisualStyleBackColor = false;
            btnEnable.Click += btnEnable_Click;
            // 
            // textSearchUser
            // 
            textSearchUser.Location = new Point(6, 20);
            textSearchUser.Name = "textSearchUser";
            textSearchUser.Size = new Size(403, 23);
            textSearchUser.TabIndex = 17;
            textSearchUser.TextChanged += textSearchUser_TextChanged;
            textSearchUser.KeyDown += textSearchUser_KeyDown;
            // 
            // labelIdUser
            // 
            labelIdUser.AutoSize = true;
            labelIdUser.ForeColor = Color.DeepSkyBlue;
            labelIdUser.Location = new Point(16, 59);
            labelIdUser.Name = "labelIdUser";
            labelIdUser.Size = new Size(18, 15);
            labelIdUser.TabIndex = 19;
            labelIdUser.Text = "ID";
            labelIdUser.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetClient);
            groupBox1.Controls.Add(textSearchUser);
            groupBox1.ForeColor = Color.DeepSkyBlue;
            groupBox1.Location = new Point(337, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(451, 53);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda de Usuario";
            // 
            // btnGetClient
            // 
            btnGetClient.Image = (Image)resources.GetObject("btnGetClient.Image");
            btnGetClient.Location = new Point(415, 17);
            btnGetClient.Name = "btnGetClient";
            btnGetClient.Size = new Size(30, 30);
            btnGetClient.SizeMode = PictureBoxSizeMode.StretchImage;
            btnGetClient.TabIndex = 24;
            btnGetClient.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnEnable);
            groupBox2.ForeColor = Color.DeepSkyBlue;
            groupBox2.Location = new Point(12, 375);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 53);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controles";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelStatus);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textDirectionUser);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textPhoneUser);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(textNameUser);
            groupBox3.Controls.Add(textUserName);
            groupBox3.Controls.Add(labelIdUser);
            groupBox3.Controls.Add(textEmailUser);
            groupBox3.Controls.Add(textPasswordUser);
            groupBox3.Controls.Add(comboRoleUser);
            groupBox3.ForeColor = Color.DeepSkyBlue;
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(303, 357);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informacion Usuario";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(228, 70);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 15);
            labelStatus.TabIndex = 30;
            labelStatus.Text = "Activo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 51);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 29;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DeepSkyBlue;
            label7.Location = new Point(16, 244);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 28;
            label7.Text = "Telefono:";
            // 
            // textDirectionUser
            // 
            textDirectionUser.Location = new Point(87, 276);
            textDirectionUser.Name = "textDirectionUser";
            textDirectionUser.Size = new Size(186, 23);
            textDirectionUser.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DeepSkyBlue;
            label6.Location = new Point(16, 279);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 26;
            label6.Text = "Direccion:";
            // 
            // textPhoneUser
            // 
            textPhoneUser.Location = new Point(87, 241);
            textPhoneUser.Name = "textPhoneUser";
            textPhoneUser.Size = new Size(187, 23);
            textPhoneUser.TabIndex = 25;
            textPhoneUser.KeyPress += textPhoneUser_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(16, 313);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 24;
            label5.Text = "Rol:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 23;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DeepSkyBlue;
            label3.Location = new Point(16, 177);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 22;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DeepSkyBlue;
            label2.Location = new Point(16, 143);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 21;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(16, 109);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 20;
            label1.Text = "Nombre:";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Checked = true;
            checkBoxActive.CheckState = CheckState.Checked;
            checkBoxActive.ForeColor = Color.DeepSkyBlue;
            checkBoxActive.Location = new Point(723, 65);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(65, 19);
            checkBoxActive.TabIndex = 24;
            checkBoxActive.Text = "Activos";
            checkBoxActive.UseVisualStyleBackColor = true;
            checkBoxActive.CheckedChanged += checkBoxActive_CheckedChanged;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxActive);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridUser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)mAuthBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetClient).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridUser;
        private Button btnAdd;
        private TextBox textNameUser;
        private TextBox textUserName;
        private TextBox textEmailUser;
        private TextBox textPasswordUser;
        private PictureBox pictureBox1;
        private ComboBox comboRoleUser;
        private Button btnUpdate;
        private Button btnEnable;
        private TextBox textSearchUser;
        private Label labelIdUser;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private PictureBox btnGetClient;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox textDirectionUser;
        private Label label6;
        private TextBox textPhoneUser;
        private CheckBox checkBoxActive;
        private BindingSource mAuthBindingSource;
        private Label labelStatus;
        private Label label8;
        private DataGridViewTextBoxColumn idAuthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Status;
    }
}