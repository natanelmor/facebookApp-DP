using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public class TopLikedPhotos : ICollectionOfTopLikedFriends
    {
        private Dictionary<User, int> m_TopLikedFriends;
        private List<Photo> m_SortPhotos;
        private LinkedList<string> m_ListOfBestFriends;

        public List<Photo> TopPhotos
        {
            get;
            set;
        }

        public TopLikedPhotos(User i_FacebookUser)
        {
             m_SortPhotos = new List<Photo>();
        }

        public void CheckYourTopLikedPhotos(User i_FacebookUser)
        {
            try
            {
                foreach (Album album in i_FacebookUser.Albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        insertByLikedCountPhotos(photo);
                        insertLikedFriend(photo);
                    }
                }

                insretTopLikedFriends();
                TopPhotos = m_SortPhotos;
            }
            catch (Exception)
            {
                throw;
            }     
        }

        private void insretTopLikedFriends()
        {
            m_ListOfBestFriends = new LinkedList<string>(); 
            int maxValue = 0;
            User topLikedFriend = null;

                for (int i = 0; i < 5; i++)
                {
                    foreach (KeyValuePair<User, int> user in m_TopLikedFriends)
                    {
                        if (maxValue < user.Value)
                        {
                            maxValue = user.Value;
                            topLikedFriend = user.Key;
                        }
                    }

                    maxValue = 0;
                    m_ListOfBestFriends.AddLast(topLikedFriend.Name);
                    m_TopLikedFriends.Remove(topLikedFriend);
                }
        }

        private void insertLikedFriend(Photo i_Photo)
        {
            try
            {
                foreach (User user in i_Photo.LikedBy)
                {
                    if (m_TopLikedFriends.ContainsKey(user))
                    {
                        m_TopLikedFriends[user]++;
                    }
                    else
                    {
                        m_TopLikedFriends.Add(user, 1);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void insertByLikedCountPhotos(Photo i_Photo)
        {
            int index = 0;
            Photo[] photoToAdd = { i_Photo };

            for(int i = 0; i < m_SortPhotos.Count; i++)
            {
                if (i_Photo.LikedBy.Count <= m_SortPhotos[i].LikedBy.Count)
                {
                    index = i + 1;
                }

                m_SortPhotos.InsertRange(index, photoToAdd);
            }
        }

        public IIterator CreateIterator()
        {
            return new TopLikedFriendsIterator(m_ListOfBestFriends);
        }
    }
}
