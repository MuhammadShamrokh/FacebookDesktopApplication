using System.Windows.Forms;

namespace ControlsFactory
{
    public interface IControlsFactory
    {
        TextBox CreateTextBox();

        Label CreateLabel();

        PictureBox CreatePictureBox();

        Panel CreatePanel();
    }
}