using Mvvm.Services;
using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvvm.ViewModels
{
    [QueryProperty(nameof(User), "user")]
    public class UserDatavm:VMbase
    {
        IDataService data;
        private string name;
        private string password;
        public string UserName
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
        private User user;
        public User User
        {
            get { return user; }
            set
            {
                if (user != null)
                {
                    user = value;
                    OnPropertyChanged();
                }
            }
        }
        public UserDatavm(IDataService data)
        {
            this.data = data;
        }

    }
}
