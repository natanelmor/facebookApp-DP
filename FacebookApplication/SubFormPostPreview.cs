using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class SubFormPostPreview : Form
    {
        public SubFormPostPreview()
        {
            InitializeComponent();
        }

        public void InitializeSubForm(Post i_PostToPreview)
        {
            labelByInfo.Text = i_PostToPreview.From.Name;
            labelTimeInfo.Text = i_PostToPreview.CreatedTime.HasValue ? i_PostToPreview.CreatedTime.Value.ToString("dddd, dd MMMM yyyy HH:mm:ss") : string.Empty;
            labelContentInfo.Text = i_PostToPreview.Message;
            pictureBoxProfilePicture.ImageLocation = i_PostToPreview.From.PictureNormalURL;
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
