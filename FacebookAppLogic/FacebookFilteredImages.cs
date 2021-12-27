using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookFilteredImages
    {
        //private readonly FacebookObjectCollection<Album> r_Albums = null;

        public FacebookFilteredImages()
        {
            //r_Albums = i_User.Albums;
            Filters = new Filters();
            Albums = null;
            FilteredPhotos = new List<Photo>();
        }

        public enum eDataOptions
        {
            Comments = 0,
            LikedBy,
            Tags
        }

        public Photo SelectedPhoto { get; set; } = null;
        public Filters Filters { get; set; }
        public FacebookObjectCollection<Album> Albums { get; private set; }
        public List<Photo> FilteredPhotos { get; private set; }

        public void FetchFilteredPhotos()
        {
            FilteredPhotos.Clear();
            if(Albums==null)
            {
                Albums = UserDataManager.Instance.User.Albums;
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

        private void filterByDate(Photo photo)
        {
            if (Filters.MinCreationDate != null)
            {
                if (photo.CreatedTime >= Filters.MinCreationDate
                   && photo.CreatedTime <= Filters.MaxCreationDate)
                {
                    FilteredPhotos.Add(photo);
                }
            }
            else
            {
                FilteredPhotos.Add(photo);
            }
        }

        public void SortPhotoListByLikes()
        {
            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.LikedBy.Count).ToList();
        }

        public void SortPhotoListByCreatedTime()
        {
            FilteredPhotos = FilteredPhotos.OrderByDescending(o => o.CreatedTime).ToList();
        }

        public List<string> SelectedImageData(int i_ChosenData)
        {
            List<string> photoData = new List<string>();
            if(SelectedPhoto != null)
            {
                switch((eDataOptions)i_ChosenData)
                {
                    case eDataOptions.Comments:
                        addSelectedImageComments(photoData);
                        break;
                    case eDataOptions.LikedBy:
                        addSelectedImageLikedBy(photoData);
                        break;
                    case eDataOptions.Tags:
                        addSelectedImageTagedUsers(photoData);
                        break;
                }
            }

            return photoData;
        }

        private void addSelectedImageComments(List<string> i_Data)
        {
            if(SelectedPhoto.Comments != null)
            {
                foreach(Comment comment in SelectedPhoto.Comments)
                {
                    i_Data.Add(comment.Message);
                }
            }
        }

        private void addSelectedImageLikedBy(List<string> i_Data)
        {
            if(SelectedPhoto.LikedBy != null)
            {
                foreach(User user in SelectedPhoto.LikedBy)
                {
                    i_Data.Add(user.Name);
                }
            }
        }

        private void addSelectedImageTagedUsers(List<string> i_Data)
        {
            if(SelectedPhoto.Tags != null)
            {
                foreach(PhotoTag Tag in SelectedPhoto.Tags)
                {
                    i_Data.Add(Tag.User.Name);
                }
            }
        }
    }
}