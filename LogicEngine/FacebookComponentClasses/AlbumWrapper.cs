using FacebookWrapper.ObjectModel;

namespace LogicEngine
{
    public class AlbumWrapper : IFacebookComponent
    {
        public AlbumWrapper(Album i_Album)
        {
            this.Album = i_Album;
        }

        public Album Album { get; }

        public string Name
        {
            get { return Album.Name; }
        }

        public string ImageURL
        {
            get { return Album.PictureAlbumURL; }
        }

        public int CompareTo(IFacebookComponent i_Other)
        {
            return Album.Name.CompareTo(i_Other.Name);
        }
    }
}