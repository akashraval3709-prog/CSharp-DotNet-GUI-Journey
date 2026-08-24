namespace program_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            lblMsg.Text += "Selected Date " + dateTimePicker.Text;

        }
    }
}
