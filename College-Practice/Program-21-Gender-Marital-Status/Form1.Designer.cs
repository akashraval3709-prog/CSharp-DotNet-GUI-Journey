namespace Program_21
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
            groupBox1 = new GroupBox();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            groupBox2 = new GroupBox();
            rdoUnmarried = new RadioButton();
            rdoMarried = new RadioButton();
            label1 = new Label();
            lblMgs = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoFemale);
            groupBox1.Controls.Add(rdoMale);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(193, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(6, 71);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(88, 27);
            rdoFemale.TabIndex = 2;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            rdoFemale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(6, 38);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(70, 27);
            rdoMale.TabIndex = 0;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            rdoMale.CheckedChanged += rdoMale_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoUnmarried);
            groupBox2.Controls.Add(rdoMarried);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(371, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(172, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "  marital status";
            // 
            // rdoUnmarried
            // 
            rdoUnmarried.AutoSize = true;
            rdoUnmarried.Location = new Point(6, 71);
            rdoUnmarried.Name = "rdoUnmarried";
            rdoUnmarried.Size = new Size(117, 27);
            rdoUnmarried.TabIndex = 1;
            rdoUnmarried.TabStop = true;
            rdoUnmarried.Text = "Unmarried";
            rdoUnmarried.UseVisualStyleBackColor = true;
            rdoUnmarried.CheckedChanged += rdoMarried_CheckedChanged;
            // 
            // rdoMarried
            // 
            rdoMarried.AutoSize = true;
            rdoMarried.Location = new Point(6, 38);
            rdoMarried.Name = "rdoMarried";
            rdoMarried.Size = new Size(95, 27);
            rdoMarried.TabIndex = 0;
            rdoMarried.TabStop = true;
            rdoMarried.Text = "Married";
            rdoMarried.UseVisualStyleBackColor = true;
            rdoMarried.CheckedChanged += rdoMarried_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(199, 58);
            label1.Name = "label1";
            label1.Size = new Size(352, 30);
            label1.TabIndex = 2;
            label1.Text = "Select Gender and Marital status";
            // 
            // lblMgs
            // 
            lblMgs.AutoSize = true;
            lblMgs.Font = new Font("Segoe UI", 10F);
            lblMgs.ForeColor = Color.FromArgb(0, 0, 64);
            lblMgs.Location = new Point(193, 298);
            lblMgs.Name = "lblMgs";
            lblMgs.Size = new Size(0, 23);
            lblMgs.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMgs);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private GroupBox groupBox2;
        private RadioButton rdoUnmarried;
        private RadioButton rdoMarried;
        private Label label1;
        private Label lblMgs;
    }
}
