using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LogicEngine
{
    public class FacebookComponentCollection : IEnumerable
    {
        private readonly List<IFacebookComponent> r_FacebookComponents;
        private Func<IFacebookComponent, bool> m_Filter;

        public FacebookComponentCollection()
        {
            r_FacebookComponents = new List<IFacebookComponent>();
        }

        public int Count
        {
            get { return r_FacebookComponents.Count; }
        }

        public Func<IFacebookComponent, bool> Filter
        {
            set
            {
                if (value != null)
                {
                    m_Filter = value;
                }
                else
                {
                    throw new Exception("Invalid FacebookComponentCollection Iterator filer");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (IFacebookComponent component in r_FacebookComponents)
            {
                if (m_Filter == null || m_Filter(component))
                {
                    yield return component;
                }
            }
        }

        public void AddMultiple<T>(FacebookObjectCollection<T> i_ObjectsList)
        {
            Type type = typeof(T);

            if (type == typeof(Group))
            {
                convertGroupsToFacebookCollection(i_ObjectsList as FacebookObjectCollection<Group>);
            }
            else if (type == typeof(Page))
            {
                convertPagesToFacebookCollection(i_ObjectsList as FacebookObjectCollection<Page>);
            }
            else if (type == typeof(DummyFriend))
            {
                convertFriendsToFacebookCollection(i_ObjectsList as FacebookObjectCollection<DummyFriend>);
            }
            else if (type == typeof(Album))
            {
               convertAlbumsToFacebookCollection(i_ObjectsList as FacebookObjectCollection<Album>);
            }
            else if (type == typeof(Event))
            {
                convertEventsToFacebookCollection(i_ObjectsList as FacebookObjectCollection<Event>);
            }
        }

        public void Add(IFacebookComponent i_FacebookComponent)
        {
            if (i_FacebookComponent != null)
            {
                r_FacebookComponents.Add(i_FacebookComponent);
            }
            else
            {
                throw new Exception("FacebookComponent cant be NULL!");
            }
        }

        public void SortArray(FacebookComponentsArraySorter i_Sorter)
        {
            i_Sorter.MergeSortArray(r_FacebookComponents, 0, r_FacebookComponents.Count - 1);
        }

        private void convertGroupsToFacebookCollection(FacebookObjectCollection<Group> i_Groups)
        {
            foreach (Group group in i_Groups)
            {
                Add(new GroupWrapper(group));
            }
        }

        private void convertAlbumsToFacebookCollection(FacebookObjectCollection<Album> i_Albums)
        {
            foreach (Album album in i_Albums)
            {
                Add(new AlbumWrapper(album));
            }
        }

        private void convertEventsToFacebookCollection(FacebookObjectCollection<Event> i_Events)
        {
            foreach (Event eventt in i_Events)
            {
                Add(new EventWrapper(eventt));
            }
        }

        private void convertFriendsToFacebookCollection(FacebookObjectCollection<DummyFriend> i_Friends)
        {
            foreach (DummyFriend friend in i_Friends)
            {
                Add(friend);
            }
        }

        private void convertPagesToFacebookCollection(FacebookObjectCollection<Page> i_Pages)
        {
            foreach (Page page in i_Pages)
            {
                Add(new PageWrapper(page));
            }
        }
    }
}