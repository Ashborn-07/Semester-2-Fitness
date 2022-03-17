using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace SLFitness
{
    public class DataBaseHandler
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public MySqlConnection Con { get { return con; } }
        public MySqlCommand Cmd { get { return cmd; } set { cmd = value; } }
        public MySqlDataReader Reader { get { return reader; } set { reader = value; } }

        public void Connect()
        {
            con = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi482834;Database=dbi482834;Pwd=Syrux79;Allow User Variables=True;");
            con.Open();
        }

        public void Disconnect()
        {
            con.Close();
            con = null;
        }
    }
}
