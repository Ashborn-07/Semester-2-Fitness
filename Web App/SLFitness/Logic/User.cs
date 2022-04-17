namespace SLFitness
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private string email;
        private string firstName;
        private string lastName;
        private string userType;
        private byte[] image;

        public int Id { get { return id; } }
        public string UserName { get { return this.username; } private set { this.username = value; } }
        public string Password { get { return this.password; } private set { this.password = value; } }
        public string Email { get { return this.email; } private set { this.email = value; } }
        public string FirstName { get { return this.firstName; } private set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } private set { this.lastName = value; } }
        public string UserType { get { return this.userType; } private set { this.userType = value; } }
        public byte[] Image { get { return this.image; } private set { this.image = value; } }

        public User(int id, string username, string password, string email, string firstName, string lastName, string userType, byte[] image)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;
            this.image = image;
        }

        public User(int id, string username, string password, string email, string firstName, string lastName, string userType)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userType = userType;
        }
    }
}
