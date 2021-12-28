using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebookLogicController
    {
        public User LoggedInUser { get; set; }

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
            catch(Exception exception)
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
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve friends");
            }
        }

        public List<string> RetrievePostedStatuses()
        {
            List<string> postsList = new List<string>();

            try
            {
                foreach(Post post in LoggedInUser.Posts)
                {
                    StatusAdapter newStatus = new StatusAdapter(post);
                    postsList.Add(newStatus.GenerateStatusFormat());
                }
            }
            catch(Exception exception)
            {
                throw new Exception("Error - failed to retrieve posted statuses");
            }

            return postsList;
        }

        public void PostStatus(string i_StatusToPost)
        {
            try
            {
                LoggedInUser.PostStatus(i_StatusToPost);
            }
            catch(Exception exception)
            {
                throw new Exception("Error - Failed to post status");
            }
        }

        public List<string> RetrieveCommentsForStatus(int i_IndexForRelatedStatus)
        {
            List<string> commentsRelated = new List<string>();

            try
            {
                foreach(Comment commentOnStatus in LoggedInUser.Posts[i_IndexForRelatedStatus].Comments)
                {
                    commentsRelated.Add(commentOnStatus.Message);
                }
            }
            catch(Exception exception)
            {
                throw new Exception("Error - Failed to retrieve comments");
            }

            return commentsRelated;
        }

        public List<String> RetrieveEvents()
        {
            List<String> eventsNames = new List<string>();

            try
            {
                foreach(Event fbEvent in LoggedInUser.Events)
                {
                    eventsNames.Add(fbEvent.Name);
                }
            }
            catch(Exception exception)
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
                foreach(Page likedPage in LoggedInUser.LikedPages)
                {
                    pagesNames.Add(likedPage.Name);
                }
            }
            catch(Exception exception)
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
                foreach(Group group in LoggedInUser.Groups)
                {
                    groupsNames.Add(group.Name);
                }
            }
            catch(Exception exception)
            {
                throw new Exception("Error - Failed to load groups");
            }

            return groupsNames;
        }
    }
}