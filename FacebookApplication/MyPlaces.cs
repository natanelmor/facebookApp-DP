using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;


namespace FacebookApplication
{
    internal class MyPlaces
    {
        private bool m_MapDisplayed;
        private GMapControl m_Map;
        private FacebookObjectCollection<Checkin> m_checkins;
        private FacebookObjectCollection<Photo> m_photosTaggedIn;
        private FacebookWrapper.ObjectModel.Location m_currLocation;

        internal MyPlaces(GMapControl i_Map, 
                          FacebookObjectCollection<Checkin> i_checkins, 
                          FacebookObjectCollection<Photo> i_photosTaggedIn, 
                          FacebookWrapper.ObjectModel.Location i_currLocation)
        {

            m_MapDisplayed = false;
            m_Map = i_Map;
            m_checkins = i_checkins;
            m_photosTaggedIn = i_photosTaggedIn;
            m_currLocation = i_currLocation;

        }

        internal bool MapDisplayed
        {
            get
            {
                return m_MapDisplayed;
            }

            set
            {
                m_MapDisplayed = value;
            }
        }

        internal GMapControl MyPlacesMap
        {
            get
            {
                return this.m_Map;
            }

            set
            {
                this.m_Map = value;
            }
        }

        internal void ShowMyPlaces()
        {
            if (m_MapDisplayed)
            {
                throw new MapAlreadyInitializedException("Map has already been initialized. Please clean it.");
            }
            else
            {
                BuildMap();
                m_MapDisplayed = true;
            }
        }

        private void BuildMap()
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker;

            foreach (Checkin checkin in m_checkins)
            {
                marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(
                    checkin.Place.Location.Latitude.Value, checkin.Place.Location.Longitude.Value),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green_pushpin);
                marker.ToolTipText = checkin.Name;
                markersOverlay.Markers.Add(marker);
            }

            foreach (Photo photo in m_photosTaggedIn)
            {
                if (photo.Place != null)
                {
                    marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(
                    photo.Place.Location.Latitude.Value, photo.Place.Location.Longitude.Value),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                    marker.ToolTipText = photo.Name;
                    markersOverlay.Markers.Add(marker);
                }
            }

            if (m_currLocation != null)
            {
                    marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(
                    m_currLocation.Latitude.Value, m_currLocation.Longitude.Value),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.pink_pushpin);
                    marker.ToolTipText = "My current location";
                    markersOverlay.Markers.Add(marker);
                
            }

            m_Map.Overlays.Add(markersOverlay);
        }

        internal void ClearMap()
        {
            reInitializeMap();
        }

        private void reInitializeMap()
        {
            foreach (GMapOverlay overlay in m_Map.Overlays)
            {
                overlay.Clear();
            }

            m_MapDisplayed = false;
        }

    }
}
