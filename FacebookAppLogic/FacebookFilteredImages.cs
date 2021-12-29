using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookFilteredImages
    {
        public FacebookFilteredImages()
        {
            Filters = new Filters();
            Albums = null;
            FilteredPhotos = new List<Photo>();
        }
        public Filters Filters { get; set; }
        public FacebookObjectCollection<Album> Albums { get; private set; }
        public List<Photo> FilteredPhotos { get; private set; }

        public List<Photo> FetchFilteredPhotos()
        {
            FilteredPhotos.Clear();
            if(Albums==null)
            {
                Albums = UserDataManager.Instance.UserAlbums;
            }

            if (Filters.SelectedAlbumIndex == null)
            {
                foreach(Album album in Albums)
                {
                    searchInAlbum(album);
                }
            }
            else
            {
                searchInAlbum(Albums[(int)Filters.SelectedAlbumIndex]);
            }
            return FilteredPhotos;
        }

        private void searchInAlbum(Album i_Album)
        {
            foreach(Photo photo in i_Album.Photos)
            {
                if(photo.LikedBy.Count >= Filters.MinAmoutOfLikes)
                {
                    if(Filters.TaggedFriend != null)
                    {
                        foreach(PhotoTag tag in photo.Tags)
                        {
                            if(tag.User.Name == Filters.TaggedFriend)
                            {
                                filterByDate(photo);
                            }
                        }
                    }
                    else
                    {
                        filterByDate(photo);
                    }
                }
            }
        }

        private void filterByDate(Photo i_Photo)
        {
            if (Filters.MinCreationDate != null)
            {
                if (i_Photo.CreatedTime >= Filters.MinCreationDate
                   && i_Photo.CreatedTime <= Filters.MaxCreationDate)
                {
                    FilteredPhotos.Add(i_Photo);
                }
            }
            else
            {
                FilteredPhotos.Add(i_Photo);
            }
        }

        public List<Photo> SortPhotoListByLikes()
        {

            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.LikedBy.Count).ToList();
            return FilteredPhotos;
        }

        public List<Photo> SortPhotoListByCreatedTime()
        {
            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.CreatedTime).ToList();
            return FilteredPhotos;
        }
    }
}