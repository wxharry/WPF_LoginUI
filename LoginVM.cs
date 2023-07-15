using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_LoginUI
{
    class LoginVM:INotifyPropertyChanged
    {
        private MainWindow _main;
        public LoginVM(MainWindow main)
        {
            _main = main; 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private LoginModel _LoginM = new LoginModel();

        public string Account
        {
            get { return _LoginM.Account; }
            set 
            {
                _LoginM.Account = value;
                RaisePropertyChanged("Account");
            }
        }

        public string Password
        {
            get { return _LoginM.Password; }
            set { _LoginM.Password = value; RaisePropertyChanged("Password"); }
        }

        void LoginFunc ()
        {
            if (Account == "admin" && Password == "123")
            {
                Index index = new Index();
                index.Show();
                _main.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Account or Password!");
                Account = "";
                Password = "";
            }
        }

        bool CanLoginExecute()
        { return true; }

        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(LoginFunc, CanLoginExecute);
            }
        }

    }
}
