using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormGroup : Form
    {
        private readonly Group r_Group;

        public FormGroup(Group i_Group)
        {
            r_Group = i_Group;
            InitializeComponent();
        }

        private void FormGroup_Load(object sender, System.EventArgs e)
        {
            this.groupBindingSource.DataSource = this.r_Group;
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }
    }
}