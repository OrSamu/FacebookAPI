﻿namespace BasicFacebookFeatures
{
    partial class AdvancedImageForm
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxShow = new System.Windows.Forms.ComboBox();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.labelAdvancedImageSearch = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.checkBoxAlbum = new System.Windows.Forms.CheckBox();
            this.checkBoxLikes = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.listBoxPictureData = new System.Windows.Forms.ListBox();
            this.comboBoxAlbumsNames = new System.Windows.Forms.ComboBox();
            this.taggedFriendLabel = new System.Windows.Forms.Label();
            this.fromAlbumLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.m_DateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.minLikesLabel = new System.Windows.Forms.Label();
            this.pictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.checkBoxTaggedFriends = new System.Windows.Forms.CheckBox();
            this.comboBoxTaggedFriend = new System.Windows.Forms.ComboBox();
            this.numericUpDownLikes = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikes)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxShow
            // 
            this.comboBoxShow.Enabled = false;
            this.comboBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShow.FormattingEnabled = true;
            this.comboBoxShow.Items.AddRange(new object[] {
            "Comments",
            "Liked By",
            "Tags"});
            this.comboBoxShow.Location = new System.Drawing.Point(363, 382);
            this.comboBoxShow.Name = "comboBoxShow";
            this.comboBoxShow.Size = new System.Drawing.Size(357, 24);
            this.comboBoxShow.TabIndex = 45;
            this.comboBoxShow.Text = "show";
            this.comboBoxShow.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.backgroundPanel.Controls.Add(this.labelAdvancedImageSearch);
            this.backgroundPanel.Controls.Add(this.panel2);
            this.backgroundPanel.Location = new System.Drawing.Point(2, 1);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(741, 82);
            this.backgroundPanel.TabIndex = 44;
            // 
            // labelAdvancedImageSearch
            // 
            this.labelAdvancedImageSearch.AutoSize = true;
            this.labelAdvancedImageSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.28F);
            this.labelAdvancedImageSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAdvancedImageSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdvancedImageSearch.Location = new System.Drawing.Point(107, 36);
            this.labelAdvancedImageSearch.Name = "labelAdvancedImageSearch";
            this.labelAdvancedImageSearch.Size = new System.Drawing.Size(374, 38);
            this.labelAdvancedImageSearch.TabIndex = 0;
            this.labelAdvancedImageSearch.Text = "Advanced Image Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logoPictureBox);
            this.panel2.Location = new System.Drawing.Point(34, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 66);
            this.panel2.TabIndex = 54;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Image = global::BasicFacebookFeatures.Properties.Resources.FBSmallLogo;
            this.logoPictureBox.Location = new System.Drawing.Point(-16, -1);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(72, 65);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 15;
            this.logoPictureBox.TabStop = false;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Enabled = false;
            this.comboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Items.AddRange(new object[] {
            "Creation Date",
            "Likes"});
            this.comboBoxSortBy.Location = new System.Drawing.Point(10, 308);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(120, 24);
            this.comboBoxSortBy.TabIndex = 41;
            this.comboBoxSortBy.Text = "Sort by:";
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.m_ComboBoxSortBy_SelectedIndexChanged);
            // 
            // checkBoxAlbum
            // 
            this.checkBoxAlbum.AutoSize = true;
            this.checkBoxAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxAlbum.Location = new System.Drawing.Point(10, 186);
            this.checkBoxAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAlbum.Name = "checkBoxAlbum";
            this.checkBoxAlbum.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlbum.TabIndex = 40;
            this.checkBoxAlbum.UseVisualStyleBackColor = true;
            this.checkBoxAlbum.CheckedChanged += new System.EventHandler(this.m_CheckBoxAlbum_CheckedChanged);
            // 
            // checkBoxLikes
            // 
            this.checkBoxLikes.AutoSize = true;
            this.checkBoxLikes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxLikes.Location = new System.Drawing.Point(10, 158);
            this.checkBoxLikes.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLikes.Name = "checkBoxLikes";
            this.checkBoxLikes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxLikes.TabIndex = 39;
            this.checkBoxLikes.UseVisualStyleBackColor = true;
            this.checkBoxLikes.CheckedChanged += new System.EventHandler(this.m_CheckBoxLikes_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxDate.Location = new System.Drawing.Point(10, 129);
            this.checkBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDate.TabIndex = 38;
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.m_CheckBoxDate_CheckedChanged);
            // 
            // listBoxPictureData
            // 
            this.listBoxPictureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPictureData.FormattingEnabled = true;
            this.listBoxPictureData.ItemHeight = 16;
            this.listBoxPictureData.Location = new System.Drawing.Point(363, 412);
            this.listBoxPictureData.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPictureData.Name = "listBoxPictureData";
            this.listBoxPictureData.Size = new System.Drawing.Size(357, 148);
            this.listBoxPictureData.TabIndex = 37;
            // 
            // comboBoxAlbumsNames
            // 
            this.comboBoxAlbumsNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxAlbumsNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxAlbumsNames.DisplayMember = "(none)";
            this.comboBoxAlbumsNames.Enabled = false;
            this.comboBoxAlbumsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAlbumsNames.FormattingEnabled = true;
            this.comboBoxAlbumsNames.Location = new System.Drawing.Point(232, 178);
            this.comboBoxAlbumsNames.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAlbumsNames.Name = "comboBoxAlbumsNames";
            this.comboBoxAlbumsNames.Size = new System.Drawing.Size(106, 24);
            this.comboBoxAlbumsNames.TabIndex = 36;
            // 
            // taggedFriendLabel
            // 
            this.taggedFriendLabel.AutoSize = true;
            this.taggedFriendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.taggedFriendLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.taggedFriendLabel.Location = new System.Drawing.Point(29, 214);
            this.taggedFriendLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taggedFriendLabel.Name = "taggedFriendLabel";
            this.taggedFriendLabel.Size = new System.Drawing.Size(97, 17);
            this.taggedFriendLabel.TabIndex = 33;
            this.taggedFriendLabel.Text = "Tagged friend";
            // 
            // fromAlbumLabel
            // 
            this.fromAlbumLabel.AutoSize = true;
            this.fromAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromAlbumLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fromAlbumLabel.Location = new System.Drawing.Point(28, 185);
            this.fromAlbumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fromAlbumLabel.Name = "fromAlbumLabel";
            this.fromAlbumLabel.Size = new System.Drawing.Size(82, 17);
            this.fromAlbumLabel.TabIndex = 32;
            this.fromAlbumLabel.Text = "From album";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toLabel.Location = new System.Drawing.Point(188, 125);
            this.toLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(25, 17);
            this.toLabel.TabIndex = 31;
            this.toLabel.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFrom.Location = new System.Drawing.Point(29, 128);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(40, 17);
            this.labelFrom.TabIndex = 30;
            this.labelFrom.Text = "From";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Enabled = false;
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(232, 122);
            this.dateTimePickerToDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(107, 23);
            this.dateTimePickerToDate.TabIndex = 29;
            // 
            // m_DateTimePickerFromDate
            // 
            this.m_DateTimePickerFromDate.Enabled = false;
            this.m_DateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_DateTimePickerFromDate.Location = new System.Drawing.Point(71, 125);
            this.m_DateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(2);
            this.m_DateTimePickerFromDate.MaxDate = new System.DateTime(2039, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.Name = "m_DateTimePickerFromDate";
            this.m_DateTimePickerFromDate.Size = new System.Drawing.Size(107, 23);
            this.m_DateTimePickerFromDate.TabIndex = 28;
            // 
            // minLikesLabel
            // 
            this.minLikesLabel.AutoSize = true;
            this.minLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minLikesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minLikesLabel.Location = new System.Drawing.Point(28, 157);
            this.minLikesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minLikesLabel.Name = "minLikesLabel";
            this.minLikesLabel.Size = new System.Drawing.Size(133, 17);
            this.minLikesLabel.TabIndex = 27;
            this.minLikesLabel.Text = "Min amount of likes:";
            // 
            // pictureBoxSelectedImage
            // 
            this.pictureBoxSelectedImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxSelectedImage.Location = new System.Drawing.Point(364, 122);
            this.pictureBoxSelectedImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSelectedImage.Name = "pictureBoxSelectedImage";
            this.pictureBoxSelectedImage.Size = new System.Drawing.Size(356, 220);
            this.pictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedImage.TabIndex = 25;
            this.pictureBoxSelectedImage.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSearch.Location = new System.Drawing.Point(11, 245);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(328, 49);
            this.buttonSearch.TabIndex = 35;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.m_ButtonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Filters:";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.Location = new System.Drawing.Point(380, 344);
            this.labelLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(45, 17);
            this.labelLikes.TabIndex = 48;
            this.labelLikes.Text = "Likes:";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(596, 344);
            this.labelComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(78, 17);
            this.labelComments.TabIndex = 49;
            this.labelComments.Text = "Comments:";
            // 
            // checkBoxTaggedFriends
            // 
            this.checkBoxTaggedFriends.AutoSize = true;
            this.checkBoxTaggedFriends.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxTaggedFriends.Location = new System.Drawing.Point(10, 215);
            this.checkBoxTaggedFriends.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTaggedFriends.Name = "checkBoxTaggedFriends";
            this.checkBoxTaggedFriends.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTaggedFriends.TabIndex = 50;
            this.checkBoxTaggedFriends.UseVisualStyleBackColor = true;
            this.checkBoxTaggedFriends.CheckedChanged += new System.EventHandler(this.m_CheckBoxTaggedFriends_CheckedChanged);
            // 
            // comboBoxTaggedFriend
            // 
            this.comboBoxTaggedFriend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxTaggedFriend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTaggedFriend.DisplayMember = "(none)";
            this.comboBoxTaggedFriend.Enabled = false;
            this.comboBoxTaggedFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTaggedFriend.FormattingEnabled = true;
            this.comboBoxTaggedFriend.Location = new System.Drawing.Point(233, 207);
            this.comboBoxTaggedFriend.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTaggedFriend.Name = "comboBoxTaggedFriend";
            this.comboBoxTaggedFriend.Size = new System.Drawing.Size(106, 24);
            this.comboBoxTaggedFriend.TabIndex = 51;
            // 
            // numericUpDownLikes
            // 
            this.numericUpDownLikes.Enabled = false;
            this.numericUpDownLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownLikes.Location = new System.Drawing.Point(232, 151);
            this.numericUpDownLikes.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLikes.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownLikes.Name = "numericUpDownLikes";
            this.numericUpDownLikes.Size = new System.Drawing.Size(105, 23);
            this.numericUpDownLikes.TabIndex = 52;
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(11, 336);
            this.flowLayoutPanelImages.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(328, 224);
            this.flowLayoutPanelImages.TabIndex = 53;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AdvancedImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 571);
            this.Controls.Add(this.flowLayoutPanelImages);
            this.Controls.Add(this.numericUpDownLikes);
            this.Controls.Add(this.comboBoxTaggedFriend);
            this.Controls.Add(this.checkBoxTaggedFriends);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelLikes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxShow);
            this.Controls.Add(this.backgroundPanel);
            this.Controls.Add(this.comboBoxSortBy);
            this.Controls.Add(this.checkBoxAlbum);
            this.Controls.Add(this.checkBoxLikes);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.listBoxPictureData);
            this.Controls.Add(this.comboBoxAlbumsNames);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.taggedFriendLabel);
            this.Controls.Add(this.fromAlbumLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.m_DateTimePickerFromDate);
            this.Controls.Add(this.minLikesLabel);
            this.Controls.Add(this.pictureBoxSelectedImage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdvancedImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Image Search";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShow;
        private System.Windows.Forms.Panel backgroundPanel;
        private System.Windows.Forms.Label labelAdvancedImageSearch;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.CheckBox checkBoxAlbum;
        private System.Windows.Forms.CheckBox checkBoxLikes;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.ListBox listBoxPictureData;
        private System.Windows.Forms.ComboBox comboBoxAlbumsNames;
        private System.Windows.Forms.Label taggedFriendLabel;
        private System.Windows.Forms.Label fromAlbumLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker m_DateTimePickerFromDate;
        private System.Windows.Forms.Label minLikesLabel;
        private System.Windows.Forms.PictureBox pictureBoxSelectedImage;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.CheckBox checkBoxTaggedFriends;
        private System.Windows.Forms.ComboBox comboBoxTaggedFriend;
        private System.Windows.Forms.NumericUpDown numericUpDownLikes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel panel2;
    }
}