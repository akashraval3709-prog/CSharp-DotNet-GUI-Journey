namespace DemoMDIForm
{
    partial class picture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(picture));
            pictureBox = new PictureBox();
            btnZoomIn = new Button();
            btnZoomOut = new Button();
            btnReset = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(836, 452);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(242, 501);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(109, 48);
            btnZoomIn.TabIndex = 1;
            btnZoomIn.Text = "Zoom In";
            btnZoomIn.UseVisualStyleBackColor = true;
            btnZoomIn.Click += btnZoomIn_Click;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(372, 501);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(109, 48);
            btnZoomOut.TabIndex = 2;
            btnZoomOut.Text = "Zoom Out";
            btnZoomOut.UseVisualStyleBackColor = true;
            btnZoomOut.Click += btnZoomOut_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(504, 501);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(109, 48);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(25, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 455);
            panel1.TabIndex = 4;
            // 
            // picture
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 574);
            Controls.Add(panel1);
            Controls.Add(btnReset);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "picture";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "picture";
            Load += picture_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private Button btnReset;
        private Panel panel1;
    }
}