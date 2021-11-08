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
namespace BasicFacebookFeatures
{
    public partial class AdvancedImageForm : Form
    {
        private const string k_ShowPhotoComment = "Comments";
        private const string k_ShowPhotoTags = "Tags";
        private const string k_ShowPhotoLikedBy = "Liked By";
        private const string k_SortByLikes = "Likes";
        private const string k_SortByCreationDate = "Creation Date";
        User m_LoggedInUser;
        List<Photo> m_Photos;
        Photo m_SelectedPhoto;

        public AdvancedImageForm(User i_User)
        {
            m_Photos = new List<Photo>();
            m_LoggedInUser = i_User;
            InitializeComponent();
            createAlbumListBox();
            createFriendListBox();
            this.PerformLayout();
        }
        private void m_CheckBoxDate_CheckedChanged(object sender, EventArgs e)
        {

            m_DateTimePickerFromDate.Enabled = m_CheckBoxDate.Checked;
            m_DateTimePickerToDate.Enabled = m_CheckBoxDate.Checked;            
        }


        private void m_CheckBoxLikes_CheckedChanged(object sender, EventArgs e)
        {
            m_NumericUpDownLikes.Enabled= m_CheckBoxLikes.Checked;
        }

        private void m_CheckBoxAlbum_CheckedChanged(object sender, EventArgs e)
        {

            m_ComboBoxAlbumsNames.Enabled = m_CheckBoxAlbum.Checked;        
        }
        private void createAlbumListBox()
        {
            foreach (Album album in m_LoggedInUser.Albums)
            {
                m_ComboBoxAlbumsNames.Items.Add(album.Name);
            }
            
        }
        private void createFriendListBox()
        {
            foreach (User friendUser in m_LoggedInUser.Friends)
            {
                m_ComboBoxTaggedFriend.Items.Add(friendUser.Name);
            }
            

        }
        private void m_ListBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ComboBoxShow.Enabled = true;
            if (m_ListBoxPictures.SelectedItems.Count == 1)
            {
                m_SelectedPhoto = m_ListBoxPictures.SelectedItem as Photo;

                if (m_SelectedPhoto.PictureNormalURL != null)
                {
                    m_PictureBoxSelectedImage.LoadAsync(m_SelectedPhoto.PictureNormalURL);
                }
                else
                {
                    m_PictureBoxSelectedImage.Image = m_PictureBoxSelectedImage.ErrorImage;
                }
                m_LabelLikes.Text = "Likes:" + m_SelectedPhoto.LikedBy.Count;
                m_LabelComments.Text = "Comments:" + m_SelectedPhoto.Comments.Count;
            }
            updateListBoxData();


        }
        private void m_ButtonSearch_Click(object sender, EventArgs e)
        {
            int minAmountOfLikes = 0;
            m_Photos.Clear();
            Album albumToSearch = null;
            string taggedFriend;
            m_ComboBoxSortBy.Enabled = true;
            try
            {
                if (m_CheckBoxLikes.Checked)
                {

                    minAmountOfLikes = (int)m_NumericUpDownLikes.Value;
                }
                else
                {
                    minAmountOfLikes = 0;
                }
                if (m_CheckBoxAlbum.Checked)
                {
                    albumToSearch = m_LoggedInUser.Albums[m_ComboBoxAlbumsNames.SelectedIndex];
                }
                if (m_CheckBoxTaggedFriends.Checked)
                {
                    taggedFriend = m_ComboBoxTaggedFriend.Text;
                }
                m_ListBoxPictures.Items.Clear();
                m_ListBoxPictureData.Items.Clear();
                if (albumToSearch == null)
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        searchInAlbum(album, minAmountOfLikes);

                    }

                }
                else
                {
                    searchInAlbum(albumToSearch, minAmountOfLikes);

                }

                if (m_ListBoxPictures.Items.Count == 0)
                {
                    MessageBox.Show("No photos to retrieve :(");
                }
                else
                {
                    m_ComboBoxSortBy.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void searchInAlbum(Album i_Album, int i_MinAmountOfLikes)
        {
            foreach (Photo photo in i_Album.Photos)
            {
                if (photo.LikedBy.Count >= i_MinAmountOfLikes)
                {
                    if (m_CheckBoxTaggedFriends.Checked)
                    {
                        foreach (PhotoTag tag in photo.Tags)
                        {
                            if(tag.User.Name==m_ComboBoxTaggedFriend.Text)
                            {
                                if (m_CheckBoxDate.Checked)
                                {
                                    if (photo.CreatedTime >= m_DateTimePickerFromDate.Value && photo.CreatedTime <= m_DateTimePickerToDate.Value)
                                    {
                                        m_ListBoxPictures.Items.Add(photo);
                                        m_Photos.Add(photo);
                                    }

                                }
                                else
                                {
                                    m_ListBoxPictures.Items.Add(photo);
                                    m_Photos.Add(photo);

                                }

                            }
                        }
                    }
                    else
                    {
                        if (m_CheckBoxDate.Checked)
                        {
                            if (photo.CreatedTime >= m_DateTimePickerFromDate.Value && photo.CreatedTime <= m_DateTimePickerToDate.Value)
                            {
                                m_ListBoxPictures.Items.Add(photo);
                                m_Photos.Add(photo);
                            }

                        }
                        else
                        {
                            m_ListBoxPictures.Items.Add(photo);
                            m_Photos.Add(photo);
                            
                        }

                    }
                }
            }
        }


        private void addPhotoToListBox()
        {
            m_ListBoxPictures.Items.Clear();
            foreach (Photo photo in m_Photos)
            {
                m_ListBoxPictures.Items.Add(photo);
            }

        }

        private void m_ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_ComboBoxSortBy.Text==k_SortByCreationDate)
            {
                sortPhotoListByCreatedTime();
            }

            if(m_ComboBoxSortBy.Text == k_SortByLikes)
            {
                sortPhotoListByLikes();
            }
            addPhotoToListBox();
        }
        private void sortPhotoListByLikes()
        {

            m_Photos = m_Photos.OrderByDescending(o => o.LikedBy.Count).ToList();
        }
        private void sortPhotoListByCreatedTime()
        {

            m_Photos = m_Photos.OrderByDescending(o => o.CreatedTime).ToList();
        }
        private void updateListBoxData()
        {
            m_ListBoxPictureData.Items.Clear();
            if (m_SelectedPhoto != null)
            {
                if (m_ComboBoxShow.Text == k_ShowPhotoComment)
                {
                    if (m_SelectedPhoto.Comments != null)
                    {
                        foreach (Comment comment in m_SelectedPhoto.Comments)
                        {
                            m_ListBoxPictureData.Items.Add(comment.Message);
                        }

                    }


                }
                if (m_ComboBoxShow.Text == k_ShowPhotoLikedBy)
                {
                    if (m_SelectedPhoto.LikedBy != null)
                    {
                        foreach (User user in m_SelectedPhoto.LikedBy)
                        {
                            m_ListBoxPictureData.Items.Add(user.Name);
                        }
                    }


                }
                if (m_ComboBoxShow.Text == k_ShowPhotoTags)
                {
                    if (m_SelectedPhoto.Tags != null)
                    {
                        foreach (PhotoTag Tag in m_SelectedPhoto.Tags)
                        {
                            m_ListBoxPictureData.Items.Add(Tag.User.Name);
                        }
                    }

                }
            }

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBoxData();
        }

        private void m_CheckBoxTaggedFriens_CheckedChanged(object sender, EventArgs e)
        {
            m_ComboBoxTaggedFriend.Enabled = m_CheckBoxTaggedFriends.Checked;
        }

    }
}
