using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SLfitness
{
    public class LogInHandler : DatabaseHandler
    {
        public int CredentialsCheck(string username, string password)
        {
            int id = 0;
            Connect();
            string sql = "SELECT id FROM indiv_user WHERE username=@Username AND password=@Password";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Username", username);
            Cmd.Parameters.AddWithValue("@Password", password);

            Reader = Cmd.ExecuteReader();

            while(Reader.Read())
            {
                id = Reader.GetInt32(0);
            }

            Disconnect();
            return id;
        }

        public string GetUserType(int id)
        {
            string type = "";
            Connect();

            string sql = "SELECT `user type` FROM indiv_user WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            Reader =Cmd.ExecuteReader();

            while (Reader.Read())
            {
                type = Reader.GetString(0);
            }
            Disconnect();

            return type;
        }
    }
}
