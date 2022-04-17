using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class DietsRepository : DatabaseHandler, IDietsRepository
    {
        public int AddDiet(Diet diet)
        {
            Connect();
            string sql = "INSERT INTO indiv_diets (`name`, `description`, `chef`, `image`) VALUES (@Name, @Description, @Chef, @Image)";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Name", diet.Name);
            Cmd.Parameters.AddWithValue("@Description", diet.Description);
            Cmd.Parameters.AddWithValue("@Chef", diet.Chef);
            Cmd.Parameters.AddWithValue("@Image", diet.Image);


            Cmd.ExecuteNonQuery();
            Disconnect();


            int i = 0;
            int id = GetIdDiet(diet.Name, diet.Description);

            switch (diet)
            {
                case ZeroCarbsDiet:
                    i = AddZeroCarbsDiet(id, diet.Calories, diet.Fat);
                    break;
                case HealthyDiet:
                    i = AddHealthyDiet(id, diet.Calories, diet.Fat, ((HealthyDiet)diet).Carbs);
                    break;
                default:
                    i = -1;
                    break;
            }

            return i;
        }

        private int AddHealthyDiet(int id, int calories, int fat, int carbs)
        {
            int i = -1;
            Connect();

            string sql = "INSERT INTO indiv_healthy_diets (`id`, `calories`, `fat`, `carbs`) VALUES (@Id, @Calories, @Fat, @Carbs)";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);
            Cmd.Parameters.AddWithValue("@Calories", calories);
            Cmd.Parameters.AddWithValue("@Fat", fat);
            Cmd.Parameters.AddWithValue("@Carbs", carbs);

            i = Cmd.ExecuteNonQuery();
            Disconnect();

            return i;
        }

        private int AddZeroCarbsDiet(int id, int calories, int fat)
        {
            int i = -1;
            Connect();

            string sql = "INSERT INTO indiv_zerocarbs_diets (`id`, `calories`, `fat`) VALUES (@Id, @Calories, @Fat)";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);
            Cmd.Parameters.AddWithValue("@Calories", calories);
            Cmd.Parameters.AddWithValue("@Fat", fat);

            i = Cmd.ExecuteNonQuery();
            Disconnect();

            return i;
        }

        private int GetIdDiet(string name, string description)
        {
            Connect();

            string sql = "SELECT `id` FROM indiv_diets WHERE name LIKE @Name AND description LIKE @Description";

            Cmd = new MySqlCommand(sql, Con);

            Cmd.Parameters.AddWithValue("@Name", name);
            Cmd.Parameters.AddWithValue("@Description", description);

            int id = -1;

            Reader = Cmd.ExecuteReader();
            if (Reader.Read())
            {
                id = Reader.GetInt32(0);
            }

            Disconnect();

            return id;
        }

        public DataTable DisplayDiets()
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM indiv_diets";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            Disconnect();

            return dt;
        }

        public DataTable DisplayHealthyDiets()
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM `indiv_diets` WHERE id IN (SELECT `id` FROM indiv_healthy_diets)";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            Disconnect();

            return dataTable;
        }

        public DataTable DisplayZaroCarbsDiets()
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM `indiv_diets` WHERE id IN (SELECT `id` FROM indiv_zerocarbs_diets)";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            Disconnect();

            return dataTable;
        }

        public string GetTypeOfDiet(int id)
        {
            Connect();
            string type = "";


            string sql = "SELECT * FROM indiv_diets WHERE id IN (SELECT id FROM indiv_zerocarbs_diets WHERE id=@id)";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                Disconnect();
                type = "Zero Carbs";
                return type;
            }

            Reader.Close();

            string sql2 = "SELECT * FROM indiv_diets WHERE id IN (SELECT id FROM indiv_healthy_diets WHERE id=@id)";
            Cmd = new MySqlCommand(sql2, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                type = "Healthy";
            }

            Disconnect();

            return type;
        }

        public Diet DisplayAboutDiet(int id, string type, int chef)
        {
            Diet diet = null;

            Connect();

            string sql = "";

            if (type.Equals("Zero Carbs"))
            {
                sql = "SELECT * FROM indiv_diets AS i INNER JOIN indiv_zerocarbs_diets AS z ON z.id = i.id WHERE i.id=@Id";
            }
            else
            {
                sql = "SELECT * FROM indiv_diets AS i INNER JOIN indiv_healthy_diets AS h ON h.id = i.id WHERE i.id=@Id";
            }

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                string name = Reader.GetString(1);
                string description = Reader.GetString(2);
                int calories = Reader.GetInt32(6);
                int fat = Reader.GetInt32(7);
                byte[] image = (byte[])(Reader["image"]);

                if (type.Equals("Healthy"))
                {
                    int carbs = Reader.GetInt32(8);
                    diet = new HealthyDiet(name, description, calories, fat, chef, image, carbs);
                }
                else
                {
                    diet = new ZeroCarbsDiet(name, description, calories, fat, chef, image);
                }
            }

            Disconnect();

            return diet;
        }

        public void UpdateHealthyDietInfo(int id, string name, string description, int calories, int fat, byte[] image, int carbs)
        {
            Connect();

            string sql = "UPDATE indiv_diets SET `name`=@name, `description`=@description, `image`=@image WHERE id=@id";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", name);
            Cmd.Parameters.AddWithValue("@description", description);
            Cmd.Parameters.AddWithValue("@image", image);
            Cmd.Parameters.AddWithValue("@id", id);

            Cmd.ExecuteNonQuery();

            sql = "UPDATE indiv_healthy_diets SET `calories`=@calories, `fat`=@fat, `carbs`=@carbs WHERE id=@id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@calories", calories);
            Cmd.Parameters.AddWithValue("@fat", fat);
            Cmd.Parameters.AddWithValue("@carbs", carbs);
            Cmd.Parameters.AddWithValue("@id", id);

            Cmd.ExecuteNonQuery();
            Disconnect();
        }

        public void UpdateZeroCarbsDietInfo(int id, string name, string description, int calories, int fat, byte[] image)
        {
            Connect();

            string sql = "UPDATE indiv_diets SET `name`=@name, `description`=@description, `image`=@image WHERE id=@id";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@name", name);
            Cmd.Parameters.AddWithValue("@description", description);
            Cmd.Parameters.AddWithValue("@image", image);
            Cmd.Parameters.AddWithValue("@id", id);

            Cmd.ExecuteNonQuery();

            sql = "UPDATE indiv_zerocarbs_diets SET `calories`=@calories, `fat`=@fat WHERE id=@id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@calories", calories);
            Cmd.Parameters.AddWithValue("@fat", fat);
            Cmd.Parameters.AddWithValue("@id", id);

            Cmd.ExecuteNonQuery();
            Disconnect();
        }

        public Image GetImage(int id)
        {
            Connect();

            string sql = "SELECT `image` FROM indiv_diets WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            Reader = Cmd.ExecuteReader();

            if (Reader.Read())
            {
                byte[] image = (byte[])(Reader["image"]);
                MemoryStream ms = new MemoryStream(image);
                Image img = new Bitmap(ms);
                Disconnect();
                return img;
            }

            Disconnect();
            return null;
        }

    }
}
