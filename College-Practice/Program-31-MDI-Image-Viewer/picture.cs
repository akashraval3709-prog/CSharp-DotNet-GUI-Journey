using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoMDIForm
{
    public partial class picture : Form
    {
        private Size originalSize;
        public picture()
        {
            InitializeComponent();
        }


        private void picture_Load(object sender, EventArgs e)
        {
            originalSize = pictureBox.Size;
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox.Width = (int)(pictureBox.Width * 1.25);
            pictureBox.Height = (int)(pictureBox.Height * 1.25);

        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox.Width = (int)(pictureBox.Width * 0.9);
            pictureBox.Height = (int)(pictureBox.Height * 0.9);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox.Size = originalSize;
        }
    }
}
