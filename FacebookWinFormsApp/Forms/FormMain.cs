using System;
using System.Windows.Forms;
using ControlsFactory;
using FacebookWrapper;
using LogicEngine;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_ApplicationID = "577484007265736";
        private readonly LogicEngineManager r_LogicEngineManager;
        private readonly UIManager r_UIManager;
        private LoginResult m_LoginResult;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            r_LogicEngineManager = LogicEngineManager.Instance;
            r_UIManager = UIManager.Instance;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            foreach (eControlsType type in Enum.GetValues(typeof(eControlsType)))
            {
                comboBoxGraphics.Items.Add(type.ToString());
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            fetchLoginResult();
            if (!r_LogicEngineManager.CheckIfLoggedInUserIsNull())
            {
                this.DialogResult = DialogResult.OK;
                if (string.IsNullOrEmpty(comboBoxGraphics.Text))
                {
                    r_UIManager.ControlsType = eControlsType.BlueControls;
                }
                else
                {
                    r_UIManager.ControlsType = (eControlsType)Enum.Parse(typeof(eControlsType), comboBoxGraphics.Text, true);
                }

                this.Close();
            }
        }

        private void fetchLoginResult()
        {
            // Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            m_LoginResult = FacebookService.Login(
                    k_ApplicationID,
                    "email",
                    "public_profile",
                    "user_hometown",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_friends",
                    "user_location",
                    "user_likes",
                    "user_photos",
                    "user_posts",
                    "user_events");

            r_LogicEngineManager.LoggedInUser = m_LoginResult.LoggedInUser;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!checkBoxRememberMe.Checked)
            {
                r_LogicEngineManager.SetAccessToken(string.Empty);
            }
            else
            {
                if (m_LoginResult != null)
                {
                    r_LogicEngineManager.SetAccessToken(m_LoginResult.AccessToken);
                    r_LogicEngineManager.SetControlsType(r_UIManager.ControlsType);
                }
            }

            r_LogicEngineManager.SetRememberUser(checkBoxRememberMe.Checked);
            m_LoginResult = null;
        }
    }
}