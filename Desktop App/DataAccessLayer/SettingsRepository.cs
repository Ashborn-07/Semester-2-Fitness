using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class SettingsRepository : DatabaseHandler, ISettingsRepository
    {

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

            Cmd.ExecuteNonQuery();
            Disconnect();
        }
    }
}