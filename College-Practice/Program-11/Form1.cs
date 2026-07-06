namespace program_11
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtFName.Text.Trim() == "")
            {
                lblMsg.Text = "Please Enter first name";
                txtFName.Focus();
            }
            else if(txtLName.Text.Trim() == "")
            {
                lblMsg.Text = "Please Enter last name";
                txtLName.Focus();
            }
            else if(txtEmail.Text.Trim() == "")
            {
                lblMsg.Text = "Please Enter Email";
                txtEmail.Focus();
            }
            else
            {
                lblMsg.Text = "";
                MessageBox.Show($"Welcome, {txtFName.Text} {txtLName.Text} \n Your Email : {txtEmail.Text}", "Message");
            }

           
        }
    }
}
