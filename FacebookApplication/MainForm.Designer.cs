namespace FacebookApplication
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCreditMessage = new System.Windows.Forms.Label();
            this.labelCredit = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.buttonLoginLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.buttonDeletePost = new System.Windows.Forms.Button();
            this.buttonShareMyPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonRefreshPosts = new System.Windows.Forms.Button();
            this.listBoxMyPosts = new System.Windows.Forms.ListBox();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.labelPhotoDescription = new System.Windows.Forms.Label();
            this.labelPreview = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.buttonUploadPhoto = new System.Windows.Forms.Button();
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxPhoto = new System.Windows.Forms.ListBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.buttonRefreshAlbums = new System.Windows.Forms.Button();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFriendLastNameInfo = new System.Windows.Forms.Label();
            this.pictureBoxFriendPicture = new System.Windows.Forms.PictureBox();
            this.labelFriendFirstNameInfo = new System.Windows.Forms.Label();
            this.labelFriendGenderInfo = new System.Windows.Forms.Label();
            this.labelFriendGender = new System.Windows.Forms.Label();
            this.labelFriendFirstName = new System.Windows.Forms.Label();
            this.labelFriendLastName = new System.Windows.Forms.Label();
            this.labelSelectedFriendInformation = new System.Windows.Forms.Label();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.buttonRefreshFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPageLikes = new System.Windows.Forms.TabPage();
            this.pictureBoxPages = new System.Windows.Forms.PictureBox();
            this.buttonRefreshPages = new System.Windows.Forms.Button();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.pictureBoxCalendar = new System.Windows.Forms.PictureBox();
            this.buttonLoadEvents = new System.Windows.Forms.Button();
            this.listBoxMyEvents = new System.Windows.Forms.ListBox();
            this.tabTaggedPlaces = new System.Windows.Forms.TabPage();
            this.checkBoxCurrentLocation = new System.Windows.Forms.CheckBox();
            this.checkBoxTagedPlaces = new System.Windows.Forms.CheckBox();
            this.checkBoxcheckins = new System.Windows.Forms.CheckBox();
            this.buttonClearMyPlaces = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.buttonShowMyPlaces = new System.Windows.Forms.Button();
            this.labelTaggedPlacesTitle = new System.Windows.Forms.Label();
            this.tabTopLikedPhotos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTopFriends = new System.Windows.Forms.ListBox();
            this.textBoxLikes2 = new System.Windows.Forms.TextBox();
            this.textBoxLikes3 = new System.Windows.Forms.TextBox();
            this.textBoxLikes4 = new System.Windows.Forms.TextBox();
            this.textBoxLikes5 = new System.Windows.Forms.TextBox();
            this.textBoxLikes6 = new System.Windows.Forms.TextBox();
            this.textBoxLikes1 = new System.Windows.Forms.TextBox();
            this.buttonGetTop = new System.Windows.Forms.Button();
            this.pictureBoxTop6 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxTop1 = new System.Windows.Forms.PictureBox();
            this.labelNumberOfConnectedFriendsInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelGenderInfo = new System.Windows.Forms.Label();
            this.labelBirthdayInfo = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLocationInfo = new System.Windows.Forms.Label();
            this.labelEmailInfo = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastNameInfo = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstNameInfo = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPosts.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.tabFriends.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).BeginInit();
            this.tabPageLikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).BeginInit();
            this.tabTaggedPlaces.SuspendLayout();
            this.tabTopLikedPhotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.labelCreditMessage);
            this.panel1.Controls.Add(this.labelCredit);
            this.panel1.Controls.Add(this.checkBoxRememberMe);
            this.panel1.Controls.Add(this.pictureBoxFacebookLogo);
            this.panel1.Controls.Add(this.buttonLoginLogout);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 363);
            this.panel1.TabIndex = 4;
            // 
            // labelCreditMessage
            // 
            this.labelCreditMessage.AutoSize = true;
            this.labelCreditMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCreditMessage.Location = new System.Drawing.Point(41, 326);
            this.labelCreditMessage.Name = "labelCreditMessage";
            this.labelCreditMessage.Size = new System.Drawing.Size(52, 12);
            this.labelCreditMessage.TabIndex = 16;
            this.labelCreditMessage.Text = "Made by:";
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCredit.Location = new System.Drawing.Point(8, 340);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(96, 12);
            this.labelCredit.TabIndex = 15;
            this.labelCredit.Text = "Elior Paz & Natanel Mor";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(10, 187);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBoxRememberMe.TabIndex = 5;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebookLogo.Image")));
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(8, 8);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(129, 133);
            this.pictureBoxFacebookLogo.TabIndex = 14;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // buttonLoginLogout
            // 
            this.buttonLoginLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoginLogout.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonLoginLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoginLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoginLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoginLogout.Location = new System.Drawing.Point(6, 147);
            this.buttonLoginLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoginLogout.Name = "buttonLoginLogout";
            this.buttonLoginLogout.Size = new System.Drawing.Size(131, 35);
            this.buttonLoginLogout.TabIndex = 0;
            this.buttonLoginLogout.Text = "Login";
            this.buttonLoginLogout.UseVisualStyleBackColor = false;
            this.buttonLoginLogout.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Location = new System.Drawing.Point(145, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 361);
            this.panel2.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPosts);
            this.tabControl.Controls.Add(this.tabPhotos);
            this.tabControl.Controls.Add(this.tabFriends);
            this.tabControl.Controls.Add(this.tabPageLikes);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabTaggedPlaces);
            this.tabControl.Controls.Add(this.tabTopLikedPhotos);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(690, 361);
            this.tabControl.TabIndex = 3;
            // 
            // tabPosts
            // 
            this.tabPosts.BackColor = System.Drawing.SystemColors.Control;
            this.tabPosts.Controls.Add(this.buttonDeletePost);
            this.tabPosts.Controls.Add(this.buttonShareMyPost);
            this.tabPosts.Controls.Add(this.textBoxPost);
            this.tabPosts.Controls.Add(this.buttonRefreshPosts);
            this.tabPosts.Controls.Add(this.listBoxMyPosts);
            this.tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPosts.Margin = new System.Windows.Forms.Padding(2);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(2);
            this.tabPosts.Size = new System.Drawing.Size(682, 335);
            this.tabPosts.TabIndex = 1;
            this.tabPosts.Text = "Posts";
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonDeletePost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeletePost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletePost.Enabled = false;
            this.buttonDeletePost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeletePost.Location = new System.Drawing.Point(546, 285);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(123, 31);
            this.buttonDeletePost.TabIndex = 4;
            this.buttonDeletePost.Text = "Delete Selected Post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // buttonShareMyPost
            // 
            this.buttonShareMyPost.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonShareMyPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShareMyPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShareMyPost.Enabled = false;
            this.buttonShareMyPost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShareMyPost.Location = new System.Drawing.Point(588, 4);
            this.buttonShareMyPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShareMyPost.Name = "buttonShareMyPost";
            this.buttonShareMyPost.Size = new System.Drawing.Size(81, 37);
            this.buttonShareMyPost.TabIndex = 3;
            this.buttonShareMyPost.Text = "Share Post";
            this.buttonShareMyPost.UseVisualStyleBackColor = true;
            this.buttonShareMyPost.Click += new System.EventHandler(this.buttonShareMyPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(6, 4);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(568, 60);
            this.textBoxPost.TabIndex = 2;
            // 
            // buttonRefreshPosts
            // 
            this.buttonRefreshPosts.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonRefreshPosts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshPosts.Enabled = false;
            this.buttonRefreshPosts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefreshPosts.Location = new System.Drawing.Point(6, 285);
            this.buttonRefreshPosts.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshPosts.Name = "buttonRefreshPosts";
            this.buttonRefreshPosts.Size = new System.Drawing.Size(101, 31);
            this.buttonRefreshPosts.TabIndex = 1;
            this.buttonRefreshPosts.Text = "Refresh Posts";
            this.buttonRefreshPosts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRefreshPosts.UseVisualStyleBackColor = true;
            this.buttonRefreshPosts.Click += new System.EventHandler(this.buttonRefreshPosts_Click);
            // 
            // listBoxMyPosts
            // 
            this.listBoxMyPosts.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.listBoxMyPosts.FormattingEnabled = true;
            this.listBoxMyPosts.Location = new System.Drawing.Point(6, 76);
            this.listBoxMyPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMyPosts.Name = "listBoxMyPosts";
            this.listBoxMyPosts.Size = new System.Drawing.Size(663, 199);
            this.listBoxMyPosts.TabIndex = 0;
            // 
            // tabPhotos
            // 
            this.tabPhotos.BackColor = System.Drawing.SystemColors.Control;
            this.tabPhotos.Controls.Add(this.labelPhotoDescription);
            this.tabPhotos.Controls.Add(this.labelPreview);
            this.tabPhotos.Controls.Add(this.labelPhoto);
            this.tabPhotos.Controls.Add(this.buttonUploadPhoto);
            this.tabPhotos.Controls.Add(this.buttonCreateAlbum);
            this.tabPhotos.Controls.Add(this.pictureBoxPhoto);
            this.tabPhotos.Controls.Add(this.listBoxPhoto);
            this.tabPhotos.Controls.Add(this.labelAlbum);
            this.tabPhotos.Controls.Add(this.buttonRefreshAlbums);
            this.tabPhotos.Controls.Add(this.listBoxAlbums);
            this.tabPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Size = new System.Drawing.Size(682, 335);
            this.tabPhotos.TabIndex = 5;
            this.tabPhotos.Text = "Photos";
            // 
            // labelPhotoDescription
            // 
            this.labelPhotoDescription.AutoSize = true;
            this.labelPhotoDescription.Location = new System.Drawing.Point(475, 308);
            this.labelPhotoDescription.Name = "labelPhotoDescription";
            this.labelPhotoDescription.Size = new System.Drawing.Size(0, 13);
            this.labelPhotoDescription.TabIndex = 11;
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(370, 11);
            this.labelPreview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(45, 13);
            this.labelPreview.TabIndex = 10;
            this.labelPreview.Text = "Preview";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(209, 11);
            this.labelPhoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(40, 13);
            this.labelPhoto.TabIndex = 4;
            this.labelPhoto.Text = "Photos";
            // 
            // buttonUploadPhoto
            // 
            this.buttonUploadPhoto.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonUploadPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUploadPhoto.Enabled = false;
            this.buttonUploadPhoto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUploadPhoto.Location = new System.Drawing.Point(7, 292);
            this.buttonUploadPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUploadPhoto.Name = "buttonUploadPhoto";
            this.buttonUploadPhoto.Size = new System.Drawing.Size(186, 32);
            this.buttonUploadPhoto.TabIndex = 9;
            this.buttonUploadPhoto.Text = "Upload A Photo To Album";
            this.buttonUploadPhoto.UseVisualStyleBackColor = true;
            this.buttonUploadPhoto.Click += new System.EventHandler(this.buttonUploadPhoto_Click);
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonCreateAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCreateAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAlbum.Enabled = false;
            this.buttonCreateAlbum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateAlbum.Location = new System.Drawing.Point(7, 222);
            this.buttonCreateAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(186, 32);
            this.buttonCreateAlbum.TabIndex = 8;
            this.buttonCreateAlbum.Text = "Create Album";
            this.buttonCreateAlbum.UseVisualStyleBackColor = true;
            this.buttonCreateAlbum.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(373, 34);
            this.pictureBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(290, 290);
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // listBoxPhoto
            // 
            this.listBoxPhoto.FormattingEnabled = true;
            this.listBoxPhoto.Location = new System.Drawing.Point(212, 33);
            this.listBoxPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPhoto.Name = "listBoxPhoto";
            this.listBoxPhoto.Size = new System.Drawing.Size(142, 290);
            this.listBoxPhoto.TabIndex = 3;
            this.listBoxPhoto.SelectedIndexChanged += new System.EventHandler(this.listBoxPhoto_SelectedIndexChanged);
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(8, 11);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(41, 13);
            this.labelAlbum.TabIndex = 1;
            this.labelAlbum.Text = "Albums";
            // 
            // buttonRefreshAlbums
            // 
            this.buttonRefreshAlbums.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonRefreshAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshAlbums.Enabled = false;
            this.buttonRefreshAlbums.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefreshAlbums.Location = new System.Drawing.Point(7, 257);
            this.buttonRefreshAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshAlbums.Name = "buttonRefreshAlbums";
            this.buttonRefreshAlbums.Size = new System.Drawing.Size(186, 32);
            this.buttonRefreshAlbums.TabIndex = 2;
            this.buttonRefreshAlbums.Text = "Refresh Albums";
            this.buttonRefreshAlbums.UseVisualStyleBackColor = true;
            this.buttonRefreshAlbums.Click += new System.EventHandler(this.buttonRefreshAlbums_Click);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(7, 34);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(186, 173);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // tabFriends
            // 
            this.tabFriends.BackColor = System.Drawing.Color.Transparent;
            this.tabFriends.Controls.Add(this.panel3);
            this.tabFriends.Controls.Add(this.labelSelectedFriendInformation);
            this.tabFriends.Controls.Add(this.labelFriendsList);
            this.tabFriends.Controls.Add(this.buttonRefreshFriends);
            this.tabFriends.Controls.Add(this.listBoxFriends);
            this.tabFriends.Location = new System.Drawing.Point(4, 22);
            this.tabFriends.Margin = new System.Windows.Forms.Padding(2);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(2);
            this.tabFriends.Size = new System.Drawing.Size(682, 335);
            this.tabFriends.TabIndex = 0;
            this.tabFriends.Text = "Friends";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelFriendLastNameInfo);
            this.panel3.Controls.Add(this.pictureBoxFriendPicture);
            this.panel3.Controls.Add(this.labelFriendFirstNameInfo);
            this.panel3.Controls.Add(this.labelFriendGenderInfo);
            this.panel3.Controls.Add(this.labelFriendGender);
            this.panel3.Controls.Add(this.labelFriendFirstName);
            this.panel3.Controls.Add(this.labelFriendLastName);
            this.panel3.Location = new System.Drawing.Point(249, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 250);
            this.panel3.TabIndex = 7;
            // 
            // labelFriendLastNameInfo
            // 
            this.labelFriendLastNameInfo.AutoSize = true;
            this.labelFriendLastNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendLastNameInfo.Location = new System.Drawing.Point(94, 201);
            this.labelFriendLastNameInfo.Name = "labelFriendLastNameInfo";
            this.labelFriendLastNameInfo.Size = new System.Drawing.Size(0, 16);
            this.labelFriendLastNameInfo.TabIndex = 18;
            // 
            // pictureBoxFriendPicture
            // 
            this.pictureBoxFriendPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFriendPicture.Location = new System.Drawing.Point(7, 6);
            this.pictureBoxFriendPicture.Name = "pictureBoxFriendPicture";
            this.pictureBoxFriendPicture.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxFriendPicture.TabIndex = 6;
            this.pictureBoxFriendPicture.TabStop = false;
            // 
            // labelFriendFirstNameInfo
            // 
            this.labelFriendFirstNameInfo.AutoSize = true;
            this.labelFriendFirstNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendFirstNameInfo.Location = new System.Drawing.Point(95, 182);
            this.labelFriendFirstNameInfo.Name = "labelFriendFirstNameInfo";
            this.labelFriendFirstNameInfo.Size = new System.Drawing.Size(0, 16);
            this.labelFriendFirstNameInfo.TabIndex = 14;
            // 
            // labelFriendGenderInfo
            // 
            this.labelFriendGenderInfo.AutoSize = true;
            this.labelFriendGenderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendGenderInfo.Location = new System.Drawing.Point(71, 220);
            this.labelFriendGenderInfo.Name = "labelFriendGenderInfo";
            this.labelFriendGenderInfo.Size = new System.Drawing.Size(0, 16);
            this.labelFriendGenderInfo.TabIndex = 14;
            // 
            // labelFriendGender
            // 
            this.labelFriendGender.AutoSize = true;
            this.labelFriendGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendGender.Location = new System.Drawing.Point(8, 220);
            this.labelFriendGender.Name = "labelFriendGender";
            this.labelFriendGender.Size = new System.Drawing.Size(63, 16);
            this.labelFriendGender.TabIndex = 17;
            this.labelFriendGender.Text = "Gender:";
            // 
            // labelFriendFirstName
            // 
            this.labelFriendFirstName.AutoSize = true;
            this.labelFriendFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendFirstName.Location = new System.Drawing.Point(8, 182);
            this.labelFriendFirstName.Name = "labelFriendFirstName";
            this.labelFriendFirstName.Size = new System.Drawing.Size(87, 16);
            this.labelFriendFirstName.TabIndex = 12;
            this.labelFriendFirstName.Text = "First Name:";
            // 
            // labelFriendLastName
            // 
            this.labelFriendLastName.AutoSize = true;
            this.labelFriendLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendLastName.Location = new System.Drawing.Point(8, 201);
            this.labelFriendLastName.Name = "labelFriendLastName";
            this.labelFriendLastName.Size = new System.Drawing.Size(86, 16);
            this.labelFriendLastName.TabIndex = 13;
            this.labelFriendLastName.Text = "Last Name:";
            // 
            // labelSelectedFriendInformation
            // 
            this.labelSelectedFriendInformation.AutoSize = true;
            this.labelSelectedFriendInformation.Location = new System.Drawing.Point(246, 6);
            this.labelSelectedFriendInformation.Name = "labelSelectedFriendInformation";
            this.labelSelectedFriendInformation.Size = new System.Drawing.Size(136, 13);
            this.labelSelectedFriendInformation.TabIndex = 5;
            this.labelSelectedFriendInformation.Text = "Selected Friend Information";
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Location = new System.Drawing.Point(5, 6);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(60, 13);
            this.labelFriendsList.TabIndex = 4;
            this.labelFriendsList.Text = "Friends List";
            // 
            // buttonRefreshFriends
            // 
            this.buttonRefreshFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRefreshFriends.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRefreshFriends.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonRefreshFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshFriends.Enabled = false;
            this.buttonRefreshFriends.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRefreshFriends.Location = new System.Drawing.Point(35, 281);
            this.buttonRefreshFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshFriends.MaximumSize = new System.Drawing.Size(112, 45);
            this.buttonRefreshFriends.MinimumSize = new System.Drawing.Size(112, 45);
            this.buttonRefreshFriends.Name = "buttonRefreshFriends";
            this.buttonRefreshFriends.Size = new System.Drawing.Size(112, 45);
            this.buttonRefreshFriends.TabIndex = 3;
            this.buttonRefreshFriends.Text = "Refresh Friends List";
            this.buttonRefreshFriends.UseVisualStyleBackColor = false;
            this.buttonRefreshFriends.Click += new System.EventHandler(this.buttonRefreshFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 21);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(175, 251);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedValueChanged += new System.EventHandler(this.listBoxFriends_SelectedValueChanged);
            // 
            // tabPageLikes
            // 
            this.tabPageLikes.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageLikes.Controls.Add(this.pictureBoxPages);
            this.tabPageLikes.Controls.Add(this.buttonRefreshPages);
            this.tabPageLikes.Controls.Add(this.listBoxPages);
            this.tabPageLikes.Location = new System.Drawing.Point(4, 22);
            this.tabPageLikes.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageLikes.Name = "tabPageLikes";
            this.tabPageLikes.Size = new System.Drawing.Size(682, 335);
            this.tabPageLikes.TabIndex = 3;
            this.tabPageLikes.Text = "Pages";
            // 
            // pictureBoxPages
            // 
            this.pictureBoxPages.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPages.BackgroundImage = global::FacebookApplication.Properties.Resources.Pages;
            this.pictureBoxPages.Location = new System.Drawing.Point(254, 7);
            this.pictureBoxPages.Name = "pictureBoxPages";
            this.pictureBoxPages.Size = new System.Drawing.Size(128, 130);
            this.pictureBoxPages.TabIndex = 2;
            this.pictureBoxPages.TabStop = false;
            // 
            // buttonRefreshPages
            // 
            this.buttonRefreshPages.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonRefreshPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefreshPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshPages.Enabled = false;
            this.buttonRefreshPages.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRefreshPages.Location = new System.Drawing.Point(253, 289);
            this.buttonRefreshPages.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRefreshPages.Name = "buttonRefreshPages";
            this.buttonRefreshPages.Size = new System.Drawing.Size(129, 34);
            this.buttonRefreshPages.TabIndex = 1;
            this.buttonRefreshPages.Text = "Refresh Pages";
            this.buttonRefreshPages.UseVisualStyleBackColor = true;
            this.buttonRefreshPages.Click += new System.EventHandler(this.buttonLoadPages_Click);
            // 
            // listBoxPages
            // 
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(7, 7);
            this.listBoxPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(242, 316);
            this.listBoxPages.TabIndex = 0;
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabEvents.Controls.Add(this.pictureBoxCalendar);
            this.tabEvents.Controls.Add(this.buttonLoadEvents);
            this.tabEvents.Controls.Add(this.listBoxMyEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(682, 335);
            this.tabEvents.TabIndex = 4;
            this.tabEvents.Text = "Events";
            // 
            // pictureBoxCalendar
            // 
            this.pictureBoxCalendar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCalendar.Image = global::FacebookApplication.Properties.Resources.calender;
            this.pictureBoxCalendar.Location = new System.Drawing.Point(437, 84);
            this.pictureBoxCalendar.Name = "pictureBoxCalendar";
            this.pictureBoxCalendar.Size = new System.Drawing.Size(123, 125);
            this.pictureBoxCalendar.TabIndex = 3;
            this.pictureBoxCalendar.TabStop = false;
            // 
            // buttonLoadEvents
            // 
            this.buttonLoadEvents.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonLoadEvents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLoadEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadEvents.Enabled = false;
            this.buttonLoadEvents.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoadEvents.Location = new System.Drawing.Point(176, 248);
            this.buttonLoadEvents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadEvents.Name = "buttonLoadEvents";
            this.buttonLoadEvents.Size = new System.Drawing.Size(113, 27);
            this.buttonLoadEvents.TabIndex = 2;
            this.buttonLoadEvents.Text = "Load Events";
            this.buttonLoadEvents.UseVisualStyleBackColor = true;
            this.buttonLoadEvents.Click += new System.EventHandler(this.buttonLoadEvents_Click);
            // 
            // listBoxMyEvents
            // 
            this.listBoxMyEvents.FormattingEnabled = true;
            this.listBoxMyEvents.Location = new System.Drawing.Point(44, 57);
            this.listBoxMyEvents.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxMyEvents.Name = "listBoxMyEvents";
            this.listBoxMyEvents.Size = new System.Drawing.Size(378, 186);
            this.listBoxMyEvents.TabIndex = 1;
            // 
            // tabTaggedPlaces
            // 
            this.tabTaggedPlaces.BackColor = System.Drawing.SystemColors.Control;
            this.tabTaggedPlaces.Controls.Add(this.checkBoxCurrentLocation);
            this.tabTaggedPlaces.Controls.Add(this.checkBoxTagedPlaces);
            this.tabTaggedPlaces.Controls.Add(this.checkBoxcheckins);
            this.tabTaggedPlaces.Controls.Add(this.buttonClearMyPlaces);
            this.tabTaggedPlaces.Controls.Add(this.map);
            this.tabTaggedPlaces.Controls.Add(this.buttonShowMyPlaces);
            this.tabTaggedPlaces.Controls.Add(this.labelTaggedPlacesTitle);
            this.tabTaggedPlaces.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabTaggedPlaces.Location = new System.Drawing.Point(4, 22);
            this.tabTaggedPlaces.Name = "tabTaggedPlaces";
            this.tabTaggedPlaces.Size = new System.Drawing.Size(682, 335);
            this.tabTaggedPlaces.TabIndex = 6;
            this.tabTaggedPlaces.Text = "Tagged Places";
            // 
            // checkBoxCurrentLocation
            // 
            this.checkBoxCurrentLocation.AutoSize = true;
            this.checkBoxCurrentLocation.Enabled = false;
            this.checkBoxCurrentLocation.Location = new System.Drawing.Point(28, 139);
            this.checkBoxCurrentLocation.Name = "checkBoxCurrentLocation";
            this.checkBoxCurrentLocation.Size = new System.Drawing.Size(143, 17);
            this.checkBoxCurrentLocation.TabIndex = 8;
            this.checkBoxCurrentLocation.Text = "show my current location";
            this.checkBoxCurrentLocation.UseVisualStyleBackColor = true;
            // 
            // checkBoxTagedPlaces
            // 
            this.checkBoxTagedPlaces.AutoSize = true;
            this.checkBoxTagedPlaces.Enabled = false;
            this.checkBoxTagedPlaces.Location = new System.Drawing.Point(28, 116);
            this.checkBoxTagedPlaces.Name = "checkBoxTagedPlaces";
            this.checkBoxTagedPlaces.Size = new System.Drawing.Size(131, 17);
            this.checkBoxTagedPlaces.TabIndex = 8;
            this.checkBoxTagedPlaces.Text = "show my taged places";
            this.checkBoxTagedPlaces.UseVisualStyleBackColor = true;
            // 
            // checkBoxcheckins
            // 
            this.checkBoxcheckins.AutoSize = true;
            this.checkBoxcheckins.Enabled = false;
            this.checkBoxcheckins.ImageKey = "(none)";
            this.checkBoxcheckins.Location = new System.Drawing.Point(28, 93);
            this.checkBoxcheckins.Name = "checkBoxcheckins";
            this.checkBoxcheckins.Size = new System.Drawing.Size(116, 17);
            this.checkBoxcheckins.TabIndex = 8;
            this.checkBoxcheckins.Text = "show my check-ins";
            this.checkBoxcheckins.UseVisualStyleBackColor = true;
            // 
            // buttonClearMyPlaces
            // 
            this.buttonClearMyPlaces.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonClearMyPlaces.Enabled = false;
            this.buttonClearMyPlaces.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearMyPlaces.Location = new System.Drawing.Point(28, 248);
            this.buttonClearMyPlaces.Name = "buttonClearMyPlaces";
            this.buttonClearMyPlaces.Size = new System.Drawing.Size(119, 39);
            this.buttonClearMyPlaces.TabIndex = 7;
            this.buttonClearMyPlaces.Text = "Clear My Places";
            this.buttonClearMyPlaces.UseVisualStyleBackColor = true;
            this.buttonClearMyPlaces.Click += new System.EventHandler(this.ButtonClearMyPlaces_Click);
            // 
            // map
            // 
            this.map.AutoScroll = true;
            this.map.AutoSize = true;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(176, 32);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 18;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(487, 297);
            this.map.TabIndex = 6;
            this.map.Zoom = 5D;
            this.map.Load += new System.EventHandler(this.Map_Load);
            // 
            // buttonShowMyPlaces
            // 
            this.buttonShowMyPlaces.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonShowMyPlaces.Enabled = false;
            this.buttonShowMyPlaces.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonShowMyPlaces.Location = new System.Drawing.Point(28, 32);
            this.buttonShowMyPlaces.Name = "buttonShowMyPlaces";
            this.buttonShowMyPlaces.Size = new System.Drawing.Size(121, 42);
            this.buttonShowMyPlaces.TabIndex = 5;
            this.buttonShowMyPlaces.Text = "Show My Places";
            this.buttonShowMyPlaces.UseVisualStyleBackColor = true;
            this.buttonShowMyPlaces.Click += new System.EventHandler(this.buttonTaggedPlaces_Click);
            // 
            // labelTaggedPlacesTitle
            // 
            this.labelTaggedPlacesTitle.AutoSize = true;
            this.labelTaggedPlacesTitle.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaggedPlacesTitle.Location = new System.Drawing.Point(346, 5);
            this.labelTaggedPlacesTitle.Name = "labelTaggedPlacesTitle";
            this.labelTaggedPlacesTitle.Size = new System.Drawing.Size(151, 26);
            this.labelTaggedPlacesTitle.TabIndex = 3;
            this.labelTaggedPlacesTitle.Text = "My Places";
            // 
            // tabTopLikedPhotos
            // 
            this.tabTopLikedPhotos.BackColor = System.Drawing.SystemColors.Control;
            this.tabTopLikedPhotos.Controls.Add(this.label1);
            this.tabTopLikedPhotos.Controls.Add(this.listBoxTopFriends);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes2);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes3);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes4);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes5);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes6);
            this.tabTopLikedPhotos.Controls.Add(this.textBoxLikes1);
            this.tabTopLikedPhotos.Controls.Add(this.buttonGetTop);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop6);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop5);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop4);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop3);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop2);
            this.tabTopLikedPhotos.Controls.Add(this.pictureBoxTop1);
            this.tabTopLikedPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabTopLikedPhotos.Name = "tabTopLikedPhotos";
            this.tabTopLikedPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTopLikedPhotos.Size = new System.Drawing.Size(682, 335);
            this.tabTopLikedPhotos.TabIndex = 7;
            this.tabTopLikedPhotos.Text = "Top Liked Photos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(529, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Top Liked Friends";
            // 
            // listBoxTopFriends
            // 
            this.listBoxTopFriends.FormattingEnabled = true;
            this.listBoxTopFriends.Location = new System.Drawing.Point(532, 89);
            this.listBoxTopFriends.Name = "listBoxTopFriends";
            this.listBoxTopFriends.Size = new System.Drawing.Size(131, 134);
            this.listBoxTopFriends.TabIndex = 14;
            // 
            // textBoxLikes2
            // 
            this.textBoxLikes2.Location = new System.Drawing.Point(85, 128);
            this.textBoxLikes2.Name = "textBoxLikes2";
            this.textBoxLikes2.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes2.TabIndex = 12;
            // 
            // textBoxLikes3
            // 
            this.textBoxLikes3.Location = new System.Drawing.Point(407, 128);
            this.textBoxLikes3.Name = "textBoxLikes3";
            this.textBoxLikes3.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes3.TabIndex = 11;
            // 
            // textBoxLikes4
            // 
            this.textBoxLikes4.Location = new System.Drawing.Point(11, 235);
            this.textBoxLikes4.Name = "textBoxLikes4";
            this.textBoxLikes4.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes4.TabIndex = 10;
            // 
            // textBoxLikes5
            // 
            this.textBoxLikes5.Location = new System.Drawing.Point(247, 226);
            this.textBoxLikes5.Name = "textBoxLikes5";
            this.textBoxLikes5.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes5.TabIndex = 9;
            // 
            // textBoxLikes6
            // 
            this.textBoxLikes6.Location = new System.Drawing.Point(476, 235);
            this.textBoxLikes6.Name = "textBoxLikes6";
            this.textBoxLikes6.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes6.TabIndex = 8;
            // 
            // textBoxLikes1
            // 
            this.textBoxLikes1.Location = new System.Drawing.Point(247, 13);
            this.textBoxLikes1.Name = "textBoxLikes1";
            this.textBoxLikes1.Size = new System.Drawing.Size(50, 20);
            this.textBoxLikes1.TabIndex = 7;
            // 
            // buttonGetTop
            // 
            this.buttonGetTop.BackgroundImage = global::FacebookApplication.Properties.Resources.button_bg;
            this.buttonGetTop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGetTop.Location = new System.Drawing.Point(107, 38);
            this.buttonGetTop.Name = "buttonGetTop";
            this.buttonGetTop.Size = new System.Drawing.Size(79, 43);
            this.buttonGetTop.TabIndex = 6;
            this.buttonGetTop.Text = "Get Top Liked Photos";
            this.buttonGetTop.UseVisualStyleBackColor = true;
            this.buttonGetTop.Click += new System.EventHandler(this.buttonGetTop_Click);
            // 
            // pictureBoxTop6
            // 
            this.pictureBoxTop6.Location = new System.Drawing.Point(351, 235);
            this.pictureBoxTop6.Name = "pictureBoxTop6";
            this.pictureBoxTop6.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop6.TabIndex = 5;
            this.pictureBoxTop6.TabStop = false;
            // 
            // pictureBoxTop5
            // 
            this.pictureBoxTop5.Location = new System.Drawing.Point(215, 235);
            this.pictureBoxTop5.Name = "pictureBoxTop5";
            this.pictureBoxTop5.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop5.TabIndex = 4;
            this.pictureBoxTop5.TabStop = false;
            // 
            // pictureBoxTop4
            // 
            this.pictureBoxTop4.Location = new System.Drawing.Point(67, 235);
            this.pictureBoxTop4.Name = "pictureBoxTop4";
            this.pictureBoxTop4.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop4.TabIndex = 3;
            this.pictureBoxTop4.TabStop = false;
            // 
            // pictureBoxTop3
            // 
            this.pictureBoxTop3.Location = new System.Drawing.Point(282, 128);
            this.pictureBoxTop3.Name = "pictureBoxTop3";
            this.pictureBoxTop3.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop3.TabIndex = 2;
            this.pictureBoxTop3.TabStop = false;
            // 
            // pictureBoxTop2
            // 
            this.pictureBoxTop2.Location = new System.Drawing.Point(141, 128);
            this.pictureBoxTop2.Name = "pictureBoxTop2";
            this.pictureBoxTop2.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop2.TabIndex = 1;
            this.pictureBoxTop2.TabStop = false;
            // 
            // pictureBoxTop1
            // 
            this.pictureBoxTop1.Location = new System.Drawing.Point(215, 22);
            this.pictureBoxTop1.Name = "pictureBoxTop1";
            this.pictureBoxTop1.Size = new System.Drawing.Size(119, 95);
            this.pictureBoxTop1.TabIndex = 0;
            this.pictureBoxTop1.TabStop = false;
            // 
            // labelNumberOfConnectedFriendsInfo
            // 
            this.labelNumberOfConnectedFriendsInfo.AutoSize = true;
            this.labelNumberOfConnectedFriendsInfo.Location = new System.Drawing.Point(171, 304);
            this.labelNumberOfConnectedFriendsInfo.Name = "labelNumberOfConnectedFriendsInfo";
            this.labelNumberOfConnectedFriendsInfo.Size = new System.Drawing.Size(0, 13);
            this.labelNumberOfConnectedFriendsInfo.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(288, 32);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(370, 282);
            this.webBrowser1.TabIndex = 4;
            // 
            // labelGenderInfo
            // 
            this.labelGenderInfo.AutoSize = true;
            this.labelGenderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGenderInfo.Location = new System.Drawing.Point(49, 290);
            this.labelGenderInfo.Name = "labelGenderInfo";
            this.labelGenderInfo.Size = new System.Drawing.Size(0, 15);
            this.labelGenderInfo.TabIndex = 13;
            // 
            // labelBirthdayInfo
            // 
            this.labelBirthdayInfo.AutoSize = true;
            this.labelBirthdayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthdayInfo.Location = new System.Drawing.Point(52, 270);
            this.labelBirthdayInfo.Name = "labelBirthdayInfo";
            this.labelBirthdayInfo.Size = new System.Drawing.Size(0, 15);
            this.labelBirthdayInfo.TabIndex = 12;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(3, 290);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(51, 15);
            this.labelGender.TabIndex = 11;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.Location = new System.Drawing.Point(3, 270);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(54, 15);
            this.labelBirthday.TabIndex = 10;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelLocationInfo
            // 
            this.labelLocationInfo.AutoSize = true;
            this.labelLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocationInfo.Location = new System.Drawing.Point(55, 250);
            this.labelLocationInfo.Name = "labelLocationInfo";
            this.labelLocationInfo.Size = new System.Drawing.Size(0, 15);
            this.labelLocationInfo.TabIndex = 7;
            // 
            // labelEmailInfo
            // 
            this.labelEmailInfo.AutoSize = true;
            this.labelEmailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmailInfo.Location = new System.Drawing.Point(41, 230);
            this.labelEmailInfo.Name = "labelEmailInfo";
            this.labelEmailInfo.Size = new System.Drawing.Size(0, 15);
            this.labelEmailInfo.TabIndex = 6;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLocation.Location = new System.Drawing.Point(3, 250);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(57, 15);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Location:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.Location = new System.Drawing.Point(3, 230);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 15);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // labelLastNameInfo
            // 
            this.labelLastNameInfo.AutoSize = true;
            this.labelLastNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastNameInfo.Location = new System.Drawing.Point(70, 210);
            this.labelLastNameInfo.Name = "labelLastNameInfo";
            this.labelLastNameInfo.Size = new System.Drawing.Size(0, 15);
            this.labelLastNameInfo.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastName.Location = new System.Drawing.Point(3, 210);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(70, 15);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstNameInfo
            // 
            this.labelFirstNameInfo.AutoSize = true;
            this.labelFirstNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstNameInfo.Location = new System.Drawing.Point(70, 190);
            this.labelFirstNameInfo.Name = "labelFirstNameInfo";
            this.labelFirstNameInfo.Size = new System.Drawing.Size(0, 15);
            this.labelFirstNameInfo.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstName.Location = new System.Drawing.Point(3, 190);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelBirthdayInfo);
            this.panel4.Controls.Add(this.labelGenderInfo);
            this.panel4.Controls.Add(this.labelLocationInfo);
            this.panel4.Controls.Add(this.labelFirstName);
            this.panel4.Controls.Add(this.pictureBoxProfilePic);
            this.panel4.Controls.Add(this.labelEmailInfo);
            this.panel4.Controls.Add(this.labelLastName);
            this.panel4.Controls.Add(this.labelFirstNameInfo);
            this.panel4.Controls.Add(this.labelLastNameInfo);
            this.panel4.Controls.Add(this.labelEmail);
            this.panel4.Controls.Add(this.labelGender);
            this.panel4.Controls.Add(this.labelLocation);
            this.panel4.Controls.Add(this.labelBirthday);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(840, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 363);
            this.panel4.TabIndex = 5;
            // 
            // pictureBoxProfilePic
            // 
            this.pictureBoxProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePic.Location = new System.Drawing.Point(5, 2);
            this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
            this.pictureBoxProfilePic.Size = new System.Drawing.Size(180, 180);
            this.pictureBoxProfilePic.TabIndex = 1;
            this.pictureBoxProfilePic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 363);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Facebook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPosts.ResumeLayout(false);
            this.tabPosts.PerformLayout();
            this.tabPhotos.ResumeLayout(false);
            this.tabPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.tabFriends.ResumeLayout(false);
            this.tabFriends.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendPicture)).EndInit();
            this.tabPageLikes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).EndInit();
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendar)).EndInit();
            this.tabTaggedPlaces.ResumeLayout(false);
            this.tabTaggedPlaces.PerformLayout();
            this.tabTopLikedPhotos.ResumeLayout(false);
            this.tabTopLikedPhotos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTop1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginLogout;
        private System.Windows.Forms.PictureBox pictureBoxProfilePic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelFirstNameInfo;
        private System.Windows.Forms.Label labelLastNameInfo;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelLocationInfo;
        private System.Windows.Forms.Label labelEmailInfo;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBirthdayInfo;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelGenderInfo;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.Button buttonShareMyPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.ListBox listBoxMyPosts;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.Label labelPhotoDescription;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Button buttonUploadPhoto;
        private System.Windows.Forms.Button buttonCreateAlbum;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ListBox listBoxPhoto;
        private System.Windows.Forms.Button buttonRefreshAlbums;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelFriendLastNameInfo;
        private System.Windows.Forms.PictureBox pictureBoxFriendPicture;
        private System.Windows.Forms.Label labelFriendFirstNameInfo;
        private System.Windows.Forms.Label labelFriendGenderInfo;
        private System.Windows.Forms.Label labelFriendGender;
        private System.Windows.Forms.Label labelFriendFirstName;
        private System.Windows.Forms.Label labelFriendLastName;
        private System.Windows.Forms.Label labelSelectedFriendInformation;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.Button buttonRefreshFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.TabPage tabPageLikes;
        private System.Windows.Forms.Button buttonRefreshPages;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Button buttonLoadEvents;
        private System.Windows.Forms.ListBox listBoxMyEvents;
        private System.Windows.Forms.TabPage tabTaggedPlaces;
        private System.Windows.Forms.Label labelCreditMessage;
        private System.Windows.Forms.Label labelCredit;
        private System.Windows.Forms.PictureBox pictureBoxPages;
        private System.Windows.Forms.PictureBox pictureBoxCalendar;
        private System.Windows.Forms.Label labelTaggedPlacesTitle;
        private System.Windows.Forms.Label labelNumberOfConnectedFriendsInfo;
        private System.Windows.Forms.Button buttonRefreshPosts;
        private System.Windows.Forms.Button buttonShowMyPlaces;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Button buttonClearMyPlaces;
        private System.Windows.Forms.CheckBox checkBoxCurrentLocation;
        private System.Windows.Forms.CheckBox checkBoxTagedPlaces;
        private System.Windows.Forms.CheckBox checkBoxcheckins;
        private System.Windows.Forms.TabPage tabTopLikedPhotos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBoxLikes2;
        private System.Windows.Forms.TextBox textBoxLikes3;
        private System.Windows.Forms.TextBox textBoxLikes4;
        private System.Windows.Forms.TextBox textBoxLikes5;
        private System.Windows.Forms.TextBox textBoxLikes6;
        private System.Windows.Forms.TextBox textBoxLikes1;
        private System.Windows.Forms.Button buttonGetTop;
        private System.Windows.Forms.PictureBox pictureBoxTop6;
        private System.Windows.Forms.PictureBox pictureBoxTop5;
        private System.Windows.Forms.PictureBox pictureBoxTop4;
        private System.Windows.Forms.PictureBox pictureBoxTop3;
        private System.Windows.Forms.PictureBox pictureBoxTop2;
        private System.Windows.Forms.PictureBox pictureBoxTop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTopFriends;
    }
}
