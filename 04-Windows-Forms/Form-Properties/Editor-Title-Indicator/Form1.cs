namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            this.Text = "MyDocument.txt - Editor";

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "MyDocument.txt* - Editor";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Text = "MyDocument.txt - Editor";
        }
    }
}
