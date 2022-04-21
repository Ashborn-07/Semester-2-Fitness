using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DatabaseHandler
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public MySqlConnection Con { get { return con; } }
        public MySqlCommand Cmd { get { return cmd; } set { cmd = value; } }
        public MySqlDataReader Reader { get { return reader; } set { reader = value; } }

        public void Connect()
        {
            if (con == null)
            {
                con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi482834;Database=dbi482834;Pwd=Syrux79;Allow User Variables=True;");
                con.Open();
            }
        }

        public void Disconnect()
        {
            if (con.State == System.Data.ConnectionState.Open && con != null)
            {
                con.Close();
                con = null;
            }
        }
    }
}
