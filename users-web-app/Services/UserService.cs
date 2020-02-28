using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using users_web_app.Models;

namespace users_web_app.Services
{
    public class UserService : IUserService
    {
        private List<User> _users;
        private User _user;
        
        public UserService()
        {
            _users = new List<User>();
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public User GetUsers(int id)
        {
            _user = null;

            for (int i = _users.Count - 1; i >= 0; i--)
            {
                if (_users[i].ID == id)
                {
                    _user = _users[i];
                }
            }
            return _user;
        }

        public User AddUser(User user)
        {
            _users.Add(user);
            return (user);
        }

        public string DeleteUser(int id)
        {
            for (int i = _users.Count - 1; i >= 0; i--)
            {
                if (_users[i].ID == i)
                {
                    _users.RemoveAt(i);
                }
            }
            return $"Successfully deleted user with ID {id}";
        }


        public User UpdateUser(int id, User user)
        {
            _user = null;

            for (int i = _users.Count - 1; i >= 0; i--)
            {
                if (_users[i].ID == i)
                {
                    _users[i] = user;
                    _user = _users[i];
                }
            }
            return _user ;
        }
    }
}
