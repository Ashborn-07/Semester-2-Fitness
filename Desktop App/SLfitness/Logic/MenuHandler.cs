using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class MenuHandler : DatabaseHandler
    {

        public Image GetImage(int id)
        {
            Connect();

            string sql = "SELECT picture FROM indiv_user WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                byte[] image = (byte[])(Reader["picture"]);
                MemoryStream ms = new MemoryStream(image);
                Image img = Image.FromStream(ms);
                Disconnect();
                return img;
            }

            Disconnect();
            return null;
        }

        public string GetFirstName(int id)
        {
            Connect();

            string sql = "SELECT `first name` FROM indiv_user WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                string firstName = Reader.GetString(0);
                Disconnect();
                return firstName;
            }

            Disconnect();
            return "";
        }
    }
}
