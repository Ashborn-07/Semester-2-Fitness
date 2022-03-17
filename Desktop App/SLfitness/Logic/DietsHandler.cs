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
            }catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            } finally
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
            } catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            } finally
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
            } catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            } finally
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
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


    }
}
