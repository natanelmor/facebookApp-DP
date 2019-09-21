using System;
using System.Collections.Generic;
using System.Linq;

namespace FacebookApplication
{
    public class TopLikedFriendsIterator : IIterator
    {
        private LinkedList<string> m_TopLikedFriendsCollection;
        private int m_CurrentIdx = -1;
        private int m_Count = -1;

        public TopLikedFriendsIterator(LinkedList<string> i_Collection)
        {
            m_TopLikedFriendsCollection = i_Collection;
            m_Count = i_Collection.Count;
        }

        public bool MoveNext()
        {
            if (m_Count != m_TopLikedFriendsCollection.Count)
            {
                throw new Exception("Collection cannot be changed during iteration!");
            }

            if (m_CurrentIdx >= m_Count)
            {
                throw new Exception("Already reached the end of the collection");
            }

            return ++m_CurrentIdx < m_TopLikedFriendsCollection.Count;
        }

        public object Current
        {
            get { return m_TopLikedFriendsCollection.ElementAt(m_CurrentIdx); }
        }

        public void Reset()
        {
            m_CurrentIdx = -1;
        }
    }
}
