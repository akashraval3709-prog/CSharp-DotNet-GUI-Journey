namespace program_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMsg.Text = cmbCountries.Text;
        }
    }
}
