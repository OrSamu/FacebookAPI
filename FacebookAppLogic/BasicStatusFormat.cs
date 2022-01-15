using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class BasicStatusFormat : IStatusFormatStrategy
    {
        public string GenerateStatusFormat(Post i_PostToFormat)
        {
            try
            {
                return i_PostToFormat.Message;
            }
            catch (Exception exception)
            {
                throw new Exception($"Error, access post failed - {exception}");
            }
        }
    }
}