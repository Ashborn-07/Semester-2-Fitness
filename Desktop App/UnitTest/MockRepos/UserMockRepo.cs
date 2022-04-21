using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace UnitTest
{
    internal class UserMockRepo : IUserRepository
    {
        private List<User> users = new List<User>();

        public UserMockRepo()
        {
            users.Add(new User(1, "username1", "email1@example.com", "f1", "l1", UserType.USER, null));
            users.Add(new User(2, "username2", "email2@example.com2", "f2", "l2", UserType.USER, null));
        }

        public User ReturnUserByUsername(string usernameInput)
        {
            return null;
        }

        public void UpdateUserInfo(int id, string username, string email, string firstName, string lastName, byte[] image)
        {
            
        }

        public void RegisterUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetAllUsersInList()
        {
            return users;            
        }

        public User GetUserById(int id)
        {
            foreach (var user in users)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }

        public void UpdateUserWeb(User user, int id)
        {
            
        }
    }
}
