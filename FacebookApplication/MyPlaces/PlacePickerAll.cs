using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    class PlacePickerAll : IPlacePicker
    {
        public bool pickPlace(Page i_place)
        {
            bool pick = false;
            if (i_place != null)
            {
                pick = true;
            }
            return pick;
        }


    }
}
