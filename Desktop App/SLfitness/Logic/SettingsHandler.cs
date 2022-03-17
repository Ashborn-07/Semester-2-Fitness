using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SLfitness
{
    public class SettingsHandler : DatabaseHandler
    {

        public void DisplayProfileInformation(int id, TextBox tbUsername, TextBox tbEmail, TextBox tbFirstName, TextBox tbLastName, PictureBox pictureBox)
        {
            Connect();

            string sql = "SELECT * FROM indiv_user WHERE id = @Id";

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
                tbUsername.Text = Reader.GetString(1);
                tbEmail.Text = Reader.GetString(3);
                tbFirstName.Text = Reader.GetString(4);
                tbLastName.Text = Reader.GetString(5);

                byte[] image = (byte[])(Reader["picture"]);
                MemoryStream ms = new MemoryStream(image);
                Image img = new Bitmap(ms);
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Disconnect();
        }
    }
}
