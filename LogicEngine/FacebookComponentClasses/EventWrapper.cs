using FacebookWrapper.ObjectModel;

namespace LogicEngine
{
    public class EventWrapper : IFacebookComponent
    {
        public EventWrapper(Event i_Event)
        {
            this.Event = i_Event;
        }

        public Event Event { get; }

        public string Name
        {
            get { return Event.Name; }
        }

        public string ImageURL
        {
            get { return Event.Cover.SourceURL; }
        }

        public int CompareTo(IFacebookComponent i_Other)
        {
            return Event.Name.CompareTo(i_Other.Name);
        }
    }
}