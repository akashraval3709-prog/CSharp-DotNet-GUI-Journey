namespace program_20
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter any one task", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox.Focus();
            }
            else
            {
                lstTo_DoList.Items.Add(txtBox.Text);
                txtBox.Clear();
                txtBox.Focus();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstTo_DoList.SelectedIndex;
            if (index != -1)
            {
                DialogResult del = MessageBox.Show("Are you want delete task", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (del.ToString() == "Yes")
                {
                    lstTo_DoList.Items.Remove(lstTo_DoList.Text);
                }
            }
            else
            {
                MessageBox.Show("Please select any one task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int index = lstTo_DoList.SelectedIndex;
            if (index != -1)
            {
                DialogResult del = MessageBox.Show("Are you want clear all task", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (del.ToString() == "Yes")
                {
                    lstTo_DoList.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("You can't clear empty list box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBox.Focus();
            }

        }

        private void lstTo_DoList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int ind = lstTo_DoList.SelectedIndex;
            if(ind !=  -1)
            {

            lstTo_DoList.Items.RemoveAt(ind);
            }
        }
    }
}
