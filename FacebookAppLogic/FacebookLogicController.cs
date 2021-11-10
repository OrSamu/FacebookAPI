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
                "user_hometown",
                "user_location",
                "groups_access_member_info",
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

        public List<string> RetrievePostedStatuses()
        {
            List<string> postsList = new List<string>();
            try
            {
                foreach (Post post in LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        postsList.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        postsList.Add(post.Caption);
                    }
                    else
                    {
                        postsList.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve friends");
            }

            return postsList;
        }

        public void PostStatus(string i_StatusToPost)
        {
            try
            {
                LoggedInUser.PostStatus(i_StatusToPost);
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to post status");
            }
        }

        /*public List<string> RetrieveCommentsForStatus(int i_IndexForRelatedStatus)
        {
            List<string> commentsRelated = new List<string>();

            FacebookObjectCollection<Comment> newComment = LoggedInUser.Posts[i_IndexForRelatedStatus].Comments;

            return commentsRelated;
        }*/

        public List<String> RetrieveEvents()
        {
            List<String> eventsNames = new List<string>();

            try
            {
                foreach (Event fbEvent in LoggedInUser.Events)
                {
                    eventsNames.Add(fbEvent.Name);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load events");
            }

            return eventsNames;
        }

        public List<String> RetrievePages()
        {
            List<String> pagesNames = new List<string>();

            try
            {
                foreach (Page likedPage in LoggedInUser.LikedPages)
                {
                    pagesNames.Add(likedPage.Name);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load pages");
            }

            return pagesNames;
        }

        public List<String> RetrieveGroups()
        {
            List<String> groupsNames = new List<string>();

            try
            {
                foreach (Group group in LoggedInUser.Groups)
                {
                    groupsNames.Add(group.Name);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load groups");
            }

            return groupsNames;
        }


    }
}
