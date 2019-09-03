using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApplication
{
    public class MapAlreadyInitializedException : Exception
    {
        public MapAlreadyInitializedException(string i_Message) : base(i_Message)
        {
        }
    }
}
