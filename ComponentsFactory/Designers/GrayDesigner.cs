using System.Drawing;
using System.Windows.Forms;

namespace ControlsFactory
{
    internal class GrayDesigner : IDesigner
    {
        public void DesignBackground(Control i_ControlToDesign)
        {
            i_ControlToDesign.BackColor = Color.LightGray;
            i_ControlToDesign.ForeColor = Color.Black;
        }

        public void DesignFont(Control i_ControlToDesign)
        {
            i_ControlToDesign.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}