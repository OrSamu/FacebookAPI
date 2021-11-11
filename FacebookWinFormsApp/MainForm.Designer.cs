
namespace BasicFacebookFeatures
{
    partial class MainForm
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
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.friendsGameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.AdvancedImageSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainFormHeadLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.postButton = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxPages = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(11, 60);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.MaximumSize = new System.Drawing.Size(100, 100);
            this.profilePictureBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // friendsGameButton
            // 
            this.friendsGameButton.Location = new System.Drawing.Point(14, 229);
            this.friendsGameButton.Name = "friendsGameButton";
            this.friendsGameButton.Size = new System.Drawing.Size(88, 23);
            this.friendsGameButton.TabIndex = 1;
            this.friendsGameButton.Text = "Friends Quiz";
            this.friendsGameButton.UseVisualStyleBackColor = true;
            this.friendsGameButton.Click += new System.EventHandler(this.friendsGameButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(14, 258);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(88, 23);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(11, 163);
            this.usernameLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvancedImageSearch
            // 
            this.AdvancedImageSearch.Location = new System.Drawing.Point(14, 200);
            this.AdvancedImageSearch.Name = "AdvancedImageSearch";
            this.AdvancedImageSearch.Size = new System.Drawing.Size(88, 23);
            this.AdvancedImageSearch.TabIndex = 4;
            this.AdvancedImageSearch.Text = "Image Filters";
            this.AdvancedImageSearch.UseVisualStyleBackColor = true;
            this.AdvancedImageSearch.Click += new System.EventHandler(this.AdvancedImageSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mainFormHeadLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 55);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Location = new System.Drawing.Point(3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 45);
            this.panel2.TabIndex = 16;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.FBSmallLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(-2, -5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(50, 50);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // mainFormHeadLabel
            // 
            this.mainFormHeadLabel.AutoSize = true;
            this.mainFormHeadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.mainFormHeadLabel.ForeColor = System.Drawing.Color.White;
            this.mainFormHeadLabel.Location = new System.Drawing.Point(212, 21);
            this.mainFormHeadLabel.Name = "mainFormHeadLabel";
            this.mainFormHeadLabel.Size = new System.Drawing.Size(278, 29);
            this.mainFormHeadLabel.TabIndex = 15;
            this.mainFormHeadLabel.Text = "Facebook - On Windows";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(135, 89);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(525, 108);
            this.listBoxPosts.TabIndex = 15;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(135, 62);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(444, 20);
            this.statusTextBox.TabIndex = 16;
            this.statusTextBox.Text = "What\'s on your mind?";
            this.statusTextBox.Click += new System.EventHandler(this.statusTextBox_Click);
            // 
            // postButton
            // 
            this.postButton.Location = new System.Drawing.Point(585, 60);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(75, 23);
            this.postButton.TabIndex = 17;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(135, 206);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(525, 82);
            this.listBoxComments.TabIndex = 18;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DisplayMember = "name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(14, 305);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(200, 147);
            this.listBoxEvents.TabIndex = 41;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.DisplayMember = "name";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(460, 305);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(200, 147);
            this.listBoxGroups.TabIndex = 42;
            // 
            // listBoxPages
            // 
            this.listBoxPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPages.DisplayMember = "name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.Location = new System.Drawing.Point(237, 305);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(200, 147);
            this.listBoxPages.TabIndex = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 473);
            this.Controls.Add(this.listBoxPages);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdvancedImageSearch);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.friendsGameButton);
            this.Controls.Add(this.profilePictureBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Button friendsGameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button AdvancedImageSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label mainFormHeadLabel;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxPages;
    }
}