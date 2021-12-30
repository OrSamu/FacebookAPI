using System.Collections.Generic;
using FacebookWrapper.ObjectModel;


namespace FacebookAppLogic
{
   public class AdvanceImageSearch
    {

        private readonly FacebookFilteredImages r_FacebookFilteredImages;
        private SelectedImage m_SelectedImage;

        public AdvanceImageSearch()
        {
            r_FacebookFilteredImages = new FacebookFilteredImages();
            m_SelectedImage = new SelectedImage();
        }
        public PhotoTags GetTagsDataType()
        {
            return new PhotoTags();
        }
        public PhotoLikes GetLikesDataType()
        {
            return new PhotoLikes();
        }
        public PhotoComments GetCommentDataType()
        {
            return new PhotoComments();
        }
        public void SetSelectedImage(Photo i_Photo)
        {
            m_SelectedImage.Photo = i_Photo;
        }
        public int GetAmountOfLikesOfSelectedPhoto()
        {
            return m_SelectedImage.LikesAmount;
        }
        public int GetAmountOfCommentsOfSelectedPhoto()
        {
            return m_SelectedImage.CommentsAmount;
        }
        public string GetURLOfSlectedPhoto()
        {
            return m_SelectedImage.PhotoURL;
        }
        public List<string> GetDataOfSelectedImage(IPhotoData i_DataType)
        {
            return m_SelectedImage.FetchSelectedData(i_DataType);
        }


        public List<Photo> GetFilteredImages()
        {
            return r_FacebookFilteredImages.FetchFilteredPhotos();
        }

        public Filters GetFilters()
        {
           return r_FacebookFilteredImages.Filters;
        }
        public List<Photo> GetFilteredImagesSortedByLikes()
        {
            return r_FacebookFilteredImages.SortPhotoListByLikes();
        }
        public List<Photo> GetFilteredImagesSortedCreationDate()
        {
            return r_FacebookFilteredImages.SortPhotoListByCreatedTime();
        }
    }
}
