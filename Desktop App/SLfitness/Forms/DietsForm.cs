using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class DietsForm : Form
    {
        private User user;
        private DietService service;
        private Menu menu;

        public DietsForm(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;
            IDietsRepository repository = new DietsRepository();
            service = new DietService(repository);
        }

        private void DietsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            NewDiet newDiet = new NewDiet(user);
            newDiet.Show();
        }

        //TODO to be displayed the extra information when clicked on row probably
        private void dataGridv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string p = dataGridv.Rows[e.RowIndex].Cells[2].Value.ToString();
            int id = Convert.ToInt32(p);

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DietImageForm dietImageForm = new DietImageForm(id);
                dietImageForm.Show();
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                //TODO with the UpdateDiet Form
                UpdateDiet updateDiet = new UpdateDiet(id, service.ReturnDietType(id), user);
                updateDiet.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilter.SelectedItem.ToString().Equals("Zero Carbs"))
            {
                try
                {
                    dataGridv.DataSource = service.DisplayDiets("zerocarbs");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (ApplicationCustomException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Healthy"))
            {
                try
                {
                    dataGridv.DataSource = service.DisplayDiets("healthy");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (ApplicationCustomException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    service.DisplayDiets("all");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridv.DataSource = service.DisplayDiets("all");
            } catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DietsForm_Load(object sender, EventArgs e)
        {
            btnRefresh_Click_1(this, e);
        }
    }
}
