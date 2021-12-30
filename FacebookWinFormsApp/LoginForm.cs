﻿using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookAppLogic;


namespace BasicFacebookFeatures
{
    public partial class LoginForm : Form
    {
        private readonly UserDataManager r_userDataManager;
        private readonly LoginPage r_LoginPage;
        public LoginForm()
        {
            InitializeComponent();
            r_LoginPage = new LoginPage();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            r_LoginPage.Login();
            if (r_LoginPage.IsAuthenticated())
            {
                Form mainForm;
                mainForm = new MainForm(this);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed - please try again");
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
