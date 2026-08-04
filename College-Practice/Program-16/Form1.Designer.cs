namespace program_16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtNumbers = new TextBox();
            groupBox2 = new GroupBox();
            btnBack = new Button();
            button18 = new Button();
            btnClear = new Button();
            button20 = new Button();
            button13 = new Button();
            btnDigits = new Button();
            button15 = new Button();
            button16 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            btnEqual = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNumbers);
            groupBox1.Location = new Point(0, -9);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(570, 98);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtNumbers
            // 
            txtNumbers.BorderStyle = BorderStyle.FixedSingle;
            txtNumbers.Location = new Point(8, 35);
            txtNumbers.Margin = new Padding(4);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.ReadOnly = true;
            txtNumbers.Size = new Size(494, 27);
            txtNumbers.TabIndex = 1;
            txtNumbers.TabStop = false;
            txtNumbers.TextAlign = HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBack);
            groupBox2.Controls.Add(button18);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(button20);
            groupBox2.Controls.Add(button13);
            groupBox2.Controls.Add(btnDigits);
            groupBox2.Controls.Add(button15);
            groupBox2.Controls.Add(button16);
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(button10);
            groupBox2.Controls.Add(button11);
            groupBox2.Controls.Add(button12);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button7);
            groupBox2.Controls.Add(button8);
            groupBox2.Controls.Add(btnEqual);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(0, 94);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(514, 384);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(372, 24);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(110, 64);
            btnBack.TabIndex = 24;
            btnBack.Text = "⌫";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // button18
            // 
            button18.Location = new Point(255, 24);
            button18.Margin = new Padding(4);
            button18.Name = "button18";
            button18.Size = new Size(110, 64);
            button18.TabIndex = 23;
            button18.Text = "AC";
            button18.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(137, 24);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 64);
            btnClear.TabIndex = 22;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button20
            // 
            button20.Location = new Point(19, 24);
            button20.Margin = new Padding(4);
            button20.Name = "button20";
            button20.Size = new Size(110, 64);
            button20.TabIndex = 21;
            button20.Text = "%";
            button20.UseVisualStyleBackColor = true;
            button20.Click += btnDigits_Click;
            // 
            // button13
            // 
            button13.Location = new Point(373, 96);
            button13.Margin = new Padding(4);
            button13.Name = "button13";
            button13.Size = new Size(110, 64);
            button13.TabIndex = 20;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += btnDigits_Click;
            // 
            // btnDigits
            // 
            btnDigits.Location = new Point(256, 96);
            btnDigits.Margin = new Padding(4);
            btnDigits.Name = "btnDigits";
            btnDigits.Size = new Size(110, 64);
            btnDigits.TabIndex = 19;
            btnDigits.Text = "9";
            btnDigits.UseVisualStyleBackColor = true;
            btnDigits.Click += btnDigits_Click;
            // 
            // button15
            // 
            button15.Location = new Point(138, 96);
            button15.Margin = new Padding(4);
            button15.Name = "button15";
            button15.Size = new Size(110, 64);
            button15.TabIndex = 18;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = true;
            button15.Click += btnDigits_Click;
            // 
            // button16
            // 
            button16.Location = new Point(21, 96);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(110, 64);
            button16.TabIndex = 17;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = true;
            button16.Click += btnDigits_Click;
            // 
            // button9
            // 
            button9.Location = new Point(372, 166);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(110, 64);
            button9.TabIndex = 16;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnDigits_Click;
            // 
            // button10
            // 
            button10.Location = new Point(254, 166);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.Size = new Size(110, 64);
            button10.TabIndex = 15;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnDigits_Click;
            // 
            // button11
            // 
            button11.Location = new Point(137, 166);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.Size = new Size(110, 64);
            button11.TabIndex = 14;
            button11.Text = "5";
            button11.UseVisualStyleBackColor = true;
            button11.Click += btnDigits_Click;
            // 
            // button12
            // 
            button12.Location = new Point(20, 166);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.Size = new Size(110, 64);
            button12.TabIndex = 13;
            button12.Text = "4";
            button12.UseVisualStyleBackColor = true;
            button12.Click += btnDigits_Click;
            // 
            // button5
            // 
            button5.Location = new Point(372, 235);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(110, 64);
            button5.TabIndex = 12;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnDigits_Click;
            // 
            // button6
            // 
            button6.Location = new Point(254, 235);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(110, 64);
            button6.TabIndex = 11;
            button6.Text = "3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnDigits_Click;
            // 
            // button7
            // 
            button7.Location = new Point(137, 235);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(110, 64);
            button7.TabIndex = 10;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnDigits_Click;
            // 
            // button8
            // 
            button8.Location = new Point(20, 235);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(110, 64);
            button8.TabIndex = 9;
            button8.Text = "1";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnDigits_Click;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(372, 304);
            btnEqual.Margin = new Padding(4);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(110, 64);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // button3
            // 
            button3.Location = new Point(254, 304);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(110, 64);
            button3.TabIndex = 7;
            button3.Text = "•";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDigits_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 304);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(110, 64);
            button2.TabIndex = 6;
            button2.Text = "0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDigits_Click;
            // 
            // button1
            // 
            button1.Location = new Point(20, 304);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(110, 64);
            button1.TabIndex = 5;
            button1.Text = "00";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDigits_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 476);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNumbers;

        private GroupBox groupBox2;
        private Button btnEqual;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button13;
        private Button btnDigits;
        private Button button15;
        private Button button16;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button btnBack;
        private Button button18;
        private Button btnClear;
        private Button button20;
    }
}
