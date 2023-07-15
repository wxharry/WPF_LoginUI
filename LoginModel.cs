using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LoginUI
{
    public class LoginModel
    {
        private string _Account;

        public string Account
        {
            get { return _Account; }
            set
            {
                _Account = value;
            }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
            }
        }
    }
}
