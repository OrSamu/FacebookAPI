using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    class LoginPage
    {
        private readonly UserDataManager r_UserDataManager;
        public LoginPage()
        {
            r_UserDataManager = UserDataManager.Instance;
        }
        public void Login()
        {
            r_UserDataManager.Login();
        }
        public void Logout()
        {
            r_UserDataManager.Logout();
        }
        public bool IsAuthenticated()
        {
            return r_UserDataManager.IsAuthenticated;
        }
    }
}
