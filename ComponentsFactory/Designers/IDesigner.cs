using System.Windows.Forms;

namespace ControlsFactory
{
    public interface IDesigner
    {
        void DesignFont(Control i_ControlToDesign);

        void DesignBackground(Control i_ControlToDesign);
    }
}