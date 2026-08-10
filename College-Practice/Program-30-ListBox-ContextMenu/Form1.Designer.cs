namespace program_30
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
            lstCountry = new ListBox();
            contextMenuStrip = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            txtTextBox = new TextBox();
            btnUpdate = new Button();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lstCountry
            // 
            lstCountry.BorderStyle = BorderStyle.FixedSingle;
            lstCountry.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCountry.FormattingEnabled = true;
            lstCountry.Items.AddRange(new object[] { "India", "USA", "UK", "Chin", "Japan", "Bhutan ", "Albania", "Algeria", "Botswana", "Brazil", "Brunei" });
            lstCountry.Location = new Point(142, 89);
            lstCountry.Name = "lstCountry";
            lstCountry.Size = new Size(196, 262);
            lstCountry.TabIndex = 0;
            lstCountry.MouseUp += lstCountry_MouseUp;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.ImageScalingSize = new Size(20, 20);
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, editToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(123, 52);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(122, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 24);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // txtTextBox
            // 
            txtTextBox.BorderStyle = BorderStyle.FixedSingle;
            txtTextBox.Location = new Point(161, 35);
            txtTextBox.Name = "txtTextBox";
            txtTextBox.Size = new Size(177, 27);
            txtTextBox.TabIndex = 1;
            txtTextBox.Visible = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(344, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtTextBox);
            Controls.Add(lstCountry);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCountry;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private TextBox txtTextBox;
        private Button btnUpdate;
    }
}
