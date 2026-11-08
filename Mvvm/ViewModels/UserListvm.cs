using Mvvm.Models;
using Mvvm.Services;
using Mvvm.ViewModels;
using Mvvm.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Input;



namespace Mvvm.ViewModels
{
    [QueryProperty(nameof(User), "user")]
    public class UserListvm : VMbase
    {
       
            IDataService data;
            private string name;
            private string password;
            List<User> userslist;
            ObservableCollection<User> users;

            private User user;
            private string displayUser;
        private string displayUser2;

        public User User
            {
                get { return user; }
                set
                {
                    user = value;
                    OnPropertyChanged();
                    ShowUserData();
                }
            }
            private void ShowUserData()
            {
                DisplayUser = User.Name + " - " + User.Password;
            }
            public ObservableCollection<User> Users
            {
                get; set;
            }
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
            public string DisplayUser
            {
                get { return displayUser; }
                set
                {
                    if (displayUser != value)
                    {
                        displayUser = value;
                        OnPropertyChanged();
                    }
                }
            }

            public ICommand ShowUserCommand
            {
                get;
            }
        public string DisplayUser2
        {
            get { return displayUser; }
            set
            {
                if (displayUser != value)
                {
                    displayUser = value;
                    OnPropertyChanged();
                }
            }
        }

        private async Task ShowUser(User p)
        {
            //await Application.Current.Windows[0].Page.DisplayAlertAsync("User Details", p.Name + "-" + p.Password, "ok");
            //displayUser = p.Name + " - " + p.Password;
            Dictionary<string, object> data2 = new Dictionary<string, object>();
            data2.Add("user", p);
            await Shell.Current.GoToAsync("UserData", data2);
            //DisplayUser2 = p.Name + " - " + p.Password;
        }
        public UserListvm(IDataService db)  
            {
                data = db;
                userslist = data.GetUsers();
                Users = new ObservableCollection<User>(userslist);
                User = userslist[1];
                ShowUserCommand = new Command<User>(async p => ShowUser(p));
        }

    }
}


