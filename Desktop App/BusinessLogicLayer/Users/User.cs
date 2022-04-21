using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer
{
    public class User
    {
        private readonly int id;
        private string username;
        private string email;
        private string firstName;
        private string lastName;
        private string password;
        private UserType type;
        private byte[] image;

        public int Id { get { return id; } }
        public string UserName { get { return this.username; } private set { this.username = value; } }
        public string Email { get { return this.email; } private set { this.email = value; } }
        public string FirstName { get { return this.firstName; } private set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } private set { this.lastName = value; } }
        public UserType Type { get { return this.type; } private set { this.type = value; } }
        public byte[] Image { get { return this.image; } private set { this.image = value; } }
        public string Password { get { return this.password; } }

        public User(int id, string username, string email, string firstName, string lastName, UserType type, byte[] image)
        {
            this.id = id;
            this.email = email;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.image = image;
        }

        public User(int id, string username, string firstName, string lastName, string email, byte[] image)
        {
            this.id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.image = image;
        }

        public User(string username, string email, string firstName, string lastName, UserType type, string password)
        {
            this.username = username;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.password = password;
        }

        public User(int id, string username, string email, string firstName, string lastName, UserType type, byte[] image, string password)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.image = image;
            this.password = password;
        }

        public User(string firstName, string lastName, string email)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
