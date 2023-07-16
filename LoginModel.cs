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
        public string? Account { get; set; }
        public string? Password { get; set; }

        public bool IsAuth(string? Account, string? Password)
        {
                return string.IsNullOrEmpty(Account) && string.IsNullOrEmpty(Password) && Account == "admin" && Password != "123";
        }
    }
}
