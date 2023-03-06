using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.Forms;
using ControlsFactory;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using LogicEngine;
using DamkaDesktopUI;

namespace BasicFacebookFeatures
{
    public partial class FormDesktopFacebook : Form
    {
        private readonly LogicEngineManager r_LogicEngineManager;
        private readonly IControlsFactory r_ControlsFactory;
        private bool m_PostsTabClicked = false;
        private bool m_GroupsTabClicked = false;
        private bool m_FriendsTabClicked = false;
        private bool m_LikedPagesTabClicked = false;
        private bool m_AlbumsTabClicked = false;
        private bool m_EventsTabClicked = false;
        private bool m_FavoriteTeamsTabClicked = false;
        private bool m_isShowingHowActiveGraph = false;

        public FormDesktopFacebook(IControlsFactory i_ControlsFactory)
        {
            this.InitializeComponent();
            this.initializeProfilePicture();
            this.r_LogicEngineManager = LogicEngineManager.Instance;
            this.r_ControlsFactory = i_ControlsFactory;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult result = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void initializeProfilePicture()
        {
            this.pictureBoxProfilePic = new CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxProfilePic).BeginInit();
            this.splitContainerProfilePicBasicUserInfo.Panel1.Controls.Add(this.pictureBoxProfilePic);
            this.pictureBoxProfilePic.Dock = DockStyle.Bottom;
            this.pictureBoxProfilePic.Location = new Point(15, 12);
            this.pictureBoxProfilePic.Margin = new Padding(2, 2, 2, 2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new Size(66, 84);
            this.pictureBoxProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePic.TabIndex = 0;
            this.pictureBoxProfilePic.TabStop = false;
            this.pictureBoxProfilePic.URL = null;
            this.pictureBoxProfilePic.Click += new System.EventHandler(this.pictureBox_click);
            ((System.ComponentModel.ISupportInitialize)this.pictureBoxProfilePic).EndInit();

        }

        private void formDesktopFacebook_Load(object sender, EventArgs e)
        {
            new Thread(this.initializeUserInfo).Start();
            this.userBindingSource.DataSource = this.r_LogicEngineManager.LoggedInUser;
        }

        private void initializeUserInfo()
        {
            this.labelUsername.Invoke(new Action(() => this.labelUsername.Text = this.r_LogicEngineManager.GetUserName()));
            this.pictureBoxProfilePic.Invoke(new Action(() => this.pictureBoxProfilePic.Load(this.r_LogicEngineManager.GetUserProfileImage())));
            this.labelEmail.Invoke(new Action(() => this.labelEmail.Text = this.r_LogicEngineManager.GetUserMail()));
            this.labelAmountOfFriends.Invoke(new Action(() => this.labelAmountOfFriends.Text = string.Format("{0} Friends", this.r_LogicEngineManager.GetUserAmountOfDummyFriends().ToString())));
            this.updateUserPostActiveGraph();
        }

        private void updateUserPostActiveGraph()
        {
            List<int> numOfPosts = this.r_LogicEngineManager.GetNumOfPostsPerMonthArray();
            int count = 1;

            foreach (int numOfPost in numOfPosts)
            {
                this.chartNumOfPosts.Invoke(new Action(() => this.chartNumOfPosts.Series["NumOfPosts"].Points.AddXY(count, numOfPost)));
                if (numOfPost > 0)
                {
                    this.chartNumOfPostsPie.Invoke(new Action(() => this.chartNumOfPostsPie.Series["Active"].Points.AddXY(count, numOfPost)));
                }

                count++;
            }
        }

        private void fetchOnThisDay()
        {
            int howManyYearsAgo;
            string onThisDayInfo = this.r_LogicEngineManager.GetOnThisDayInfo(out howManyYearsAgo);
            string caption;

            if (howManyYearsAgo < 0)
            {
                howManyYearsAgo *= -1;
                caption = $"On your birthdate, {howManyYearsAgo} years after you were born";
            }
            else if (howManyYearsAgo == 0)
            {
                caption = $"On your birthdate, on the year you were born";
            }
            else
            {
                caption = $"On your birthdate, {howManyYearsAgo} years before you were born";
            }

            MessageBox.Show(onThisDayInfo, caption);
        }

        private void tabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab == this.tabPagePosts)
            {
                if (!this.m_PostsTabClicked)
                {
                    new Thread(this.fetchPosts).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageAlbums)
            {
                if (!this.m_AlbumsTabClicked)
                {
                    this.r_LogicEngineManager.FilterName = string.Empty;
                    new Thread(() => this.fetchFacebookComponents(FacebookComponentType.Albums, this.flowLayoutPanelAlbums, this.buttonSortUpAlbums, this.buttonSortDownAlbums)).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageEvents)
            {
                if (!this.m_EventsTabClicked)
                {
                    this.r_LogicEngineManager.FilterName = string.Empty;
                    new Thread(() => this.fetchFacebookComponents(FacebookComponentType.Events, this.flowLayoutPanelEvents, this.buttonSortUpEvents, this.buttonSortDownEvents)).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageFriends)
            {
                if (!this.m_FriendsTabClicked)
                {
                    this.r_LogicEngineManager.FilterName = string.Empty;
                    new Thread(() => this.fetchFacebookComponents(FacebookComponentType.Friends, this.flowLayoutPanelFriends, this.buttonSortUpFriends, this.buttonSortDownFriends)).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageGroups)
            {
                if (!this.m_GroupsTabClicked)
                {
                    this.r_LogicEngineManager.FilterName = string.Empty;
                    new Thread(() => this.fetchFacebookComponents(FacebookComponentType.Groups, this.flowLayoutPanelGroups, this.buttonSortUpGroups, this.buttonSortDownGroups)).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageLikedPages)
            {
                if (!this.m_LikedPagesTabClicked)
                {
                    this.r_LogicEngineManager.FilterName = string.Empty;
                    new Thread(() => this.fetchFacebookComponents(FacebookComponentType.LikedPages, this.flowLayoutPanelLikedPages, this.buttonSortUpPages, this.buttonSortDownPages)).Start();
                }
            }
            else if (this.tabControl.SelectedTab == this.tabPageFavoriteTeamsGroup)
            {
                if (!this.m_FavoriteTeamsTabClicked)
                {
                    new Thread(this.fetchFavoriteTeamsFriends).Start();
                }
            }
        }

        private void lunchNewGame()
        {
            new DamkaUserInterfaceManager().StartGame();
        }

        private void fetchFavoriteTeamsFriends()
        {
            FacebookComponentCollection favoriteTeamsFriends = this.r_LogicEngineManager.GetFavoriteTeamsDummyFriends();

            foreach (IFacebookComponent friend in favoriteTeamsFriends)
            {
                this.listBoxFavoriteTeams.Invoke(new Action(() => this.listBoxFavoriteTeams.Items.Add(friend)));
            }

            this.m_FavoriteTeamsTabClicked = true;
            if (this.listBoxFavoriteTeams.Items.Count == 0)
            {
                this.buttonCreateGroupFavoriteTeams.Enabled = false;
            }
        }

        private void fetchPosts()
        {
            List<Post> userPosts = this.r_LogicEngineManager.GetUserPosts();
            string username = this.r_LogicEngineManager.GetUserName();
            ComplexPost panelPost;

            this.flowLayoutPanelPosts.Controls.Clear();
            foreach (Post post in userPosts)
            {
                panelPost = new ComplexPost(this.r_ControlsFactory, post);
                panelPost.DesignPostPanel(this.flowLayoutPanelPosts.Width, i_PanelBorderStyle: BorderStyle.FixedSingle);
                panelPost.DesignMainLabel();
                panelPost.DesignSecondaryLabel();
                panelPost.WasClicked += this.post_WasClicked;
                this.flowLayoutPanelPosts.Invoke(new Action(() => this.flowLayoutPanelPosts.Controls.Add(panelPost.Panel)));
            }

            this.m_PostsTabClicked = true;
        }

        private void fetchFacebookComponents(FacebookComponentType i_ComponentType, FlowLayoutPanel i_flowLayoutPanel, Button i_SortUpButton, Button i_SortDownButton)
        {
            const bool v_IsSorted = true;
            FacebookComponentCollection facebookComponents;

            try
            {
                facebookComponents = this.r_LogicEngineManager.GetRequestedComponent(i_ComponentType, !v_IsSorted);
                this.addFacebookComponentToFlowLayout(i_ComponentType, facebookComponents, i_flowLayoutPanel, i_SortUpButton, i_SortDownButton);
                if (facebookComponents.Count > 0)
                {
                    this.toggleFlagByComponentConfiguration(i_ComponentType);
                }
            }
            catch
            {
                this.Invoke(new Action(() => MessageBox.Show("Oops, something went wrong. Please try again later.", "Error")));
            }
        }

        private void addFacebookComponentToFlowLayout(FacebookComponentType i_ComponentType, FacebookComponentCollection i_Info, FlowLayoutPanel i_FlowLayoutPanel, Button i_SortUpButton, Button i_SortDownButton)
        {
            ComplexFacebookComponent tempComplexFacebookComponent;

            i_FlowLayoutPanel.Invoke(new Action(() => i_FlowLayoutPanel.Controls.Clear()));
            if (i_Info.Count != 0)
            {
                i_SortUpButton.Invoke(new Action(() => i_SortUpButton.Visible = false));
                i_SortDownButton.Invoke(new Action(() => i_SortDownButton.Visible = false));
                foreach (IFacebookComponent info in i_Info)
                {
                    tempComplexFacebookComponent = new ComplexFacebookComponent(r_ControlsFactory);
                    tempComplexFacebookComponent.FacebookComponent = info;
                    tempComplexFacebookComponent.DesignPanel();
                    tempComplexFacebookComponent.DesignLabel(i_LabelFontStyle: FontStyle.Bold);
                    tempComplexFacebookComponent.DesignPicture();
                    tempComplexFacebookComponent.SetLabelText(info.Name);
                    tempComplexFacebookComponent.SetImageByUrl(info.ImageURL);
                    tempComplexFacebookComponent.WasClicked += this.facebookComponent_WasClicked;
                    i_FlowLayoutPanel.Invoke(new Action(() => i_FlowLayoutPanel.Controls.Add(tempComplexFacebookComponent.Panel)));
                }

                i_SortUpButton.Invoke(new Action(() => i_SortUpButton.Visible = true));
                i_SortDownButton.Invoke(new Action(() => i_SortDownButton.Visible = true));
            }
            else
            {
                this.Invoke(new Action(() => MessageBox.Show(string.Format("User has no {0}", i_ComponentType.ToString()), "Empty Content")));
            }
        }

        private void toggleFlagByComponentConfiguration(FacebookComponentType i_ComponentType)
        {
            switch (i_ComponentType)
            {
                case FacebookComponentType.Albums:
                    this.m_AlbumsTabClicked = true;
                    break;
                case FacebookComponentType.Events:
                    this.m_EventsTabClicked = true;
                    break;
                case FacebookComponentType.LikedPages:
                    this.m_LikedPagesTabClicked = true;
                    break;
                case FacebookComponentType.Friends:
                    this.m_FriendsTabClicked = true;
                    break;
                case FacebookComponentType.Groups:
                    this.m_GroupsTabClicked = true;
                    break;
            }
        }

        private void formDesktopFacebook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.r_LogicEngineManager.SaveAppSettings();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            const bool v_RememberUser = true;

            FacebookService.LogoutWithUI();
            this.r_LogicEngineManager.SetAccessToken(string.Empty);
            this.r_LogicEngineManager.SetRememberUser(!v_RememberUser);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCreateGroupFavoriteTeams_Click(object sender, EventArgs e)
        {
            FacebookComponentCollection selectedFriends = new FacebookComponentCollection();
            string message;

            foreach (IFacebookComponent friend in this.listBoxFavoriteTeams.SelectedItems)
            {
                selectedFriends.Add(friend as DummyFriend);
            }

            if (selectedFriends.Count > 0)
            {
                message = "Group successfully created!";
                try
                {
                    this.r_LogicEngineManager.CreateGroupForFavoriteTeamsDummyFriends(selectedFriends);
                }
                catch
                {
                    message = "Sorry, creating groups isn't currently supported by the Graph.Facebook API";
                }
            }
            else
            {
                message = "Please select friends from the list!";
            }

            MessageBox.Show(message);
        }

        private void buttonFetchByAge_Click(object sender, EventArgs e)
        {
            int startingAge, endingAge;
            string message;
            string startingAgeTextBox = textBoxStartingAge.Text;
            string endingAgeTextBox = textBoxEndingAge.Text;
            FacebookComponentCollection friendsByAgeList = new FacebookComponentCollection();

            if (this.checkIfAgeTextBoxValid(startingAgeTextBox) && this.checkIfAgeTextBoxValid(endingAgeTextBox))
            {
                startingAge = int.Parse(startingAgeTextBox);
                endingAge = int.Parse(endingAgeTextBox);
                if (startingAge <= endingAge)
                {
                    friendsByAgeList = this.r_LogicEngineManager.GetAgeRangeDummyFriends(startingAge, endingAge);
                    this.listBoxMeetupEventFriends.Items.Clear();
                    foreach (DummyFriend friend in friendsByAgeList)
                    {
                        this.listBoxMeetupEventFriends.Items.Add(friend);
                    }

                    if (friendsByAgeList.Count == 0)
                    {
                        message = "No friends in said age group!";
                    }
                    else
                    {
                        message = "Friends fetched successfully.";
                        this.buttonCreateMeetupEvent.Enabled = true;
                        this.dateTimePickerMeetupEvent.Enabled = true;
                    }
                }
                else
                {
                    message = "The starting age must be equal or bigger than the ending age!";
                }
            }
            else
            {
                message = "Please enter a number!";
            }

            MessageBox.Show(message);
        }

        private bool checkIfAgeTextBoxValid(string i_TextBoxAge)
        {
            bool isTextBoxAgeValid = false;
            int conversionResult;

            if (i_TextBoxAge != null || i_TextBoxAge != string.Empty)
            {
                if (int.TryParse(i_TextBoxAge, out conversionResult))
                {
                    isTextBoxAgeValid = true;
                }
            }

            return isTextBoxAgeValid;
        }

        private void buttonCreateMeetupEvent_Click(object sender, EventArgs e)
        {
            FacebookComponentCollection selectedFriends = new FacebookComponentCollection();
            string message;

            foreach (IFacebookComponent friend in this.listBoxMeetupEventFriends.SelectedItems)
            {
                selectedFriends.Add(friend as DummyFriend);
            }

            if (selectedFriends.Count > 0)
            {
                message = "Event successfully created!";
                try
                {
                    this.r_LogicEngineManager.CreateMeetupEventForDummyFriends(selectedFriends, this.dateTimePickerMeetupEvent.Value);
                }
                catch
                {
                    message = "Sorry, creating events isn't currently supported by the Graph.Facebook API";
                }
            }
            else
            {
                message = "Please select friends from the list!";
            }

            MessageBox.Show(message);
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            string textToPost = this.textboxPost.Text;

            if (textToPost == string.Empty)
            {
                MessageBox.Show("Please enter something to post!");
            }
            else
            {
                try
                {
                    this.textboxPost.Clear();
                    this.r_LogicEngineManager.PostStatus(textToPost);
                }
                catch
                {
                    MessageBox.Show("Sorry, posting statuses isn't currently supported by the Graph.Facebook API");
                }

                this.flowLayoutPanelPosts.Controls.Clear();
                this.fetchPosts(); // fetching posts with the addition of the new post, currently not supported in the Wrapper API
            }
        }

        private void buttonThisDay_Click(object sender, EventArgs e)
        {
            this.fetchOnThisDay();
        }

        private void emailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isValidTextBox(this.emailTextBox.Text, this.isValidMailAddress, this.labelMailErrorMsg, e);
        }

        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            this.labelEmail.Invoke(new Action(() => this.labelEmail.Text = this.r_LogicEngineManager.GetUserMail()));
        }

        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isValidTextBox(this.firstNameTextBox.Text, this.isValidName, this.labelFirstNameErrorMsg, e);
        }

        private void firstNameTextBox_Validated(object sender, EventArgs e)
        {
            this.updateUsernameLabelInTitle();
        }

        private void lastNameTextBox_Validated(object sender, EventArgs e)
        {
            this.updateUsernameLabelInTitle();
        }

        private void updateUsernameLabelInTitle()
        {
            string username;

            username = string.Format("{0} {1}", this.r_LogicEngineManager.GetUserFirstname(), this.r_LogicEngineManager.GetUserLastname());
            this.labelUsername.Invoke(new Action(() => this.labelUsername.Text = username));
        }

        private void lastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isValidTextBox(this.lastNameTextBox.Text, this.isValidName, this.labelLastNameErrorMsg, e);
        }

