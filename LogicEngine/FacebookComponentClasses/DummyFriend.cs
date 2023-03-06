namespace LogicEngine
{
    public class DummyFriend : IFacebookComponent
    {
        public string Name { get; set; }

        public string ProfilePicURL { get; set; }

        public string Birthday { get; set; }

        public eFootballTeam FavoriteTeam { get; set; }

        public string ImageURL
        {
            get { return ProfilePicURL; }
        }

        public int CompareTo(IFacebookComponent i_Other)
        {
            return this.Name.CompareTo(i_Other.Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}