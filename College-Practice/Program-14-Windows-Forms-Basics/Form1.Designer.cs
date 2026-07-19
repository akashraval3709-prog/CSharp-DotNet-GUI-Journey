namespace program_14
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
            groupBox1 = new GroupBox();
            lblName = new Label();
            txtBox = new TextBox();
            btnGgChange = new Button();
            btnMessageBox = new Button();
            bntClear = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtBox);
            groupBox1.Controls.Add(btnGgChange);
            groupBox1.Controls.Add(btnMessageBox);
            groupBox1.Controls.Add(bntClear);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(80, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Operations";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(116, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Enter Name";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(150, 60);
            txtBox.Name = "txtBox";
            txtBox.PlaceholderText = "Enter your name";
            txtBox.Size = new Size(300, 32);
            txtBox.TabIndex = 1;
            // 
            // btnGgChange
            // 
            btnGgChange.BackColor = Color.DodgerBlue;
            btnGgChange.FlatAppearance.BorderSize = 0;
            btnGgChange.FlatStyle = FlatStyle.Flat;
            btnGgChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGgChange.ForeColor = Color.White;
            btnGgChange.Location = new Point(21, 191);
            btnGgChange.Name = "btnGgChange";
            btnGgChange.Size = new Size(130, 42);
            btnGgChange.TabIndex = 2;
            btnGgChange.Text = "Change Color";
            btnGgChange.UseVisualStyleBackColor = false;
            btnGgChange.Click += btnGgChange_Click;
            // 
            // btnMessageBox
            // 
            btnMessageBox.BackColor = Color.DodgerBlue;
            btnMessageBox.FlatAppearance.BorderSize = 0;
            btnMessageBox.FlatStyle = FlatStyle.Flat;
            btnMessageBox.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMessageBox.ForeColor = Color.White;
            btnMessageBox.Location = new Point(179, 191);
            btnMessageBox.Name = "btnMessageBox";
            btnMessageBox.Size = new Size(148, 42);
            btnMessageBox.TabIndex = 3;
            btnMessageBox.Text = "Show Message";
            btnMessageBox.UseVisualStyleBackColor = false;
            btnMessageBox.Click += btnMessageBox_Click;
            // 
            // bntClear
            // 
            bntClear.BackColor = Color.DodgerBlue;
            bntClear.FlatAppearance.BorderSize = 0;
            bntClear.FlatStyle = FlatStyle.Flat;
            bntClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntClear.ForeColor = Color.White;
            bntClear.Location = new Point(355, 191);
            bntClear.Name = "bntClear";
            bntClear.Size = new Size(130, 42);
            bntClear.TabIndex = 4;
            bntClear.Text = "Clear";
            bntClear.UseVisualStyleBackColor = false;
            bntClear.Click += bntClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 400);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Forms Demo";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblName;
        private TextBox txtBox;
        private Button btnGgChange;
        private Button btnMessageBox;
        private Button bntClear;
    }
}