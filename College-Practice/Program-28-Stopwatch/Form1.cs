namespace program_28
{
    public partial class Form1 : Form
    {
        int m, s, ms;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bntStop.Enabled = false;
            timerStopWatch.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bntStop.Enabled = true;
            timerStopWatch.Enabled = true;
        }

        private void timerStopWatch_Tick(object sender, EventArgs e)
        {
            ms++;

            if (ms == 10)
            {
                s++;
                ms = 0;
            }

            if (s == 59)
            {
                m++;
                s = 0;
            }

            lblTimer.Text = $"{m} : {s} : {ms}";
        }

        private void bntStop_Click(object sender, EventArgs e)
        {

            timerStopWatch.Enabled = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "0 : 0 : 0";
            m = 0;
            s = 0;
            ms = 0;
            timerStopWatch.Enabled = false;
            bntStop.Enabled = false;

        }
    }
}
