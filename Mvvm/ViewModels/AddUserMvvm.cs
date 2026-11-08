using Mvvm.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Mvvm.ViewModels
{
    public class AddUserMvvm : VMbase
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

        public ICommand RegisterCommand
        {
            get;
        }
        public AddUserMvvm(IDataService data)
        {
            db=data ;
            RegisterCommand = new Command(Register);
        }
        private void Register()
        {
            MessageVisible = true;
            if (db.IsExist(Name))
            {
                MessageError = "There is already a user with this name";
                MessageColor = Colors.Red;
            }
            else
            {
                db.Register(Name, Password);
                if (db.IsRegister(Name, Password))
                {
                    MessageError = "Register succeded";
                    MessageColor = Colors.Green;
                }
                else
                {
                    MessageError = "There is already a user with this name";
                    MessageColor = Colors.Red;
                }
            }
        }
    }
}
    
