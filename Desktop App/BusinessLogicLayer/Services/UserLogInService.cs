using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserLogInService
    {
        private IUserLogInRepository repository;

        public UserLogInService(IUserLogInRepository repository)
        {
            this.repository = repository;
        }

        public User UserDataValidation(string username, string password)
        {
            if (username.Length > 2 && password.Length > 2)
            {
                if (username.Length <= 30 && password.Length <= 30)
                {
                    User user = repository.ReturnUserByCredentails(username, password);

                    if (user != null)
                    {
                        return user;
                    }
                    throw new ApplicationException("Username or password are incorrect.");
                }
                throw new ApplicationException("Username and password lenght is invalid. It must be equal or less than 30 characters.");
            }
            throw new ApplicationException("Username and password lenght is invalid. It must be at least 2 characters.");
        }
    }
}
