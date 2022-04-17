using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLayer
{
    public class User
    {
        private int id;
        private string username;
        private string email;
        private string firstName;
        private string lastName;
        private UserType type;
        private Image image;

        public int Id { get { return id; } }
        public string UserName { get { return this.username; } set { this.username = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public UserType Type { get { return this.type; } set { this.type = value; } }
        public Image Image { get { return this.image; } set { this.image = value; } }

        public User(int id, string username, string email, string firstName, string lastName, UserType type, Image image)
        {
            this.id = id;
            this.email = email;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.type = type;
            this.image = image;
        }

        public User(int id, string username, string firstName, string lastName, string email, Image image)
        {
            this.id = id;
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    }
}
