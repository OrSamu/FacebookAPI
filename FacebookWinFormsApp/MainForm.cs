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
    }
}
