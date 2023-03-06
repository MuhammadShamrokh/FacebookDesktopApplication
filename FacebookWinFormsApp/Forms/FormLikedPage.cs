using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormLikedPage : Form
    {
        private readonly Page r_Page;

        public FormLikedPage(Page i_Page)
        {
            r_Page = i_Page;
            InitializeComponent();
        }

        private void FormLikedPage_Load(object sender, System.EventArgs e)
        {
            this.pageBindingSource.DataSource = r_Page;
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }
    }
}