using MySql.Data.MySqlClient;
using SLFitness.Models;
using System.Collections.Generic;
using System.Drawing;
using System.IO;


namespace SLFitness
{
    public class DataAccess : DataBaseHandler
    {
        public bool CreateUser(string username, string password, string email, string firstName, string lastName)
        {
            Connect();

            int i = -1;

            string sql = "INSERT INTO indiv_user (`username`, `password`, `email`, `first name`, `last name`, `user type`) VALUES (@username, @password, @email, @firstname, @lastname, @userType)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@password", password);
            Cmd.Parameters.AddWithValue("@email", email);
            Cmd.Parameters.AddWithValue("@firstname", firstName);
            Cmd.Parameters.AddWithValue("@lastname", lastName);
            Cmd.Parameters.AddWithValue("@userType", "USER");

            try
            {
                i = Cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                throw new System.Exception();
            }
            finally
            {
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Disconnect();
                }
            }

            if (i != -1)
            {
                return true;
            }

            return false;
        }

        public User CreadentailsCheck(string username, string password)
        {
            User user = null;
            Connect();

            string sql = "SELECT * FROM indiv_user WHERE username=@username AND password=@password";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@password", password);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                int id = Reader.GetInt32(0);
                string userName = Reader.GetString(1);
                string passWord = Reader.GetString(2);
                string email = Reader.GetString(3);
                string firstName = Reader.GetString(4);
                string lastName = Reader.GetString(5);
                string userType = Reader.GetString(6);
                if (Reader["picture"] != null)
                {
                    user = new User(id, userName, passWord, email, firstName, lastName, userType, ((byte[])Reader["picture"]));
                    Disconnect();
                    return user;
                }

                user = new User(id, userName, passWord, email, firstName, lastName, userType); 
            }

            Disconnect();

            return user;
        }

        public List<Diet> GetList()
        {
            Connect();
            List<Diet> diets = new List<Diet>();

            string sql = "SELECT * FROM indiv_diets";

            Cmd = new MySqlCommand(sql, Con);

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException)
            {

            }
            finally
            {
                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string name = Reader.GetString(1);
                    string description = Reader.GetString(2);
                    int chef = Reader.GetInt32(3);
                    byte[] image = (byte[])(Reader["image"]);
                    Diet diet = new Diet(id, name, description, chef, image);
                    diets.Add(diet);
                }
            }

            if (Con.State == System.Data.ConnectionState.Open)
            {
                Disconnect();
            }

            return diets;
        }
    }
}
