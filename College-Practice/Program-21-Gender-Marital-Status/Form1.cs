using System.Runtime.InteropServices;

namespace Program_21
{
    public partial class Form1 : Form
    {
        string gender, marital_status;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblMgs.Text = "";
            rdoMarried.Checked = false;
            rdoMale.Checked = false;
        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {
            Message();

        }

        private void rdoMarried_CheckedChanged(object sender, EventArgs e)
        {

            Message();
        }

        public void Message()
        {
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                lblMgs.Text = "";
                return;
            }

            if (!rdoMarried.Checked && !rdoUnmarried.Checked)
            {
                lblMgs.Text = "";
                return;
            }

            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if (rdoMarried.Checked)
            {
                marital_status = "Married";
            }
            else
            {
                marital_status = "Un Married";
            }
            lblMgs.Text = $"You are {gender} and  {marital_status}";
        }

       
    }
}
