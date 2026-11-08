using Mvvm.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Mvvm.ViewModels
{
    public class LoginPageVM: VMbase
    {
        IDataService db;
        private string name;
        private string password;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool messageVisible;
        public bool MessageVisible
        {
            get { return messageVisible; }
            set
            {
                if (messageVisible != value)
                {
                    messageVisible = value;
                    OnPropertyChanged();
                }
            }
        }
        private string messageError;
        public string MessageError
        {
            get { return messageError; }
            set
            {
                if (messageError != value)
                {
                    messageError = value;
                    OnPropertyChanged();
                }
            }
        }
        private Color messageColor;
        public Color MessageColor
        {
            get { return messageColor; }
            set
            {
                if (messageColor != value)
                {
                    messageColor = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand LoginCommand
        {
            get;
        }
        public LoginPageVM(IDataService data)
        {
            db = data;
            LoginCommand = new Command(Login);
        }
        private void Login()
        {
            MessageVisible = true;
            if (db.IsRegister(Name, Password))
            {
                MessageError = "you are in";
                MessageColor = Colors.Green;
            }
            else
            {
                MessageError = "Login Failed";
                MessageColor = Colors.Red;
            }
        }
    }
}
