namespace program_23
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
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            btnDateCalculate = new Button();
            label1 = new Label();
            label2 = new Label();
            lblMag = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(97, 147);
            monthCalendar1.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            monthCalendar1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(452, 147);
            monthCalendar2.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            monthCalendar2.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 1;
            // 
            // btnDateCalculate
            // 
            btnDateCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDateCalculate.ForeColor = SystemColors.Highlight;
            btnDateCalculate.Location = new Point(347, 385);
            btnDateCalculate.Name = "btnDateCalculate";
            btnDateCalculate.Size = new Size(115, 45);
            btnDateCalculate.TabIndex = 2;
            btnDateCalculate.Text = "Calculate";
            btnDateCalculate.UseVisualStyleBackColor = true;
            btnDateCalculate.Click += btnDateCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(128, 110);
            label1.Name = "label1";
            label1.Size = new Size(179, 23);
            label1.TabIndex = 3;
            label1.Text = "Start MonthCalendar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(496, 110);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 4;
            label2.Text = "End MonthCalendar";
            // 
            // lblMag
            // 
            lblMag.AutoSize = true;
            lblMag.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMag.ForeColor = Color.Navy;
            lblMag.Location = new Point(166, 488);
            lblMag.Name = "lblMag";
            lblMag.Size = new Size(0, 23);
            lblMag.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 577);
            Controls.Add(lblMag);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDateCalculate);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Button btnDateCalculate;
        private Label label1;
        private Label label2;
        private Label lblMag;
    }
}
