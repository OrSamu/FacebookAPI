using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    public partial class AdvancedImageForm : Form
    {
        private readonly FacebookImages r_FacebookImages;
        private const string k_NoAlbumPickedError = "Please choose an album";
        private const string k_SortByLikes = "Likes";
        private const string k_SortByCreationDate = "Creation Date";
        private const string k_NoTaggedPickedError = "Please choose a tagged friend";
        private const string k_NoPhotosFoundError = "No photos to retrieve :(";

        public AdvancedImageForm(User i_User)
        {
            r_FacebookImages = new FacebookImages(i_User);
            InitializeComponent();
            createAlbumListBox(i_User);
            createFriendListBox(i_User);
            this.PerformLayout();
        }

        private void createAlbumListBox(User i_User)
        {
            foreach(Album album in i_User.Albums)
            {
                comboBoxAlbumsNames.Items.Add(album.Name);
            }
        }

        private void createFriendListBox(User i_User)
        {
            foreach(User friendUser in i_User.Friends)
            {
                comboBoxTaggedFriend.Items.Add(friendUser.Name);
            }
        }

        private void m_CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            m_DateTimePickerFromDate.Enabled = checkBoxDate.Checked;
            dateTimePickerToDate.Enabled = checkBoxDate.Checked;
        }

        private void m_CheckBoxLikes_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownLikes.Enabled = checkBoxLikes.Checked;
        }

        private void m_CheckBoxAlbum_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxAlbumsNames.Enabled = checkBoxAlbum.Checked;
        }

        private void m_CheckBoxTaggedFriends_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxTaggedFriend.Enabled = checkBoxTaggedFriends.Checked;
        }

        private void m_ButtonSearch_Click(object sender, EventArgs e)
        {
            r_FacebookImages.Filters.ResetFilter();
            if(fecthFilters(r_FacebookImages.Filters))
            {
                try
                {
                    r_FacebookImages.FetchFilteredPhotos();
                    flowLayoutPanelImages.Controls.Clear();
                    listBoxPictureData.Items.Clear();

                    if(r_FacebookImages.Photos.Count == 0)
                    {
                        MessageBox.Show(k_NoPhotosFoundError);
                    }
                    else
                    {
                        addPhotoToListBoxImagePanel();
                        comboBoxSortBy.Enabled = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool fecthFilters(Filters i_Filters)
        {
            bool validInput = true;
            if(checkBoxLikes.Checked)
            {
                i_Filters.MinAmoutOfLikes = (int)numericUpDownLikes.Value;
            }

            if(checkBoxDate.Checked)
            {
                i_Filters.MinCreationDate = m_DateTimePickerFromDate.Value;
                i_Filters.MaxCreationDate = dateTimePickerToDate.Value;
            }

            if(checkBoxAlbum.Checked)
            {
                if(comboBoxAlbumsNames.SelectedIndex != -1)
                {
                    i_Filters.SelectedAlbumIndex = comboBoxAlbumsNames.SelectedIndex;
                }
                else
                {
                    validInput = false;
                    MessageBox.Show(k_NoAlbumPickedError);
                }
            }

            if(checkBoxTaggedFriends.Checked)
            {
                if(comboBoxTaggedFriend.SelectedIndex != -1)
                {
                    i_Filters.TaggedFriend = comboBoxTaggedFriend.Text;
                }
                else
                {
                    MessageBox.Show(k_NoTaggedPickedError);
                    validInput = false;
                }
            }

            return validInput;
        }

        private void addPhotoToListBoxImagePanel()
        {
            if(flowLayoutPanelImages.Controls.Count != 0)
            {
                flowLayoutPanelImages.Controls.Clear();
            }

            foreach(Photo photo in r_FacebookImages.Photos)
            {
                GridPhoto picture = new GridPhoto(photo);
                picture.Click += Picture_Click;
                flowLayoutPanelImages.Controls.Add(picture);
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            comboBoxShow.Enabled = true;

            r_FacebookImages.SelectedPhoto = (sender as GridPhoto).Photo;

            if(r_FacebookImages.SelectedPhoto.PictureNormalURL != null)
            {
                pictureBoxSelectedImage.LoadAsync(r_FacebookImages.SelectedPhoto.PictureNormalURL);
            }
            else
            {
                pictureBoxSelectedImage.Image = pictureBoxSelectedImage.ErrorImage;
            }

            labelLikes.Text = "Likes:" + r_FacebookImages.SelectedPhoto.LikedBy.Count;
            labelComments.Text = "Comments:" + r_FacebookImages.SelectedPhoto.Comments.Count;

            updateListBoxData();
        }

        private void m_ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSortBy.Text == k_SortByCreationDate)
            {
                r_FacebookImages.SortPhotoListByCreatedTime();
            }

            if(comboBoxSortBy.Text == k_SortByLikes)
            {
                r_FacebookImages.SortPhotoListByLikes();
            }

            addPhotoToListBoxImagePanel();
        }

        private void updateListBoxData()
        {
            listBoxPictureData.Items.Clear();
            List<string> imageData;
            imageData = r_FacebookImages.SelectedImageData(comboBoxShow.SelectedIndex);
            if(imageData.Count != 0)
            {
                foreach(string data in imageData)
                {
                    listBoxPictureData.Items.Add(data);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBoxData();
        }
    }
}