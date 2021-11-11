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
    public class GridPhoto: PictureBox
    {
        private Photo m_Photo;
        public GridPhoto(Photo i_Photo)
        {
            m_Photo = i_Photo;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.LoadAsync(i_Photo.PictureAlbumURL);
        }

        public Photo Photo
        {
            get { return m_Photo; }
            set { m_Photo = value; }
        }

    }
}
