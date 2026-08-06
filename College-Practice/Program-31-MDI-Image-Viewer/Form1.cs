namespace DemoMDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {



            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "select a file";
            fileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = fileDialog.FileName;

                picture pf = new picture();

                pf.MdiParent = this;
                pf.pictureBox.Image = Image.FromFile(filePath);
                pf.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                pf.Show();
            }





        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;


            if (activeChild != null)
            {

                activeChild.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
