using LogicEngine;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriend : Form
    {
        private readonly DummyFriend r_Friend;

        public FormFriend(DummyFriend i_Friend)
        {
            r_Friend = i_Friend;
            InitializeComponent();
        }

        private void FormFriend_Load(object sender, System.EventArgs e)
        {
            this.dummyFriendBindingSource.DataSource = r_Friend;
            pictureBoxFriendProfilePic.ImageLocation = r_Friend.ProfilePicURL;
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }
    }
}