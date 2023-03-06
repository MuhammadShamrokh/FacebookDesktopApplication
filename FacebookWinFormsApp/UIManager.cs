using System.Windows.Forms;
using ControlsFactory;
using FacebookWrapper;
using LogicEngine;

namespace BasicFacebookFeatures
{
    public sealed class UIManager
    {
        private static readonly object sr_InstanceLock = new object();
        private static UIManager s_Instance;
        private readonly LogicEngineManager r_LogicEngineManager;

        private UIManager()
        {
            this.r_LogicEngineManager = LogicEngineManager.Instance;
        }

        public static UIManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UIManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public eControlsType ControlsType { get; set; }

        public void StartApplication()
        {
            DialogResult dialogResult;
            IControlsFactory controlsFactory;

            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (this.r_LogicEngineManager.GetRememberUser())
            {
                this.r_LogicEngineManager.ConnectWithAccessToken();
                this.ControlsType = this.r_LogicEngineManager.GetControlsType();
                dialogResult = DialogResult.OK;
            }
            else
            {
                dialogResult = new FormMain().ShowDialog();
            }

            while (dialogResult == DialogResult.OK)
            {
                controlsFactory = FactoryBuilder.BuildFactory(this.ControlsType);
                dialogResult = new FormDesktopFacebook(controlsFactory).ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    dialogResult = new FormMain().ShowDialog();
                }
            }
        }
    }
}