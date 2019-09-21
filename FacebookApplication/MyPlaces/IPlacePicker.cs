using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    interface IPlacePicker
    {
        bool pickPlace(Page i_place);
    }
}
