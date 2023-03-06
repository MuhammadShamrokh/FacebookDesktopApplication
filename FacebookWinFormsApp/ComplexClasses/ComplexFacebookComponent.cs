using System;
using System.Drawing;
using System.Windows.Forms;
using ControlsFactory;
using LogicEngine;

namespace BasicFacebookFeatures
{
    internal class ComplexFacebookComponent
    {
        private const int k_PanelWidth = 120;
        private const int k_PanelHeight = 150;
        private const int k_LabelWidth = 120;
        private const int k_LabelHeight = 30;
        private const int k_PictureWidth = 120;
        private const int k_PictureHeight = 120;

        public ComplexFacebookComponent(IControlsFactory i_ControlsFactory)
        {
            this.Panel = i_ControlsFactory.CreatePanel();
            this.LabelText = i_ControlsFactory.CreateLabel();
            this.LabelText.Click += new EventHandler(this.OnFacebookComponentClick);
            this.CircularPictureBox = i_ControlsFactory.CreatePictureBox() as CircularPictureBox;
            this.CircularPictureBox.Click += new EventHandler(this.OnFacebookComponentClick);
        }

        public event Action<IFacebookComponent> WasClicked;

        public Panel Panel { get; }

        public Label LabelText { get; set; }

        public CircularPictureBox CircularPictureBox { get; set; }

        public IFacebookComponent FacebookComponent { get; set; }

        public void DesignPicture(int i_PictureHeight = k_PictureHeight, int i_PictureWidth = k_PictureWidth, DockStyle i_PictureDockStyle = DockStyle.Bottom)
        {
            if (this.CircularPictureBox != null)
            {
                this.CircularPictureBox.BackColor = Color.White;
                this.CircularPictureBox.Width = i_PictureWidth;
                this.CircularPictureBox.Height = i_PictureHeight;
                this.CircularPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.CircularPictureBox.Dock = i_PictureDockStyle;
                this.Panel.Controls.Add(this.CircularPictureBox);
            }
            else
            {
                throw new Exception("ComplexPictureBox doesnt have picture box to design.");
            }
        }

        public void DesignLabel(int i_LabelWidth = k_LabelWidth, int i_LabelHeight = k_LabelHeight, BorderStyle i_LabelBorderStyle = BorderStyle.Fixed3D, FontStyle i_LabelFontStyle = FontStyle.Bold, DockStyle i_LabelDockStyle = DockStyle.Top)
        {
            if (this.LabelText != null)
            {
                this.LabelText.Width = i_LabelWidth;
                this.LabelText.Height = i_LabelHeight;
                this.LabelText.BorderStyle = i_LabelBorderStyle;
                this.LabelText.Font = new Font("Microsoft Sans Serif", 7.8F, i_LabelFontStyle, GraphicsUnit.Point, 0);
                this.LabelText.AutoSize = false;
                this.LabelText.Dock = i_LabelDockStyle;
                this.Panel.Controls.Add(this.LabelText);
            }
            else
            {
                throw new Exception("ComplexPictureBox doesnt have label to design.");
            }
        }

        public void DesignPanel(int i_PanelWidth = k_PanelWidth, int i_PanelHeight = k_PanelHeight, BorderStyle i_PanelBorderStyle = BorderStyle.Fixed3D)
        {
            this.Panel.Width = i_PanelWidth;
            this.Panel.Height = i_PanelHeight;
            this.Panel.BorderStyle = i_PanelBorderStyle;
        }

        public void SetLabelText(string i_Text)
        {
            this.LabelText.Text = i_Text;
        }

        public void SetImageByUrl(string i_PictureURL)
        {
            this.CircularPictureBox.Load(i_PictureURL);
        }

        protected virtual void OnFacebookComponentClick(object sender, EventArgs e)
        {
            if (this.WasClicked != null)
            {
                this.WasClicked.Invoke(this.FacebookComponent);
            }
        }
    }
}