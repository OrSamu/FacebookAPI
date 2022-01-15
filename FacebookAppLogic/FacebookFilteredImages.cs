using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookFilteredImages:IEnumerable<Photo>
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

        public void CreateFilteredPhotos()
        {
            FilteredPhotos.Clear();
            if (Albums == null)
            {
                Albums = UserDataManager.Instance.RetrieveUserAlbums();
            }

            if (Filters.SelectedAlbumIndex == null)
            {
                foreach (Album album in Albums)
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

        private void filterByDate(Photo i_Photo)
        {
            if(Filters.MinCreationDate != null)
            {
                if(i_Photo.CreatedTime >= Filters.MinCreationDate && i_Photo.CreatedTime <= Filters.MaxCreationDate)
                {
                    FilteredPhotos.Add(i_Photo);
                }
            }
            else
            {
                FilteredPhotos.Add(i_Photo);
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
        
        public IEnumerator<Photo> GetEnumerator()
        {
            return new FilteredPhotosIterator(this);
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class FilteredPhotosIterator : IEnumerator<Photo>
        {
            private FacebookFilteredImages m_Agregate;
            private int m_Count;
            private int m_Index=-1;

            public FilteredPhotosIterator(FacebookFilteredImages i_Collection)
            {
                m_Agregate = i_Collection;
                m_Count = m_Agregate.FilteredPhotos.Count;
            }
            public Photo Current
            {
                get
                {
                    return m_Agregate.FilteredPhotos[m_Index];
                }
            }

            object System.Collections.IEnumerator.Current 
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
                return;
            }

            public bool MoveNext()
            {
                if (m_Count != m_Agregate.FilteredPhotos.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }
                if (m_Index >= m_Count)
                {
                    throw new Exception("Already reached the end of the collection");
                }

                return ++m_Index < m_Agregate.FilteredPhotos.Count;
            }

            public void Reset()
            {
                m_Index = -1;
            }
        }
        
    }
}