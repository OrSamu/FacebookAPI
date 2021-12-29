using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;
using System.Threading;
namespace BasicFacebookFeatures
{
    public partial class AdvancedImageSearchForm : Form
    {
        private const string k_NoAlbumPickedError = "Please choose an album";
        private const string k_SortByLikes = "Likes";
        private const string k_SortByCreationDate = "Creation Date";
        private const string k_NoTaggedPickedError = "Please choose a tagged friend";
        private const string k_NoPhotosFoundError = "No photos to retrieve :(";
        private const string k_RedHexCode = "#cc0202";
        private const string k_GreenHexCode = "#39B54A";
        private readonly AdvanceImageSearch r_AdvanceImageSearch;


        public AdvancedImageSearchForm()
        {
            r_AdvanceImageSearch = new AdvanceImageSearch();
            InitializeComponent();
            createAlbumListBox();
            createFriendListBox();
            createImageDataListBox();
            this.PerformLayout();
        }

        private void createAlbumListBox()
        {
            foreach (Album album in UserDataManager.Instance.UserAlbums)
            {
                comboBoxAlbumsNames.Items.Add(album.Name);
            }
        }

        private void createFriendListBox()
        {

            foreach (User friendUser in UserDataManager.Instance.User.Friends)
            {
                comboBoxTaggedFriend.Items.Add(friendUser.Name);
            }
        }
        private void createImageDataListBox()
        {
            comboBoxShowData.Items.Add(r_AdvanceImageSearch.GetLikesDataType());
            comboBoxShowData.Items.Add(r_AdvanceImageSearch.GetCommentDataType());
            comboBoxShowData.Items.Add(r_AdvanceImageSearch.GetTagsDataType());
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
            if (fecthFilters(r_AdvanceImageSearch.GetFilters()))
            {
                buttonSearch.Text = "Loading...";
                buttonSearch.Enabled = false;
                buttonSearch.BackColor = System.Drawing.ColorTranslator.FromHtml(k_RedHexCode);
                flowLayoutPanelImages.Controls.Clear();
                listBoxPictureData.Items.Clear();
                new Thread(showFilteredPhotos).Start();
            }
                
        }
        private void showFilteredPhotos()
        {
            try
            {
                List<Photo> gridPhotos = r_AdvanceImageSearch.GetFilteredImages();
                if (gridPhotos.Count == 0)
                {
                    MessageBox.Show(k_NoPhotosFoundError);
                }
                else
                {
                    addPhotoToListBoxImagePanel(gridPhotos);
                    comboBoxSortBy.Invoke(new Action(() => comboBoxSortBy.Enabled = true));
                }

                buttonSearch.Invoke(new Action(() =>
                {
                    buttonSearch.Text = "Search";
                    buttonSearch.Enabled = true;
                    buttonSearch.BackColor = System.Drawing.ColorTranslator.FromHtml(k_GreenHexCode);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool fecthFilters(Filters i_Filters)
        {
            bool validInput = true;
            i_Filters.MinAmoutOfLikes = checkBoxLikes.Checked ? (int)numericUpDownLikes.Value : 0;
            i_Filters.SelectedAlbumIndex = checkBoxAlbum.Checked ? (int?)comboBoxAlbumsNames.SelectedIndex : null;
            i_Filters.TaggedFriend = checkBoxTaggedFriends.Checked ? comboBoxTaggedFriend.Text : null;

            if (checkBoxDate.Checked)
            {
                i_Filters.MinCreationDate = m_DateTimePickerFromDate.Value;
                i_Filters.MaxCreationDate = dateTimePickerToDate.Value;
            }
            else
            {
                i_Filters.MinCreationDate = null;
                i_Filters.MaxCreationDate = null;
            }

            if(i_Filters.SelectedAlbumIndex==-1)
            {
                validInput = false;
                MessageBox.Show(k_NoAlbumPickedError);
            }
            if (checkBoxTaggedFriends.Checked && string.IsNullOrEmpty(i_Filters.TaggedFriend))
            {
                MessageBox.Show(k_NoTaggedPickedError);
                validInput = false;
            }
            return validInput;
        }

        private void addPhotoToListBoxImagePanel(List<Photo> i_GridPhotos)
        {
            if (flowLayoutPanelImages.Controls.Count != 0)
            {
                flowLayoutPanelImages.Invoke(new Action(() => flowLayoutPanelImages.Controls.Clear()));
            }

            foreach (Photo photo in i_GridPhotos)
            {
                flowLayoutPanelImages.Invoke(new Action(() =>
                {
                    GridPhoto picture = new GridPhoto(photo);
                    picture.Click += Picture_Click;
                    flowLayoutPanelImages.Controls.Add(picture);
                }));
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            comboBoxShowData.Enabled = true;            
            r_AdvanceImageSearch.SetSelectedImage((sender as GridPhoto).Photo);
            string SelectedImageURL = r_AdvanceImageSearch.GetURLOfSlectedPhoto();

            if (SelectedImageURL != null)
            {
                pictureBoxSelectedImage.LoadAsync(SelectedImageURL);
            }
            else
            {
                pictureBoxSelectedImage.Image = pictureBoxSelectedImage.ErrorImage;
            }

            labelLikes.Text = "Likes:" + r_AdvanceImageSearch.GetAmountOfLikesOfSelectedPhoto();
            labelComments.Text = "Comments:" + r_AdvanceImageSearch.GetAmountOfCommentsOfSelectedPhoto();
            new Thread(updateListBoxData).Start();
        }

        private void m_ComboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Photo> gridPhotos=null;
            if (comboBoxSortBy.Text == k_SortByCreationDate)
            {
                gridPhotos = r_AdvanceImageSearch.GetFilteredImagesSortedCreationDate();
            }

            if(comboBoxSortBy.Text == k_SortByLikes)
            {
                gridPhotos = r_AdvanceImageSearch.GetFilteredImagesSortedByLikes();
            }

            addPhotoToListBoxImagePanel(gridPhotos);
        }

        private void updateListBoxData()
        {
            try
            {
                if(comboBoxShowData.SelectedIndex>=0)
                {
                    IPhotoData photoData = (comboBoxShowData.SelectedItem as IPhotoData);
                    listBoxPictureData.Items.Clear();
                    
                    List<string> imageData= r_AdvanceImageSearch.GetDataOfSelectedImage(photoData);

                    if (imageData.Count != 0)
                    {
                        foreach (string data in imageData)
                        {
                            listBoxPictureData.Invoke(new Action(() => listBoxPictureData.Items.Add(data)));

                        }
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void comboBoxShowData_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(updateListBoxData).Start();
        }
    }
}