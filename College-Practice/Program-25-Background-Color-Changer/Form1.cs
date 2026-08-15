namespace program_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntBgChange_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();

            DialogResult d = c.ShowDialog();

            if(d == DialogResult.OK)
            {
                this.BackColor = c.Color;
            }
        }
    }
}
