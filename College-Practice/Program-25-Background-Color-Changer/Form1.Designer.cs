namespace program_25
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
            bntBgChange = new Button();
            SuspendLayout();
            // 
            // bntBgChange
            // 
            bntBgChange.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntBgChange.Location = new Point(315, 47);
            bntBgChange.Name = "bntBgChange";
            bntBgChange.Size = new Size(176, 56);
            bntBgChange.TabIndex = 0;
            bntBgChange.Text = "Change BGColor";
            bntBgChange.UseVisualStyleBackColor = true;
            bntBgChange.Click += bntBgChange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntBgChange);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Background Color Changer";
            ResumeLayout(false);
        }

        #endregion

        private Button bntBgChange;
    }
}
