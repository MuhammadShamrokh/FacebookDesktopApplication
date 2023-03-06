using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormAlbum : Form
    {
        private readonly Album r_Album;

        public FormAlbum(Album i_Album)
        {
            this.r_Album = i_Album;
            this.InitializeComponent();
        }

        private void FormAlbum_Load(object sender, System.EventArgs e)
        {
            this.albumBindingSource.DataSource = this.r_Album;
            new Thread(() => this.photoBindingSource.DataSource = this.r_Album.Photos).Start();
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }
    }
}