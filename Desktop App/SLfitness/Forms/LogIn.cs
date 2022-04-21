using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class LogIn : Form
    {
        private User user;
        private UserService service;

        public LogIn()
        {
            InitializeComponent();
            IUserRepository repository = new UserRepository();
            service = new UserService(repository);
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