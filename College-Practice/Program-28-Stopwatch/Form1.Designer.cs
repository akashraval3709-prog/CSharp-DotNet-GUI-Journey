namespace program_28
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
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            bntStop = new Button();
            btnReset = new Button();
            lblTimer = new Label();
            panel1 = new Panel();
            timerStopWatch = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnStart.Location = new Point(88, 220);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 41);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // bntStop
            // 
            bntStop.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntStop.Location = new Point(211, 220);
            bntStop.Name = "bntStop";
            bntStop.Size = new Size(94, 41);
            bntStop.TabIndex = 1;
            bntStop.Text = "Stop";
            bntStop.UseVisualStyleBackColor = true;
            bntStop.Click += bntStop_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReset.Location = new Point(331, 220);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 41);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.BackColor = Color.FromArgb(255, 128, 0);
            lblTimer.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(190, 99);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(0, 46);
            lblTimer.TabIndex = 3;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTimer);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(bntStop);
            panel1.Controls.Add(btnReset);
            panel1.Location = new Point(135, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 289);
            panel1.TabIndex = 4;
            // 
            // timerStopWatch
            // 
            timerStopWatch.Tick += timerStopWatch_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button bntStop;
        private Button btnReset;
        private Label lblTimer;
        private Panel panel1;
        private System.Windows.Forms.Timer timerStopWatch;
    }
}
