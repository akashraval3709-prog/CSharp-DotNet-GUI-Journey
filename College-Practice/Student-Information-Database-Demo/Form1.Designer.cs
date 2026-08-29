namespace DBDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label5 = new Label();
            dgvData = new DataGridView();
            panel2 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            label4 = new Label();
            txtCity = new TextBox();
            txtRollNo = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dgvData);
            panel1.Location = new Point(407, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 426);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(266, 4);
            label5.Name = "label5";
            label5.Size = new Size(206, 28);
            label5.TabIndex = 1;
            label5.Text = "Student Records List";
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(15, 36);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.Size = new Size(784, 308);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(rdoFemale);
            panel2.Controls.Add(rdoMale);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(txtRollNo);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 426);
            panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(218, 339);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 42);
            btnClear.TabIndex = 6;
            btnClear.Text = "Cancel";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.HotTrack;
            btnAdd.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(117, 339);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 42);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI", 9.6F, FontStyle.Bold);
            rdoFemale.Location = new Point(234, 204);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(86, 25);
            rdoFemale.TabIndex = 3;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Segoe UI", 9.6F, FontStyle.Bold);
            rdoMale.Location = new Point(157, 205);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(69, 25);
            rdoMale.TabIndex = 2;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label4.Location = new Point(72, 205);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Gender  :";
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(151, 259);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 4;
            // 
            // txtRollNo
            // 
            txtRollNo.BorderStyle = BorderStyle.FixedSingle;
            txtRollNo.Location = new Point(151, 87);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.Size = new Size(125, 27);
            txtRollNo.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(151, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label3.Location = new Point(95, 259);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "City :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label2.Location = new Point(87, 150);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label1.Location = new Point(74, 90);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Roll No :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(98, 4);
            label6.Name = "label6";
            label6.Size = new Size(192, 28);
            label6.TabIndex = 7;
            label6.Text = "New Student Entry";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 629);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration & Records";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtCity;
        private TextBox txtRollNo;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label label4;
        private Button btnAdd;
        private DataGridView dgvData;
        private Label label5;
        private Button btnClear;
        private Label label6;
    }
}
