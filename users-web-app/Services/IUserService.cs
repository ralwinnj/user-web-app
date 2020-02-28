using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users_web_app.Models;

namespace users_web_app.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUsers(int id);
        public User AddUser(User user);
        public User UpdateUser(int id, User user);
        public string DeleteUser(int id);
    }
}