        private void isValidTextBox(string i_TextToCheck, Func<string, bool> i_checkFunc, Label i_LabelToShowIfInvalid, System.ComponentModel.CancelEventArgs e)
        {
            if (!i_checkFunc(i_TextToCheck))
            {
                e.Cancel = true;
                i_LabelToShowIfInvalid.Visible = true;
            }
            else
            {
                i_LabelToShowIfInvalid.Visible = false;
            }
        }

        private bool isValidName(string i_Username)
        {
            Regex regex = new Regex(@"^[A-z][A-z|\.|\s]+$");

            return regex.IsMatch(i_Username);
        }

        private bool isValidMailAddress(string i_MailAddress)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(i_MailAddress);
        }

        private void post_WasClicked(Post i_Post)
        {
            StringBuilder stringBuilder;

            this.panelPostsInfo.Visible = true;
            this.labelPostCreateDate.Text = string.Format("{0}/{1}/{2}", i_Post.CreatedTime.Value.Day, i_Post.CreatedTime.Value.Month, i_Post.CreatedTime.Value.Year);
            this.labelPostCreateTime.Text = string.Format("{0}:{1}:{2}", i_Post.CreatedTime.Value.Hour, i_Post.CreatedTime.Value.Minute, i_Post.CreatedTime.Value.Second);
            if (i_Post.PictureURL != null)
            {
                this.pictureBoxPost.ImageLocation = i_Post.PictureURL;
            }
            else
            {
                this.pictureBoxPost.Image = Properties.Resources.noImage;
            }

            if (i_Post.Place != null)
            {
                this.labelPostCreationLocation.Text = i_Post.Place.Location.City;
            }
            else
            {
                this.labelPostCreationLocation.Text = "No Location";
            }

            if (i_Post.Comments.Count == 0)
            {
                this.richTextBoxComments.Rtf = @"{\rtf1\ansi\b NO COMMENTS ON THIS POST\b0}";
            }
            else
            {
                stringBuilder = new StringBuilder();
                stringBuilder.Append(@"{\rtf1\ansi\deff0{\fonttbl{\f0\fnil\fcharset0 Microsoft Sans Serif;}" +
                          @"{\f1\fnil Microsoft Sans Serif;}}\viewkind4\uc1\pard\lang2052\f0\fs17");
                foreach (Comment comment in i_Post.Comments)
                {
                    stringBuilder.Append(@"\b " + comment.From.ToString() + "  " + @"\b0 ");
                    stringBuilder.Append(comment.Message);
                    stringBuilder.Append(@"\par\par");
                }

                stringBuilder.Append(@"}");
                this.richTextBoxComments.Rtf = stringBuilder.ToString();
            }
        }

