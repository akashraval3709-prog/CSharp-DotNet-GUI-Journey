namespace program_15
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
            lblTitle = new Label();
            lbMsg = new Label();
            cmbCountries = new ComboBox();

            SuspendLayout();

            //=========================================
            // Form
            //=========================================

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(700, 350);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Country Selection";

            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 45, 48);
            lblTitle.Location = new Point(220, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 35);
            lblTitle.Text = "Select Your Country";

            

            cmbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountries.Font = new Font("Segoe UI", 10F);
            cmbCountries.FormattingEnabled = true;
            cmbCountries.Items.AddRange(new object[]
            {
                "India",
                "Iran",
                "Bangladesh",
                "Belize",
                "Bhutan",
                "Afghanistan",
                "Australia",
                "Pakistan",
                "China"
            });

            cmbCountries.Location = new Point(230, 110);
            cmbCountries.Name = "cmbCountries";
            cmbCountries.Size = new Size(240, 31);
            cmbCountries.SelectedIndexChanged += cmbCountries_SelectedIndexChanged;

           

            lbMsg.AutoSize = false;
            lbMsg.Location = new Point(140, 190);
            lbMsg.Name = "lbMsg";
            lbMsg.Size = new Size(420, 40);

            lbMsg.TextAlign = ContentAlignment.MiddleCenter;

            lbMsg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            lbMsg.ForeColor = Color.DodgerBlue;

            lbMsg.BackColor = Color.White;

            lbMsg.BorderStyle = BorderStyle.FixedSingle;

            lbMsg.Text = "Please select a country.";

           

            Controls.Add(lblTitle);
            Controls.Add(cmbCountries);
            Controls.Add(lbMsg);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lbMsg;
        private ComboBox cmbCountries;
    }
}
