using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    class PlacePickerFromIsrael : IPlacePicker
    {
        public bool pickPlace(Page i_place)
        {
            bool pick = false;
            if (i_place != null)
            {
                if (i_place.Location.Country == "Israel")
                {
                    pick = true;
                }
            }
            return pick;
        }
    }
}
