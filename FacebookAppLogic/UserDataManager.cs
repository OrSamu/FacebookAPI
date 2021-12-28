using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public sealed class UserDataManager
    {
        private static UserDataManager s_Instance = null;
        private static object s_LockObj = new Object();
        private string m_ProfilePictureURL = null;
        private string m_UserName = null;
        private FacebookObjectCollection<User> m_FriendsList = null;
        private FacebookObjectCollection<Post> m_StatusesList = null;
        private FacebookObjectCollection<Page> m_PagesList = null;
        private FacebookObjectCollection<Event> m_EventsList = null;
        private FacebookObjectCollection<Group> m_GroupsList = null;

        private UserDataManager() { }

        public static UserDataManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserDataManager();
                        }
                    }
                }

                return s_Instance;
            }
        }
        public User User { get; set; }
        public bool IsAuthenticated { get; private set; }
        public FacebookObjectCollection<Album> UserAlbums { get; set; }
        public void Login()
        {
            IsAuthenticated = false;
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
                "user_hometown",
                "user_location",
                "groups_access_member_info",
                "email");

            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                IsAuthenticated = true;
                User = loginResult.LoggedInUser;
            }
        }
        public void Logout()
        {
            FacebookService.Logout(null);
            User = null;
        }

        public string RetrieveProfilePicture()
        {
            try
            {
                if(m_ProfilePictureURL == null)
                {
                    m_ProfilePictureURL = User.PictureNormalURL;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve profile picture");
            }

            return m_ProfilePictureURL;
        }

        public string RetrieveUsername()
        {
            try
            {
                if (m_UserName == null)
                {
                    m_UserName = User.FirstName + ' ' + User.LastName;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve username");
            }

            return m_UserName;
        }
        public FacebookObjectCollection<User> RetrieveFriends()
        {
            try
            {
                if(m_FriendsList == null)
                {
                    m_FriendsList = User.Friends;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve friends");
            }

            return m_FriendsList;
        }

        public FacebookObjectCollection<Post> RetrievePostedStatuses()
        {
            try
            {
                if(m_StatusesList == null)
                {
                    m_StatusesList = User.Posts;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - failed to retrieve posted statuses");
            }

            return m_StatusesList;
        }

        public List<string> RetrieveCommentsForStatus(int i_IndexForRelatedStatus)
        {
            List<string> commentsRelated = new List<string>();

            try
            {
                foreach (Comment commentOnStatus in User.Posts[i_IndexForRelatedStatus].Comments)
                {
                    commentsRelated.Add(commentOnStatus.Message);
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to retrieve comments");
            }

            return commentsRelated;
        }

        public FacebookObjectCollection<Event> RetrieveEvents()
        {

            try
            {
                if(m_EventsList == null)
                {
                    m_EventsList = User.Events;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load events");
            }

            return m_EventsList;
        }

        public FacebookObjectCollection<Page> RetrievePages()
        {

            try
            {
                if (m_PagesList == null)
                {
                    m_PagesList = User.LikedPages;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load pages");
            }

            return m_PagesList;
        }

        public FacebookObjectCollection<Group> RetrieveGroups()
        {

            try
            {
                if (m_GroupsList == null)
                {
                    m_GroupsList = User.Groups;
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to load groups");
            }

            return m_GroupsList;
        }

        public void PostStatus(string i_StatusToPost)
        {
            try
            {
                User.PostStatus(i_StatusToPost);
            }
            catch (Exception exception)
            {
                throw new Exception("Error - Failed to post status");
            }
        }
    }
}
