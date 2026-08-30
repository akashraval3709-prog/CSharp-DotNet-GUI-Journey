namespace DBDemo
{
    partial class frmUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            label5 = new Label();
            btnSave = new Button();
            panel2 = new Panel();
            label7 = new Label();
            dtBrithDate = new DateTimePicker();
            btnClear = new Button();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            label4 = new Label();
            txtCity = new TextBox();
            txtRollNo = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(169, 13);
            label5.Name = "label5";
            label5.Size = new Size(201, 28);
            label5.TabIndex = 7;
            label5.Text = "Edit Student Record";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(148, 341);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 58);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtBrithDate);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(rdoFemale);
            panel2.Controls.Add(rdoMale);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtCity);
            panel2.Controls.Add(txtRollNo);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(87, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 426);
            panel2.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 230);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 9;
            label7.Text = "Date Of Birth :";
            // 
            // dtBrithDate
            // 
            dtBrithDate.Format = DateTimePickerFormat.Short;
            dtBrithDate.Location = new Point(222, 228);
            dtBrithDate.Name = "dtBrithDate";
            dtBrithDate.Size = new Size(125, 27);
            dtBrithDate.TabIndex = 8;
            dtBrithDate.Value = new DateTime(2026, 8, 30, 0, 0, 0, 0);
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.HotTrack;
            btnClear.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(300, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 58);
            btnClear.TabIndex = 6;
            btnClear.Text = "Cancel";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI", 9.6F, FontStyle.Bold);
            rdoFemale.Location = new Point(303, 188);
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
            rdoMale.Location = new Point(226, 189);
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
            label4.Location = new Point(141, 189);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 2;
            label4.Text = "Gender  :";
            // 
            // txtCity
            // 
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Location = new Point(218, 277);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 4;
            // 
            // txtRollNo
            // 
            txtRollNo.BorderStyle = BorderStyle.FixedSingle;
            txtRollNo.Location = new Point(220, 71);
            txtRollNo.Name = "txtRollNo";
            txtRollNo.Size = new Size(125, 27);
            txtRollNo.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(220, 130);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label3.Location = new Point(162, 277);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 3;
            label3.Text = "City :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label2.Location = new Point(156, 134);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold);
            label1.Location = new Point(143, 74);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Roll No :";
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmUpdate";
            Text = "Update Student Details";
            Load += frmUpdate_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Button btnSave;
        private Panel panel2;
        private Label label7;
        private DateTimePicker dtBrithDate;
        private Button btnClear;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private Label label4;
        private TextBox txtCity;
        private TextBox txtRollNo;
        private TextBox txtName;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
