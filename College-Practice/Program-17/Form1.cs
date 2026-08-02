namespace program_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (chbox1.Checked == false && chBox2.Checked == false && chBox3.Checked == false && chBox4.Checked == false)
            {
                btnSubmit.Enabled = false;

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            btnSubmit.Enabled = true;
            if (chbox1.Checked == true)
            {
                lstHobbies.Items.Add(chbox1.Text);
            }
            if (chBox2.Checked == true)
            {
                lstHobbies.Items.Add(chBox2.Text);
            }
            if (chBox3.Checked == true)
            {
                lstHobbies.Items.Add(chBox3.Text);
            }
            if (chBox4.Checked == true)
            {
                lstHobbies.Items.Add(chBox4.Text);
            }




            btnSubmit.Enabled = false;
        }

        private void chbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbox1.Checked == true)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }



        }

        private void chBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox2.Checked == true)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }


        }

        private void chBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox3.Checked == true)
            {
               
            btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }

        }

        private void chBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox4.Checked == true)
            {
              
            btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }

        }
    }
}
