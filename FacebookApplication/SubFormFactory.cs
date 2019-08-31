using System.Windows.Forms;

namespace FacebookApplication
{
    public static class SubFormFactory
    {
        public enum eSubFormTypes
        {
            PostPreview,
            PhotoPreview,
            PhotoUpload
        }

        public static Form CreateForm(eSubFormTypes i_SubFormType)
        {
            Form subForm = null;

            switch (i_SubFormType)
            {
                case eSubFormTypes.PostPreview:
                    {
                        subForm = new SubFormPostPreview();
                        break;
                    }

                case eSubFormTypes.PhotoPreview:
                    {
                        subForm = new SubFormPhotoPreview();
                        break;
                    }

                case eSubFormTypes.PhotoUpload:
                    {
                        subForm = new SubFormPhotoUpload();
                        break;
                    }
            }

            return subForm;
        }
    }
}
