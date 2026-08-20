namespace program_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            progressBar.Value = trackBar.Value;
            lblPer.Text = progressBar.Value + " %";
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
