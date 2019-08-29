using System;
using System.Windows.Forms;
using System.Threading;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class SubFormPhotoUpload : Form
    {
        private Album m_Album;
        private Thread m_FileDialogThread;
        private bool m_IsDialogOK;

        public SubFormPhotoUpload()
        {
            InitializeComponent();
            m_IsDialogOK = false;
        }

        public Album Album
        {
            set
            {
                m_Album = value;
            }
        }

        private void startBrowsePhotosThread(FileDialog i_FileDialog)
        {
            if (m_FileDialogThread == null || !m_FileDialogThread.IsAlive)
            {
                m_FileDialogThread = new Thread(new ParameterizedThreadStart(browsePhotos));
                m_FileDialogThread.SetApartmentState(ApartmentState.STA);
                m_FileDialogThread.Start(i_FileDialog);
                m_FileDialogThread.Join();
            }
            else
            {
                browsePhotos(i_FileDialog);
            }
        }

        private void browsePhotos(object i_FileDialog)
        {
            if ((i_FileDialog as FileDialog).ShowDialog() == DialogResult.OK)
            {
                m_IsDialogOK = true;
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.JPG)| *.JPG";
            startBrowsePhotosThread(fileDialog);

            if (m_IsDialogOK)
            {
                textBoxFilePath.Enabled = false;
                textBoxFilePath.Text = fileDialog.FileName;
                buttonUpload.Enabled = true;
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_Album != null)
                {
                    m_Album.UploadPhoto(textBoxFilePath.Text);
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Authentication error. Cannot upload a photo for current user to Facebook.");
            }
        }
    }
}
