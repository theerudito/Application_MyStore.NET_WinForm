namespace Store.Presentador.Company
{
    partial class frmReportUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportUsers));
            groupBox1 = new GroupBox();
            btnSearchReport = new Button();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearchReport);
            groupBox1.Controls.Add(dateEnd);
            groupBox1.Controls.Add(dateStart);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 92);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // btnSearchReport
            // 
            btnSearchReport.BackColor = Color.DodgerBlue;
            btnSearchReport.FlatAppearance.BorderSize = 0;
            btnSearchReport.FlatStyle = FlatStyle.Flat;
            btnSearchReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchReport.ForeColor = Color.White;
            btnSearchReport.Location = new Point(682, 49);
            btnSearchReport.Name = "btnSearchReport";
            btnSearchReport.Size = new Size(75, 23);
            btnSearchReport.TabIndex = 5;
            btnSearchReport.Text = "Buscar";
            btnSearchReport.UseVisualStyleBackColor = false;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(433, 49);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(229, 23);
            dateEnd.TabIndex = 4;
            // 
            // dateStart
            // 
            dateStart.Location = new Point(104, 47);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(229, 23);
            dateStart.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(298, 9);
            label3.Name = "label3";
            label3.Size = new Size(170, 21);
            label3.TabIndex = 2;
            label3.Text = "Reportes de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 51);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Desde:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(351, 52);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 0;
            label1.Text = "Hasta:";
            // 
            // frmReportUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 62, 80);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmReportUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReportUsers";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearchReport;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}