using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class FacebooksFriends
    {
        private readonly FacebookObjectCollection<User> r_FriendsList;
        private readonly int r_FriendsListLength;
        private readonly Random r_RandomNumber = new Random();

        public User RandomFriend
        {
            get;
            private set;
        }

        public FacebooksFriends(FacebookLogicController i_FacebookLogicController)
        {
            r_FriendsList = i_FacebookLogicController.RetrieveFriends();
            r_FriendsListLength = r_FriendsList.Count;
        }

        public void PickRandomFriend()
        {
            int randomIndexForAFriend = r_RandomNumber.Next(0, r_FriendsListLength);
            RandomFriend = r_FriendsList[randomIndexForAFriend];
        }

        public string RetrieveRandomFriendProfilePicture()
        {
            try
            {
                return RandomFriend.PictureNormalURL;
            }   
            catch (Exception exception)
            {
                throw new Exception("Failed to retrieve friend's profile picture");
            }
        }

        public string RetrieveRandomFriendName()
        {
            try
            {
                return RandomFriend.FirstName + ' ' + RandomFriend.LastName;
            }
            catch (Exception exception)
            {
                throw new Exception("Failed to retrieve friend's name");
            }
        }


    }
}
