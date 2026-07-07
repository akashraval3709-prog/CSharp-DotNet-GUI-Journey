namespace program_12
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

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtMsg.TextAlign = HorizontalAlignment.Left;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            txtMsg.TextAlign = HorizontalAlignment.Right;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            txtMsg.TextAlign = HorizontalAlignment.Center;
        }
    }
}
