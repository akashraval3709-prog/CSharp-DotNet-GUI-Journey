namespace program_27
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
            trackBar = new TrackBar();
            progressBar = new ProgressBar();
            lblPer = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // trackBar
            // 
            trackBar.Location = new Point(261, 161);
            trackBar.Maximum = 100;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(305, 56);
            trackBar.TabIndex = 0;
            trackBar.TickFrequency = 5;
            trackBar.Scroll += trackBar_Scroll;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(261, 259);
            progressBar.Name = "progressBar";
            progressBar.RightToLeft = RightToLeft.Yes;
            progressBar.Size = new Size(305, 29);
            progressBar.Step = 5;
            progressBar.TabIndex = 1;
            progressBar.Tag = " ";
            // 
            // lblPer
            // 
            lblPer.AutoSize = true;
            lblPer.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPer.Location = new Point(572, 263);
            lblPer.Name = "lblPer";
            lblPer.Size = new Size(0, 20);
            lblPer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(597, 172);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblPer);
            Controls.Add(progressBar);
            Controls.Add(trackBar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar;
        private ProgressBar progressBar;
        private Label lblPer;
        private Label label1;
    }
}
