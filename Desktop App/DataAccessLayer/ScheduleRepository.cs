using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class ScheduleRepository : DatabaseHandler, IScheduleRepository
    {

        public DataTable DisplaySchedule()
        {
            Connect();

            string sql = "SELECT * FROM indiv_schedule";

            Cmd = new MySqlCommand(sql, Con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(Cmd);
            DataTable data = new DataTable();

            try
            {
                adapter.Fill(data);
            }
            finally
            {
                Disconnect();
            }

            return data;
        }

        public DataTable DisplayByFilters(string location)
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
            }
            finally
            {
                Disconnect();
            }

            return dataTable;
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

                while (Reader.Read())
                {
                    vs.Add(Reader["location"].ToString());
                }
            }
            finally
            {
                Disconnect();
            }

            return vs;
        }

        public DataTable FilterByDate(string date)
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
            } finally
            {
                Disconnect();
            }

            return dataTable;
        }
    }
}
