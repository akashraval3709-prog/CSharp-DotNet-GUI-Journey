namespace program_11
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            btnRegister = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(202, 131);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(204, 175);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 1;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(222, 215);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 2;
            label3.Text = "Email ID :";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(309, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtLName
            // 
            txtLName.BorderStyle = BorderStyle.FixedSingle;
            txtLName.Location = new Point(309, 171);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 27);
            txtLName.TabIndex = 4;
            // 
            // txtFName
            // 
            txtFName.BorderStyle = BorderStyle.FixedSingle;
            txtFName.Location = new Point(309, 127);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(125, 27);
            txtFName.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.RoyalBlue;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.HighlightText;
            btnRegister.Location = new Point(327, 284);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(91, 44);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(318, 250);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 20);
            lblMsg.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg);
            Controls.Add(btnRegister);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "RegisterForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtLName;
        private TextBox txtFName;
        private Button btnRegister;
        private Label lblMsg;
    }
}