        private void facebookComponent_WasClicked(IFacebookComponent i_FacebookComponent)
        {
            if (i_FacebookComponent is AlbumWrapper)
            {
                new FormAlbum((i_FacebookComponent as AlbumWrapper).Album).ShowDialog();
            }
            else if (i_FacebookComponent is EventWrapper)
            {
                new FormEvent((i_FacebookComponent as EventWrapper).Event).ShowDialog();
            }
            else if (i_FacebookComponent is GroupWrapper)
            {
                new FormGroup((i_FacebookComponent as GroupWrapper).Group).ShowDialog();
            }
            else if (i_FacebookComponent is PageWrapper)
            {
                new FormLikedPage((i_FacebookComponent as PageWrapper).LikedPage).ShowDialog();
            }
            else if (i_FacebookComponent is DummyFriend)
            {
                new FormFriend(i_FacebookComponent as DummyFriend).ShowDialog();
            }
            else
            {
                throw new Exception("Invalid FacebookComponent was sent to facebookComponent_WasClicked");
            }
        }

        private void tabControl_Deselected(object sender, TabControlEventArgs e)
        {
            this.panelPostsInfo.Visible = false;
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            Image image = (sender as PictureBox).Image;

            new FormImageShow(image).ShowDialog();
        }

        private void buttonShowHowActiveGraph_Click(object sender, EventArgs e)
        {
            this.m_isShowingHowActiveGraph = !this.m_isShowingHowActiveGraph;
            this.panelBorder.Visible = this.m_isShowingHowActiveGraph;
        }

