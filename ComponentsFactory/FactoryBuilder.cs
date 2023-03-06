namespace ControlsFactory
{
    public static class FactoryBuilder
    {
        public static IControlsFactory BuildFactory(eControlsType i_ControlsType)
        {
            IControlsFactory factory;

            switch (i_ControlsType)
            {
                case eControlsType.RedContols:
                    factory = new ControlsFactory<RedDesigner>();
                    break;
                case eControlsType.BlueControls:
                    factory = new ControlsFactory<BlueDesigner>();
                    break;
                case eControlsType.BlackControls:
                    factory = new ControlsFactory<BlackDesigner>();
                    break;
                case eControlsType.GrayControls:
                    factory = new ControlsFactory<GrayDesigner>();
                    break;
                default:
                    factory = new ControlsFactory<BlueDesigner>();
                    break;
            }

            return factory;
        }
    }
}