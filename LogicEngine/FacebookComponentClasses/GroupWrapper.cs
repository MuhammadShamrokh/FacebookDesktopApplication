using FacebookWrapper.ObjectModel;

namespace LogicEngine
{
    public class GroupWrapper : IFacebookComponent
    {
        public GroupWrapper(Group i_Group)
        {
            this.Group = i_Group;
        }

        public Group Group { get; }

        public string Name
        {
            get { return Group.Name; }
        }

        public string ImageURL
        {
            get { return Group.PictureLargeURL; }
        }

        public int CompareTo(IFacebookComponent i_Other)
        {
            return Group.Name.CompareTo(i_Other.Name);
        }
    }
}