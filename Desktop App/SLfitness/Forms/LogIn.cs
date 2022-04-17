using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitness
{
    public partial class LogIn : Form
    {
        private User user;
        private UserLogInService service;

        public LogIn()
        {
            InitializeComponent();
            IUserLogInRepository repository = new UserLogInRepository();
            service = new UserLogInService(repository);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("Username and password field must be filled!");
                return;
            }

            string username = tbUsername.Text;
            string password = tbPassword.Text;

            try
            {
                user = service.UserDataValidation(username, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbUsername.Text = "";
                tbPassword.Text = "";
            }

            if (user != null)
            {
                switch (user.Type)
                {
                    case UserType.COACH:
                        Menu menu = new Menu(user);
                        menu.Show();
                        this.Close();
                        break;
                    case UserType.USER:
                        MessageBox.Show("This application is only for coaches");
                        break;
                }
            }
        }
    }
}