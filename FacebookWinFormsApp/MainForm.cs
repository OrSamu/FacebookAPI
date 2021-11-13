using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp.DevTools.Database;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private const string k_EmptyDataRetrieved = "No data to show";
        private const string k_DefaultStatusText = "What's on your mind?";
        private const string k_ErrorForTryingToPostEmptyStatus = "Error - can't post empty status";



        private readonly LoginForm r_LoginForm;
        private readonly FacebookLogicController r_FacebookLogicController;
        
        public MainForm(LoginForm i_LoginForm, FacebookLogicController i_FacebookLogicController)
        {
            InitializeComponent();
            r_LoginForm = i_LoginForm;
            r_FacebookLogicController = i_FacebookLogicController;
            r_LoginForm.Visible = false;
            retrieveUserProfileData();
        }

        private void retrieveUserProfileData()
        {
            profilePictureBox.ImageLocation = r_FacebookLogicController.RetrieveProfilePicture();
            usernameLabel.Text = r_FacebookLogicController.RetrieveUsername();
            showUserStatuses();
            showUserEvents();
            showUserGroups();
            showUserPages();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            r_FacebookLogicController.Logout();
            r_LoginForm.Visible = true;
            Close();
        }

        private void friendsGameButton_Click(object sender, EventArgs e)
        {
            FriendsQuizForm friendQuizForm = new FriendsQuizForm(r_FacebookLogicController);
            friendQuizForm.ShowDialog();
        }

        private void AdvancedImageSearch_Click(object sender, EventArgs e)
        {
            AdvancedImageForm form = new AdvancedImageForm(r_FacebookLogicController.LoggedInUser);
            form.ShowDialog();
        }

        private void statusTextBox_Click(object sender, EventArgs e)
        {
            bool isDefaultStatus = string.Equals(statusTextBox.Text, k_DefaultStatusText);
            if (isDefaultStatus)
            {
                statusTextBox.Clear();
            }

            postButton.Enabled = true;
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            bool isStatusEmpty = string.IsNullOrEmpty(statusTextBox.Text);

            try
            {
                if(isStatusEmpty)
                {
                    MessageBox.Show(k_ErrorForTryingToPostEmptyStatus);
                }

                r_FacebookLogicController.PostStatus(statusTextBox.Text);
                listBoxPosts.Items.Add(statusTextBox.Text);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                postButton.Enabled = false;
                statusTextBox.Text = k_DefaultStatusText;
            }
        }

        private void showUserStatuses()
        {
            try
            {
                List<string> userPostedStatuses = r_FacebookLogicController.RetrievePostedStatuses();
                
                if (userPostedStatuses.Count > 0)
                {
                    foreach (string status in userPostedStatuses)
                    {
                        listBoxPosts.Items.Add(status);
                    }
                }
                else
                {
                    listBoxPosts.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxComments.Items.Clear();
            try
            {
                List<string> commentsForStatus = r_FacebookLogicController.RetrieveCommentsForStatus(listBoxPosts.SelectedIndex);

                if (commentsForStatus.Count > 0)
                {
                    foreach (string comment in commentsForStatus)
                    {
                        listBoxComments.Items.Add(comment);
                    }
                }
                else
                {
                    listBoxComments.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserEvents()
        {
            listBoxEvents.Items.Clear();
            try
            {
                List<string> userEvents = r_FacebookLogicController.RetrieveEvents();

                if (userEvents.Count > 0)
                {
                    foreach (string facebookEventName in userEvents)
                    {
                        listBoxEvents.Items.Add(facebookEventName);
                    }
                }
                else
                {
                    listBoxEvents.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserPages()
        {
            listBoxPages.Items.Clear();
            try
            {
                List<string> userLikedPages = r_FacebookLogicController.RetrievePages();

                if (userLikedPages.Count > 0)
                {
                    foreach (string likedPageName in userLikedPages)
                    {
                        listBoxPages.Items.Add(likedPageName);
                    }
                }
                else
                {
                    listBoxPages.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserGroups()
        {
            listBoxGroups.Items.Clear();
            try
            {
                List<string> userLikedGroups = r_FacebookLogicController.RetrieveGroups();

                if(userLikedGroups.Count > 0)
                {
                    foreach (string likedGroupName in userLikedGroups)
                    {
                        listBoxGroups.Items.Add(likedGroupName);
                    }
                }
                else
                {
                    listBoxGroups.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
