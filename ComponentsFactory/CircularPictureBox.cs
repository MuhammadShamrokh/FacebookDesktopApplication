using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlsFactory
{
    public class CircularPictureBox : PictureBox
    {
        public string URL { get; set; }

        public new void Load(string i_ImageUrl)
        {
            this.URL = i_ImageUrl;
        }

        protected override void OnPaint(PaintEventArgs i_PaintEventArgs)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            if (this.ImageLocation == null)
            {
                this.ImageLocation = this.URL;
            }

            graphicsPath.AddEllipse(0, 0, this.ClientSize.Width, this.ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(i_PaintEventArgs);
        }
    }
}