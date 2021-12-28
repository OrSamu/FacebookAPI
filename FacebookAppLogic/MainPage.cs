using System;
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

        public List<string> RetrieveEvents()
        {
            List<string> eventsList = new List<string>();

            foreach(Event userEvent in r_UserDataManager.RetrieveEvents())
            {
                eventsList.Add(userEvent.Name);
            }

            return eventsList;
        }

        public List<string> RetrievePages()
        {
            List<string> pagesList = new List<string>();

            foreach (Page page in r_UserDataManager.RetrievePages())
            {
                pagesList.Add(page.Name);
            }

            return pagesList;
        }

        public List<string> RetrieveGroups()
        {
            List<string> groupsList = new List<string>();

            foreach (Group group in r_UserDataManager.RetrieveGroups())
            {
                groupsList.Add(group.Name);
            }

            return groupsList;
        }

        public void PostStatus(string i_StatusToPost)
        {
            r_UserDataManager.PostStatus(i_StatusToPost);
        }
    }
}
