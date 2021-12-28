using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp.DevTools.Database;
using System.Threading;
using FacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private const string k_EmptyDataRetrieved = "No data to show";
        private const string k_DefaultStatusText = "What's on your mind?";
        private const string k_ErrorForTryingToPostEmptyStatus = "Error - can't post empty status";

        private readonly LoginForm r_LoginForm;
        //private readonly FacebookLogicController r_FacebookLogicController;
        private readonly MainPage r_MainPage;

        public MainForm(LoginForm i_LoginForm, FacebookLogicController i_FacebookLogicController)
        {
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            r_LoginForm = i_LoginForm;
            //r_FacebookLogicController = i_FacebookLogicController;
            r_LoginForm.Visible = false;
            r_MainPage = new MainPage();

            //runs on different thread
            //retrieveUserProfileData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserDataManager.Instance.Logout();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            retrieveUserProfileData();
        }

        private void retrieveUserProfileData()
        {
            profilePictureBox.ImageLocation = UserDataManager.Instance.RetrieveProfilePicture();
            usernameLabel.Text = UserDataManager.Instance.RetrieveUsername();
            new Thread(showUserStatuses).Start();
            new Thread(showUserGroups).Start();
            new Thread(showUserEvents).Start();
            new Thread(showUserPages).Start();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //r_FacebookLogicController.Logout();
            r_LoginForm.Visible = true;
            Close();
        }

        private void friendsGameButton_Click(object sender, EventArgs e)
        {
            FriendsQuizForm friendQuizForm = new FriendsQuizForm();
            friendQuizForm.ShowDialog();
        }

        private void AdvancedImageSearch_Click(object sender, EventArgs e)
        {
            AdvancedImageForm form = new AdvancedImageForm();
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

                r_MainPage.PostStatus(statusTextBox.Text);
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
                List<string> userPostedStatuses = r_MainPage.RetrievePostedStatuses();

                if (userPostedStatuses.Count > 0)
                {
                    foreach (string status in userPostedStatuses)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(status)));
                        //listboxposts.items.add(status);
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
            //listBoxComments.Items.Clear();
            try
            {
                List<string> commentsForStatus = r_MainPage.RetrieveCommentsForStatus(listBoxPosts.SelectedIndex);

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
            //listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
            try
            {
                List<string> userEvents = r_MainPage.RetrieveEvents();

                if (userEvents.Count > 0)
                {
                    foreach (string facebookEventName in userEvents)
                    {
                        listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(facebookEventName)));
                        //listBoxEvents.Items.Add(facebookEventName);
                    }
                }
                else
                {
                    listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(k_EmptyDataRetrieved)));
                    //listBoxEvents.Items.Add(k_EmptyDataRetrieved);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserPages()
        {
            //listBoxPages.Items.Clear();
            try
            {
                List<string> userLikedPages = r_MainPage.RetrievePages();

                if (userLikedPages.Count > 0)
                {
                    foreach (string likedPageName in userLikedPages)
                    {
                        listBoxPages.Invoke(new Action(() => listBoxPages.Items.Add(likedPageName)));
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
            //listBoxGroups.Items.Clear();
            try
            {
                List<string> userLikedGroups = r_MainPage.RetrieveGroups();

                if(userLikedGroups.Count > 0)
                {
                    foreach (string likedGroupName in userLikedGroups)
                    {
                        listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(likedGroupName)));
                        //listBoxGroups.Items.Add(likedGroupName);
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
