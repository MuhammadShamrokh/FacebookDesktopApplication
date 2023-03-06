using System.Windows.Forms;

namespace ControlsFactory
{
    public class ControlsFactory<T> : IControlsFactory
        where T : IDesigner, new()
    {
        private readonly T r_Designer;

        public ControlsFactory()
        {
            this.r_Designer = new T();
        }

        public Label CreateLabel()
        {
            Label label = new Label();

            this.designControl(label);

            return label;
        }

        public TextBox CreateTextBox()
        {
            TextBox textBox = new TextBox();

            this.designControl(textBox);

            return textBox;
        }

        public Panel CreatePanel()
        {
            Panel panel = new Panel();

            this.designControl(panel);

            return panel;
        }

        public PictureBox CreatePictureBox()
        {
            CircularPictureBox pictureBox = new CircularPictureBox();

            this.designControl(pictureBox);

            return pictureBox;
        }

        private void designControl(Control io_Control)
        {
            this.r_Designer.DesignFont(io_Control);
            this.r_Designer.DesignBackground(io_Control);
        }
    }
}