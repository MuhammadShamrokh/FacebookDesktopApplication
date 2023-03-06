using System;
using System.Drawing;
using System.Windows.Forms;
using ControlsFactory;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class ComplexPost
    {
        private const int k_PanelHeight = 55;
        private const int k_LabelContectHeight = 35;
        private const int k_LabelNumOfCommentsHeight = 20;
        private const int k_PanelWidthDiffrence = 30;
        private const string k_PostPhotoIndicator = "[photo]";
        private readonly Post r_Post;

        public ComplexPost(IControlsFactory i_ControlsFactory, Post i_Post)
        {
            this.Panel = i_ControlsFactory.CreatePanel();
            this.LabelMainContent = i_ControlsFactory.CreateLabel();
            this.LabelMainContent.Click += new EventHandler(this.OnPostClick);
            this.setContentText(i_Post);
            this.LabelScondaryContent = i_ControlsFactory.CreateLabel();
            this.LabelScondaryContent.Click += new EventHandler(this.OnPostClick);
            this.setLikesCommentsNumberText(i_Post);
            this.r_Post = i_Post;
        }

        public event Action<Post> WasClicked;

        public Panel Panel { get; }

        public Label LabelMainContent { get; set; }

        public Label LabelScondaryContent { get; set; }

        public void DesignPostPanel(int i_PanelWidth, int i_PanelHeight = k_PanelHeight, BorderStyle i_PanelBorderStyle = BorderStyle.FixedSingle)
        {
            this.Panel.Width = i_PanelWidth - k_PanelWidthDiffrence;
            this.Panel.Height = i_PanelHeight;
            this.Panel.BorderStyle = i_PanelBorderStyle;
            this.Panel.BackColor = Color.White;
        }

        public void DesignMainLabel(FontStyle i_LabelContentFontstyle = FontStyle.Bold, int i_LabelContentHeight = k_LabelContectHeight, DockStyle i_LabelContentDockStyle = DockStyle.Top, BorderStyle i_LabelContentBorderStyle = BorderStyle.None)
        {
            if (this.LabelMainContent != null)
            {
                this.LabelMainContent.BackColor = Color.Transparent;
                this.LabelMainContent.ForeColor = Color.Black;
                this.LabelMainContent.Font = new Font("Microsoft Sans Serif", 7.8F, i_LabelContentFontstyle, GraphicsUnit.Point, 0);
                this.LabelMainContent.BorderStyle = i_LabelContentBorderStyle;
                this.LabelMainContent.AutoSize = false;
                this.LabelMainContent.Height = i_LabelContentHeight;
                this.LabelMainContent.Dock = i_LabelContentDockStyle;
                this.Panel.Controls.Add(this.LabelMainContent);
            }
        }

        public void DesignSecondaryLabel(FontStyle i_LabelCommentsFontStyle = FontStyle.Regular, int i_LabelCommentsHeight = k_LabelNumOfCommentsHeight, BorderStyle i_LabelCommentsBorderStyle = BorderStyle.None, DockStyle i_LabelCommentsDockStyle = DockStyle.Bottom)
        {
            if (this.LabelScondaryContent != null)
            {
                this.LabelScondaryContent.Font = new Font("Microsoft Sans Serif", 7.8F, i_LabelCommentsFontStyle, GraphicsUnit.Point, 0);
                this.LabelScondaryContent.AutoSize = false;
                this.LabelScondaryContent.BorderStyle = i_LabelCommentsBorderStyle;
                this.LabelScondaryContent.Height = i_LabelCommentsHeight;
                this.LabelScondaryContent.Dock = i_LabelCommentsDockStyle;
                this.LabelScondaryContent.FlatStyle = FlatStyle.Flat;
                this.Panel.Controls.Add(this.LabelScondaryContent);
            }
        }

        private void setContentText(Post i_Post)
        {
            string postMessage;

            if (i_Post.Message != null)
            {
                postMessage = i_Post.Message;
            }
            else if (i_Post.Caption != null)
            {
                postMessage = i_Post.Caption;
            }
            else
            {
                postMessage = string.Format("[{0}]", i_Post.Type);
            }

            if (postMessage != k_PostPhotoIndicator)
            {
                this.LabelMainContent.Text = postMessage;
            }
            else
            {
                this.LabelMainContent.Text = string.Format("A new photo was uploaded");
            }
        }

        private void setLikesCommentsNumberText(Post i_Post)
        {
            this.LabelScondaryContent.Text = string.Format("post has {0} Comments", i_Post.Comments.Count);
        }

        protected virtual void OnPostClick(object sender, EventArgs e)
        {
            if (this.WasClicked != null)
            {
                this.WasClicked.Invoke(this.r_Post);
            }
        }
    }
}