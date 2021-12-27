using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookAppLogic;
using System.Threading;
namespace BasicFacebookFeatures
{
    public partial class AdvancedImageForm : Form
    {
        private readonly FacebookFilteredImages r_FacebookImages;
        private const string k_NoAlbumPickedError = "Please choose an album";
        private const string k_SortByLikes = "Likes";
        private const string k_SortByCreationDate = "Creation Date";
        private const string k_NoTaggedPickedError = "Please choose a tagged friend";
        private const string k_NoPhotosFoundError = "No photos to retrieve :(";
        private const string k_RedHexCode = "#cc0202";
        private const string k_GreenHexCode = "#39B54A";
        

        public AdvancedImageForm()
        {
            r_FacebookImages = new FacebookFilteredImages();
            InitializeComponent();
            createAlbumListBox();
            createFriendListBox();
            createImageDataListBox();
            this.PerformLayout();
        }

        private void createAlbumListBox()
        {
            foreach (Album album in UserDataManager.Instance.User.Albums)
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
            comboBoxShowData.Items.Add(new PhotoLikes());
            comboBoxShowData.Items.Add(new PhotoComments());
            comboBoxShowData.Items.Add(new PhotoTags());
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
            if (fecthFilters(r_FacebookImages.Filters))
            {
                buttonSearch.Text = "Loading...";
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
                r_FacebookImages.FetchFilteredPhotos();
            //flowLayoutPanelImages.Invoke(new Action(() => flowLayoutPanelImages.Controls.Clear()));
            //listBoxPictureData.Invoke(new Action(() => listBoxPictureData.Items.Clear()));
                if (r_FacebookImages.FilteredPhotos.Count == 0)
                {
                    MessageBox.Show(k_NoPhotosFoundError);
                }
                else
                {
                    addPhotoToListBoxImagePanel();
                    comboBoxSortBy.Invoke(new Action(() => comboBoxSortBy.Enabled = true));
                }

                buttonSearch.Invoke(new Action(() => {
                buttonSearch.Text = "Search";
                buttonSearch.BackColor = System.Drawing.ColorTranslator.FromHtml(k_GreenHexCode);
                }));

                //comboBoxSortBy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                flowLayoutPanelImages.Invoke(new Action(() => flowLayoutPanelImages.Controls.Clear()));
            }

            foreach(Photo photo in r_FacebookImages.FilteredPhotos)
            {
                flowLayoutPanelImages.Invoke(new Action(() => {
                    GridPhoto picture = new GridPhoto(photo);
                    picture.Click += Picture_Click;
                    flowLayoutPanelImages.Controls.Add(picture);
                    }));
            }
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            comboBoxShowData.Enabled = true;

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
            try
            {
                if(comboBoxShowData.SelectedIndex>=0)
                {
                    IPhotoData photoData = (comboBoxShowData.SelectedItem as IPhotoData);
                    listBoxPictureData.Items.Clear();
                    List<string> imageData = photoData.GetData(r_FacebookImages.SelectedPhoto);

                    if (imageData.Count != 0)
                    {
                        foreach (string data in imageData)
                        {
                            listBoxPictureData.Items.Add(data);
                            //listBoxPictureData.Invoke(new Action(() => listBoxPictureData.Items.Add(data)));

                        }
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            //Old

            //List<string> imageData;
            //listBoxPictureData.Items.Clear();
            //imageData = r_FacebookImages.SelectedImageData(comboBoxShowData.SelectedIndex);
            //if(imageData.Count != 0)
            //{
            //    foreach(string data in imageData)
            //    {
            //        listBoxPictureData.Invoke(new Action(() => listBoxPictureData.Items.Add(data)));
            //        //listBoxPictureData.Items.Add(data);
            //    }
            //}
        }

        private void comboBoxShowData_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBoxData();
            //new Thread(updateListBoxData).Start();
        }
    }
}