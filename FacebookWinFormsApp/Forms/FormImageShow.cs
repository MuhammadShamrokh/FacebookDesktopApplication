using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormImageShow : Form
    {
        private readonly Image r_Image;

        public FormImageShow(Image i_Image)
        {
            r_Image = i_Image;
            InitializeComponent();
        }

        private void ImageShowForm_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Image = r_Image;
        }
    }
}