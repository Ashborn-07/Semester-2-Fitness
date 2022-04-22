using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt;

namespace BusinessLogicLayer
{
    public class UserService
    {
        private IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public User UserDataValidation(string username, string password)
        {
            if (UsernameAndPasswordValidation(username, password))
            {
                User user = repository.ReturnUserByUsername(username);

                if (BCrypt.Net.BCrypt.Verify(password, user.Password) == true)
                {
                    return user;
                }

                throw new ApplicationCustomException("Username or password are incorrect.");
            }

            throw new ApplicationCustomException("Username and password lenght is invalid. It must be between 3 and 30 characters/symbols.");
        }

        public void UpdateUserInfo(User user)
        {
            if (EmailValidation(user.Email))
            {
                repository.UpdateUserInfo(user.Id, user.UserName, user.Email, user.FirstName, user.LastName, user.Image);
                return;
            }

            throw new ApplicationCustomException("Email input is not valid. It should have \"@, .com, .nl\" etc.");
        }

        public void RegisterUser(User user)
        {
            if (EmailValidation(user.Email))
            {
                if (UsernameAndPasswordValidation(user.UserName, user.Password))
                {
                    User newUser = new User(user.UserName, user.Email, user.FirstName, user.LastName, UserType.USER, BCrypt.Net.BCrypt.HashPassword(user.Password));
                    repository.RegisterUser(newUser);
                    return; //added after sending
                }
                throw new ApplicationCustomException("Username and password lenght is invalid. It must be between 3 and 30 characters/symbols.");
            }
            throw new ApplicationCustomException("Email input is not valid. It should have \"@, .com, .nl\" etc.");
        }

        private bool EmailValidation(string email)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-]+)\.([a-zA-Z]{2,5})$";

            RegexOptions option = RegexOptions.Multiline;

            return Regex.IsMatch(email, pattern, option);
        }

        private bool UsernameAndPasswordValidation(string username, string password)
        {
            if (username.Length > 2 && password.Length > 2)
            {
                if (username.Length <= 30 && password.Length <= 30)
                {
                    return true;
                }
            }

            return false;
        }

        public List<User> GetUsersInList()
        {
            return repository.GetAllUsersInList();
        }

        public User GetUserById(int id)
        {
            return repository.GetUserById(id);
        }

        public void UpdateUserWeb(User user, int id)
        {
            repository.UpdateUserWeb(user, id);
        }
    }
}
