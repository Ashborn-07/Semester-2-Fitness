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
    public class UserLogInRepository : DatabaseHandler, IUserLogInRepository
    {
        public User ReturnUserByCredentails(string usernameInput, string passwordInput)
        {
            User user = null;

            Connect();

            string sql = "SELECT * FROM indiv_user WHERE username=@Username AND password=@Password";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Username", usernameInput);
            Cmd.Parameters.AddWithValue("@Password", passwordInput);

            Reader = Cmd.ExecuteReader();

            while(Reader.Read())
            {
                int id = Reader.GetInt32(0);
                string username = Reader.GetString(1);
                string email = Reader.GetString(3);
                string firstName = Reader.GetString(4);
                string lastName = Reader.GetString(5);
                string type = Reader.GetString(6);
                byte[] vs = (byte[])(Reader["picture"]);
                MemoryStream stream = new MemoryStream(vs);
                Image image = new Bitmap(stream);

                switch(type)
                {
                    case "COACH":
                        user = new User(id, username, email, firstName, lastName, UserType.COACH, image);
                        break;
                    case "USER":
                        user = new User(id, username, email, firstName, lastName, UserType.USER, image);
                        break;
                }
            }

            Disconnect();
            return user;
        }
    }
}
