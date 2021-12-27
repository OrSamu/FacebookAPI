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
    }

}
