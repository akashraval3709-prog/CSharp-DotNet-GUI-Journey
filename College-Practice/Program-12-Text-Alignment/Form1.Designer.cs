namespace program_12
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            txtMsg = new TextBox();
            btnLeft = new Button();
            btnCenter = new Button();
            btnRight = new Button();
            SuspendLayout();

            // 
            // txtMsg
            // 
            txtMsg.BackColor = Color.White;
            txtMsg.BorderStyle = BorderStyle.FixedSingle;
            txtMsg.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            txtMsg.ForeColor = Color.MidnightBlue;
            txtMsg.Location = new Point(200, 90);
            txtMsg.Name = "txtMsg";
            txtMsg.Size = new Size(400, 39);
            txtMsg.TabIndex = 0;
            txtMsg.Text = "Hello World!";
            txtMsg.TextAlign = HorizontalAlignment.Center;

            // 
            // btnLeft
            // 
            btnLeft.BackColor = Color.RoyalBlue;
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLeft.ForeColor = Color.White;
            btnLeft.Location = new Point(120, 200);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(150, 45);
            btnLeft.TabIndex = 1;
            btnLeft.Text = "⬅ Left";
            btnLeft.UseVisualStyleBackColor = false;
            btnLeft.Click += btnLeft_Click;

            // 
            // btnCenter
            // 
            btnCenter.BackColor = Color.DarkOrange;
            btnCenter.FlatAppearance.BorderSize = 0;
            btnCenter.FlatStyle = FlatStyle.Flat;
            btnCenter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCenter.ForeColor = Color.White;
            btnCenter.Location = new Point(325, 200);
            btnCenter.Name = "btnCenter";
            btnCenter.Size = new Size(150, 45);
            btnCenter.TabIndex = 2;
            btnCenter.Text = "◎ Center";
            btnCenter.UseVisualStyleBackColor = false;
            btnCenter.Click += btnCenter_Click;

            // 
            // btnRight
            // 
            btnRight.BackColor = Color.ForestGreen;
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRight.ForeColor = Color.White;
            btnRight.Location = new Point(530, 200);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(150, 45);
            btnRight.TabIndex = 3;
            btnRight.Text = "Right ➜";
            btnRight.UseVisualStyleBackColor = false;
            btnRight.Click += btnRight_Click;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 248, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnRight);
            Controls.Add(btnCenter);
            Controls.Add(btnLeft);
            Controls.Add(txtMsg);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "✨ Text Alignment Demo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMsg;
        private Button btnLeft;
        private Button btnCenter;
        private Button btnRight;
    }
}