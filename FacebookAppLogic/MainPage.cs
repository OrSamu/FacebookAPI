﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class MainPage
    {
        private readonly UserDataManager r_UserDataManager;

        public MainPage()
        {
            r_UserDataManager = UserDataManager.Instance;
        }

        public string RetrieveProfilePicture()
        {
            return r_UserDataManager.RetrieveProfilePicture();
        }

        public string RetrieveUsername()
        {
            return r_UserDataManager.RetrieveUsername();
        }

        public List<string> RetrievePostedStatuses()
        {
            List<string> postedStatuses = new List<string>();

            foreach(Post status in r_UserDataManager.RetrievePostedStatuses())
            {
                postedStatuses.Add(new StatusAdapter(status).GenerateStatusFormat());
            }

            return postedStatuses;
        }

        public List<string> RetrieveCommentsForStatus(int i_StatusIndex)
        {
            return r_UserDataManager.RetrieveCommentsForStatus(i_StatusIndex);
        }

        public FacebookObjectCollection<Event> RetrieveEvents()
        {
            return r_UserDataManager.RetrieveEvents();
        }

        public FacebookObjectCollection<Page> RetrievePages()
        {
            return r_UserDataManager.RetrievePages();
        }

        public FacebookObjectCollection<Group> RetrieveGroups()
        {
            return r_UserDataManager.RetrieveGroups();
        }

        public void PostStatus(string i_StatusToPost)
        {
            r_UserDataManager.PostStatus(i_StatusToPost);
        }
    }
}
