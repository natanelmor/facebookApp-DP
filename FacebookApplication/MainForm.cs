using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text;
using System.Threading;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace FacebookApplication
{
    public sealed partial class MainForm : Form
    {
        private static MainForm s_Instance = null;
        private static object s_LockObj = new Object();
        private User m_FacebookUser;
        private Settings m_Settings;
        private MyPlaces m_MyPlaces;
        private TopLikedPhotos m_TopLikedPhotos;
        private SubFormPostPreview m_SubFormPostPreview;
        private Thread m_PostPreviewThread;
        private SubFormPhotoPreview m_SubFormPhotoPreview;
        private Thread m_PhotoPreviewThread;
        private SubFormPhotoUpload m_SubFormPhotoUpload;
        private Thread m_PhotoUploadThread;

        private MainForm()
        {
            InitializeComponent();
            addObserversToNotifiers();
            m_SubFormPhotoPreview = SubFormFactory.CreateForm(SubFormFactory.eSubFormTypes.PhotoPreview) as SubFormPhotoPreview;
            m_SubFormPostPreview = SubFormFactory.CreateForm(SubFormFactory.eSubFormTypes.PostPreview) as SubFormPostPreview;
            m_SubFormPhotoUpload = SubFormFactory.CreateForm(SubFormFactory.eSubFormTypes.PhotoUpload) as SubFormPhotoUpload;
        }

        public static MainForm Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock(s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new MainForm();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            m_Settings = Settings.LoadFromFile();

            if (m_Settings.RememberMe && !string.IsNullOrEmpty(m_Settings.AccessToken))
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Size = m_Settings.WindowSize;
                this.Location = m_Settings.WindowLocation;
                LoginResult result = FacebookService.Connect(m_Settings.AccessToken);
                m_FacebookUser = result.LoggedInUser;
                checkBoxRememberMe.Checked = true;
                reloadUI();

            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_FacebookUser != null)
            {
                m_Settings.SaveToFile();
                FacebookService.Logout(logout_Operations);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLoginLogout.Notify();
            LoginResult result = FacebookService.Login(
            "1201096130063323",
            "email",
            "user_posts",
            "user_friends",
            "user_likes",
            "user_photos",
            "user_events",
            "user_birthday",
            "user_location",
            "user_gender",
            "user_tagged_places");

            m_Settings.AccessToken = result.AccessToken;

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_FacebookUser = result.LoggedInUser;
                reloadUI();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void reloadUI()
        {
            pictureBoxProfilePic.ImageLocation = m_FacebookUser.PictureNormalURL;
            pictureBoxProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Text = string.Format("Facebook - {0}", m_FacebookUser.Name);
            buttonLoginLogout.Click -= buttonLogin_Click;
            buttonLoginLogout.Click += buttonLogout_Click;
            buttonLoginLogout.Text = "Logout";
            makeButtonsEnabled(true);
            loadAbout();
            loadMyPosts();
            loadAlbums();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLoginLogout.Notify();
            FacebookService.Logout(logout_Operations);
        }

        private void logout_Operations()
        {
            this.Text = "Facebook";
            pictureBoxProfilePic.ImageLocation = null;
            buttonLoginLogout.Click += buttonLogin_Click;
            buttonLoginLogout.Text = "Login";
            buttonLoginLogout.Click -= buttonLogout_Click;
            clearAbout();
            clearMyPosts();
            clearPhotos();
            listBoxFriends.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxMyEvents.Items.Clear();


            clearTopLikedPhotos();

            makeButtonsEnabled(false);
            if (m_MyPlaces != null)
            {
                m_MyPlaces.ClearMap();
            }
        }

        private void makeButtonsEnabled(bool i_IsButtonEnabled)
        {
            buttonRefreshAlbums.Enabled = i_IsButtonEnabled;
            buttonShareMyPost.Enabled = i_IsButtonEnabled;
            buttonRefreshPosts.Enabled = i_IsButtonEnabled;
            buttonLoadEvents.Enabled = i_IsButtonEnabled;
            buttonRefreshFriends.Enabled = i_IsButtonEnabled;
            buttonRefreshPages.Enabled = i_IsButtonEnabled;
            buttonCreateAlbum.Enabled = i_IsButtonEnabled;
            buttonDeletePost.Enabled = i_IsButtonEnabled;
            buttonUploadPhoto.Enabled = i_IsButtonEnabled;
            buttonPostShowMoreDetails.Enabled = i_IsButtonEnabled;
            buttonShowMyPlaces.Enabled = i_IsButtonEnabled;
            buttonClearMyPlaces.Enabled = i_IsButtonEnabled;
            checkBoxcheckins.Enabled = i_IsButtonEnabled;
            checkBoxTagedPlaces.Enabled = i_IsButtonEnabled;
            checkBoxCurrentLocation.Enabled = i_IsButtonEnabled;
            buttonGetTop.Enabled = i_IsButtonEnabled;

        }

        private void addObserversToNotifiers()
        {
            buttonLoginLogout.Attach(this.lastClickLabel);
            buttonRefreshAlbums.Attach(this.lastClickLabel);
            buttonShareMyPost.Attach(this.lastClickLabel);
            buttonRefreshPosts.Attach(this.lastClickLabel);
            buttonLoadEvents.Attach(this.lastClickLabel);
            buttonRefreshFriends.Attach(this.lastClickLabel);
            buttonRefreshPages.Attach(this.lastClickLabel);
            buttonCreateAlbum.Attach(this.lastClickLabel);
            buttonDeletePost.Attach(this.lastClickLabel);
            buttonUploadPhoto.Attach(this.lastClickLabel);
            buttonPostShowMoreDetails.Attach(this.lastClickLabel);
            buttonShowMyPlaces.Attach(this.lastClickLabel);
            buttonClearMyPlaces.Attach(this.lastClickLabel);
            buttonGetTop.Attach(this.lastClickLabel);
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            m_Settings.RememberMe = checkBoxRememberMe.Checked;
            m_Settings.WindowSize = this.Size;
            m_Settings.WindowLocation = this.Location;
        }

        private void loadAbout()
        {
            facebookUserBindingSource.DataSource = m_FacebookUser;
        }

        private void clearAbout()
        {
           facebookUserBindingSource.Clear();
        }

        private void loadMyPosts()
        {
            m_FacebookUser.ReFetch();
            listBoxMyPosts.Items.Clear();
            listBoxMyPosts.DisplayMember = "Message";

            foreach (Post post in m_FacebookUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxMyPosts.Items.Add(post);
                }
            }

            if (m_FacebookUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
            }
        }

        private void Map_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(32.046440, 34.759790);
            map.Zoom = 10;
        }

        private void sharePost()
        {
            try
            {
                m_FacebookUser.PostStatus(textBoxPost.Text);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Sorry, there is no permission to share a post from this application.");
            }
            finally
            {
                textBoxPost.Text = string.Empty;
            }
        }

        private void deletePost()
        {
            if (listBoxMyPosts.SelectedItem != null)
            {
                try
                {
                    m_FacebookUser.Posts[listBoxMyPosts.SelectedIndex].Delete();
                }
                catch (FacebookOAuthException)
                {
                    MessageBox.Show("Authentication error. Cannot delete a post for current user to Facebook.");
                }
            }
            else
            {
                MessageBox.Show("Post doesn't exist.");
            }

            loadMyPosts();
        }

        private void clearMyPosts()
        {
            listBoxMyPosts.Items.Clear();
            textBoxPost.Text = string.Empty;
        }

        private void loadAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (Album albums in m_FacebookUser.Albums)
            {
                listBoxAlbums.Items.Add(albums);
            }
        }

        private void createAlbum()
        {
            string inputAlbumName = Microsoft.VisualBasic.Interaction.InputBox("Please enter an album name:");
            try
            {
                m_FacebookUser.CreateAlbum(inputAlbumName);
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot create an album for current user on Facebook.");
            }
        }

        private void uploadPhoto()
        {
            try
            {
                if (listBoxAlbums.SelectedItem != null)
                {
                    var FD = new OpenFileDialog();
                    FD.Filter = "Image Files(*.JPG)| *.JPG";
                    if (FD.ShowDialog() == DialogResult.OK)
                    {
                        (listBoxAlbums.SelectedItem as Album).UploadPhoto(FD.FileName);
                    }
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot upload a photo for current user to Facebook.");
            }
        }

        private void clearPhotos()
        {
            listBoxAlbums.Items.Clear();
            listBoxPhoto.Items.Clear();
            pictureBoxPhoto.ImageLocation = null;
        }

        private void loadFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            foreach (User friend in m_FacebookUser.Friends)
            {
                listBoxFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_FacebookUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve.");
            }
        }

        private void loadPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page userLikedPage in m_FacebookUser.LikedPages)
                {
                    listBoxPages.Items.Add(userLikedPage);
                }

                if (m_FacebookUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve.");
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot fetch liked pages for current user from Facebook.");
            }
        }

        private void loadEvents()
        {
            listBoxMyEvents.Items.Clear();
            listBoxMyEvents.DisplayMember = "Name";

            try
            {
                foreach (Event userEvent in m_FacebookUser.Events)
                {
                    listBoxMyEvents.Items.Add(userEvent);
                }

                if (m_FacebookUser.Events.Count == 0)
                {
                    MessageBox.Show("No Events to retrieve.");
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot fetch events for current user from Facebook.");
            }
        }

        private void buttonRefreshPosts_Click(object sender, EventArgs e)
        {
            buttonRefreshPosts.Notify();
            loadMyPosts();
        }

        private void buttonShareMyPost_Click(object sender, EventArgs e)
        {
            buttonShareMyPost.Notify();
            sharePost();
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            buttonDeletePost.Notify();
            deletePost();
        }

        private void buttonRefreshAlbums_Click(object sender, EventArgs e)
        {
            buttonRefreshAlbums.Notify();
            loadAlbums();
        }

        private void listBoxPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPhoto.SelectedItem != null)
            {
                pictureBoxPhoto.ImageLocation = (listBoxPhoto.SelectedItem as Photo).PictureNormalURL;
                pictureBoxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                labelPhotoDescription.Text = (listBoxPhoto.SelectedItem as Photo).Message;
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPhoto.Items.Clear();
            listBoxPhoto.DisplayMember = "Name";

            foreach (Photo photo in (listBoxAlbums.SelectedItem as Album).Photos)
            {
                listBoxPhoto.Items.Add(photo);
            }
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            buttonCreateAlbum.Notify();
            createAlbum();
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            buttonUploadPhoto.Notify();
            if (listBoxAlbums.SelectedItem != null)
            {
                startPhotoUploadFormThread(listBoxAlbums.SelectedItem as Album);
            }
        }

        private void buttonRefreshFriends_Click(object sender, EventArgs e)
        {
            buttonRefreshFriends.Notify();
            loadFriends();
        }

        private void listBoxFriends_SelectedValueChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            User friend = listBoxFriends.SelectedItem as User;
            pictureBoxFriendPicture.ImageLocation = friend.PictureNormalURL;
            pictureBoxFriendPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.labelFriendFirstNameInfo.Text = friend.FirstName;
            this.labelFriendLastNameInfo.Text = friend.LastName;
            this.labelFriendGenderInfo.Text = friend.Gender == User.eGender.female ? "Female" : "Male";
        }

        private void buttonLoadPages_Click(object sender, EventArgs e)
        {
            buttonRefreshPages.Notify();
            loadPages();
        }

        private void buttonLoadEvents_Click(object sender, EventArgs e)
        {
            buttonLoadEvents.Notify();
            loadEvents();
        }

        private void buttonGetTop_Click(object sender, EventArgs e)
        {
            buttonGetTop.Notify();
            topLikedPhotos();
        }

        private void topLikedPhotos()
        {
            try
            {
                if (m_TopLikedPhotos == null)
                {
                    m_TopLikedPhotos = new TopLikedPhotos(m_FacebookUser);
                }

                m_TopLikedPhotos.CheckYourTopLikedPhotos(m_FacebookUser);

                IIterator TopFriendsIterator = m_TopLikedPhotos.CreateIterator();

                while (TopFriendsIterator.MoveNext())
                {
                    listBoxTopFriends.Items.Add(TopFriendsIterator.Current as string);
                }

                insretTop6Photo(m_TopLikedPhotos.TopPhotos);
            }
            catch (Exception)
            {
                MessageBox.Show("Authentication error");
            } 
        }

        private void insretTop6Photo(List<Photo> i_Photos)
        {
            try
            {
                pictureBoxTop1.ImageLocation = i_Photos[0].PictureThumbURL;
                pictureBoxTop1.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes1.Text = i_Photos[0].LikedBy.Count.ToString() + " Likes";

                pictureBoxTop2.ImageLocation = i_Photos[1].PictureThumbURL;
                pictureBoxTop2.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes2.Text = i_Photos[1].LikedBy.Count.ToString() + " Likes";

                pictureBoxTop3.ImageLocation = i_Photos[2].PictureThumbURL;
                pictureBoxTop3.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes3.Text = i_Photos[2].LikedBy.Count.ToString() + " Likes";

                pictureBoxTop4.ImageLocation = i_Photos[3].PictureThumbURL;
                pictureBoxTop4.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes4.Text = i_Photos[3].LikedBy.Count.ToString() + " Likes";

                pictureBoxTop5.ImageLocation = i_Photos[4].PictureThumbURL;
                pictureBoxTop5.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes5.Text = i_Photos[4].LikedBy.Count.ToString() + " Likes";

                pictureBoxTop6.ImageLocation = i_Photos[5].PictureThumbURL;
                pictureBoxTop6.SizeMode = PictureBoxSizeMode.StretchImage;
                textBoxLikes6.Text = i_Photos[5].LikedBy.Count.ToString() + " Likes";
            }
            catch (Exception)
            {

            }
        }

        private void clearTopLikedPhotos()
        {
            pictureBoxTop1.ImageLocation = null;
            pictureBoxTop2.ImageLocation = null;
            pictureBoxTop3.ImageLocation = null;
            pictureBoxTop4.ImageLocation = null;
            pictureBoxTop5.ImageLocation = null;
            pictureBoxTop6.ImageLocation = null;

            textBoxLikes1.Text = string.Empty;
            textBoxLikes2.Text = string.Empty;
            textBoxLikes3.Text = string.Empty;
            textBoxLikes4.Text = string.Empty;
            textBoxLikes5.Text = string.Empty;
            textBoxLikes6.Text = string.Empty;
        }

        private void buttonTaggedPlaces_Click(object sender, EventArgs e)
        {
            buttonShowMyPlaces.Notify();
            FacebookObjectCollection<Checkin> checkins = null;
            FacebookObjectCollection<Photo> photosTaggedIn = null;
            FacebookWrapper.ObjectModel.Location currLocation = null;
            IPlacePicker placePicker = new PlacePickerAll();

            if ((string)SelectPlacesFrom.SelectedItem == "Jerusalem")
            {
                placePicker = new PlacePickerFromJerusalem();
            }
            else if ((string)SelectPlacesFrom.SelectedItem == "Tel Aviv")
            {
                placePicker = new PlacePickerFromTelAviv();
            }
            else if ((string)SelectPlacesFrom.SelectedItem == "Israel")
            {
                placePicker = new PlacePickerFromIsrael();
            }
            
            if (checkBoxcheckins.Checked == true)
            {
                checkins = m_FacebookUser.Checkins;
            }

            if (checkBoxTagedPlaces.Checked == true)
            {
                photosTaggedIn = m_FacebookUser.PhotosTaggedIn;
            }

            if (checkBoxCurrentLocation.Checked == true)
            {
                currLocation = m_FacebookUser.Location.Location;
            }

            if (m_MyPlaces == null)
            {

                m_MyPlaces = new MyPlaces(this.map, checkins, photosTaggedIn, currLocation, placePicker);
            }

            try
            {
                m_MyPlaces.ShowMyPlaces();
            }
            catch (MapAlreadyInitializedException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonClearMyPlaces_Click(object sender, EventArgs e)
        {
            buttonClearMyPlaces.Notify();
            if (m_MyPlaces != null)
            {
                m_MyPlaces.ClearMap();
            }
        }

        private void startPostPreviewFormThread(Post i_PostToPreview)
        {
            if (m_PostPreviewThread == null || !m_PostPreviewThread.IsAlive)
            {
                m_PostPreviewThread = new Thread(new ParameterizedThreadStart(showSubFormPostPreview));
                m_PostPreviewThread.Start(i_PostToPreview);
            }
            else
            {
                m_SubFormPostPreview.InitializeSubForm(i_PostToPreview);
            }
        }

        private void showSubFormPostPreview(object i_PostToPreview)
        {
            m_SubFormPostPreview.InitializeSubForm(i_PostToPreview as Post);
            m_SubFormPostPreview.ShowDialog();
        }


        private void startPhotoPreviewFormThread(Photo i_PhotoToPreview)
        {
            if (m_PhotoPreviewThread == null || !m_PhotoPreviewThread.IsAlive)
            {
                m_PhotoPreviewThread = new Thread(new ParameterizedThreadStart(showSubFormPhotoPreview));
                m_PhotoPreviewThread.Start(i_PhotoToPreview);
            }
            else
            {
                m_SubFormPhotoPreview.InitializeSubForm(i_PhotoToPreview);
            }
        }

        private void showSubFormPhotoPreview(object i_PhotoToPreview)
        {
            m_SubFormPhotoPreview.InitializeSubForm(i_PhotoToPreview as Photo);
            m_SubFormPhotoPreview.ShowDialog();
        }

        private void startPhotoUploadFormThread(Album i_AlbumToUpload)
        {
            if (m_PhotoUploadThread == null || !m_PhotoUploadThread.IsAlive)
            {
                m_PhotoUploadThread = new Thread(new ParameterizedThreadStart(showSubFormPhotoUpload));
                m_PhotoUploadThread.Start(i_AlbumToUpload);
            }
            else
            {
                m_SubFormPhotoUpload.Album = i_AlbumToUpload;
            }
        }

        private void showSubFormPhotoUpload(object i_AlbumToUpload)
        {
            m_SubFormPhotoUpload.Album = i_AlbumToUpload as Album;
            m_SubFormPhotoUpload.ShowDialog();
        }

        private void buttonPostShowMoreDetails_Click(object sender, EventArgs e)
        {
            buttonPostShowMoreDetails.Notify();
            if (listBoxMyPosts.SelectedItem != null)
            {
                startPostPreviewFormThread(listBoxMyPosts.SelectedItem as Post);
            }
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {
            if (listBoxPhoto.SelectedItem != null)
            {
                startPhotoPreviewFormThread(listBoxPhoto.SelectedItem as Photo);
            }
        }
    }
}