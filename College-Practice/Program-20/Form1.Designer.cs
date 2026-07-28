namespace program_20
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label1 = new Label();
            lstTo_DoList = new ListBox();
            txtBox = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.5F);
            btnAdd.Location = new Point(310, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 32);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.5F);
            btnDelete.Location = new Point(30, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 35);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9.5F);
            btnClear.Location = new Point(220, 380);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 35);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(138, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Task:";
            // 
            // lstTo_DoList
            // 
            lstTo_DoList.Font = new Font("Segoe UI", 10F);
            lstTo_DoList.FormattingEnabled = true;
            lstTo_DoList.Location = new Point(30, 105);
            lstTo_DoList.Name = "lstTo_DoList";
            lstTo_DoList.Size = new Size(370, 257);
            lstTo_DoList.TabIndex = 3;
            lstTo_DoList.MouseDoubleClick += lstTo_DoList_MouseDoubleClick;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Segoe UI", 10F);
            txtBox.Location = new Point(30, 55);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(270, 30);
            txtBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 441);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lstTo_DoList);
            Controls.Add(btnAdd);
            Controls.Add(txtBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To-Do List Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Label label1;
        private TextBox txtBox;
        private ListBox lstTo_DoList;
    }
}
