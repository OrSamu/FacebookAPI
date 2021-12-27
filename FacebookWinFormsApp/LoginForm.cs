using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private readonly FacebookLogicController r_FacebookLogicController;
        private readonly UserDataManager r_userDataManager;

        public LoginForm()
        {
            InitializeComponent();
            r_FacebookLogicController = new FacebookLogicController();
            r_userDataManager = UserDataManager.Instance;
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            r_userDataManager.Login();
            if (r_userDataManager.IsAuthenticated)
            {
                Form mainForm;

                r_FacebookLogicController.LoggedInUser = r_userDataManager.User;
                mainForm = new MainForm(this, r_FacebookLogicController);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed - please try again");
            }
            //login();
        }

        //
        private void login()
        {
            bool isAccessTokenEmpty = true;
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

            isAccessTokenEmpty = string.IsNullOrEmpty(loginResult.AccessToken);
            if (!isAccessTokenEmpty)
            {
                Form mainForm;

                r_FacebookLogicController.LoggedInUser = loginResult.LoggedInUser;
                mainForm = new MainForm(this, r_FacebookLogicController);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed - please try again");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_userDataManager.Logout();
            //r_FacebookLogicController.Logout();
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
