using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookAppLogic;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        //private const string k_SuccessfulPostPublish = "Post published successfully";
        //private const string k_EmptyPostPublishAttempt = "You cannot publish an empty post";
        private const string k_DefaultStatusText = "What's on your mind?";

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
                    MessageBox.Show("Error - can't post empty status");
                }

                r_FacebookLogicController.PostStatus(statusTextBox.Text);
                //refresh posts

            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                postButton.Enabled = false;
                statusTextBox.Text = "What's on your mind?";
            }
        }

        private void showUserStatuses()
        {
            try
            {
                List<string> userPostedStatuses = r_FacebookLogicController.RetrievePostedStatuses();

                foreach(string status in userPostedStatuses)
                {
                    listBoxPosts.Items.Add(status);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> commentsForStatus = r_FacebookLogicController.RetrieveCommentsForStatus(listBoxPosts.SelectedIndex);

                foreach(string comment in commentsForStatus)
                {
                    listBoxComments.Items.Add(comment);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserEvents()
        {
            try
            {
                List<string> userEvents = r_FacebookLogicController.RetrieveEvents();

                foreach (string facebookEventName in userEvents)
                {
                    listBoxEvents.Items.Add(facebookEventName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserPages()
        {
            try
            {
                List<string> userLikedPages = r_FacebookLogicController.RetrievePages();

                foreach (string likedPageName in userLikedPages)
                {
                    listBoxPages.Items.Add(likedPageName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void showUserGroups()
        {
            try
            {
                List<string> userLikedGroups = r_FacebookLogicController.RetrieveGroups();

                foreach (string likedGroupName in userLikedGroups)
                {
                    listBoxGroups.Items.Add(likedGroupName);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }


    }
}
