using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormEvent : Form
    {
        private readonly Event r_Event;

        public FormEvent(Event i_Event)
        {
            r_Event = i_Event;
            InitializeComponent();
        }

        private void FormEvent_Load(object sender, System.EventArgs e)
        {
            this.eventBindingSource.DataSource = r_Event;
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }
    }
}