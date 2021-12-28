using System;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class StatusAdapter : IStatusFormat
    {

        private readonly Post r_OldFormatPost;

        public StatusAdapter(Post i_PostToFormat)
        {
            r_OldFormatPost = i_PostToFormat;
        }

        public string GenerateStatusFormat()
        {
            try
            {
                StringBuilder newPost = new StringBuilder();

                newPost.Append(string.Format("({0}): ", r_OldFormatPost.CreatedTime.ToString()));
                if (r_OldFormatPost.Message != null)
                {
                    newPost.Append(r_OldFormatPost.Message);
                }
                else if (r_OldFormatPost.Caption != null)
                {
                    newPost.Append(r_OldFormatPost.Caption);
                }
                else
                {
                    newPost.Append(string.Format("[{0}]", r_OldFormatPost.Type));
                }

                return newPost.ToString();
            }
            catch(Exception exception)
            {
                throw new Exception("Failed to format user's posts");
            }
        }
    }
}
