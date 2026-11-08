using Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mvvm.Services
{
    public class DBdemo : IDataService
    {
        List<User> users = new List<User>();
        public DBdemo()
        {
            users.Add(new Models.User { Name = "uri", Password = "admin" });
            users.Add(new Models.User { Name = "ori", Password = "admin" });
            users.Add(new Models.User { Name = "ari", Password = "admin" });

        }
        public bool IsExist(string username)
        {
            var user = users.FirstOrDefault(u => u.Name == username);
            return user != null;
        }
        public bool IsRegister(string username, string password)
        {
            var user = users.FirstOrDefault(u => u.Name == username && u.Password == password);
            return user != null;
        }
        public void Register(string username, string password)
        {
            users.Add(new Models.User { Name = username, Password = password });
        }
        public string GetAllUsers()
        {
            // return users.Select(x => new Models.User { Name = x.Name, Password = x.Password }).ToList();
            string data = string.Join("\n", users.Select(s => $"{s.Name} - {s.Password}"));
            return data;
        }

        List<User> IDataService.GetUsers()
        {
            return users.Select(x => new User { Name = x.Name, Password = x.Password }).ToList();


        }
    }
}
