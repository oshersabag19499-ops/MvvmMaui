using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvvm.Services
{
    public interface IDataService
    {

        public bool IsExist(string username);

        public bool IsRegister(string username, string password);

        public void Register(string username, string password);

        public string GetAllUsers();
        public List<User> GetUsers();
    }       
}
