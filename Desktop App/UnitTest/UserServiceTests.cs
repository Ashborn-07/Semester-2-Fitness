using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using Xunit;

namespace UnitTest
{
    public class UserServiceTests
    {
        [Fact]
        public void ReturnUserByCredentials()
        {
            //Arrange
            IUserRepository repository = new UserMockRepo();
            User dummyUser = new User(1, "username1", "email@example.com1", "f1", "l1", UserType.USER, null);
            int id = 1;
            UserService service = new UserService(repository);

            //Action
            User user = service.GetUserById(id);

            //Assert
            Assert.Equal(dummyUser.UserName, user.UserName);
        }

        [Fact]
        public void RegisterUserIncreasingListCount()
        {
            //Arrange
            IUserRepository repository = new UserMockRepo();
            UserService service = new UserService(repository);
            UserMockRepo dummyMockRepo = new UserMockRepo();
            User user = new User(3, "username3", "email3@example.com", "f2asd", "l2asd", UserType.USER, null);

            //Action
            service.RegisterUser(user);
            List<User> users = service.GetUsersInList();
            List<User> dummyUsers = dummyMockRepo.GetAllUsersInList();

            //Assert
            Assert.Equal(users.Count, dummyUsers.Count);
        }
    }
}
