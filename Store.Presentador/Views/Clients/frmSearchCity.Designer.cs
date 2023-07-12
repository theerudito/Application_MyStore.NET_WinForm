namespace Store.Presentador.Clients
{
    partial class frmAddCity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCity));
            mCityBindingSource = new BindingSource(components);
            panel1 = new Panel();
            textSearchCity = new TextBox();
            btnClose = new PictureBox();
            label1 = new Label();
            dataGridCity = new DataGridView();
            idCityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btnAddCity = new PictureBox();
            labelIdCity = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mCityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAddCity).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // mCityBindingSource
            // 
            mCityBindingSource.DataSource = typeof(Models.MCity);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 1);
            panel1.TabIndex = 17;
            // 
            // textSearchCity
            // 
            textSearchCity.Location = new Point(10, 38);
            textSearchCity.Name = "textSearchCity";
            textSearchCity.Size = new Size(247, 23);
            textSearchCity.TabIndex = 17;
            textSearchCity.TextChanged += textSearchCity_TextChanged;
            textSearchCity.KeyDown += textSearchCity_KeyDown;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.btnCloseOne;
            btnClose.Location = new Point(280, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(20, 20);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 18;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(81, 6);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 19;
            label1.Text = "Buscar Ciudad";
            // 
            // dataGridCity
            // 
            dataGridCity.AutoGenerateColumns = false;
            dataGridCity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCity.Columns.AddRange(new DataGridViewColumn[] { idCityDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn });
            dataGridCity.DataSource = mCityBindingSource;
            dataGridCity.Location = new Point(6, 70);
            dataGridCity.Name = "dataGridCity";
            dataGridCity.ReadOnly = true;
            dataGridCity.RowTemplate.Height = 25;
            dataGridCity.Size = new Size(290, 297);
            dataGridCity.TabIndex = 20;
            dataGridCity.CellClick += dataGridCity_CellClick;
            dataGridCity.CellDoubleClick += dataGridCity_CellDoubleClick;
            // 
            // idCityDataGridViewTextBoxColumn
            // 
            idCityDataGridViewTextBoxColumn.DataPropertyName = "IdCity";
            idCityDataGridViewTextBoxColumn.HeaderText = "IdCity";
            idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
            idCityDataGridViewTextBoxColumn.ReadOnly = true;
            idCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            cityDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            cityDataGridViewTextBoxColumn.ReadOnly = true;
            cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnAddCity
            // 
            btnAddCity.Cursor = Cursors.Hand;
     
            btnAddCity.Location = new Point(263, 31);
            btnAddCity.Name = "btnAddCity";
            btnAddCity.Size = new Size(30, 30);
            btnAddCity.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddCity.TabIndex = 21;
            btnAddCity.TabStop = false;
            btnAddCity.Click += btnAddCity_Click;
            // 
            // labelIdCity
            // 
            labelIdCity.AutoSize = true;
            labelIdCity.ForeColor = Color.DeepSkyBlue;
            labelIdCity.Location = new Point(10, 6);
            labelIdCity.Name = "labelIdCity";
            labelIdCity.Size = new Size(18, 15);
            labelIdCity.TabIndex = 22;
            labelIdCity.Text = "ID";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(labelIdCity);
            panel5.Controls.Add(btnAddCity);
            panel5.Controls.Add(dataGridCity);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(textSearchCity);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(307, 378);
            panel5.TabIndex = 21;
            // 
            // frmAddCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(307, 379);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAddCity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Ciudad";
            ((System.ComponentModel.ISupportInitialize)mCityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAddCity).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource mCityBindingSource;
        private Panel panel1;
        private TextBox textSearchCity;
        private PictureBox btnClose;
        private Label label1;
        private DataGridView dataGridCity;
        private DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private PictureBox btnAddCity;
        private Label labelIdCity;
        private Panel panel5;
    }
}