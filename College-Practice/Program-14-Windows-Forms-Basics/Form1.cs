namespace program_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.;

        }
        private void btnGgChange_Click(object sender, EventArgs e)
        {

            if (this.BackColor == Color.WhiteSmoke)
            {
                this.BackColor = Color.Black;
            }
            else if (this.BackColor == Color.Black)
            {
                this.BackColor = Color.Gray;
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;

            }

        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            txtBox.Focus();
        }

       
    }
}

