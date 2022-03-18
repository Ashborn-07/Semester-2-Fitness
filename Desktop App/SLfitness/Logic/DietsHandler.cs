using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLfitness
{
    public class DietsHandler : DatabaseHandler
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

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }

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

            try
            {
                i = Cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }

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

            try
            {
                i = Cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }

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

            try
            {
                Reader = Cmd.ExecuteReader();
                if (Reader.Read())
                {
                    id = Reader.GetInt32(0);
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }

            return id;
        }

        public void DisplayDiets(DataGridView dgv)
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM indiv_diets";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dt = new DataTable();

            try
            {
                adapter.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
        }

        public void DisplayHealthyDiets(DataGridView dgv)
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM `indiv_diets` WHERE id IN (SELECT `id` FROM indiv_healthy_diets)";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
        }

        public void DisplayZaroCarbsDiets(DataGridView dgv)
        {
            Connect();
            string sql = "SELECT `id`, `name`, `description`, `chef` FROM `indiv_diets` WHERE id IN (SELECT `id` FROM indiv_zerocarbs_diets)";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
        }

        public Image GetImage(int id)
        {
            Connect();

            string sql = "SELECT `image` FROM indiv_diets WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

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

        public HealthyDiet GetHealthy(string name, string description, int chef, byte[] image, int calories, int fat, int carbs)
        {
            HealthyDiet healthyDiet = new HealthyDiet(name, description, calories, fat, chef, image, carbs);

            return healthyDiet;
        }

        public ZeroCarbsDiet GetCarbsDiet(string name, string description, int chef, byte[] image, int calories, int fat)
        {
            ZeroCarbsDiet zeroCarbsDiet = new ZeroCarbsDiet(name, description, calories, fat, chef, image);

            return zeroCarbsDiet;
        }

        public string GetTypeOfDiet(int id)
        {
            Connect();
            string type = "";
            

            string sql = "SELECT * FROM indiv_diets WHERE id IN (SELECT id FROM indiv_zerocarbs_diets WHERE id=@id)";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@id", id);

            

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }


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

            try
            {
               Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }


            if (Reader.Read())
            {
                type = "Healthy";
            }

            Disconnect();

            return type;
        }

        public void DisplayAboutDiet(int id, TextBox tbName, TextBox tbDescription, NumericUpDown numCalories, NumericUpDown numFat, NumericUpDown numCarbs, PictureBox pictureBox, string type)
        {
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

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }

            if (Reader.Read())
            {
                tbName.Text = Reader.GetString(1);
                tbDescription.Text = Reader.GetString(2);
                numCalories.Value = Reader.GetInt32(6);
                numFat.Value = Reader.GetInt32(7);

                byte[] image = (byte[])(Reader["image"]);
                MemoryStream ms = new MemoryStream(image);
                Image img = new Bitmap(ms);
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                if (type.Equals("Healthy"))
                {
                    numCarbs.Enabled = true;
                    numCarbs.Value = Reader.GetInt32(8);
                }
            }

            Disconnect();
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

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

            sql = "UPDATE indiv_healthy_diets SET `calories`=@calories, `fat`=@fat, `carbs`=@carbs WHERE id=@id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@calories", calories);
            Cmd.Parameters.AddWithValue("@fat", fat);
            Cmd.Parameters.AddWithValue("@carbs", carbs);
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
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

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            sql = "UPDATE indiv_zerocarbs_diets SET `calories`=@calories, `fat`=@fat WHERE id=@id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@calories", calories);
            Cmd.Parameters.AddWithValue("@fat", fat);
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
