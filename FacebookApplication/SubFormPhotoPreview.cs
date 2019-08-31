using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication
{
    public partial class SubFormPhotoPreview : Form
    {
        public SubFormPhotoPreview()
        {
            InitializeComponent();
        }

        public void InitializeSubForm(Photo i_PhotoToPreview)
        {
            if (i_PhotoToPreview.Name == null)
            {
                this.Text = "Photo Preview";
            }
            else
            {
                this.Text = i_PhotoToPreview.Name;
            }

            pictureBoxPreview.ImageLocation = i_PhotoToPreview.PictureNormalURL;
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
