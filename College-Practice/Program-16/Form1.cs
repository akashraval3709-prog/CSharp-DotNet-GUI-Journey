using System.Data;

namespace program_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnDigits_Click(object sender, EventArgs e)
        {
            if (txtNumbers.Text == "ERROR")
            {
                txtNumbers.Clear();
                txtNumbers.ForeColor = Color.Black;
                return;
            }
            try
            {

                Button btn = (Button)sender;

                txtNumbers.ForeColor = Color.Black;
                
                txtNumbers.Text += btn.Text;
            }
            catch
            {
                txtNumbers.Text = "ERROR";
                txtNumbers.ForeColor = Color.Red;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                txtNumbers.Text = dt.Compute(txtNumbers.Text, "").ToString();
                txtNumbers.ForeColor = Color.Black;
            }
            catch
            {
                txtNumbers.Text = "ERROR";
                txtNumbers.ForeColor = Color.Red;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (txtNumbers.Text.Trim() != "") { String result = txtNumbers.Text.Substring(0, txtNumbers.Text.Length - 1); txtNumbers.Text = result; }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumbers.Clear();
        }
    }
}
