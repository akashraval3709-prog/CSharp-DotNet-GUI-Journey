namespace program_17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            lstHobbies = new ListBox();
            chbox1 = new CheckBox();
            chBox2 = new CheckBox();
            chBox3 = new CheckBox();
            chBox4 = new CheckBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(45, 45, 48);
            label1.Location = new Point(255, 40);
            label1.Name = "label1";
            label1.Size = new Size(273, 37);
            label1.TabIndex = 0;
            label1.Text = "Select Your Hobbies";
            // 
            // lstHobbies
            // 
            lstHobbies.BorderStyle = BorderStyle.FixedSingle;
            lstHobbies.Font = new Font("Segoe UI", 10F);
            lstHobbies.FormattingEnabled = true;
            lstHobbies.Location = new Point(255, 290);
            lstHobbies.Name = "lstHobbies";
            lstHobbies.Size = new Size(270, 117);
            lstHobbies.TabIndex = 6;
            // 
            // chbox1
            // 
            chbox1.AutoSize = true;
            chbox1.Font = new Font("Segoe UI", 10F);
            chbox1.ForeColor = Color.Black;
            chbox1.Location = new Point(258, 120);
            chbox1.Name = "chbox1";
            chbox1.Size = new Size(94, 27);
            chbox1.TabIndex = 1;
            chbox1.Text = "Reading";
            chbox1.UseVisualStyleBackColor = true;
            chbox1.CheckedChanged += chbox1_CheckedChanged;
            // 
            // chBox2
            // 
            chBox2.AutoSize = true;
            chBox2.Font = new Font("Segoe UI", 10F);
            chBox2.ForeColor = Color.Black;
            chBox2.Location = new Point(418, 120);
            chBox2.Name = "chBox2";
            chBox2.Size = new Size(92, 27);
            chBox2.TabIndex = 2;
            chBox2.Text = "Gaming";
            chBox2.UseVisualStyleBackColor = true;
            chBox2.CheckedChanged += chBox2_CheckedChanged;
            // 
            // chBox3
            // 
            chBox3.AutoSize = true;
            chBox3.Font = new Font("Segoe UI", 10F);
            chBox3.ForeColor = Color.Black;
            chBox3.Location = new Point(258, 165);
            chBox3.Name = "chBox3";
            chBox3.Size = new Size(76, 27);
            chBox3.TabIndex = 3;
            chBox3.Text = "Music";
            chBox3.UseVisualStyleBackColor = true;
            chBox3.CheckedChanged += chBox3_CheckedChanged;
            // 
            // chBox4
            // 
            chBox4.AutoSize = true;
            chBox4.Font = new Font("Segoe UI", 10F);
            chBox4.ForeColor = Color.Black;
            chBox4.Location = new Point(418, 165);
            chBox4.Name = "chBox4";
            chBox4.Size = new Size(100, 27);
            chBox4.TabIndex = 4;
            chBox4.Text = "Traveling";
            chBox4.UseVisualStyleBackColor = true;
            chBox4.CheckedChanged += chBox4_CheckedChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(315, 220);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 42);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(chbox1);
            Controls.Add(chBox2);
            Controls.Add(chBox3);
            Controls.Add(chBox4);
            Controls.Add(btnSubmit);
            Controls.Add(lstHobbies);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hobbies Selection";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHobbies;
        private CheckBox chbox1;
        private CheckBox chBox2;
        private CheckBox chBox3;
        private CheckBox chBox4;
        private Button btnSubmit;
    }
}