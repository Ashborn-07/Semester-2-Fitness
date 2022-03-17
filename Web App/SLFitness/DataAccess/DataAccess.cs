using MySql.Data.MySqlClient;
using SLFitness.Models;
using System.Collections.Generic;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

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
                Disconnect();
            }

            if (i != -1)
            {
                return true;
            }

            return false;
        }

        public int CheckUserCreadentialsAndReturnID(string username, string password)
        {
            Connect();

            int id = -1;

            string sql = "SELECT `id` FROM indiv_user WHERE username=@username AND password=@password";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@username", username);
            Cmd.Parameters.AddWithValue("@password", password);

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException)
            {
                throw new System.Exception();
            }

            if (Reader.Read())
            {
                id = Reader.GetInt32(0);
            }

            Disconnect();

            return id;
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
            } catch (MySqlException)
            {

            } finally
            {
                while(Reader.Read())
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

            Disconnect();

            return diets;
        }
    }
}
