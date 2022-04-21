using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class UserRepository : DatabaseHandler, IUserRepository
    {
        public User ReturnUserByUsername(string usernameInput)
        {
            User user = null;

            Connect();

            string sql = "SELECT * FROM indiv_user WHERE username=@Username";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Username", usernameInput);

            try
            {
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string username = Reader.GetString(1);
                    string password = Reader.GetString(2);
                    string email = Reader.GetString(3);
                    string firstName = Reader.GetString(4);
                    string lastName = Reader.GetString(5);
                    string type = Reader.GetString(6);
                    byte[] vs;
                    if (DBNull.Value.Equals(Reader["picture"]))
                    {
                        vs = null;
                    }
                    else
                    {
                        vs = (byte[])(Reader["picture"]);
                    }

                    switch (type)
                    {
                        case "COACH":
                            user = new User(id, username, email, firstName, lastName, UserType.COACH, vs, password);
                            break;
                        case "USER":
                            user = new User(id, username, email, firstName, lastName, UserType.USER, vs, password);
                            break;
                    }

                }
            } finally
            {
                Disconnect();
            }

            return user;
        }

        public void UpdateUserInfo(int id, string username, string email, string firstName, string lastName, byte[] image)
        {
            Connect();

            string sql = "UPDATE indiv_user SET username=@Username, email=@Email, `first name`=@FirstName, `last name`=@LastName, `picture`=@Image WHERE id=@ID";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Username", username);
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@FirstName", firstName);
            Cmd.Parameters.AddWithValue("@LastName", lastName);
            Cmd.Parameters.AddWithValue("@Image", image);
            Cmd.Parameters.AddWithValue("@ID", id);

            try
            {
                Cmd.ExecuteNonQuery();
            } finally
            {
                Disconnect();
            }
        }

        public void RegisterUser(User user)
        {
            Connect();

            string sql = "INSERT INTO indiv_user (`username`, `password`, `email`, `first name`, `last name`, `user type`) VALUES (@username, @password, @email, @firstName, @lastName, @userType)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@username", user.UserName);
            Cmd.Parameters.AddWithValue("@password", user.Password);
            Cmd.Parameters.AddWithValue("@email", user.Email);
            Cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            Cmd.Parameters.AddWithValue("@lastName", user.LastName);
            Cmd.Parameters.AddWithValue("@userType", user.Type.ToString());

            try
            {
                Cmd.ExecuteNonQuery();
            } finally
            {
                Disconnect();
            }
        } 

        public List<User> GetAllUsersInList()
        {
            List<User> users = new List<User>();
            Connect();

            string sql = "SELECT `id`, `username`, `email`, `first name`, `last name`, `user type`, `picture` FROM indiv_user";

            Cmd = new MySqlCommand(sql, Con);

            try
            {
                Reader = Cmd.ExecuteReader();

                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string username = Reader.GetString(1);
                    string email = Reader.GetString(2);
                    string firstName = Reader.GetString(3);
                    string lastName = Reader.GetString(4);
                    string type = Reader.GetString(5);
                    byte[] vs;
                    if (DBNull.Value.Equals(Reader["picture"]))
                    {
                        vs = null;
                    }
                    else
                    {
                        vs = (byte[])(Reader["picture"]);
                    }

                    users.Add(new User(id, username, email, firstName, lastName, (UserType)Enum.Parse(typeof(UserType), type), vs));
                }
            } finally
            {
                Disconnect();
            }

            return users;
        }

        public User GetUserById(int id)
        {
            User user = null;
            Connect();

            string sql = "SELECT * FROM indiv_user WHERE id = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Reader = Cmd.ExecuteReader();

                if (Reader.Read())
                {
                    string firstName = Reader["first name"].ToString();
                    string lastName = Reader["last name"].ToString();
                    string email = Reader["email"].ToString();

                    user = new User(firstName, lastName, email);
                }

            }
            finally
            {
                Disconnect();
            }

            return user;
        }

        public void UpdateUserWeb(User user, int id)
        {
            Connect();

            string sql = "UPDATE indiv_user SET `email` = @email, `first name` = @firstName, `last name` = @lastName WHERE `id` = @id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@email", user.Email);
            Cmd.Parameters.AddWithValue("@firstName", user.FirstName);
            Cmd.Parameters.AddWithValue("@lastName", user.LastName);
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
