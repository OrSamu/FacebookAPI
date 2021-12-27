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
        public Photo Photo { get; set; }
        public GridPhoto(Photo i_Photo)
        {
            Photo = i_Photo;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.WaitOnLoad = false;
            //this.Invoke(new Action(() => this.LoadAsync(i_Photo.PictureAlbumURL)));
            this.LoadAsync(i_Photo.PictureAlbumURL);
        }
    }
}
