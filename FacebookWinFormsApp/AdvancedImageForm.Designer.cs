namespace BasicFacebookFeatures
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
            this.m_ComboBoxShow = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_LabelAdvancedImageSearch = new System.Windows.Forms.Label();
            this.m_ComboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.m_CheckBoxAlbum = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxLikes = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxDate = new System.Windows.Forms.CheckBox();
            this.m_ListBoxPictureData = new System.Windows.Forms.ListBox();
            this.m_ComboBoxAlbumsNames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_LabelTo = new System.Windows.Forms.Label();
            this.m_LabelFrom = new System.Windows.Forms.Label();
            this.m_DateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.m_DateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.m_PictureBoxSelectedImage = new System.Windows.Forms.PictureBox();
            this.m_ButtonSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.m_LabelLikes = new System.Windows.Forms.Label();
            this.m_LabelComments = new System.Windows.Forms.Label();
            this.m_CheckBoxTaggedFriends = new System.Windows.Forms.CheckBox();
            this.m_ComboBoxTaggedFriend = new System.Windows.Forms.ComboBox();
            this.m_NumericUpDownLikes = new System.Windows.Forms.NumericUpDown();
            this.m_FlowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownLikes)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ComboBoxShow
            // 
            this.m_ComboBoxShow.Enabled = false;
            this.m_ComboBoxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ComboBoxShow.FormattingEnabled = true;
            this.m_ComboBoxShow.Items.AddRange(new object[] {
            "Comments",
            "Liked By",
            "Tags"});
            this.m_ComboBoxShow.Location = new System.Drawing.Point(943, 357);
            this.m_ComboBoxShow.Name = "m_ComboBoxShow";
            this.m_ComboBoxShow.Size = new System.Drawing.Size(357, 24);
            this.m_ComboBoxShow.TabIndex = 45;
            this.m_ComboBoxShow.Text = "show";
            this.m_ComboBoxShow.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.m_LabelAdvancedImageSearch);
            this.panel1.Location = new System.Drawing.Point(9, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 82);
            this.panel1.TabIndex = 44;
            // 
            // m_LabelAdvancedImageSearch
            // 
            this.m_LabelAdvancedImageSearch.AutoSize = true;
            this.m_LabelAdvancedImageSearch.Font = new System.Drawing.Font("Archivo Black", 24.28F);
            this.m_LabelAdvancedImageSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.m_LabelAdvancedImageSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_LabelAdvancedImageSearch.Location = new System.Drawing.Point(5, 27);
            this.m_LabelAdvancedImageSearch.Name = "m_LabelAdvancedImageSearch";
            this.m_LabelAdvancedImageSearch.Size = new System.Drawing.Size(453, 46);
            this.m_LabelAdvancedImageSearch.TabIndex = 0;
            this.m_LabelAdvancedImageSearch.Text = "Advanced image search";
            // 
            // m_ComboBoxSortBy
            // 
            this.m_ComboBoxSortBy.Enabled = false;
            this.m_ComboBoxSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ComboBoxSortBy.FormattingEnabled = true;
            this.m_ComboBoxSortBy.Items.AddRange(new object[] {
            "Creation Date",
            "Likes"});
            this.m_ComboBoxSortBy.Location = new System.Drawing.Point(392, 89);
            this.m_ComboBoxSortBy.Name = "m_ComboBoxSortBy";
            this.m_ComboBoxSortBy.Size = new System.Drawing.Size(120, 24);
            this.m_ComboBoxSortBy.TabIndex = 41;
            this.m_ComboBoxSortBy.Text = "Sort by:";
            this.m_ComboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.m_ComboBoxSortBy_SelectedIndexChanged);
            // 
            // m_CheckBoxAlbum
            // 
            this.m_CheckBoxAlbum.AutoSize = true;
            this.m_CheckBoxAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_CheckBoxAlbum.Location = new System.Drawing.Point(32, 285);
            this.m_CheckBoxAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_CheckBoxAlbum.Name = "m_CheckBoxAlbum";
            this.m_CheckBoxAlbum.Size = new System.Drawing.Size(15, 14);
            this.m_CheckBoxAlbum.TabIndex = 40;
            this.m_CheckBoxAlbum.UseVisualStyleBackColor = true;
            this.m_CheckBoxAlbum.CheckedChanged += new System.EventHandler(this.m_CheckBoxAlbum_CheckedChanged);
            // 
            // m_CheckBoxLikes
            // 
            this.m_CheckBoxLikes.AutoSize = true;
            this.m_CheckBoxLikes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_CheckBoxLikes.Location = new System.Drawing.Point(32, 258);
            this.m_CheckBoxLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_CheckBoxLikes.Name = "m_CheckBoxLikes";
            this.m_CheckBoxLikes.Size = new System.Drawing.Size(15, 14);
            this.m_CheckBoxLikes.TabIndex = 39;
            this.m_CheckBoxLikes.UseVisualStyleBackColor = true;
            this.m_CheckBoxLikes.CheckedChanged += new System.EventHandler(this.m_CheckBoxLikes_CheckedChanged);
            // 
            // m_CheckBoxDate
            // 
            this.m_CheckBoxDate.AutoSize = true;
            this.m_CheckBoxDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_CheckBoxDate.Location = new System.Drawing.Point(32, 225);
            this.m_CheckBoxDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_CheckBoxDate.Name = "m_CheckBoxDate";
            this.m_CheckBoxDate.Size = new System.Drawing.Size(15, 14);
            this.m_CheckBoxDate.TabIndex = 38;
            this.m_CheckBoxDate.UseVisualStyleBackColor = true;
            this.m_CheckBoxDate.CheckedChanged += new System.EventHandler(this.m_CheckBoxDate_CheckedChanged);
            // 
            // m_ListBoxPictureData
            // 
            this.m_ListBoxPictureData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ListBoxPictureData.FormattingEnabled = true;
            this.m_ListBoxPictureData.ItemHeight = 16;
            this.m_ListBoxPictureData.Location = new System.Drawing.Point(943, 387);
            this.m_ListBoxPictureData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_ListBoxPictureData.Name = "m_ListBoxPictureData";
            this.m_ListBoxPictureData.Size = new System.Drawing.Size(357, 164);
            this.m_ListBoxPictureData.TabIndex = 37;
            // 
            // m_ComboBoxAlbumsNames
            // 
            this.m_ComboBoxAlbumsNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_ComboBoxAlbumsNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_ComboBoxAlbumsNames.DisplayMember = "(none)";
            this.m_ComboBoxAlbumsNames.Enabled = false;
            this.m_ComboBoxAlbumsNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ComboBoxAlbumsNames.FormattingEnabled = true;
            this.m_ComboBoxAlbumsNames.Location = new System.Drawing.Point(260, 279);
            this.m_ComboBoxAlbumsNames.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_ComboBoxAlbumsNames.Name = "m_ComboBoxAlbumsNames";
            this.m_ComboBoxAlbumsNames.Size = new System.Drawing.Size(106, 24);
            this.m_ComboBoxAlbumsNames.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(53, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tagged friend";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(53, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "From album";
            // 
            // m_LabelTo
            // 
            this.m_LabelTo.AutoSize = true;
            this.m_LabelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_LabelTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_LabelTo.Location = new System.Drawing.Point(215, 227);
            this.m_LabelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelTo.Name = "m_LabelTo";
            this.m_LabelTo.Size = new System.Drawing.Size(25, 17);
            this.m_LabelTo.TabIndex = 31;
            this.m_LabelTo.Text = "To";
            // 
            // m_LabelFrom
            // 
            this.m_LabelFrom.AutoSize = true;
            this.m_LabelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.m_LabelFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_LabelFrom.Location = new System.Drawing.Point(53, 225);
            this.m_LabelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelFrom.Name = "m_LabelFrom";
            this.m_LabelFrom.Size = new System.Drawing.Size(40, 17);
            this.m_LabelFrom.TabIndex = 30;
            this.m_LabelFrom.Text = "From";
            // 
            // m_DateTimePickerToDate
            // 
            this.m_DateTimePickerToDate.Enabled = false;
            this.m_DateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_DateTimePickerToDate.Location = new System.Drawing.Point(259, 225);
            this.m_DateTimePickerToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_DateTimePickerToDate.Name = "m_DateTimePickerToDate";
            this.m_DateTimePickerToDate.Size = new System.Drawing.Size(107, 23);
            this.m_DateTimePickerToDate.TabIndex = 29;
            // 
            // m_DateTimePickerFromDate
            // 
            this.m_DateTimePickerFromDate.Enabled = false;
            this.m_DateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_DateTimePickerFromDate.Location = new System.Drawing.Point(95, 225);
            this.m_DateTimePickerFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_DateTimePickerFromDate.MaxDate = new System.DateTime(2039, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerFromDate.Name = "m_DateTimePickerFromDate";
            this.m_DateTimePickerFromDate.Size = new System.Drawing.Size(107, 23);
            this.m_DateTimePickerFromDate.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(53, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Min amount of likes:";
            // 
            // m_PictureBoxSelectedImage
            // 
            this.m_PictureBoxSelectedImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_PictureBoxSelectedImage.Location = new System.Drawing.Point(943, 114);
            this.m_PictureBoxSelectedImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_PictureBoxSelectedImage.Name = "m_PictureBoxSelectedImage";
            this.m_PictureBoxSelectedImage.Size = new System.Drawing.Size(356, 220);
            this.m_PictureBoxSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxSelectedImage.TabIndex = 25;
            this.m_PictureBoxSelectedImage.TabStop = false;
            // 
            // m_ButtonSearch
            // 
            this.m_ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(181)))), ((int)(((byte)(74)))));
            this.m_ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.m_ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonSearch.Font = new System.Drawing.Font("Impact", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ButtonSearch.ForeColor = System.Drawing.Color.White;
            this.m_ButtonSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_ButtonSearch.Location = new System.Drawing.Point(67, 407);
            this.m_ButtonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_ButtonSearch.Name = "m_ButtonSearch";
            this.m_ButtonSearch.Size = new System.Drawing.Size(253, 80);
            this.m_ButtonSearch.TabIndex = 35;
            this.m_ButtonSearch.Text = "Search";
            this.m_ButtonSearch.UseVisualStyleBackColor = false;
            this.m_ButtonSearch.Click += new System.EventHandler(this.m_ButtonSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Filters:";
            // 
            // m_LabelLikes
            // 
            this.m_LabelLikes.AutoSize = true;
            this.m_LabelLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelLikes.Location = new System.Drawing.Point(959, 336);
            this.m_LabelLikes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelLikes.Name = "m_LabelLikes";
            this.m_LabelLikes.Size = new System.Drawing.Size(45, 17);
            this.m_LabelLikes.TabIndex = 48;
            this.m_LabelLikes.Text = "Likes:";
            // 
            // m_LabelComments
            // 
            this.m_LabelComments.AutoSize = true;
            this.m_LabelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LabelComments.Location = new System.Drawing.Point(1175, 336);
            this.m_LabelComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LabelComments.Name = "m_LabelComments";
            this.m_LabelComments.Size = new System.Drawing.Size(78, 17);
            this.m_LabelComments.TabIndex = 49;
            this.m_LabelComments.Text = "Comments:";
            // 
            // m_CheckBoxTaggedFriends
            // 
            this.m_CheckBoxTaggedFriends.AutoSize = true;
            this.m_CheckBoxTaggedFriends.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.m_CheckBoxTaggedFriends.Location = new System.Drawing.Point(32, 314);
            this.m_CheckBoxTaggedFriends.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_CheckBoxTaggedFriends.Name = "m_CheckBoxTaggedFriends";
            this.m_CheckBoxTaggedFriends.Size = new System.Drawing.Size(15, 14);
            this.m_CheckBoxTaggedFriends.TabIndex = 50;
            this.m_CheckBoxTaggedFriends.UseVisualStyleBackColor = true;
            this.m_CheckBoxTaggedFriends.CheckedChanged += new System.EventHandler(this.m_CheckBoxTaggedFriens_CheckedChanged);
            // 
            // m_ComboBoxTaggedFriend
            // 
            this.m_ComboBoxTaggedFriend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.m_ComboBoxTaggedFriend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.m_ComboBoxTaggedFriend.DisplayMember = "(none)";
            this.m_ComboBoxTaggedFriend.Enabled = false;
            this.m_ComboBoxTaggedFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ComboBoxTaggedFriend.FormattingEnabled = true;
            this.m_ComboBoxTaggedFriend.Location = new System.Drawing.Point(260, 311);
            this.m_ComboBoxTaggedFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_ComboBoxTaggedFriend.Name = "m_ComboBoxTaggedFriend";
            this.m_ComboBoxTaggedFriend.Size = new System.Drawing.Size(106, 24);
            this.m_ComboBoxTaggedFriend.TabIndex = 51;
            // 
            // m_NumericUpDownLikes
            // 
            this.m_NumericUpDownLikes.Enabled = false;
            this.m_NumericUpDownLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NumericUpDownLikes.Location = new System.Drawing.Point(260, 253);
            this.m_NumericUpDownLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_NumericUpDownLikes.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.m_NumericUpDownLikes.Name = "m_NumericUpDownLikes";
            this.m_NumericUpDownLikes.Size = new System.Drawing.Size(105, 23);
            this.m_NumericUpDownLikes.TabIndex = 52;
            // 
            // m_FlowLayoutPanelImages
            // 
            this.m_FlowLayoutPanelImages.AutoScroll = true;
            this.m_FlowLayoutPanelImages.BackColor = System.Drawing.Color.White;
            this.m_FlowLayoutPanelImages.Location = new System.Drawing.Point(392, 118);
            this.m_FlowLayoutPanelImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.m_FlowLayoutPanelImages.Name = "m_FlowLayoutPanelImages";
            this.m_FlowLayoutPanelImages.Size = new System.Drawing.Size(522, 434);
            this.m_FlowLayoutPanelImages.TabIndex = 53;
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
            this.ClientSize = new System.Drawing.Size(1310, 571);
            this.Controls.Add(this.m_FlowLayoutPanelImages);
            this.Controls.Add(this.m_NumericUpDownLikes);
            this.Controls.Add(this.m_ComboBoxTaggedFriend);
            this.Controls.Add(this.m_CheckBoxTaggedFriends);
            this.Controls.Add(this.m_LabelComments);
            this.Controls.Add(this.m_LabelLikes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_ComboBoxShow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_ComboBoxSortBy);
            this.Controls.Add(this.m_CheckBoxAlbum);
            this.Controls.Add(this.m_CheckBoxLikes);
            this.Controls.Add(this.m_CheckBoxDate);
            this.Controls.Add(this.m_ListBoxPictureData);
            this.Controls.Add(this.m_ComboBoxAlbumsNames);
            this.Controls.Add(this.m_ButtonSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_LabelTo);
            this.Controls.Add(this.m_LabelFrom);
            this.Controls.Add(this.m_DateTimePickerToDate);
            this.Controls.Add(this.m_DateTimePickerFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_PictureBoxSelectedImage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdvancedImageForm";
            this.Text = "AdvancedImageForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxSelectedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumericUpDownLikes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_ComboBoxShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_LabelAdvancedImageSearch;
        private System.Windows.Forms.ComboBox m_ComboBoxSortBy;
        private System.Windows.Forms.CheckBox m_CheckBoxAlbum;
        private System.Windows.Forms.CheckBox m_CheckBoxLikes;
        private System.Windows.Forms.CheckBox m_CheckBoxDate;
        private System.Windows.Forms.ListBox m_ListBoxPictureData;
        private System.Windows.Forms.ComboBox m_ComboBoxAlbumsNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_LabelTo;
        private System.Windows.Forms.Label m_LabelFrom;
        private System.Windows.Forms.DateTimePicker m_DateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker m_DateTimePickerFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox m_PictureBoxSelectedImage;
        private System.Windows.Forms.Button m_ButtonSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label m_LabelLikes;
        private System.Windows.Forms.Label m_LabelComments;
        private System.Windows.Forms.CheckBox m_CheckBoxTaggedFriends;
        private System.Windows.Forms.ComboBox m_ComboBoxTaggedFriend;
        private System.Windows.Forms.NumericUpDown m_NumericUpDownLikes;
        private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanelImages;
        private System.Windows.Forms.ImageList imageList1;
    }
}