        private void buttonSortUpPages_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = (sender as Button).Visible;

            this.labelSeachPageMsg.Visible = visible;
            this.buttonSearchPage.Visible = visible;
            this.textBoxSearchPage.Visible = visible;
        }

        private void buttonSortUpGroups_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = (sender as Button).Visible;

            this.labelSearchGroupMsg.Visible = visible;
            this.buttonSearchGroup.Visible = visible;
            this.textBoxSearchGroup.Visible = visible;
        }

        private void buttonSortUpFriends_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = (sender as Button).Visible;

            this.labelSeachFriendMsg.Visible = visible;
            this.buttonSortDownFriends.Visible = visible;
            this.buttonSearchFriend.Visible = visible;
            this.textBoxSearchFriend.Visible = visible;
        }

        private void buttonSortUpEvents_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = (sender as Button).Visible;

            this.labelSearchEventMsg.Visible = visible;
            this.buttonSearchEvent.Visible = visible;
            this.textBoxSearchEvent.Visible = visible;
        }

        private void buttonSortUpAlbums_VisibleChanged(object sender, EventArgs e)
        {
            bool visible = (sender as Button).Visible;

            this.labelSeachAlbumMsg.Visible = visible;
            this.buttonSearchAlbum.Visible = visible;
            this.textBoxSearchAlbum.Visible = visible;
        }

        private void buttonSearchFriend_Click(object sender, EventArgs e)
        {
            this.fetchSpecificNameComponent(this.textBoxSearchFriend, FacebookComponentType.Friends, this.flowLayoutPanelFriends, this.buttonSortUpFriends, this.buttonShowAllFriend);
        }

        private void buttonShowAllFriend_Click(object sender, EventArgs e)
        {
            this.showAllComponent(this.buttonShowAllFriend, this.textBoxSearchFriend, FacebookComponentType.Friends, this.flowLayoutPanelFriends, this.buttonSortUpFriends, this.buttonSortDownFriends);
        }

        private void buttonSearchAlbum_Click(object sender, EventArgs e)
        {
            fetchSpecificNameComponent(textBoxSearchAlbum, FacebookComponentType.Albums, flowLayoutPanelAlbums, buttonSortUpAlbums, buttonShowAllAlbum);
        }

        private void buttonShowAllAlbum_Click(object sender, EventArgs e)
        {
            showAllComponent(buttonShowAllAlbum, textBoxSearchAlbum, FacebookComponentType.Albums, flowLayoutPanelAlbums, buttonSortUpAlbums, buttonSortDownAlbums);
        }

        private void buttonSearchEvent_Click(object sender, EventArgs e)
        {
            fetchSpecificNameComponent(textBoxSearchEvent, FacebookComponentType.Events, flowLayoutPanelEvents, buttonSortUpEvents, buttonShowAllEvent);
        }

        private void buttonShowAllEvent_Click(object sender, EventArgs e)
        {
            showAllComponent(buttonShowAllEvent, textBoxSearchEvent, FacebookComponentType.Events, flowLayoutPanelEvents, buttonSortUpEvents, buttonSortDownEvents);
        }

        private void buttonSearchGroup_Click(object sender, EventArgs e)
        {
            fetchSpecificNameComponent(textBoxSearchGroup, FacebookComponentType.Groups, flowLayoutPanelGroups, buttonSortUpGroups, buttonShowAllGroup);
        }

        private void buttonShowAllGroup_Click(object sender, EventArgs e)
        {
            showAllComponent(buttonShowAllGroup, textBoxSearchGroup, FacebookComponentType.Groups, flowLayoutPanelGroups, buttonSortUpGroups, buttonSortDownGroups);
        }

        private void buttonSearchPage_Click(object sender, EventArgs e)
        {
            fetchSpecificNameComponent(textBoxSearchPage, FacebookComponentType.LikedPages, flowLayoutPanelLikedPages, buttonSortUpPages, buttonShowAllPage);
        }

        private void buttonShowAllPage_Click(object sender, EventArgs e)
        {
            showAllComponent(buttonShowAllPage, textBoxSearchPage, FacebookComponentType.LikedPages, flowLayoutPanelLikedPages, buttonSortUpPages, buttonSortDownPages);
        }

        private void fetchSpecificNameComponent(TextBox i_Textbox, FacebookComponentType i_Type, FlowLayoutPanel i_Panel, Button i_ButtonOne, Button i_ButtonTwo)
        {
            string text = i_Textbox.Text;

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Please enter a name first", "No name was entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                r_LogicEngineManager.FilterName = text;
                new Thread(() => this.fetchFacebookComponents(i_Type, i_Panel, i_ButtonOne, i_ButtonTwo)).Start();
            }
        }

        private void showAllComponent(Button i_ShowAllButton, TextBox i_TextBox, FacebookComponentType i_Type, FlowLayoutPanel i_Panel, Button i_ButtonOne, Button i_ButtonTwo)
        {
            r_LogicEngineManager.FilterName = null;
            new Thread(() => this.fetchFacebookComponents(i_Type, i_Panel, i_ButtonOne, i_ButtonTwo)).Start();
            i_ShowAllButton.Visible = false;
            i_TextBox.Text = string.Empty;
        }

        private void buttonSortUpAlbums_Click(object sender, EventArgs e)
        {
            sortUpComponentsInPanel(FacebookComponentType.Albums, flowLayoutPanelAlbums, buttonSortUpAlbums, buttonSortDownAlbums);
        }

        private void buttonSortDownAlbums_Click(object sender, EventArgs e)
        {
            sortDownComponentsInPanel(FacebookComponentType.Albums, flowLayoutPanelAlbums, buttonSortUpAlbums, buttonSortDownAlbums);
        }

        private void buttonSortUpEvents_Click(object sender, EventArgs e)
        {
            sortUpComponentsInPanel(FacebookComponentType.Events, flowLayoutPanelEvents, buttonSortUpEvents, buttonSortDownEvents);
        }

        private void buttonSortDownEvents_Click(object sender, EventArgs e)
        {
            sortDownComponentsInPanel(FacebookComponentType.Events, flowLayoutPanelEvents, buttonSortUpEvents, buttonSortDownEvents);
        }

        private void buttonSortUpFriends_Click(object sender, EventArgs e)
        {
            sortUpComponentsInPanel(FacebookComponentType.Friends, flowLayoutPanelFriends, buttonSortUpFriends, buttonSortDownFriends);
        }

        private void buttonSortDownFriends_Click(object sender, EventArgs e)
        {
            sortDownComponentsInPanel(FacebookComponentType.Friends, flowLayoutPanelFriends, buttonSortUpFriends, buttonSortDownFriends);
        }

        private void buttonSortUpPages_Click(object sender, EventArgs e)
        {
            sortUpComponentsInPanel(FacebookComponentType.LikedPages, flowLayoutPanelLikedPages, buttonSortUpPages, buttonSortDownPages);
        }

        private void buttonSortDownPages_Click(object sender, EventArgs e)
        {
            sortDownComponentsInPanel(FacebookComponentType.LikedPages, flowLayoutPanelLikedPages, buttonSortUpPages, buttonSortDownPages);
        }


        private void buttonSortUpGroups_Click(object sender, EventArgs e)
        {
            sortUpComponentsInPanel(FacebookComponentType.Groups, flowLayoutPanelGroups, buttonSortUpGroups, buttonSortDownGroups);
        }


        private void buttonSortDownGroups_Click(object sender, EventArgs e)
        {
            sortDownComponentsInPanel(FacebookComponentType.Groups, flowLayoutPanelGroups, buttonSortUpGroups, buttonSortUpGroups);
        }

        private void sortUpComponentsInPanel(FacebookComponentType i_Type, FlowLayoutPanel i_Panel, Button i_ButtonOne, Button i_ButtonTwo)
        {
            const bool v_IsSorted = true;

            r_LogicEngineManager.SetUpSortingMethod();
            new Thread(
                () => addFacebookComponentToFlowLayout(i_Type, r_LogicEngineManager.GetRequestedComponent(i_Type, v_IsSorted), i_Panel, i_ButtonOne, i_ButtonTwo)).Start();
        }

        private void sortDownComponentsInPanel(FacebookComponentType i_Type, FlowLayoutPanel i_Panel, Button i_ButtonOne, Button i_ButtonTwo)
        {
            const bool v_IsSorted = true;

            r_LogicEngineManager.SetDownSortingMethod();
            new Thread(
                () => addFacebookComponentToFlowLayout(i_Type, r_LogicEngineManager.GetRequestedComponent(i_Type, v_IsSorted), i_Panel, i_ButtonOne, i_ButtonTwo)).Start();
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            lunchNewGame();
        }
    }
}