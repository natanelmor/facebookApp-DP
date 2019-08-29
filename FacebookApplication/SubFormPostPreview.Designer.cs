namespace FacebookApplication
{
    public partial class SubFormPostPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFormPostPreview));
            this.labelContent = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelBy = new System.Windows.Forms.Label();
            this.labelByInfo = new System.Windows.Forms.Label();
            this.labelTimeInfo = new System.Windows.Forms.Label();
            this.labelContentInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(78, 49);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(47, 13);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "Content:";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxProfilePicture.TabIndex = 1;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(78, 31);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time:";
            // 
            // labelBy
            // 
            this.labelBy.AutoSize = true;
            this.labelBy.Location = new System.Drawing.Point(78, 13);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(22, 13);
            this.labelBy.TabIndex = 3;
            this.labelBy.Text = "By:";
            // 
            // labelByInfo
            // 
            this.labelByInfo.AutoSize = true;
            this.labelByInfo.Location = new System.Drawing.Point(131, 13);
            this.labelByInfo.Name = "labelByInfo";
            this.labelByInfo.Size = new System.Drawing.Size(0, 13);
            this.labelByInfo.TabIndex = 4;
            // 
            // labelTimeInfo
            // 
            this.labelTimeInfo.AutoSize = true;
            this.labelTimeInfo.Location = new System.Drawing.Point(131, 31);
            this.labelTimeInfo.Name = "labelTimeInfo";
            this.labelTimeInfo.Size = new System.Drawing.Size(0, 13);
            this.labelTimeInfo.TabIndex = 5;
            // 
            // labelContentInfo
            // 
            this.labelContentInfo.AutoSize = true;
            this.labelContentInfo.Location = new System.Drawing.Point(131, 49);
            this.labelContentInfo.Name = "labelContentInfo";
            this.labelContentInfo.Size = new System.Drawing.Size(0, 13);
            this.labelContentInfo.TabIndex = 6;
            // 
            // SubFormPostPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 83);
            this.Controls.Add(this.labelContentInfo);
            this.Controls.Add(this.labelTimeInfo);
            this.Controls.Add(this.labelByInfo);
            this.Controls.Add(this.labelBy);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.labelContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubFormPostPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Post Preview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelBy;
        private System.Windows.Forms.Label labelByInfo;
        private System.Windows.Forms.Label labelTimeInfo;
        private System.Windows.Forms.Label labelContentInfo;
    }
}