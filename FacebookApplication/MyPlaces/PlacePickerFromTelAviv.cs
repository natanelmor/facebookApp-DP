using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    class PlacePickerFromTelAviv : IPlacePicker
    {
        public bool pickPlace(Page i_place)
        {
            bool pick = false;
            if(i_place !=null)
            {
                if (i_place.Location.City == "Tel Aviv")
                {
                    pick = true;
                }
            }
            return pick;
        }
    }
}
