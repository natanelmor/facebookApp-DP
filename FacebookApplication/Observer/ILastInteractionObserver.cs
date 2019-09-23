using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    interface ILastInteractionObserver
    {
        void Update(string i_Interaction);
    }
}
