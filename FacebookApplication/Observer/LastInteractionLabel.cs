using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacebookApplication 
{
    class LastInteractionLabel : Label, ILastInteractionObserver
    {
        public void Update(string i_Interaction)
        {
            Console.WriteLine(this.Text);
            this.Text = i_Interaction;
        }
    }
}
