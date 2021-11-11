using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
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
            foreach (Album album in i_User.Albums)
            {
                m_ComboBoxAlbumsNames.Items.Add(album.Name);
            }

        }
        private void createFriendListBox(User i_User)
        {
            foreach (User friendUser in i_User.Friends)
            {
                m_ComboBoxTaggedFriend.Items.Add(friendUser.Name);
            }


        }
        private void m_CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {

            m_DateTimePickerFromDate.Enabled = m_CheckBoxDate.Checked;
            m_DateTimePickerToDate.Enabled = m_CheckBoxDate.Checked;
        }


        private void m_CheckBoxLikes_CheckedChanged(object sender, EventArgs e)
        {
            m_NumericUpDownLikes.Enabled = m_CheckBoxLikes.Checked;
        }

        private void m_CheckBoxAlbum_CheckedChanged(object sender, EventArgs e)
        {

            m_ComboBoxAlbumsNames.Enabled = m_CheckBoxAlbum.Checked;
        }
        private void m_CheckBoxTaggedFriends_CheckedChanged(object sender, EventArgs e)
        {
            m_ComboBoxTaggedFriend.Enabled = m_CheckBoxTaggedFriends.Checked;
        }

        private void m_ButtonSearch_Click(object sender, EventArgs e)
        {
            r_FacebookImages.Filters.ResetFilter();
            if (fecthFilters(r_FacebookImages.Filters))
            {                
                try
                {
                    r_FacebookImages.FetchFilteredPhotos();
                    m_FlowLayoutPanelImages.Controls.Clear();
                    m_ListBoxPictureData.Items.Clear();

                    if (r_FacebookImages.Photos.Count == 0)
                    {
                        MessageBox.Show(k_NoPhotosFoundError);
                    }
                    else
                    {
                        addPhotoToListBoxImagePanel();
                        m_ComboBoxSortBy.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
   

        }

        private bool fecthFilters(Filters i_Filters)
        {
            bool validInput = true;
            if (m_CheckBoxLikes.Checked)
            {

                i_Filters.MinAmoutOfLikes = (int)m_NumericUpDownLikes.Value;
            }

            if(m_CheckBoxDate.Checked)
            {
                i_Filters.MinCreationDate = m_DateTimePickerFromDate.Value;
                i_Filters.MaxCreationDate = m_DateTimePickerToDate.Value;
            }

            if (m_CheckBoxAlbum.Checked)
            {
                if(m_ComboBoxAlbumsNames.SelectedIndex!=-1)
                {
                    i_Filters.SelectedAlbumIndex= m_ComboBoxAlbumsNames.SelectedIndex;
                }
                else
                {
                    validInput = false;
                    MessageBox.Show(k_NoAlbumPickedError);
                }
               
            }

            if (m_CheckBoxTaggedFriends.Checked)
            {
                if (m_ComboBoxTaggedFriend.SelectedIndex != -1)
                {
                    i_Filters.TaggedFriend= m_ComboBoxTaggedFriend.Text; 
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
            if (m_FlowLayoutPanelImages.Controls.Count != 0)
            {
                m_FlowLayoutPanelImages.Controls.Clear();
            }
            foreach (Photo photo in r_FacebookImages.Photos)
            {
                GridPhoto picture = new GridPhoto(photo);
                picture.Click += Picture_Click;
                m_FlowLayoutPanelImages.Controls.Add(picture);
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            m_ComboBoxShow.Enabled = true;

            r_FacebookImages.SelectedPhoto = (sender as GridPhoto).Photo;

            if (r_FacebookImages.SelectedPhoto.PictureNormalURL != null)
            {
                m_PictureBoxSelectedImage.LoadAsync(r_FacebookImages.SelectedPhoto.PictureNormalURL);
            }
            else
            {
                m_PictureBoxSelectedImage.Image = m_PictureBoxSelectedImage.ErrorImage;
            }
            m_LabelLikes.Text = "Likes:" + r_FacebookImages.SelectedPhoto.LikedBy.Count;
            m_LabelComments.Text = "Comments:" + r_FacebookImages.SelectedPhoto.Comments.Count;

            updateListBoxData();
        }


        private void m_ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ComboBoxSortBy.Text == k_SortByCreationDate)
            {
                r_FacebookImages.SortPhotoListByCreatedTime();
            }

            if (m_ComboBoxSortBy.Text == k_SortByLikes)
            {
                r_FacebookImages.SortPhotoListByLikes();
            }
            addPhotoToListBoxImagePanel();
        }

        private void updateListBoxData()
        {
            m_ListBoxPictureData.Items.Clear();
            List<string> imageData;
            imageData = r_FacebookImages.SelectedImageData(m_ComboBoxShow.SelectedIndex);
            if(imageData.Count!=0)
            {
                foreach (string data in imageData)
                {
                    m_ListBoxPictureData.Items.Add(data);
                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBoxData();
        }



    }
}
