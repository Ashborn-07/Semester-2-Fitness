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
            string sql = "INSERT INTO indiv_diets (`name`, `type`, `description`, `chef`, `calories`, `fat`, `carbs`, `image`) VALUES (@Name, @Type, @Description, @Chef, @Calories, @Fat, @Carbs, @Image)";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Name", diet.Name);
            Cmd.Parameters.AddWithValue("@Type", diet.Type);
            Cmd.Parameters.AddWithValue("@Description", diet.Description);
            Cmd.Parameters.AddWithValue("@Chef", diet.Chef);
            Cmd.Parameters.AddWithValue("@Calories", diet.Calories);
            Cmd.Parameters.AddWithValue("@Fat", diet.Fat);
            Cmd.Parameters.AddWithValue("@Carbs", );
            Cmd.Parameters.AddWithValue("@Image", diet.Image);

            int i = -1;

            try
            {
                i = Cmd.ExecuteNonQuery();
                
            }catch(MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                Disconnect();
            }

            return i;
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
                dgv.DataSource = dt ;
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

            string sql = "SELECT image FROM indiv_diets WHERE id=@Id";
            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Id", id);

            try
            {
                Reader = Cmd.ExecuteReader();
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Reader.Read())
            {
                byte[] image = (byte[])(Reader["image"]);
                MemoryStream ms = new MemoryStream(image);
                Image img = Image.FromStream(ms);
                Disconnect();
                return img;
            }

            Disconnect();
            return null;
        }

        public HealthyDiet CreateHealthyDiet(string name, string description, string type, int calories, int fat, int carbs, byte[] image)
        {
            HealthyDiet diet;

            
            return null;
        }

        public ZeroCarbsDiet CreateZeroCarbsDiet(string name, string description, string type, int calories, int fat, byte[] image)
        {
            ZeroCarbsDiet diet;

            

            return null;
        }
    }
}
