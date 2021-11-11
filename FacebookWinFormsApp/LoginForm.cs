using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private readonly FacebookLogicController r_FacebookLogicController;

        public LoginForm()
        {
            InitializeComponent();
            r_FacebookLogicController = new FacebookLogicController();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Form mainForm;
                r_FacebookLogicController.Login();
                mainForm = new MainForm(this, r_FacebookLogicController);
                mainForm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_FacebookLogicController.Logout();
            Application.Exit();
        }
	}
}
