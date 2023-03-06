using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ControlsFactory;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace LogicEngine
{
    public sealed class LogicEngineManager
    {
        private const int k_DaysInYear = 365;
        private const int k_CharactersInYearString = 4;
        private const int k_CharactersInMonthString = 2;
        private const int k_CharactersInDayString = 2;
        private const char k_DateSeparator = '/';
        private const string k_OnThisDayFilePath = @"./onThisDay.xml";
        private const string k_DummyFriendsDataFilePath = @"./DummyFriendsData.xml";
        private static readonly object sr_InstanceLock = new object();
        private static LogicEngineManager s_Instance;
        private readonly AppSettings r_AppSettings;
        private readonly FacebookComponentCache r_ComponentsCache;
        private readonly FacebookComponentsArraySorter r_SortingMachine;
        private DummyFriend[] m_DummyFriends;
        private OnThisDay[] m_OnTheseDays;
        private eFootballTeam m_LoggedInUsersFavoriteTeam = eFootballTeam.RealMadrid;

        private LogicEngineManager()
        {
            this.r_AppSettings = AppSettings.LoadAppSettingsFromFile();
            this.r_SortingMachine = new FacebookComponentsArraySorter();
            this.r_ComponentsCache = new FacebookComponentCache();
            this.m_OnTheseDays = new OnThisDay[k_DaysInYear];
            this.updateOnThisDayFromXMLFile();
            this.updateDummyFriends();
        }

        public static LogicEngineManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new LogicEngineManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public string FilterName { get; set; }

        public User LoggedInUser { get; set; }

        public void SetUpSortingMethod()
        {
            this.r_SortingMachine.Test = (c1, c2) => c1.CompareTo(c2) < 0;
        }

        public void SetDownSortingMethod()
        {
            this.r_SortingMachine.Test = (c1, c2) => c1.CompareTo(c2) >= 0;
        }

        public void ConnectWithAccessToken()
        {
            string accessToken = this.r_AppSettings.AccessToken;

            this.LoggedInUser = FacebookService.Connect(accessToken).LoggedInUser;
        }

        public void SaveAppSettings()
        {
            this.r_AppSettings.SaveAppSettingsToFile();
        }

        public void SetAccessToken(string i_AccessToken)
        {
            this.r_AppSettings.AccessToken = i_AccessToken;
        }

        public bool GetRememberUser()
        {
            return this.r_AppSettings.RememberUser;
        }

        public void SetRememberUser(bool i_RememberUser)
        {
            this.r_AppSettings.RememberUser = i_RememberUser;
        }

        public void SetControlsType(eControlsType i_ControlsType)
        {
            this.r_AppSettings.ControlsType = i_ControlsType;
        }

        public eControlsType GetControlsType()
        {
            return this.r_AppSettings.ControlsType;
        }

        public bool CheckIfLoggedInUserIsNull()
        {
            return this.LoggedInUser == null;
        }

        public string GetUserName()
        {
            return this.LoggedInUser.Name;
        }

        public string GetUserFirstname()
        {
            return this.LoggedInUser.FirstName;
        }

        public string GetUserLastname()
        {
            return this.LoggedInUser.LastName;
        }

        public string GetOnThisDayInfo(out int i_HowManyYearsAgo)
        {
            Date userBirthDate = new Date() { Day = this.getDayOfBirth(), Month = this.getMonthOfBirth(), Year = this.getYearOfBirth() };
            string onThisDayInfo = this.m_OnTheseDays[userBirthDate.Day].Info;

            i_HowManyYearsAgo = userBirthDate.Year - this.m_OnTheseDays[userBirthDate.Day].Date.Year;

            return onThisDayInfo;
        }

        public string GetUserMail()
        {
            return this.LoggedInUser.Email != null ? this.LoggedInUser.Email : "Unknown";
        }

        public int GetUserAmountOfDummyFriends()
        {
            return this.m_DummyFriends.Length;
        }

        public string GetUserProfileImage()
        {
            return this.LoggedInUser.PictureNormalURL;
        }

        public List<Post> GetUserPosts()
        {
            List<Post> userPosts = new List<Post>();

            foreach (Post post in this.LoggedInUser.Posts)
            {
                userPosts.Add(post);
            }

            return userPosts;
        }

        public FacebookComponentCollection GetFavoriteTeamsDummyFriends()
        {
            FacebookComponentCollection favTeamFriends = new FacebookComponentCollection();

            foreach (DummyFriend friend in this.m_DummyFriends)
            {
                if (friend.FavoriteTeam == this.m_LoggedInUsersFavoriteTeam)
                {
                    favTeamFriends.Add(friend);
                }
            }

            return favTeamFriends;
        }

        public FacebookComponentCollection GetRequestedComponent(FacebookComponentType i_ComponentType, bool i_IsSorted)
        {
            FacebookComponentCollection componentList;

            switch (i_ComponentType)
            {
                case FacebookComponentType.Albums:
                    componentList = this.getUserAlbums(i_IsSorted);
                    break;
                case FacebookComponentType.Events:
                    componentList = this.getUserEvents(i_IsSorted);
                    break;
                case FacebookComponentType.LikedPages:
                    componentList = this.getUserLikedPages(i_IsSorted);
                    break;
                case FacebookComponentType.Friends:
                    componentList = this.getUserDummyFriends(i_IsSorted);
                    break;
                case FacebookComponentType.Groups:
                    componentList = this.getUserGroups(i_IsSorted);
                    break;
                default:
                    componentList = new FacebookComponentCollection();
                    break;
            }

            componentList.Filter = this.filterComponentsByName;
            return componentList;
        }

        public void CreateGroupForFavoriteTeamsDummyFriends(FacebookComponentCollection i_SelectedFriends)
        {
            FacebookComponentCollection favTeamFriendsGroup = new FacebookComponentCollection();

            foreach (DummyFriend friend in i_SelectedFriends)
            {
                favTeamFriendsGroup.Add(friend);
            }
        }

        public FacebookComponentCollection GetAgeRangeDummyFriends(int i_StartingAge, int i_EndingAge)
        {
            FacebookComponentCollection friends = new FacebookComponentCollection();
            int age;

            foreach (DummyFriend friend in this.m_DummyFriends)
            {
                age = this.calculateUserAge(friend.Birthday);
                if (age >= i_StartingAge && age <= i_EndingAge)
                {
                    friends.Add(friend);
                }
            }

            return friends;
        }

        public void CreateMeetupEventForDummyFriends(FacebookComponentCollection selectedFriends, DateTime i_StartTime)
        {
        }

        public void PostStatus(string i_TextToPost)
        {
            this.LoggedInUser.PostStatus(i_TextToPost);
        }

        public List<int> GetNumOfPostsPerMonthArray()
        {
            List<int> numOfPostsPerMonthList = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            foreach (Post post in this.LoggedInUser.Posts)
            {
                if (post.CreatedTime.HasValue)
                {
                    if (post.CreatedTime.Value.Year == DateTime.Now.Year)
                    {
                        numOfPostsPerMonthList[post.CreatedTime.Value.Month - 1] += 1;
                    }
                }
            }

            return numOfPostsPerMonthList;
        }

        private void updateDummyFriends()
        {
            using (Stream stream = new FileStream(k_DummyFriendsDataFilePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DummyFriend[]));
                this.m_DummyFriends = xmlSerializer.Deserialize(stream) as DummyFriend[];
            }
        }

        private void updateOnThisDayFromXMLFile()
        {
            using (Stream stream = new FileStream(k_OnThisDayFilePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(OnThisDay[]));
                this.m_OnTheseDays = xmlSerializer.Deserialize(stream) as OnThisDay[];
            }
        }

        private int getDayOfBirth()
        {
            string birthdate = this.LoggedInUser.Birthday;
            int firstIndexOfSeparator = birthdate.IndexOf(k_DateSeparator) + 1;
            int monthOfBirth = int.Parse(birthdate.Substring(firstIndexOfSeparator, k_CharactersInDayString));

            return monthOfBirth;
        }

        private int getYearOfBirth()
        {
            string birthdate = this.LoggedInUser.Birthday;
            int lastIndexOfSeparator = birthdate.LastIndexOf(k_DateSeparator) + 1;
            int yearOfBirth = int.Parse(birthdate.Substring(lastIndexOfSeparator, k_CharactersInYearString));

            return yearOfBirth;
        }

        private int getMonthOfBirth()
        {
            string birthdate = this.LoggedInUser.Birthday;
            int dayOfBirth = int.Parse(birthdate.Substring(0, k_CharactersInMonthString));

            return dayOfBirth;
        }

        private FacebookComponentCollection getUserAlbums(bool i_IsSorted)
        {
            FacebookComponentCollection userAlbums;


            if (this.areDetailsUpToDate(FacebookComponentType.Albums))
            {
                userAlbums = this.r_ComponentsCache.Albums;
            }
            else
            {
                userAlbums = new FacebookComponentCollection();
                userAlbums.AddMultiple(LoggedInUser.Albums);
                this.r_ComponentsCache.Albums = userAlbums;
            }

            if (i_IsSorted)
            {
                userAlbums.SortArray(this.r_SortingMachine);
            }

            return userAlbums;
        }

        private FacebookComponentCollection getUserEvents(bool i_IsSorted)
        {
            FacebookComponentCollection userEvents;

            if (this.areDetailsUpToDate(FacebookComponentType.Events))
            {
                userEvents = this.r_ComponentsCache.Events;
            }
            else
            {
                userEvents = new FacebookComponentCollection();
                userEvents.AddMultiple(LoggedInUser.Events);
                this.r_ComponentsCache.Events = userEvents;
            }

            if (i_IsSorted)
            {
                userEvents.SortArray(this.r_SortingMachine);
            }

            return userEvents;
        }

        private FacebookComponentCollection getUserGroups(bool i_IsSorted)
        {

            FacebookComponentCollection userGroups;

            if (this.areDetailsUpToDate(FacebookComponentType.Groups))
            {
                userGroups = this.r_ComponentsCache.Groups;
            }
            else
            {
                userGroups = new FacebookComponentCollection();
                userGroups.AddMultiple(LoggedInUser.Groups);
                this.r_ComponentsCache.Groups = userGroups;
            }

            if (i_IsSorted)
            {
                userGroups.SortArray(this.r_SortingMachine);
            }

            return userGroups;
        }

        private FacebookComponentCollection getUserDummyFriends(bool i_IsSorted)
        {
            FacebookComponentCollection userDummyFriends;

            if (this.areDetailsUpToDate(FacebookComponentType.Friends))
            {
                userDummyFriends = this.r_ComponentsCache.Friends;
            }
            else
            {
                userDummyFriends = new FacebookComponentCollection();
                foreach (DummyFriend friend in this.m_DummyFriends)
                {
                    userDummyFriends.Add(friend);
                }

                this.r_ComponentsCache.Friends = userDummyFriends;
            }

            if (i_IsSorted)
            {
                userDummyFriends.SortArray(this.r_SortingMachine);
            }

            return userDummyFriends;
        }

        private FacebookComponentCollection getUserLikedPages(bool i_IsSorted)
        {
            FacebookComponentCollection userLikedPages;

            if (this.areDetailsUpToDate(FacebookComponentType.LikedPages))
            {
                userLikedPages = this.r_ComponentsCache.Pages;
            }
            else
            {
                userLikedPages = new FacebookComponentCollection();
                userLikedPages.AddMultiple(LoggedInUser.LikedPages);
                this.r_ComponentsCache.Pages = userLikedPages;
            }

            if (i_IsSorted)
            {
                userLikedPages.SortArray(this.r_SortingMachine);
            }

            return userLikedPages;
        }

        private bool areDetailsUpToDate(FacebookComponentType i_Type)
        {
            bool isUpToDate;

            switch (i_Type)
            {
                case FacebookComponentType.Albums:
                    isUpToDate = (this.r_ComponentsCache.Albums != null) && (this.LoggedInUser.Albums.Count == this.r_ComponentsCache.Albums.Count);
                    break;
                case FacebookComponentType.Events:
                    isUpToDate = (this.r_ComponentsCache.Events != null) && (this.LoggedInUser.Events.Count == this.r_ComponentsCache.Events.Count);
                    break;
                case FacebookComponentType.LikedPages:
                    isUpToDate = (this.r_ComponentsCache.Pages != null) && (this.LoggedInUser.LikedPages.Count == this.r_ComponentsCache.Pages.Count);
                    break;
                case FacebookComponentType.Friends:
                    isUpToDate = this.r_ComponentsCache.Friends != null;
                    break;
                case FacebookComponentType.Groups:
                    isUpToDate = (this.r_ComponentsCache.Groups != null) && (this.LoggedInUser.Groups.Count == this.r_ComponentsCache.Groups.Count);
                    break;
                default:
                    isUpToDate = false;
                    break;
            }

            return isUpToDate;
        }

        private int calculateUserAge(string dateOfBirth)
        {
            int yearOfBirth, currentYear, userAge;

            currentYear = DateTime.Now.Year;
            yearOfBirth = int.Parse(dateOfBirth.Substring(dateOfBirth.Length - k_CharactersInYearString));
            userAge = currentYear - yearOfBirth;

            return userAge;
        }

        private bool filterComponentsByName(IFacebookComponent i_Component)
        {
            bool isValidComponent = false;

            if (string.IsNullOrEmpty(this.FilterName))
            {
                isValidComponent = true;
            }
            else
            {
                isValidComponent = i_Component.Name.Contains(this.FilterName);
            }

            return isValidComponent;
        }
    }
}