using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookLogicController
    {
        public User LoggedInUser
        {
            get; 
            private set;
        }

        public void Login()
        {
            bool isAccessTokenEmpty = true;
            LoginResult loginResult = FacebookService.Login(
                "973153713605868",
                
                "user_likes",
                "user_photos",
                "user_posts",
                "user_friends",
                "user_birthday",
                "user_gender",
                "user_videos",
                "user_link",
                "user_events",
                //"user_tagged_places",
                //"user_hometown",
                //"user_location",
                //"groups_access_member_info",
                "email");

            isAccessTokenEmpty = string.IsNullOrEmpty(loginResult.AccessToken);
            if (!isAccessTokenEmpty)
            {
                LoggedInUser = loginResult.LoggedInUser;
            }
            else
            {
                throw new Exception("Login failed - please try again");
            }
        }

        public void Logout()
        {
            FacebookService.Logout(null);
            LoggedInUser = null;
        }

        public string RetrieveProfilePicture()
        {
            try
            {
                return LoggedInUser.PictureNormalURL;
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve profile picture");
            }
        }

        public string RetrieveUsername()
        {
            try
            {
                return LoggedInUser.FirstName + ' ' + LoggedInUser.LastName;
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve username");
            }
        }

        public FacebookObjectCollection<User> RetrieveFriends()
        {
            try
            {
                return LoggedInUser.Friends;
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve friends");
            }
        }
    }
}
