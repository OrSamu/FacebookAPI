using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class PostAdapter : IPostData
    {

        private readonly Post r_OldFormatPost;

        public PostAdapter(Post i_PostToFormat)
        {
            r_OldFormatPost = i_PostToFormat;
        }

        public string GeneratePostWithDataFormat()
        {
            try
            {
                string newPost;

                newPost = string.Format("({0}) - (Likes: {1}): {2}",
                    r_OldFormatPost.CreatedTime.ToString(),
                    r_OldFormatPost.LikedBy.Count,
                    r_OldFormatPost.ToString());

                return newPost;
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to format user's posts");
            }
        }
    }
}
