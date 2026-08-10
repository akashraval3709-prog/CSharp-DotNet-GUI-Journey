namespace program_30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCountry.SelectedIndex != -1)
            {
                lstCountry.Items.Remove(lstCountry.SelectedItem);

            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void lstCountry_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(lstCountry, e.Location);

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstCountry.SelectedIndex != -1)
            {
                txtTextBox.Visible = true;
                btnUpdate.Visible = true;
                int index = lstCountry.SelectedIndex;
                txtTextBox.Text = lstCountry.SelectedItem.ToString();
                


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstCountry.SelectedIndex;
            lstCountry.Items.RemoveAt(index);
            lstCountry.Items.Insert(index, txtTextBox.Text);
            txtTextBox.Visible =false;
            btnUpdate.Visible =false;

        }
    }
}
