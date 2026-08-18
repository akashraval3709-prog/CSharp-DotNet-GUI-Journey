namespace program_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDateCalculate_Click(object sender, EventArgs e)
        {
            TimeSpan difference = monthCalendar2.SelectionEnd.Date - monthCalendar1.SelectionStart.Date;
            int day = Math.Abs(difference.Days);
            lblMag.Text = "Difference between the two dates in day " + day;
        }
    }
}
