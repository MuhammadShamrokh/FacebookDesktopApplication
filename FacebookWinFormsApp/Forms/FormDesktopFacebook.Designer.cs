using ControlsFactory;
namespace BasicFacebookFeatures
{
    partial class FormDesktopFacebook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label localeLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesktopFacebook));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.splitContainerProfilePicBasicUserInfo = new System.Windows.Forms.SplitContainer();
            this.splitContainerBasicUserInfo = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAmountOfFriends = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.splitContainerInfo = new System.Windows.Forms.SplitContainer();
            this.labelLastNameErrorMsg = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.labelFirstNameErrorMsg = new System.Windows.Forms.Label();
            this.labelMailErrorMsg = new System.Windows.Forms.Label();
            this.localeTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.buttonThisDay = new System.Windows.Forms.Button();
            this.splitContainergraph = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHowActiveMsg = new System.Windows.Forms.Label();
            this.buttonShowHideHowActive = new System.Windows.Forms.Button();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.chartNumOfPosts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNumOfPostsPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.splitContainerPosts = new System.Windows.Forms.SplitContainer();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textboxPost = new System.Windows.Forms.TextBox();
            this.panelPostsInfo = new System.Windows.Forms.Panel();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.labelPostPicture = new System.Windows.Forms.Label();
            this.labelPostCreationLocation = new System.Windows.Forms.Label();
            this.labelCreationLocation = new System.Windows.Forms.Label();
            this.labelPostCreateTime = new System.Windows.Forms.Label();
            this.labelPostCreateDate = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelCreationTime = new System.Windows.Forms.Label();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.labelPostCreationDate = new System.Windows.Forms.Label();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.splitContainerAlbums = new System.Windows.Forms.SplitContainer();
            this.buttonShowAllAlbum = new System.Windows.Forms.Button();
            this.buttonSearchAlbum = new System.Windows.Forms.Button();
            this.labelSeachAlbumMsg = new System.Windows.Forms.Label();
            this.textBoxSearchAlbum = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSortAlbumsBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSortUpAlbums = new System.Windows.Forms.Button();
            this.buttonSortDownAlbums = new System.Windows.Forms.Button();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.splitContainerEvents = new System.Windows.Forms.SplitContainer();
            this.buttonShowAllEvent = new System.Windows.Forms.Button();
            this.buttonSearchEvent = new System.Windows.Forms.Button();
            this.labelSearchEventMsg = new System.Windows.Forms.Label();
            this.textBoxSearchEvent = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSortEventBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSortUpEvents = new System.Windows.Forms.Button();
            this.buttonSortDownEvents = new System.Windows.Forms.Button();
            this.flowLayoutPanelEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.splitContainerFriends = new System.Windows.Forms.SplitContainer();
            this.buttonShowAllFriend = new System.Windows.Forms.Button();
            this.buttonSearchFriend = new System.Windows.Forms.Button();
            this.labelSeachFriendMsg = new System.Windows.Forms.Label();
            this.textBoxSearchFriend = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSortFriendBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSortUpFriends = new System.Windows.Forms.Button();
            this.buttonSortDownFriends = new System.Windows.Forms.Button();
            this.flowLayoutPanelFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.splitContainerGroups = new System.Windows.Forms.SplitContainer();
            this.buttonShowAllGroup = new System.Windows.Forms.Button();
            this.buttonSearchGroup = new System.Windows.Forms.Button();
            this.labelSearchGroupMsg = new System.Windows.Forms.Label();
            this.textBoxSearchGroup = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelSortGroupBtns = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSortUpGroups = new System.Windows.Forms.Button();
            this.buttonSortDownGroups = new System.Windows.Forms.Button();
            this.flowLayoutPanelGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageLikedPages = new System.Windows.Forms.TabPage();
            this.splitContainerLikedPages = new System.Windows.Forms.SplitContainer();
            this.buttonShowAllPage = new System.Windows.Forms.Button();
            this.buttonSearchPage = new System.Windows.Forms.Button();
            this.labelSeachPageMsg = new System.Windows.Forms.Label();
            this.textBoxSearchPage = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelLikedPagesConfig = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSortUpPages = new System.Windows.Forms.Button();
            this.buttonSortDownPages = new System.Windows.Forms.Button();
            this.flowLayoutPanelLikedPages = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageFavoriteTeamsGroup = new System.Windows.Forms.TabPage();
            this.labelSameFVTeamRequest = new System.Windows.Forms.Label();
            this.panelSameFvTeam = new System.Windows.Forms.Panel();
            this.labelSameFVTeamFriends = new System.Windows.Forms.Label();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.buttonCreateGroupFavoriteTeams = new System.Windows.Forms.Button();
            this.tabPageFeature2 = new System.Windows.Forms.TabPage();
            this.labelFeatrueExplanation = new System.Windows.Forms.Label();
            this.panelEventDateSettings = new System.Windows.Forms.Panel();
            this.labelDateRequest = new System.Windows.Forms.Label();
            this.dateTimePickerMeetupEvent = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateMeetupEvent = new System.Windows.Forms.Button();
            this.panelPickedAgeList = new System.Windows.Forms.Panel();
            this.labelRangeAgeFriendList = new System.Windows.Forms.Label();
            this.listBoxMeetupEventFriends = new System.Windows.Forms.ListBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelAgeRangeRequest = new System.Windows.Forms.Label();
            this.buttonFetchByAge = new System.Windows.Forms.Button();
            this.textBoxStartingAge = new System.Windows.Forms.TextBox();
            this.labelAgeRangeChar = new System.Windows.Forms.Label();
            this.textBoxEndingAge = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.checkinsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPlayGame = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            localeLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProfilePicBasicUserInfo)).BeginInit();
            this.splitContainerProfilePicBasicUserInfo.Panel2.SuspendLayout();
            this.splitContainerProfilePicBasicUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasicUserInfo)).BeginInit();
            this.splitContainerBasicUserInfo.Panel1.SuspendLayout();
            this.splitContainerBasicUserInfo.Panel2.SuspendLayout();
            this.splitContainerBasicUserInfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).BeginInit();
            this.splitContainerInfo.Panel1.SuspendLayout();
            this.splitContainerInfo.Panel2.SuspendLayout();
            this.splitContainerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainergraph)).BeginInit();
            this.splitContainergraph.Panel1.SuspendLayout();
            this.splitContainergraph.Panel2.SuspendLayout();
            this.splitContainergraph.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelBorder.SuspendLayout();
            this.panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumOfPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumOfPostsPie)).BeginInit();
            this.tabPagePosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPosts)).BeginInit();
            this.splitContainerPosts.Panel1.SuspendLayout();
            this.splitContainerPosts.Panel2.SuspendLayout();
            this.splitContainerPosts.SuspendLayout();
            this.panelPostsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAlbums)).BeginInit();
            this.splitContainerAlbums.Panel1.SuspendLayout();
            this.splitContainerAlbums.Panel2.SuspendLayout();
            this.splitContainerAlbums.SuspendLayout();
            this.flowLayoutPanelSortAlbumsBtns.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEvents)).BeginInit();
            this.splitContainerEvents.Panel1.SuspendLayout();
            this.splitContainerEvents.Panel2.SuspendLayout();
            this.splitContainerEvents.SuspendLayout();
            this.flowLayoutPanelSortEventBtns.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFriends)).BeginInit();
            this.splitContainerFriends.Panel1.SuspendLayout();
            this.splitContainerFriends.Panel2.SuspendLayout();
            this.splitContainerFriends.SuspendLayout();
            this.flowLayoutPanelSortFriendBtns.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGroups)).BeginInit();
            this.splitContainerGroups.Panel1.SuspendLayout();
            this.splitContainerGroups.Panel2.SuspendLayout();
            this.splitContainerGroups.SuspendLayout();
            this.flowLayoutPanelSortGroupBtns.SuspendLayout();
            this.tabPageLikedPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLikedPages)).BeginInit();
            this.splitContainerLikedPages.Panel1.SuspendLayout();
            this.splitContainerLikedPages.Panel2.SuspendLayout();
            this.splitContainerLikedPages.SuspendLayout();
            this.flowLayoutPanelLikedPagesConfig.SuspendLayout();
            this.tabPageFavoriteTeamsGroup.SuspendLayout();
            this.panelSameFvTeam.SuspendLayout();
            this.tabPageFeature2.SuspendLayout();
            this.panelEventDateSettings.SuspendLayout();
            this.panelPickedAgeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(24, 130);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(100, 30);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(24, 80);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(100, 30);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(24, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(100, 30);
            idLabel.TabIndex = 15;
            idLabel.Text = "Id:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imageNormalLabel.Location = new System.Drawing.Point(25, 330);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(92, 16);
            imageNormalLabel.TabIndex = 24;
            imageNormalLabel.Text = "Cover Photo";
            // 
            // localeLabel
            // 
            localeLabel.AutoSize = true;
            localeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localeLabel.Location = new System.Drawing.Point(24, 280);
            localeLabel.Name = "localeLabel";
            localeLabel.Size = new System.Drawing.Size(58, 16);
            localeLabel.TabIndex = 26;
            localeLabel.Text = "Locale:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(24, 180);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(86, 16);
            firstNameLabel.TabIndex = 31;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(24, 230);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(85, 16);
            lastNameLabel.TabIndex = 32;
            lastNameLabel.Text = "Last Name:";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.splitContainerProfilePicBasicUserInfo);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControl);
            this.splitContainerMain.Size = new System.Drawing.Size(1201, 853);
            this.splitContainerMain.SplitterDistance = 118;
            this.splitContainerMain.SplitterWidth = 30;
            this.splitContainerMain.TabIndex = 5;
            // 
            // splitContainerProfilePicBasicUserInfo
            // 
            this.splitContainerProfilePicBasicUserInfo.BackColor = System.Drawing.Color.White;
            this.splitContainerProfilePicBasicUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProfilePicBasicUserInfo.IsSplitterFixed = true;
            this.splitContainerProfilePicBasicUserInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerProfilePicBasicUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerProfilePicBasicUserInfo.Name = "splitContainerProfilePicBasicUserInfo";
            // 
            // splitContainerProfilePicBasicUserInfo.Panel1
            // 
            this.splitContainerProfilePicBasicUserInfo.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerProfilePicBasicUserInfo.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // splitContainerProfilePicBasicUserInfo.Panel2
            // 
            this.splitContainerProfilePicBasicUserInfo.Panel2.Controls.Add(this.splitContainerBasicUserInfo);
            this.splitContainerProfilePicBasicUserInfo.Size = new System.Drawing.Size(1201, 118);
            this.splitContainerProfilePicBasicUserInfo.SplitterDistance = 111;
            this.splitContainerProfilePicBasicUserInfo.SplitterWidth = 20;
            this.splitContainerProfilePicBasicUserInfo.TabIndex = 0;
            // 
            // splitContainerBasicUserInfo
            // 
            this.splitContainerBasicUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBasicUserInfo.IsSplitterFixed = true;
            this.splitContainerBasicUserInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBasicUserInfo.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerBasicUserInfo.Name = "splitContainerBasicUserInfo";
            this.splitContainerBasicUserInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBasicUserInfo.Panel1
            // 
            this.splitContainerBasicUserInfo.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerBasicUserInfo.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainerBasicUserInfo.Panel2
            // 
            this.splitContainerBasicUserInfo.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainerBasicUserInfo.Panel2.Controls.Add(this.labelEmail);
            this.splitContainerBasicUserInfo.Panel2.Controls.Add(this.labelAmountOfFriends);
            this.splitContainerBasicUserInfo.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.splitContainerBasicUserInfo.Size = new System.Drawing.Size(1070, 118);
            this.splitContainerBasicUserInfo.SplitterDistance = 43;
            this.splitContainerBasicUserInfo.SplitterWidth = 5;
            this.splitContainerBasicUserInfo.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelUsername);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1070, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.labelUsername.Location = new System.Drawing.Point(4, 3);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelUsername.Size = new System.Drawing.Size(174, 42);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "[UserName]";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Red;
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.Location = new System.Drawing.Point(185, 2);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 41);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.labelEmail.Location = new System.Drawing.Point(5, 0);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelEmail.Size = new System.Drawing.Size(58, 18);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "[Email]";
            // 
            // labelAmountOfFriends
            // 
            this.labelAmountOfFriends.AutoSize = true;
            this.labelAmountOfFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountOfFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.labelAmountOfFriends.Location = new System.Drawing.Point(5, 18);
            this.labelAmountOfFriends.Margin = new System.Windows.Forms.Padding(0);
            this.labelAmountOfFriends.Name = "labelAmountOfFriends";
            this.labelAmountOfFriends.Padding = new System.Windows.Forms.Padding(5, 0, 0, 10);
            this.labelAmountOfFriends.Size = new System.Drawing.Size(137, 28);
            this.labelAmountOfFriends.TabIndex = 2;
            this.labelAmountOfFriends.Text = "[AmountOfFriends]";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageInfo);
            this.tabControl.Controls.Add(this.tabPagePosts);
            this.tabControl.Controls.Add(this.tabPageAlbums);
            this.tabControl.Controls.Add(this.tabPageEvents);
            this.tabControl.Controls.Add(this.tabPageFriends);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageLikedPages);
            this.tabControl.Controls.Add(this.tabPageFavoriteTeamsGroup);
            this.tabControl.Controls.Add(this.tabPageFeature2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1201, 705);
            this.tabControl.TabIndex = 7;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControlSelectedIndexChanged);
            this.tabControl.Deselected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Deselected);
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.BackColor = System.Drawing.Color.White;
            this.tabPageInfo.Controls.Add(this.splitContainerInfo);
            this.tabPageInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageInfo.Size = new System.Drawing.Size(1193, 676);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Info";
            // 
            // splitContainerInfo
            // 
            this.splitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerInfo.Location = new System.Drawing.Point(4, 4);
            this.splitContainerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerInfo.Name = "splitContainerInfo";
            // 
            // splitContainerInfo.Panel1
            // 
            this.splitContainerInfo.Panel1.AutoScroll = true;
            this.splitContainerInfo.Panel1.Controls.Add(this.btnPlayGame);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelLastNameErrorMsg);
            this.splitContainerInfo.Panel1.Controls.Add(lastNameLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.lastNameTextBox);
            this.splitContainerInfo.Panel1.Controls.Add(firstNameLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.firstNameTextBox);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelFirstNameErrorMsg);
            this.splitContainerInfo.Panel1.Controls.Add(this.labelMailErrorMsg);
            this.splitContainerInfo.Panel1.Controls.Add(localeLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.localeTextBox);
            this.splitContainerInfo.Panel1.Controls.Add(imageNormalLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.imageNormalPictureBox);
            this.splitContainerInfo.Panel1.Controls.Add(birthdayLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.birthdayDateTimePicker);
            this.splitContainerInfo.Panel1.Controls.Add(emailLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.emailTextBox);
            this.splitContainerInfo.Panel1.Controls.Add(idLabel);
            this.splitContainerInfo.Panel1.Controls.Add(this.idTextBox);
            this.splitContainerInfo.Panel1.Controls.Add(this.buttonThisDay);
            // 
            // splitContainerInfo.Panel2
            // 
            this.splitContainerInfo.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerInfo.Panel2.Controls.Add(this.splitContainergraph);
            this.splitContainerInfo.Size = new System.Drawing.Size(1185, 668);
            this.splitContainerInfo.SplitterDistance = 470;
            this.splitContainerInfo.TabIndex = 11;
            // 
            // labelLastNameErrorMsg
            // 
            this.labelLastNameErrorMsg.AutoSize = true;
            this.labelLastNameErrorMsg.Font = new System.Drawing.Font("David", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastNameErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelLastNameErrorMsg.Location = new System.Drawing.Point(141, 252);
            this.labelLastNameErrorMsg.Name = "labelLastNameErrorMsg";
            this.labelLastNameErrorMsg.Size = new System.Drawing.Size(246, 13);
            this.labelLastNameErrorMsg.TabIndex = 34;
            this.labelLastNameErrorMsg.Text = "Last name isn\'t available. Please try another.";
            this.labelLastNameErrorMsg.Visible = false;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(142, 227);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(222, 22);
            this.lastNameTextBox.TabIndex = 33;
            this.lastNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.lastNameTextBox_Validating);
            this.lastNameTextBox.Validated += new System.EventHandler(this.lastNameTextBox_Validated);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(142, 174);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(224, 22);
            this.firstNameTextBox.TabIndex = 32;
            this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
            this.firstNameTextBox.Validated += new System.EventHandler(this.firstNameTextBox_Validated);
            // 
            // labelFirstNameErrorMsg
            // 
            this.labelFirstNameErrorMsg.AutoSize = true;
            this.labelFirstNameErrorMsg.Font = new System.Drawing.Font("David", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNameErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelFirstNameErrorMsg.Location = new System.Drawing.Point(141, 199);
            this.labelFirstNameErrorMsg.Name = "labelFirstNameErrorMsg";
            this.labelFirstNameErrorMsg.Size = new System.Drawing.Size(247, 13);
            this.labelFirstNameErrorMsg.TabIndex = 31;
            this.labelFirstNameErrorMsg.Text = "First name isn\'t available. Please try another.";
            this.labelFirstNameErrorMsg.Visible = false;
            // 
            // labelMailErrorMsg
            // 
            this.labelMailErrorMsg.AutoSize = true;
            this.labelMailErrorMsg.Font = new System.Drawing.Font("David", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMailErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.labelMailErrorMsg.Location = new System.Drawing.Point(139, 102);
            this.labelMailErrorMsg.Name = "labelMailErrorMsg";
            this.labelMailErrorMsg.Size = new System.Drawing.Size(285, 13);
            this.labelMailErrorMsg.TabIndex = 30;
            this.labelMailErrorMsg.Text = "This mail address isn\'t available. Please try another.";
            this.labelMailErrorMsg.Visible = false;
            // 
            // localeTextBox
            // 
            this.localeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Locale", true));
            this.localeTextBox.Location = new System.Drawing.Point(142, 277);
            this.localeTextBox.Name = "localeTextBox";
            this.localeTextBox.ReadOnly = true;
            this.localeTextBox.Size = new System.Drawing.Size(222, 22);
            this.localeTextBox.TabIndex = 27;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "CoverPhoto.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(25, 350);
            this.imageNormalPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(392, 153);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 25;
            this.imageNormalPictureBox.TabStop = false;
            this.imageNormalPictureBox.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.userBindingSource;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(142, 126);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(224, 22);
            this.birthdayDateTimePicker.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(142, 78);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 22);
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            this.emailTextBox.Validated += new System.EventHandler(this.emailTextBox_Validated);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(145, 37);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(221, 22);
            this.idTextBox.TabIndex = 16;
            // 
            // buttonThisDay
            // 
            this.buttonThisDay.AutoSize = true;
            this.buttonThisDay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonThisDay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonThisDay.Location = new System.Drawing.Point(371, 124);
            this.buttonThisDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonThisDay.Name = "buttonThisDay";
            this.buttonThisDay.Size = new System.Drawing.Size(111, 32);
            this.buttonThisDay.TabIndex = 11;
            this.buttonThisDay.Text = "On this day";
            this.buttonThisDay.UseVisualStyleBackColor = false;
            this.buttonThisDay.Click += new System.EventHandler(this.buttonThisDay_Click);
            // 
            // splitContainergraph
            // 
            this.splitContainergraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainergraph.IsSplitterFixed = true;
            this.splitContainergraph.Location = new System.Drawing.Point(0, 0);
            this.splitContainergraph.Name = "splitContainergraph";
            this.splitContainergraph.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainergraph.Panel1
            // 
            this.splitContainergraph.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainergraph.Panel2
            // 
            this.splitContainergraph.Panel2.Controls.Add(this.panelBorder);
            this.splitContainergraph.Size = new System.Drawing.Size(711, 668);
            this.splitContainergraph.SplitterDistance = 26;
            this.splitContainergraph.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.labelHowActiveMsg);
            this.flowLayoutPanel2.Controls.Add(this.buttonShowHideHowActive);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(711, 26);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // labelHowActiveMsg
            // 
            this.labelHowActiveMsg.AutoSize = true;
            this.labelHowActiveMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowActiveMsg.Location = new System.Drawing.Point(3, 0);
            this.labelHowActiveMsg.Name = "labelHowActiveMsg";
            this.labelHowActiveMsg.Size = new System.Drawing.Size(221, 18);
            this.labelHowActiveMsg.TabIndex = 2;
            this.labelHowActiveMsg.Text = "How active are you this year";
            // 
            // buttonShowHideHowActive
            // 
            this.buttonShowHideHowActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowHideHowActive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowHideHowActive.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowHideHowActive.Location = new System.Drawing.Point(230, 3);
            this.buttonShowHideHowActive.Name = "buttonShowHideHowActive";
            this.buttonShowHideHowActive.Size = new System.Drawing.Size(98, 23);
            this.buttonShowHideHowActive.TabIndex = 3;
            this.buttonShowHideHowActive.Text = "Show/Hide";
            this.buttonShowHideHowActive.UseVisualStyleBackColor = false;
            this.buttonShowHideHowActive.Click += new System.EventHandler(this.buttonShowHowActiveGraph_Click);
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelBorder.Controls.Add(this.panelGraph);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(0, 0);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(6);
            this.panelBorder.Size = new System.Drawing.Size(711, 638);
            this.panelBorder.TabIndex = 4;
            this.panelBorder.Visible = false;
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.Color.White;
            this.panelGraph.Controls.Add(this.chartNumOfPosts);
            this.panelGraph.Controls.Add(this.chartNumOfPostsPie);
            this.panelGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraph.Location = new System.Drawing.Point(6, 6);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(699, 626);
            this.panelGraph.TabIndex = 3;
            // 
            // chartNumOfPosts
            // 
            this.chartNumOfPosts.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Title = "Month";
            chartArea3.AxisY.Title = "Posts";
            chartArea3.Name = "ChartArea1";
            this.chartNumOfPosts.ChartAreas.Add(chartArea3);
            this.chartNumOfPosts.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Name = "Legend1";
            this.chartNumOfPosts.Legends.Add(legend3);
            this.chartNumOfPosts.Location = new System.Drawing.Point(0, 0);
            this.chartNumOfPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartNumOfPosts.Name = "chartNumOfPosts";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "NumOfPosts";
            this.chartNumOfPosts.Series.Add(series3);
            this.chartNumOfPosts.Size = new System.Drawing.Size(699, 363);
            this.chartNumOfPosts.TabIndex = 0;
            title3.Name = "HowActive";
            this.chartNumOfPosts.Titles.Add(title3);
            // 
            // chartNumOfPostsPie
            // 
            this.chartNumOfPostsPie.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Area3DStyle.Enable3D = true;
            chartArea4.Name = "ChartArea1";
            this.chartNumOfPostsPie.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartNumOfPostsPie.Legends.Add(legend4);
            this.chartNumOfPostsPie.Location = new System.Drawing.Point(3, 357);
            this.chartNumOfPostsPie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartNumOfPostsPie.Name = "chartNumOfPostsPie";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Active";
            this.chartNumOfPostsPie.Series.Add(series4);
            this.chartNumOfPostsPie.Size = new System.Drawing.Size(283, 305);
            this.chartNumOfPostsPie.TabIndex = 1;
            title4.Name = "Percentage";
            title4.Text = "Percentage per month";
            this.chartNumOfPostsPie.Titles.Add(title4);
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.Controls.Add(this.splitContainerPosts);
            this.tabPagePosts.Location = new System.Drawing.Point(4, 25);
            this.tabPagePosts.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePosts.Name = "tabPagePosts";
            this.tabPagePosts.Size = new System.Drawing.Size(1193, 676);
            this.tabPagePosts.TabIndex = 4;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
            // 
            // splitContainerPosts
            // 
            this.splitContainerPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPosts.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerPosts.Name = "splitContainerPosts";
            this.splitContainerPosts.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPosts.Panel1
            // 
            this.splitContainerPosts.Panel1.Controls.Add(this.buttonPost);
            this.splitContainerPosts.Panel1.Controls.Add(this.textboxPost);
            // 
            // splitContainerPosts.Panel2
            // 
            this.splitContainerPosts.Panel2.Controls.Add(this.panelPostsInfo);
            this.splitContainerPosts.Panel2.Controls.Add(this.flowLayoutPanelPosts);
            this.splitContainerPosts.Size = new System.Drawing.Size(1193, 676);
            this.splitContainerPosts.SplitterDistance = 40;
            this.splitContainerPosts.SplitterWidth = 10;
            this.splitContainerPosts.TabIndex = 1;
            // 
            // buttonPost
            // 
            this.buttonPost.AutoSize = true;
            this.buttonPost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPost.Image = ((System.Drawing.Image)(resources.GetObject("buttonPost.Image")));
            this.buttonPost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPost.Location = new System.Drawing.Point(503, 7);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(125, 42);
            this.buttonPost.TabIndex = 1;
            this.buttonPost.Text = "Post";
            this.buttonPost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textboxPost
            // 
            this.textboxPost.Location = new System.Drawing.Point(16, 7);
            this.textboxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxPost.Multiline = true;
            this.textboxPost.Name = "textboxPost";
            this.textboxPost.Size = new System.Drawing.Size(463, 40);
            this.textboxPost.TabIndex = 0;
            // 
            // panelPostsInfo
            // 
            this.panelPostsInfo.Controls.Add(this.richTextBoxComments);
            this.panelPostsInfo.Controls.Add(this.labelPostPicture);
            this.panelPostsInfo.Controls.Add(this.labelPostCreationLocation);
            this.panelPostsInfo.Controls.Add(this.labelCreationLocation);
            this.panelPostsInfo.Controls.Add(this.labelPostCreateTime);
            this.panelPostsInfo.Controls.Add(this.labelPostCreateDate);
            this.panelPostsInfo.Controls.Add(this.labelComments);
            this.panelPostsInfo.Controls.Add(this.labelCreationTime);
            this.panelPostsInfo.Controls.Add(this.pictureBoxPost);
            this.panelPostsInfo.Controls.Add(this.labelPostCreationDate);
            this.panelPostsInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPostsInfo.Location = new System.Drawing.Point(0, 431);
            this.panelPostsInfo.Name = "panelPostsInfo";
            this.panelPostsInfo.Size = new System.Drawing.Size(1193, 195);
            this.panelPostsInfo.TabIndex = 1;
            this.panelPostsInfo.Visible = false;
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Location = new System.Drawing.Point(525, 27);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(607, 144);
            this.richTextBoxComments.TabIndex = 11;
            this.richTextBoxComments.Text = "";
            // 
            // labelPostPicture
            // 
            this.labelPostPicture.AutoSize = true;
            this.labelPostPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostPicture.Location = new System.Drawing.Point(318, 9);
            this.labelPostPicture.Name = "labelPostPicture";
            this.labelPostPicture.Size = new System.Drawing.Size(50, 16);
            this.labelPostPicture.TabIndex = 10;
            this.labelPostPicture.Text = "Image";
            // 
            // labelPostCreationLocation
            // 
            this.labelPostCreationLocation.Location = new System.Drawing.Point(135, 130);
            this.labelPostCreationLocation.Name = "labelPostCreationLocation";
            this.labelPostCreationLocation.Size = new System.Drawing.Size(180, 25);
            this.labelPostCreationLocation.TabIndex = 9;
            this.labelPostCreationLocation.Text = "label4";
            // 
            // labelCreationLocation
            // 
            this.labelCreationLocation.AutoSize = true;
            this.labelCreationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreationLocation.Location = new System.Drawing.Point(20, 130);
            this.labelCreationLocation.Name = "labelCreationLocation";
            this.labelCreationLocation.Size = new System.Drawing.Size(66, 16);
            this.labelCreationLocation.TabIndex = 8;
            this.labelCreationLocation.Text = "Location";
            // 
            // labelPostCreateTime
            // 
            this.labelPostCreateTime.Location = new System.Drawing.Point(135, 80);
            this.labelPostCreateTime.Name = "labelPostCreateTime";
            this.labelPostCreateTime.Size = new System.Drawing.Size(180, 25);
            this.labelPostCreateTime.TabIndex = 7;
            this.labelPostCreateTime.Text = "label2";
            // 
            // labelPostCreateDate
            // 
            this.labelPostCreateDate.Location = new System.Drawing.Point(135, 27);
            this.labelPostCreateDate.Name = "labelPostCreateDate";
            this.labelPostCreateDate.Size = new System.Drawing.Size(180, 25);
            this.labelPostCreateDate.TabIndex = 6;
            this.labelPostCreateDate.Text = "label1";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(522, 9);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(79, 16);
            this.labelComments.TabIndex = 4;
            this.labelComments.Text = "Comments";
            // 
            // labelCreationTime
            // 
            this.labelCreationTime.AutoSize = true;
            this.labelCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreationTime.Location = new System.Drawing.Point(20, 80);
            this.labelCreationTime.Name = "labelCreationTime";
            this.labelCreationTime.Size = new System.Drawing.Size(104, 16);
            this.labelCreationTime.TabIndex = 2;
            this.labelCreationTime.Text = "Creation Time";
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.Image = global::BasicFacebookFeatures.Properties.Resources.noImage;
            this.pictureBoxPost.Location = new System.Drawing.Point(321, 27);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(158, 119);
            this.pictureBoxPost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPost.TabIndex = 1;
            this.pictureBoxPost.TabStop = false;
            this.pictureBoxPost.Click += new System.EventHandler(this.pictureBox_click);
            // 
            // labelPostCreationDate
            // 
            this.labelPostCreationDate.AutoSize = true;
            this.labelPostCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostCreationDate.Location = new System.Drawing.Point(20, 30);
            this.labelPostCreationDate.Name = "labelPostCreationDate";
            this.labelPostCreationDate.Size = new System.Drawing.Size(102, 16);
            this.labelPostCreationDate.TabIndex = 0;
            this.labelPostCreationDate.Text = "Creation Date";
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelPosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(1193, 426);
            this.flowLayoutPanelPosts.TabIndex = 0;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.Controls.Add(this.splitContainerAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 25);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAlbums.Size = new System.Drawing.Size(1193, 676);
            this.tabPageAlbums.TabIndex = 1;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // splitContainerAlbums
            // 
            this.splitContainerAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAlbums.IsSplitterFixed = true;
            this.splitContainerAlbums.Location = new System.Drawing.Point(4, 4);
            this.splitContainerAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerAlbums.Name = "splitContainerAlbums";
            this.splitContainerAlbums.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAlbums.Panel1
            // 
            this.splitContainerAlbums.Panel1.Controls.Add(this.buttonShowAllAlbum);
            this.splitContainerAlbums.Panel1.Controls.Add(this.buttonSearchAlbum);
            this.splitContainerAlbums.Panel1.Controls.Add(this.labelSeachAlbumMsg);
            this.splitContainerAlbums.Panel1.Controls.Add(this.textBoxSearchAlbum);
            this.splitContainerAlbums.Panel1.Controls.Add(this.flowLayoutPanelSortAlbumsBtns);
            // 
            // splitContainerAlbums.Panel2
            // 
            this.splitContainerAlbums.Panel2.Controls.Add(this.flowLayoutPanelAlbums);
            this.splitContainerAlbums.Size = new System.Drawing.Size(1185, 668);
            this.splitContainerAlbums.SplitterDistance = 58;
            this.splitContainerAlbums.SplitterWidth = 10;
            this.splitContainerAlbums.TabIndex = 1;
            // 
            // buttonShowAllAlbum
            // 
            this.buttonShowAllAlbum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowAllAlbum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowAllAlbum.Location = new System.Drawing.Point(210, 2);
            this.buttonShowAllAlbum.Name = "buttonShowAllAlbum";
            this.buttonShowAllAlbum.Size = new System.Drawing.Size(90, 25);
            this.buttonShowAllAlbum.TabIndex = 9;
            this.buttonShowAllAlbum.Text = "Show all";
            this.buttonShowAllAlbum.UseVisualStyleBackColor = false;
            this.buttonShowAllAlbum.Visible = false;
            this.buttonShowAllAlbum.Click += new System.EventHandler(this.buttonShowAllAlbum_Click);
            // 
            // buttonSearchAlbum
            // 
            this.buttonSearchAlbum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearchAlbum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchAlbum.Location = new System.Drawing.Point(210, 30);
            this.buttonSearchAlbum.Name = "buttonSearchAlbum";
            this.buttonSearchAlbum.Size = new System.Drawing.Size(90, 25);
            this.buttonSearchAlbum.TabIndex = 8;
            this.buttonSearchAlbum.Text = "Search";
            this.buttonSearchAlbum.UseVisualStyleBackColor = false;
            this.buttonSearchAlbum.Visible = false;
            this.buttonSearchAlbum.Click += new System.EventHandler(this.buttonSearchAlbum_Click);
            // 
            // labelSeachAlbumMsg
            // 
            this.labelSeachAlbumMsg.AutoSize = true;
            this.labelSeachAlbumMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeachAlbumMsg.Location = new System.Drawing.Point(5, 12);
            this.labelSeachAlbumMsg.Name = "labelSeachAlbumMsg";
            this.labelSeachAlbumMsg.Size = new System.Drawing.Size(114, 16);
            this.labelSeachAlbumMsg.TabIndex = 5;
            this.labelSeachAlbumMsg.Text = "Seach by name";
            this.labelSeachAlbumMsg.Visible = false;
            // 
            // textBoxSearchAlbum
            // 
            this.textBoxSearchAlbum.Location = new System.Drawing.Point(5, 30);
            this.textBoxSearchAlbum.Name = "textBoxSearchAlbum";
            this.textBoxSearchAlbum.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchAlbum.TabIndex = 3;
            this.textBoxSearchAlbum.Visible = false;
            // 
            // flowLayoutPanelSortAlbumsBtns
            // 
            this.flowLayoutPanelSortAlbumsBtns.Controls.Add(this.buttonSortUpAlbums);
            this.flowLayoutPanelSortAlbumsBtns.Controls.Add(this.buttonSortDownAlbums);
            this.flowLayoutPanelSortAlbumsBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSortAlbumsBtns.Location = new System.Drawing.Point(305, 0);
            this.flowLayoutPanelSortAlbumsBtns.Name = "flowLayoutPanelSortAlbumsBtns";
            this.flowLayoutPanelSortAlbumsBtns.Size = new System.Drawing.Size(880, 58);
            this.flowLayoutPanelSortAlbumsBtns.TabIndex = 0;
            // 
            // buttonSortUpAlbums
            // 
            this.buttonSortUpAlbums.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSortUpAlbums.AutoSize = true;
            this.buttonSortUpAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortUpAlbums.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortUpAlbums.Image")));
            this.buttonSortUpAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortUpAlbums.Location = new System.Drawing.Point(3, 2);
            this.buttonSortUpAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortUpAlbums.Name = "buttonSortUpAlbums";
            this.buttonSortUpAlbums.Size = new System.Drawing.Size(60, 57);
            this.buttonSortUpAlbums.TabIndex = 0;
            this.buttonSortUpAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortUpAlbums.UseVisualStyleBackColor = true;
            this.buttonSortUpAlbums.Visible = false;
            this.buttonSortUpAlbums.VisibleChanged += new System.EventHandler(this.buttonSortUpAlbums_VisibleChanged);
            this.buttonSortUpAlbums.Click += new System.EventHandler(this.buttonSortUpAlbums_Click);
            // 
            // buttonSortDownAlbums
            // 
            this.buttonSortDownAlbums.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSortDownAlbums.AutoSize = true;
            this.buttonSortDownAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDownAlbums.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDownAlbums.Image")));
            this.buttonSortDownAlbums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortDownAlbums.Location = new System.Drawing.Point(69, 2);
            this.buttonSortDownAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortDownAlbums.Name = "buttonSortDownAlbums";
            this.buttonSortDownAlbums.Size = new System.Drawing.Size(60, 57);
            this.buttonSortDownAlbums.TabIndex = 2;
            this.buttonSortDownAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortDownAlbums.UseVisualStyleBackColor = true;
            this.buttonSortDownAlbums.Visible = false;
            this.buttonSortDownAlbums.Click += new System.EventHandler(this.buttonSortDownAlbums_Click);
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(1185, 600);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.splitContainerEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 25);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Size = new System.Drawing.Size(1193, 676);
            this.tabPageEvents.TabIndex = 2;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // splitContainerEvents
            // 
            this.splitContainerEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerEvents.IsSplitterFixed = true;
            this.splitContainerEvents.Location = new System.Drawing.Point(0, 0);
            this.splitContainerEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerEvents.Name = "splitContainerEvents";
            this.splitContainerEvents.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerEvents.Panel1
            // 
            this.splitContainerEvents.Panel1.Controls.Add(this.buttonShowAllEvent);
            this.splitContainerEvents.Panel1.Controls.Add(this.buttonSearchEvent);
            this.splitContainerEvents.Panel1.Controls.Add(this.labelSearchEventMsg);
            this.splitContainerEvents.Panel1.Controls.Add(this.textBoxSearchEvent);
            this.splitContainerEvents.Panel1.Controls.Add(this.flowLayoutPanelSortEventBtns);
            // 
            // splitContainerEvents.Panel2
            // 
            this.splitContainerEvents.Panel2.Controls.Add(this.flowLayoutPanelEvents);
            this.splitContainerEvents.Size = new System.Drawing.Size(1193, 676);
            this.splitContainerEvents.SplitterDistance = 56;
            this.splitContainerEvents.SplitterWidth = 10;
            this.splitContainerEvents.TabIndex = 1;
            // 
            // buttonShowAllEvent
            // 
            this.buttonShowAllEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowAllEvent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowAllEvent.Location = new System.Drawing.Point(210, 4);
            this.buttonShowAllEvent.Name = "buttonShowAllEvent";
            this.buttonShowAllEvent.Size = new System.Drawing.Size(90, 23);
            this.buttonShowAllEvent.TabIndex = 9;
            this.buttonShowAllEvent.Text = "Show all";
            this.buttonShowAllEvent.UseVisualStyleBackColor = false;
            this.buttonShowAllEvent.Visible = false;
            this.buttonShowAllEvent.Click += new System.EventHandler(this.buttonShowAllEvent_Click);
            // 
            // buttonSearchEvent
            // 
            this.buttonSearchEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearchEvent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchEvent.Location = new System.Drawing.Point(210, 30);
            this.buttonSearchEvent.Name = "buttonSearchEvent";
            this.buttonSearchEvent.Size = new System.Drawing.Size(90, 25);
            this.buttonSearchEvent.TabIndex = 8;
            this.buttonSearchEvent.Text = "Search";
            this.buttonSearchEvent.UseVisualStyleBackColor = false;
            this.buttonSearchEvent.Visible = false;
            this.buttonSearchEvent.Click += new System.EventHandler(this.buttonSearchEvent_Click);
            // 
            // labelSearchEventMsg
            // 
            this.labelSearchEventMsg.AutoSize = true;
            this.labelSearchEventMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchEventMsg.Location = new System.Drawing.Point(5, 11);
            this.labelSearchEventMsg.Name = "labelSearchEventMsg";
            this.labelSearchEventMsg.Size = new System.Drawing.Size(114, 16);
            this.labelSearchEventMsg.TabIndex = 5;
            this.labelSearchEventMsg.Text = "Seach by name";
            this.labelSearchEventMsg.Visible = false;
            // 
            // textBoxSearchEvent
            // 
            this.textBoxSearchEvent.Location = new System.Drawing.Point(5, 30);
            this.textBoxSearchEvent.Name = "textBoxSearchEvent";
            this.textBoxSearchEvent.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchEvent.TabIndex = 3;
            this.textBoxSearchEvent.Visible = false;
            // 
            // flowLayoutPanelSortEventBtns
            // 
            this.flowLayoutPanelSortEventBtns.Controls.Add(this.buttonSortUpEvents);
            this.flowLayoutPanelSortEventBtns.Controls.Add(this.buttonSortDownEvents);
            this.flowLayoutPanelSortEventBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSortEventBtns.Location = new System.Drawing.Point(313, 0);
            this.flowLayoutPanelSortEventBtns.Name = "flowLayoutPanelSortEventBtns";
            this.flowLayoutPanelSortEventBtns.Size = new System.Drawing.Size(880, 56);
            this.flowLayoutPanelSortEventBtns.TabIndex = 0;
            // 
            // buttonSortUpEvents
            // 
            this.buttonSortUpEvents.AutoSize = true;
            this.buttonSortUpEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortUpEvents.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortUpEvents.Image")));
            this.buttonSortUpEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortUpEvents.Location = new System.Drawing.Point(3, 2);
            this.buttonSortUpEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortUpEvents.Name = "buttonSortUpEvents";
            this.buttonSortUpEvents.Size = new System.Drawing.Size(60, 57);
            this.buttonSortUpEvents.TabIndex = 0;
            this.buttonSortUpEvents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortUpEvents.UseVisualStyleBackColor = true;
            this.buttonSortUpEvents.Visible = false;
            this.buttonSortUpEvents.VisibleChanged += new System.EventHandler(this.buttonSortUpEvents_VisibleChanged);
            this.buttonSortUpEvents.Click += new System.EventHandler(this.buttonSortUpEvents_Click);
            // 
            // buttonSortDownEvents
            // 
            this.buttonSortDownEvents.AutoSize = true;
            this.buttonSortDownEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDownEvents.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDownEvents.Image")));
            this.buttonSortDownEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortDownEvents.Location = new System.Drawing.Point(69, 2);
            this.buttonSortDownEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortDownEvents.Name = "buttonSortDownEvents";
            this.buttonSortDownEvents.Size = new System.Drawing.Size(60, 57);
            this.buttonSortDownEvents.TabIndex = 1;
            this.buttonSortDownEvents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortDownEvents.UseVisualStyleBackColor = true;
            this.buttonSortDownEvents.Visible = false;
            this.buttonSortDownEvents.Click += new System.EventHandler(this.buttonSortDownEvents_Click);
            // 
            // flowLayoutPanelEvents
            // 
            this.flowLayoutPanelEvents.AutoScroll = true;
            this.flowLayoutPanelEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEvents.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelEvents.Name = "flowLayoutPanelEvents";
            this.flowLayoutPanelEvents.Size = new System.Drawing.Size(1193, 610);
            this.flowLayoutPanelEvents.TabIndex = 0;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.Controls.Add(this.splitContainerFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 25);
            this.tabPageFriends.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Size = new System.Drawing.Size(1193, 676);
            this.tabPageFriends.TabIndex = 3;
            this.tabPageFriends.Text = "Friends";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // splitContainerFriends
            // 
            this.splitContainerFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFriends.IsSplitterFixed = true;
            this.splitContainerFriends.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerFriends.Name = "splitContainerFriends";
            this.splitContainerFriends.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFriends.Panel1
            // 
            this.splitContainerFriends.Panel1.Controls.Add(this.buttonShowAllFriend);
            this.splitContainerFriends.Panel1.Controls.Add(this.buttonSearchFriend);
            this.splitContainerFriends.Panel1.Controls.Add(this.labelSeachFriendMsg);
            this.splitContainerFriends.Panel1.Controls.Add(this.textBoxSearchFriend);
            this.splitContainerFriends.Panel1.Controls.Add(this.flowLayoutPanelSortFriendBtns);
            // 
            // splitContainerFriends.Panel2
            // 
            this.splitContainerFriends.Panel2.Controls.Add(this.flowLayoutPanelFriends);
            this.splitContainerFriends.Size = new System.Drawing.Size(1193, 676);
            this.splitContainerFriends.SplitterDistance = 55;
            this.splitContainerFriends.SplitterWidth = 10;
            this.splitContainerFriends.TabIndex = 1;
            // 
            // buttonShowAllFriend
            // 
            this.buttonShowAllFriend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowAllFriend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowAllFriend.Location = new System.Drawing.Point(210, 3);
            this.buttonShowAllFriend.Name = "buttonShowAllFriend";
            this.buttonShowAllFriend.Size = new System.Drawing.Size(90, 23);
            this.buttonShowAllFriend.TabIndex = 7;
            this.buttonShowAllFriend.Text = "Show all";
            this.buttonShowAllFriend.UseVisualStyleBackColor = false;
            this.buttonShowAllFriend.Visible = false;
            this.buttonShowAllFriend.Click += new System.EventHandler(this.buttonShowAllFriend_Click);
            // 
            // buttonSearchFriend
            // 
            this.buttonSearchFriend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearchFriend.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchFriend.Location = new System.Drawing.Point(210, 30);
            this.buttonSearchFriend.Name = "buttonSearchFriend";
            this.buttonSearchFriend.Size = new System.Drawing.Size(90, 25);
            this.buttonSearchFriend.TabIndex = 6;
            this.buttonSearchFriend.Text = "Search";
            this.buttonSearchFriend.UseVisualStyleBackColor = false;
            this.buttonSearchFriend.Visible = false;
            this.buttonSearchFriend.Click += new System.EventHandler(this.buttonSearchFriend_Click);
            // 
            // labelSeachFriendMsg
            // 
            this.labelSeachFriendMsg.AutoSize = true;
            this.labelSeachFriendMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeachFriendMsg.Location = new System.Drawing.Point(2, 11);
            this.labelSeachFriendMsg.Name = "labelSeachFriendMsg";
            this.labelSeachFriendMsg.Size = new System.Drawing.Size(114, 16);
            this.labelSeachFriendMsg.TabIndex = 5;
            this.labelSeachFriendMsg.Text = "Seach by name";
            this.labelSeachFriendMsg.Visible = false;
            // 
            // textBoxSearchFriend
            // 
            this.textBoxSearchFriend.Location = new System.Drawing.Point(5, 30);
            this.textBoxSearchFriend.Name = "textBoxSearchFriend";
            this.textBoxSearchFriend.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchFriend.TabIndex = 3;
            this.textBoxSearchFriend.Visible = false;
            // 
            // flowLayoutPanelSortFriendBtns
            // 
            this.flowLayoutPanelSortFriendBtns.Controls.Add(this.buttonSortUpFriends);
            this.flowLayoutPanelSortFriendBtns.Controls.Add(this.buttonSortDownFriends);
            this.flowLayoutPanelSortFriendBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSortFriendBtns.Location = new System.Drawing.Point(313, 0);
            this.flowLayoutPanelSortFriendBtns.Name = "flowLayoutPanelSortFriendBtns";
            this.flowLayoutPanelSortFriendBtns.Size = new System.Drawing.Size(880, 55);
            this.flowLayoutPanelSortFriendBtns.TabIndex = 0;
            // 
            // buttonSortUpFriends
            // 
            this.buttonSortUpFriends.AutoSize = true;
            this.buttonSortUpFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortUpFriends.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortUpFriends.Image")));
            this.buttonSortUpFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortUpFriends.Location = new System.Drawing.Point(3, 2);
            this.buttonSortUpFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortUpFriends.Name = "buttonSortUpFriends";
            this.buttonSortUpFriends.Size = new System.Drawing.Size(60, 57);
            this.buttonSortUpFriends.TabIndex = 0;
            this.buttonSortUpFriends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortUpFriends.UseVisualStyleBackColor = true;
            this.buttonSortUpFriends.Visible = false;
            this.buttonSortUpFriends.VisibleChanged += new System.EventHandler(this.buttonSortUpFriends_VisibleChanged);
            this.buttonSortUpFriends.Click += new System.EventHandler(this.buttonSortUpFriends_Click);
            // 
            // buttonSortDownFriends
            // 
            this.buttonSortDownFriends.AutoSize = true;
            this.buttonSortDownFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDownFriends.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDownFriends.Image")));
            this.buttonSortDownFriends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortDownFriends.Location = new System.Drawing.Point(69, 2);
            this.buttonSortDownFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortDownFriends.Name = "buttonSortDownFriends";
            this.buttonSortDownFriends.Size = new System.Drawing.Size(60, 57);
            this.buttonSortDownFriends.TabIndex = 1;
            this.buttonSortDownFriends.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortDownFriends.UseVisualStyleBackColor = true;
            this.buttonSortDownFriends.Visible = false;
            this.buttonSortDownFriends.Click += new System.EventHandler(this.buttonSortDownFriends_Click);
            // 
            // flowLayoutPanelFriends
            // 
            this.flowLayoutPanelFriends.AutoScroll = true;
            this.flowLayoutPanelFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFriends.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelFriends.Name = "flowLayoutPanelFriends";
            this.flowLayoutPanelFriends.Size = new System.Drawing.Size(1193, 611);
            this.flowLayoutPanelFriends.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.splitContainerGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Size = new System.Drawing.Size(1193, 676);
            this.tabPageGroups.TabIndex = 5;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // splitContainerGroups
            // 
            this.splitContainerGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGroups.IsSplitterFixed = true;
            this.splitContainerGroups.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerGroups.Name = "splitContainerGroups";
            this.splitContainerGroups.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerGroups.Panel1
            // 
            this.splitContainerGroups.Panel1.Controls.Add(this.buttonShowAllGroup);
            this.splitContainerGroups.Panel1.Controls.Add(this.buttonSearchGroup);
            this.splitContainerGroups.Panel1.Controls.Add(this.labelSearchGroupMsg);
            this.splitContainerGroups.Panel1.Controls.Add(this.textBoxSearchGroup);
            this.splitContainerGroups.Panel1.Controls.Add(this.flowLayoutPanelSortGroupBtns);
            // 
            // splitContainerGroups.Panel2
            // 
            this.splitContainerGroups.Panel2.Controls.Add(this.flowLayoutPanelGroups);
            this.splitContainerGroups.Size = new System.Drawing.Size(1193, 676);
            this.splitContainerGroups.SplitterDistance = 55;
            this.splitContainerGroups.SplitterWidth = 10;
            this.splitContainerGroups.TabIndex = 1;
            // 
            // buttonShowAllGroup
            // 
            this.buttonShowAllGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowAllGroup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowAllGroup.Location = new System.Drawing.Point(210, 4);
            this.buttonShowAllGroup.Name = "buttonShowAllGroup";
            this.buttonShowAllGroup.Size = new System.Drawing.Size(90, 23);
            this.buttonShowAllGroup.TabIndex = 9;
            this.buttonShowAllGroup.Text = "Show all";
            this.buttonShowAllGroup.UseVisualStyleBackColor = false;
            this.buttonShowAllGroup.Visible = false;
            this.buttonShowAllGroup.Click += new System.EventHandler(this.buttonShowAllGroup_Click);
            // 
            // buttonSearchGroup
            // 
            this.buttonSearchGroup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearchGroup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchGroup.Location = new System.Drawing.Point(210, 30);
            this.buttonSearchGroup.Name = "buttonSearchGroup";
            this.buttonSearchGroup.Size = new System.Drawing.Size(90, 25);
            this.buttonSearchGroup.TabIndex = 8;
            this.buttonSearchGroup.Text = "Search";
            this.buttonSearchGroup.UseVisualStyleBackColor = false;
            this.buttonSearchGroup.Visible = false;
            this.buttonSearchGroup.Click += new System.EventHandler(this.buttonSearchGroup_Click);
            // 
            // labelSearchGroupMsg
            // 
            this.labelSearchGroupMsg.AutoSize = true;
            this.labelSearchGroupMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchGroupMsg.Location = new System.Drawing.Point(5, 11);
            this.labelSearchGroupMsg.Name = "labelSearchGroupMsg";
            this.labelSearchGroupMsg.Size = new System.Drawing.Size(114, 16);
            this.labelSearchGroupMsg.TabIndex = 5;
            this.labelSearchGroupMsg.Text = "Seach by name";
            this.labelSearchGroupMsg.Visible = false;
            // 
            // textBoxSearchGroup
            // 
            this.textBoxSearchGroup.Location = new System.Drawing.Point(5, 30);
            this.textBoxSearchGroup.Name = "textBoxSearchGroup";
            this.textBoxSearchGroup.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchGroup.TabIndex = 3;
            this.textBoxSearchGroup.Visible = false;
            // 
            // flowLayoutPanelSortGroupBtns
            // 
            this.flowLayoutPanelSortGroupBtns.Controls.Add(this.buttonSortUpGroups);
            this.flowLayoutPanelSortGroupBtns.Controls.Add(this.buttonSortDownGroups);
            this.flowLayoutPanelSortGroupBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelSortGroupBtns.Location = new System.Drawing.Point(313, 0);
            this.flowLayoutPanelSortGroupBtns.Name = "flowLayoutPanelSortGroupBtns";
            this.flowLayoutPanelSortGroupBtns.Size = new System.Drawing.Size(880, 55);
            this.flowLayoutPanelSortGroupBtns.TabIndex = 0;
            // 
            // buttonSortUpGroups
            // 
            this.buttonSortUpGroups.AutoSize = true;
            this.buttonSortUpGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortUpGroups.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortUpGroups.Image")));
            this.buttonSortUpGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortUpGroups.Location = new System.Drawing.Point(3, 2);
            this.buttonSortUpGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortUpGroups.Name = "buttonSortUpGroups";
            this.buttonSortUpGroups.Size = new System.Drawing.Size(60, 57);
            this.buttonSortUpGroups.TabIndex = 0;
            this.buttonSortUpGroups.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortUpGroups.UseVisualStyleBackColor = true;
            this.buttonSortUpGroups.Visible = false;
            this.buttonSortUpGroups.VisibleChanged += new System.EventHandler(this.buttonSortUpGroups_VisibleChanged);
            this.buttonSortUpGroups.Click += new System.EventHandler(this.buttonSortUpGroups_Click);
            // 
            // buttonSortDownGroups
            // 
            this.buttonSortDownGroups.AutoSize = true;
            this.buttonSortDownGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDownGroups.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDownGroups.Image")));
            this.buttonSortDownGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortDownGroups.Location = new System.Drawing.Point(69, 2);
            this.buttonSortDownGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortDownGroups.Name = "buttonSortDownGroups";
            this.buttonSortDownGroups.Size = new System.Drawing.Size(60, 57);
            this.buttonSortDownGroups.TabIndex = 1;
            this.buttonSortDownGroups.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortDownGroups.UseVisualStyleBackColor = true;
            this.buttonSortDownGroups.Visible = false;
            this.buttonSortDownGroups.Click += new System.EventHandler(this.buttonSortDownGroups_Click);
            // 
            // flowLayoutPanelGroups
            // 
            this.flowLayoutPanelGroups.AutoScroll = true;
            this.flowLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelGroups.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelGroups.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelGroups.Name = "flowLayoutPanelGroups";
            this.flowLayoutPanelGroups.Size = new System.Drawing.Size(1193, 611);
            this.flowLayoutPanelGroups.TabIndex = 0;
            // 
            // tabPageLikedPages
            // 
            this.tabPageLikedPages.Controls.Add(this.splitContainerLikedPages);
            this.tabPageLikedPages.Location = new System.Drawing.Point(4, 25);
            this.tabPageLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLikedPages.Name = "tabPageLikedPages";
            this.tabPageLikedPages.Size = new System.Drawing.Size(1193, 676);
            this.tabPageLikedPages.TabIndex = 6;
            this.tabPageLikedPages.Text = "Liked Pages";
            this.tabPageLikedPages.UseVisualStyleBackColor = true;
            // 
            // splitContainerLikedPages
            // 
            this.splitContainerLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLikedPages.IsSplitterFixed = true;
            this.splitContainerLikedPages.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerLikedPages.Name = "splitContainerLikedPages";
            this.splitContainerLikedPages.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLikedPages.Panel1
            // 
            this.splitContainerLikedPages.Panel1.Controls.Add(this.buttonShowAllPage);
            this.splitContainerLikedPages.Panel1.Controls.Add(this.buttonSearchPage);
            this.splitContainerLikedPages.Panel1.Controls.Add(this.labelSeachPageMsg);
            this.splitContainerLikedPages.Panel1.Controls.Add(this.textBoxSearchPage);
            this.splitContainerLikedPages.Panel1.Controls.Add(this.flowLayoutPanelLikedPagesConfig);
            // 
            // splitContainerLikedPages.Panel2
            // 
            this.splitContainerLikedPages.Panel2.Controls.Add(this.flowLayoutPanelLikedPages);
            this.splitContainerLikedPages.Size = new System.Drawing.Size(1193, 676);
            this.splitContainerLikedPages.SplitterDistance = 54;
            this.splitContainerLikedPages.SplitterWidth = 10;
            this.splitContainerLikedPages.TabIndex = 1;
            // 
            // buttonShowAllPage
            // 
            this.buttonShowAllPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonShowAllPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonShowAllPage.Location = new System.Drawing.Point(210, 0);
            this.buttonShowAllPage.Name = "buttonShowAllPage";
            this.buttonShowAllPage.Size = new System.Drawing.Size(90, 23);
            this.buttonShowAllPage.TabIndex = 9;
            this.buttonShowAllPage.Text = "Show all";
            this.buttonShowAllPage.UseVisualStyleBackColor = false;
            this.buttonShowAllPage.Visible = false;
            this.buttonShowAllPage.Click += new System.EventHandler(this.buttonShowAllPage_Click);
            // 
            // buttonSearchPage
            // 
            this.buttonSearchPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSearchPage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearchPage.Location = new System.Drawing.Point(210, 25);
            this.buttonSearchPage.Name = "buttonSearchPage";
            this.buttonSearchPage.Size = new System.Drawing.Size(90, 25);
            this.buttonSearchPage.TabIndex = 8;
            this.buttonSearchPage.Text = "Search";
            this.buttonSearchPage.UseVisualStyleBackColor = false;
            this.buttonSearchPage.Visible = false;
            this.buttonSearchPage.Click += new System.EventHandler(this.buttonSearchPage_Click);
            // 
            // labelSeachPageMsg
            // 
            this.labelSeachPageMsg.AutoSize = true;
            this.labelSeachPageMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeachPageMsg.Location = new System.Drawing.Point(5, 9);
            this.labelSeachPageMsg.Name = "labelSeachPageMsg";
            this.labelSeachPageMsg.Size = new System.Drawing.Size(114, 16);
            this.labelSeachPageMsg.TabIndex = 2;
            this.labelSeachPageMsg.Text = "Seach by name";
            this.labelSeachPageMsg.Visible = false;
            // 
            // textBoxSearchPage
            // 
            this.textBoxSearchPage.Location = new System.Drawing.Point(5, 25);
            this.textBoxSearchPage.Name = "textBoxSearchPage";
            this.textBoxSearchPage.Size = new System.Drawing.Size(200, 22);
            this.textBoxSearchPage.TabIndex = 0;
            this.textBoxSearchPage.Visible = false;
            // 
            // flowLayoutPanelLikedPagesConfig
            // 
            this.flowLayoutPanelLikedPagesConfig.Controls.Add(this.buttonSortUpPages);
            this.flowLayoutPanelLikedPagesConfig.Controls.Add(this.buttonSortDownPages);
            this.flowLayoutPanelLikedPagesConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelLikedPagesConfig.Location = new System.Drawing.Point(313, 0);
            this.flowLayoutPanelLikedPagesConfig.Name = "flowLayoutPanelLikedPagesConfig";
            this.flowLayoutPanelLikedPagesConfig.Size = new System.Drawing.Size(880, 54);
            this.flowLayoutPanelLikedPagesConfig.TabIndex = 0;
            // 
            // buttonSortUpPages
            // 
            this.buttonSortUpPages.AutoSize = true;
            this.buttonSortUpPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortUpPages.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortUpPages.Image")));
            this.buttonSortUpPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortUpPages.Location = new System.Drawing.Point(3, 2);
            this.buttonSortUpPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortUpPages.Name = "buttonSortUpPages";
            this.buttonSortUpPages.Size = new System.Drawing.Size(60, 57);
            this.buttonSortUpPages.TabIndex = 0;
            this.buttonSortUpPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortUpPages.UseVisualStyleBackColor = true;
            this.buttonSortUpPages.Visible = false;
            this.buttonSortUpPages.VisibleChanged += new System.EventHandler(this.buttonSortUpPages_VisibleChanged);
            this.buttonSortUpPages.Click += new System.EventHandler(this.buttonSortUpPages_Click);
            // 
            // buttonSortDownPages
            // 
            this.buttonSortDownPages.AutoSize = true;
            this.buttonSortDownPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSortDownPages.Image = ((System.Drawing.Image)(resources.GetObject("buttonSortDownPages.Image")));
            this.buttonSortDownPages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSortDownPages.Location = new System.Drawing.Point(69, 2);
            this.buttonSortDownPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSortDownPages.Name = "buttonSortDownPages";
            this.buttonSortDownPages.Size = new System.Drawing.Size(60, 57);
            this.buttonSortDownPages.TabIndex = 1;
            this.buttonSortDownPages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSortDownPages.UseVisualStyleBackColor = true;
            this.buttonSortDownPages.Visible = false;
            this.buttonSortDownPages.Click += new System.EventHandler(this.buttonSortDownPages_Click);
            // 
            // flowLayoutPanelLikedPages
            // 
            this.flowLayoutPanelLikedPages.AutoScroll = true;
            this.flowLayoutPanelLikedPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLikedPages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelLikedPages.Name = "flowLayoutPanelLikedPages";
            this.flowLayoutPanelLikedPages.Size = new System.Drawing.Size(1193, 612);
            this.flowLayoutPanelLikedPages.TabIndex = 0;
            // 
            // tabPageFavoriteTeamsGroup
            // 
            this.tabPageFavoriteTeamsGroup.Controls.Add(this.labelSameFVTeamRequest);
            this.tabPageFavoriteTeamsGroup.Controls.Add(this.panelSameFvTeam);
            this.tabPageFavoriteTeamsGroup.Controls.Add(this.buttonCreateGroupFavoriteTeams);
            this.tabPageFavoriteTeamsGroup.Location = new System.Drawing.Point(4, 25);
            this.tabPageFavoriteTeamsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFavoriteTeamsGroup.Name = "tabPageFavoriteTeamsGroup";
            this.tabPageFavoriteTeamsGroup.Size = new System.Drawing.Size(1193, 676);
            this.tabPageFavoriteTeamsGroup.TabIndex = 7;
            this.tabPageFavoriteTeamsGroup.Text = "Create football fans Group";
            this.tabPageFavoriteTeamsGroup.UseVisualStyleBackColor = true;
            // 
            // labelSameFVTeamRequest
            // 
            this.labelSameFVTeamRequest.AutoSize = true;
            this.labelSameFVTeamRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSameFVTeamRequest.Location = new System.Drawing.Point(44, 32);
            this.labelSameFVTeamRequest.Name = "labelSameFVTeamRequest";
            this.labelSameFVTeamRequest.Size = new System.Drawing.Size(544, 25);
            this.labelSameFVTeamRequest.TabIndex = 3;
            this.labelSameFVTeamRequest.Text = "Please, choose friends from the list to start a new group";
            // 
            // panelSameFvTeam
            // 
            this.panelSameFvTeam.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelSameFvTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSameFvTeam.Controls.Add(this.labelSameFVTeamFriends);
            this.panelSameFvTeam.Controls.Add(this.listBoxFavoriteTeams);
            this.panelSameFvTeam.Location = new System.Drawing.Point(49, 95);
            this.panelSameFvTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSameFvTeam.Name = "panelSameFvTeam";
            this.panelSameFvTeam.Size = new System.Drawing.Size(500, 400);
            this.panelSameFvTeam.TabIndex = 2;
            // 
            // labelSameFVTeamFriends
            // 
            this.labelSameFVTeamFriends.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelSameFVTeamFriends.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSameFVTeamFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSameFVTeamFriends.Location = new System.Drawing.Point(0, 0);
            this.labelSameFVTeamFriends.Name = "labelSameFVTeamFriends";
            this.labelSameFVTeamFriends.Size = new System.Drawing.Size(496, 20);
            this.labelSameFVTeamFriends.TabIndex = 2;
            this.labelSameFVTeamFriends.Text = "Friends with same favourite football team list";
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 16;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(0, 24);
            this.listBoxFavoriteTeams.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(496, 372);
            this.listBoxFavoriteTeams.TabIndex = 1;
            // 
            // buttonCreateGroupFavoriteTeams
            // 
            this.buttonCreateGroupFavoriteTeams.AutoSize = true;
            this.buttonCreateGroupFavoriteTeams.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateGroupFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateGroupFavoriteTeams.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateGroupFavoriteTeams.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateGroupFavoriteTeams.Image")));
            this.buttonCreateGroupFavoriteTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateGroupFavoriteTeams.Location = new System.Drawing.Point(53, 516);
            this.buttonCreateGroupFavoriteTeams.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateGroupFavoriteTeams.Name = "buttonCreateGroupFavoriteTeams";
            this.buttonCreateGroupFavoriteTeams.Size = new System.Drawing.Size(173, 44);
            this.buttonCreateGroupFavoriteTeams.TabIndex = 0;
            this.buttonCreateGroupFavoriteTeams.Text = "Create Group";
            this.buttonCreateGroupFavoriteTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateGroupFavoriteTeams.UseVisualStyleBackColor = false;
            this.buttonCreateGroupFavoriteTeams.Click += new System.EventHandler(this.buttonCreateGroupFavoriteTeams_Click);
            // 
            // tabPageFeature2
            // 
            this.tabPageFeature2.Controls.Add(this.labelFeatrueExplanation);
            this.tabPageFeature2.Controls.Add(this.panelEventDateSettings);
            this.tabPageFeature2.Controls.Add(this.panelPickedAgeList);
            this.tabPageFeature2.Controls.Add(this.labelTo);
            this.tabPageFeature2.Controls.Add(this.labelFrom);
            this.tabPageFeature2.Controls.Add(this.labelAgeRangeRequest);
            this.tabPageFeature2.Controls.Add(this.buttonFetchByAge);
            this.tabPageFeature2.Controls.Add(this.textBoxStartingAge);
            this.tabPageFeature2.Controls.Add(this.labelAgeRangeChar);
            this.tabPageFeature2.Controls.Add(this.textBoxEndingAge);
            this.tabPageFeature2.Location = new System.Drawing.Point(4, 25);
            this.tabPageFeature2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFeature2.Name = "tabPageFeature2";
            this.tabPageFeature2.Size = new System.Drawing.Size(1193, 676);
            this.tabPageFeature2.TabIndex = 8;
            this.tabPageFeature2.Text = "Create age-based Event";
            this.tabPageFeature2.UseVisualStyleBackColor = true;
            // 
            // labelFeatrueExplanation
            // 
            this.labelFeatrueExplanation.AutoSize = true;
            this.labelFeatrueExplanation.Location = new System.Drawing.Point(645, 315);
            this.labelFeatrueExplanation.Name = "labelFeatrueExplanation";
            this.labelFeatrueExplanation.Size = new System.Drawing.Size(288, 16);
            this.labelFeatrueExplanation.TabIndex = 12;
            this.labelFeatrueExplanation.Text = "*pick friends from the list to be able to set a date";
            // 
            // panelEventDateSettings
            // 
            this.panelEventDateSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEventDateSettings.Controls.Add(this.labelDateRequest);
            this.panelEventDateSettings.Controls.Add(this.dateTimePickerMeetupEvent);
            this.panelEventDateSettings.Controls.Add(this.buttonCreateMeetupEvent);
            this.panelEventDateSettings.Location = new System.Drawing.Point(643, 190);
            this.panelEventDateSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEventDateSettings.Name = "panelEventDateSettings";
            this.panelEventDateSettings.Size = new System.Drawing.Size(287, 123);
            this.panelEventDateSettings.TabIndex = 11;
            // 
            // labelDateRequest
            // 
            this.labelDateRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDateRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRequest.Location = new System.Drawing.Point(0, 0);
            this.labelDateRequest.Name = "labelDateRequest";
            this.labelDateRequest.Size = new System.Drawing.Size(283, 20);
            this.labelDateRequest.TabIndex = 7;
            this.labelDateRequest.Text = "Pick the event date: ";
            // 
            // dateTimePickerMeetupEvent
            // 
            this.dateTimePickerMeetupEvent.Enabled = false;
            this.dateTimePickerMeetupEvent.Location = new System.Drawing.Point(-3, 41);
            this.dateTimePickerMeetupEvent.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerMeetupEvent.Name = "dateTimePickerMeetupEvent";
            this.dateTimePickerMeetupEvent.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerMeetupEvent.TabIndex = 6;
            // 
            // buttonCreateMeetupEvent
            // 
            this.buttonCreateMeetupEvent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonCreateMeetupEvent.Enabled = false;
            this.buttonCreateMeetupEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateMeetupEvent.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonCreateMeetupEvent.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateMeetupEvent.Image")));
            this.buttonCreateMeetupEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCreateMeetupEvent.Location = new System.Drawing.Point(93, 71);
            this.buttonCreateMeetupEvent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateMeetupEvent.Name = "buttonCreateMeetupEvent";
            this.buttonCreateMeetupEvent.Size = new System.Drawing.Size(171, 30);
            this.buttonCreateMeetupEvent.TabIndex = 5;
            this.buttonCreateMeetupEvent.Text = "Create Event";
            this.buttonCreateMeetupEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateMeetupEvent.UseVisualStyleBackColor = false;
            this.buttonCreateMeetupEvent.Click += new System.EventHandler(this.buttonCreateMeetupEvent_Click);
            // 
            // panelPickedAgeList
            // 
            this.panelPickedAgeList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelPickedAgeList.Controls.Add(this.labelRangeAgeFriendList);
            this.panelPickedAgeList.Controls.Add(this.listBoxMeetupEventFriends);
            this.panelPickedAgeList.Location = new System.Drawing.Point(53, 166);
            this.panelPickedAgeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPickedAgeList.Name = "panelPickedAgeList";
            this.panelPickedAgeList.Size = new System.Drawing.Size(541, 300);
            this.panelPickedAgeList.TabIndex = 10;
            // 
            // labelRangeAgeFriendList
            // 
            this.labelRangeAgeFriendList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelRangeAgeFriendList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRangeAgeFriendList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRangeAgeFriendList.Location = new System.Drawing.Point(0, 0);
            this.labelRangeAgeFriendList.Name = "labelRangeAgeFriendList";
            this.labelRangeAgeFriendList.Size = new System.Drawing.Size(541, 20);
            this.labelRangeAgeFriendList.TabIndex = 5;
            this.labelRangeAgeFriendList.Text = "Frriends in picked-age list";
            // 
            // listBoxMeetupEventFriends
            // 
            this.listBoxMeetupEventFriends.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxMeetupEventFriends.FormattingEnabled = true;
            this.listBoxMeetupEventFriends.ItemHeight = 16;
            this.listBoxMeetupEventFriends.Location = new System.Drawing.Point(0, 24);
            this.listBoxMeetupEventFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMeetupEventFriends.Name = "listBoxMeetupEventFriends";
            this.listBoxMeetupEventFriends.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMeetupEventFriends.Size = new System.Drawing.Size(541, 276);
            this.listBoxMeetupEventFriends.TabIndex = 4;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(579, 22);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(26, 16);
            this.labelTo.TabIndex = 9;
            this.labelTo.Text = "(to)";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(479, 22);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(41, 16);
            this.labelFrom.TabIndex = 8;
            this.labelFrom.Text = "(from)";
            // 
            // labelAgeRangeRequest
            // 
            this.labelAgeRangeRequest.AutoSize = true;
            this.labelAgeRangeRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeRangeRequest.Location = new System.Drawing.Point(48, 39);
            this.labelAgeRangeRequest.Name = "labelAgeRangeRequest";
            this.labelAgeRangeRequest.Size = new System.Drawing.Size(377, 25);
            this.labelAgeRangeRequest.TabIndex = 7;
            this.labelAgeRangeRequest.Text = "Please friends age range to continue: ";
            // 
            // buttonFetchByAge
            // 
            this.buttonFetchByAge.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonFetchByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchByAge.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFetchByAge.Location = new System.Drawing.Point(460, 81);
            this.buttonFetchByAge.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchByAge.Name = "buttonFetchByAge";
            this.buttonFetchByAge.Size = new System.Drawing.Size(161, 28);
            this.buttonFetchByAge.TabIndex = 0;
            this.buttonFetchByAge.Text = "Continue";
            this.buttonFetchByAge.UseVisualStyleBackColor = false;
            this.buttonFetchByAge.Click += new System.EventHandler(this.buttonFetchByAge_Click);
            // 
            // textBoxStartingAge
            // 
            this.textBoxStartingAge.Location = new System.Drawing.Point(469, 42);
            this.textBoxStartingAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartingAge.Name = "textBoxStartingAge";
            this.textBoxStartingAge.Size = new System.Drawing.Size(63, 22);
            this.textBoxStartingAge.TabIndex = 1;
            // 
            // labelAgeRangeChar
            // 
            this.labelAgeRangeChar.AutoSize = true;
            this.labelAgeRangeChar.Location = new System.Drawing.Point(539, 46);
            this.labelAgeRangeChar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgeRangeChar.Name = "labelAgeRangeChar";
            this.labelAgeRangeChar.Size = new System.Drawing.Size(11, 16);
            this.labelAgeRangeChar.TabIndex = 2;
            this.labelAgeRangeChar.Text = "-";
            // 
            // textBoxEndingAge
            // 
            this.textBoxEndingAge.Location = new System.Drawing.Point(559, 42);
            this.textBoxEndingAge.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEndingAge.Name = "textBoxEndingAge";
            this.textBoxEndingAge.Size = new System.Drawing.Size(63, 22);
            this.textBoxEndingAge.TabIndex = 3;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // checkinsBindingSource
            // 
            this.checkinsBindingSource.DataMember = "Checkins";
            this.checkinsBindingSource.DataSource = this.userBindingSource;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(28, 524);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(200, 40);
            this.btnPlayGame.TabIndex = 35;
            this.btnPlayGame.Text = "Lets Have Fun!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // FormDesktopFacebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1201, 853);
            this.Controls.Add(this.splitContainerMain);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1019, 797);
            this.Name = "FormDesktopFacebook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formDesktopFacebook_FormClosing);
            this.Load += new System.EventHandler(this.formDesktopFacebook_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.splitContainerProfilePicBasicUserInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProfilePicBasicUserInfo)).EndInit();
            this.splitContainerProfilePicBasicUserInfo.ResumeLayout(false);
            this.splitContainerBasicUserInfo.Panel1.ResumeLayout(false);
            this.splitContainerBasicUserInfo.Panel2.ResumeLayout(false);
            this.splitContainerBasicUserInfo.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBasicUserInfo)).EndInit();
            this.splitContainerBasicUserInfo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.splitContainerInfo.Panel1.ResumeLayout(false);
            this.splitContainerInfo.Panel1.PerformLayout();
            this.splitContainerInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerInfo)).EndInit();
            this.splitContainerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.splitContainergraph.Panel1.ResumeLayout(false);
            this.splitContainergraph.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainergraph)).EndInit();
            this.splitContainergraph.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panelBorder.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartNumOfPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNumOfPostsPie)).EndInit();
            this.tabPagePosts.ResumeLayout(false);
            this.splitContainerPosts.Panel1.ResumeLayout(false);
            this.splitContainerPosts.Panel1.PerformLayout();
            this.splitContainerPosts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPosts)).EndInit();
            this.splitContainerPosts.ResumeLayout(false);
            this.panelPostsInfo.ResumeLayout(false);
            this.panelPostsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            this.splitContainerAlbums.Panel1.ResumeLayout(false);
            this.splitContainerAlbums.Panel1.PerformLayout();
            this.splitContainerAlbums.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAlbums)).EndInit();
            this.splitContainerAlbums.ResumeLayout(false);
            this.flowLayoutPanelSortAlbumsBtns.ResumeLayout(false);
            this.flowLayoutPanelSortAlbumsBtns.PerformLayout();
            this.tabPageEvents.ResumeLayout(false);
            this.splitContainerEvents.Panel1.ResumeLayout(false);
            this.splitContainerEvents.Panel1.PerformLayout();
            this.splitContainerEvents.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerEvents)).EndInit();
            this.splitContainerEvents.ResumeLayout(false);
            this.flowLayoutPanelSortEventBtns.ResumeLayout(false);
            this.flowLayoutPanelSortEventBtns.PerformLayout();
            this.tabPageFriends.ResumeLayout(false);
            this.splitContainerFriends.Panel1.ResumeLayout(false);
            this.splitContainerFriends.Panel1.PerformLayout();
            this.splitContainerFriends.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFriends)).EndInit();
            this.splitContainerFriends.ResumeLayout(false);
            this.flowLayoutPanelSortFriendBtns.ResumeLayout(false);
            this.flowLayoutPanelSortFriendBtns.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.splitContainerGroups.Panel1.ResumeLayout(false);
            this.splitContainerGroups.Panel1.PerformLayout();
            this.splitContainerGroups.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerGroups)).EndInit();
            this.splitContainerGroups.ResumeLayout(false);
            this.flowLayoutPanelSortGroupBtns.ResumeLayout(false);
            this.flowLayoutPanelSortGroupBtns.PerformLayout();
            this.tabPageLikedPages.ResumeLayout(false);
            this.splitContainerLikedPages.Panel1.ResumeLayout(false);
            this.splitContainerLikedPages.Panel1.PerformLayout();
            this.splitContainerLikedPages.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLikedPages)).EndInit();
            this.splitContainerLikedPages.ResumeLayout(false);
            this.flowLayoutPanelLikedPagesConfig.ResumeLayout(false);
            this.flowLayoutPanelLikedPagesConfig.PerformLayout();
            this.tabPageFavoriteTeamsGroup.ResumeLayout(false);
            this.tabPageFavoriteTeamsGroup.PerformLayout();
            this.panelSameFvTeam.ResumeLayout(false);
            this.tabPageFeature2.ResumeLayout(false);
            this.tabPageFeature2.PerformLayout();
            this.panelEventDateSettings.ResumeLayout(false);
            this.panelPickedAgeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkinsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.SplitContainer splitContainerProfilePicBasicUserInfo;
        private System.Windows.Forms.SplitContainer splitContainerBasicUserInfo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAmountOfFriends;
        private System.Windows.Forms.Label labelEmail;
        private CircularPictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Button buttonLogout;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePosts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageAlbums;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.TabPage tabPageEvents;
        private System.Windows.Forms.TabPage tabPageFriends;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageLikedPages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroups;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLikedPages;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEvents;
        private System.Windows.Forms.TabPage tabPageFavoriteTeamsGroup;
        private System.Windows.Forms.TabPage tabPageFeature2;
        private System.Windows.Forms.Button buttonFetchByAge;
        private System.Windows.Forms.TextBox textBoxStartingAge;
        private System.Windows.Forms.Label labelAgeRangeChar;
        private System.Windows.Forms.TextBox textBoxEndingAge;
        private System.Windows.Forms.ListBox listBoxMeetupEventFriends;
        private System.Windows.Forms.Button buttonCreateMeetupEvent;
        private System.Windows.Forms.DateTimePicker dateTimePickerMeetupEvent;
        private System.Windows.Forms.SplitContainer splitContainerAlbums;
        private System.Windows.Forms.Button buttonSortUpAlbums;
        private System.Windows.Forms.SplitContainer splitContainerEvents;
        private System.Windows.Forms.Button buttonSortUpEvents;
        private System.Windows.Forms.SplitContainer splitContainerFriends;
        private System.Windows.Forms.Button buttonSortUpFriends;
        private System.Windows.Forms.SplitContainer splitContainerGroups;
        private System.Windows.Forms.Button buttonSortUpGroups;
        private System.Windows.Forms.SplitContainer splitContainerLikedPages;
        private System.Windows.Forms.Button buttonSortUpPages;
        private System.Windows.Forms.SplitContainer splitContainerPosts;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textboxPost;
        private System.Windows.Forms.Label labelSameFVTeamRequest;
        private System.Windows.Forms.Label labelSameFVTeamFriends;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.Button buttonCreateGroupFavoriteTeams;
        private System.Windows.Forms.Panel panelSameFvTeam;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelAgeRangeRequest;
        private System.Windows.Forms.Panel panelEventDateSettings;
        private System.Windows.Forms.Label labelDateRequest;
        private System.Windows.Forms.Panel panelPickedAgeList;
        private System.Windows.Forms.Label labelRangeAgeFriendList;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainerInfo;
        private System.Windows.Forms.Label labelFeatrueExplanation;
        private System.Windows.Forms.Button buttonThisDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumOfPostsPie;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource checkinsBindingSource;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.TextBox localeTextBox;
        private System.Windows.Forms.Label labelFirstNameErrorMsg;
        private System.Windows.Forms.Label labelMailErrorMsg;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label labelLastNameErrorMsg;
        private System.Windows.Forms.Button buttonSortDownEvents;
        private System.Windows.Forms.Button buttonSortDownAlbums;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSortAlbumsBtns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSortEventBtns;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSortFriendBtns;
        private System.Windows.Forms.Button buttonSortDownFriends;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSortGroupBtns;
        private System.Windows.Forms.Button buttonSortDownGroups;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLikedPagesConfig;
        private System.Windows.Forms.Button buttonSortDownPages;
        private System.Windows.Forms.Panel panelPostsInfo;
        private System.Windows.Forms.Label labelPostCreationLocation;
        private System.Windows.Forms.Label labelCreationLocation;
        private System.Windows.Forms.Label labelPostCreateTime;
        private System.Windows.Forms.Label labelPostCreateDate;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelCreationTime;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label labelPostCreationDate;
        private System.Windows.Forms.Label labelPostPicture;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.Label labelHowActiveMsg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNumOfPosts;
        private System.Windows.Forms.SplitContainer splitContainergraph;
        private System.Windows.Forms.Panel panelBorder;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button buttonShowHideHowActive;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxSearchPage;
        private System.Windows.Forms.Label labelSeachPageMsg;
        private System.Windows.Forms.Label labelSeachAlbumMsg;
        private System.Windows.Forms.TextBox textBoxSearchAlbum;
        private System.Windows.Forms.Label labelSearchEventMsg;
        private System.Windows.Forms.TextBox textBoxSearchEvent;
        private System.Windows.Forms.Label labelSeachFriendMsg;
        private System.Windows.Forms.TextBox textBoxSearchFriend;
        private System.Windows.Forms.Label labelSearchGroupMsg;
        private System.Windows.Forms.TextBox textBoxSearchGroup;
        private System.Windows.Forms.Button buttonShowAllAlbum;
        private System.Windows.Forms.Button buttonSearchAlbum;
        private System.Windows.Forms.Button buttonShowAllEvent;
        private System.Windows.Forms.Button buttonSearchEvent;
        private System.Windows.Forms.Button buttonShowAllFriend;
        private System.Windows.Forms.Button buttonSearchFriend;
        private System.Windows.Forms.Button buttonShowAllGroup;
        private System.Windows.Forms.Button buttonSearchGroup;
        private System.Windows.Forms.Button buttonShowAllPage;
        private System.Windows.Forms.Button buttonSearchPage;
        private System.Windows.Forms.Button btnPlayGame;
    }
}