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
    internal class ScheduleHandler : DatabaseHandler
    {

        public void DisplaySchedule(DataGridView dgv)
        {
            Connect();

            string sql = "SELECT * FROM indiv_schedule";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable data = new DataTable();

            try
            {
                adapter.Fill(data);
                dgv.DataSource = data;
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

        public void DisplayByFilters(string location, DataGridView dgv)
        {
            Connect();

            string sql = "SELECT * FROM indiv_schedule WHERE location = @Location";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Location", location);

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

        public List<string> GetLocations()
        {
            Connect();
            List<string> vs = new List<string>();

            string sql = "SELECT DISTINCT `location` FROM indiv_schedule";
            Cmd = new MySqlCommand(sql, Con);

            try
            {
                Reader = Cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            while (Reader.Read())
            {
                vs.Add(Reader["location"].ToString());
            }

            Disconnect();

            return vs;
        }

        public void FilterByDate(string date, DataGridView dataGridView)
        {
            Connect();

            string sql = "SELECT * FROM indiv_schedule WHERE date = @Date";

            Cmd = new MySqlCommand(sql, Con);
            Cmd.Parameters.AddWithValue("@Date", date);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
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
    }
}
