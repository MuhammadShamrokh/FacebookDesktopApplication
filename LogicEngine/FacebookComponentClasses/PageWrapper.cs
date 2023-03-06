using FacebookWrapper.ObjectModel;

namespace LogicEngine
{
    public class PageWrapper : IFacebookComponent
    {
        public PageWrapper(Page i_Page)
        {
            this.LikedPage = i_Page;
        }

        public Page LikedPage { get; }

        public string Name
        {
            get { return LikedPage.Name; }
        }

        public string ImageURL
        {
            get { return LikedPage.PictureLargeURL; }
        }

        public int CompareTo(IFacebookComponent i_Other)
        {
            return LikedPage.Name.CompareTo(i_Other.Name);
        }
    }
}