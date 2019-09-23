using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    interface ISubject
    {
        void Attach(ILastInteractionObserver i_ObserverToAttach);

        void Detach(ILastInteractionObserver i_ObserverToDetach);

        void Notify();
    }
}
