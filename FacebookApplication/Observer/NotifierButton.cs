using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FacebookApplication
{
    class NotifierButton : Button, ISubject
    {
        private List<ILastInteractionObserver> m_LastInteractionObservers;

        public NotifierButton()
        {
            m_LastInteractionObservers = new List<ILastInteractionObserver>();
        }

        public void Attach(ILastInteractionObserver i_ObserverToAttach)
        {
            m_LastInteractionObservers.Add(i_ObserverToAttach);
        }

        public void Detach(ILastInteractionObserver i_ObserverToDetach)
        {
            m_LastInteractionObservers.Remove(i_ObserverToDetach);
        }

        public void Notify()
        {
            foreach (ILastInteractionObserver lastInteractionObserver in m_LastInteractionObservers)
            {
                lastInteractionObserver.Update(this.Text);
            }

        }
    }
}
