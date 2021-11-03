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
    public partial class Form1 : Form
    {
        User m_LoggedInUser;
        FacebookObjectCollection<User> m_Friends;
        FacebookObjectCollection<Photo> m_Photos;
        Album
        public Form1(User i_User)
        {
            InitializeComponent();
            m_LoggedInUser = i_User;
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if(album.Photos!=null)
                {
                    foreach (Photo Photo in album.Photos)
                    {
                        
                        m_ListBoxPictures.Items.Add(Photo);
                        //m_Photos.Add(Photo);
                    }

                }

            }
            
            
        }
        private void m_ListBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_ListBoxPictures.SelectedItems.Count == 1)
            {
                Photo selectedPhoto = m_ListBoxPictures.SelectedItem as Photo;
                if (selectedPhoto.PictureAlbumURL != null)
                {

                    //m_PictureBoxSelected.LoadAsync(selectedPhoto.PictureAlbumURL);
                    //m_PictureBoxSelected.LoadAsync(selectedPhoto.PictureNormalURL);
                    m_PictureBoxSelected.LoadAsync(selectedPhoto.PictureThumbURL);

                }
                //else
                //{
                //    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                //}
            }

        }
    }
}
