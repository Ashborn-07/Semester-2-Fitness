namespace SLfitness
{
    public partial class LogIn : Form
    {
        private int activeUserID;

        public LogIn()
        {
            InitializeComponent();
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

            LogInHandler handler = new LogInHandler();
            activeUserID = handler.CredentialsCheck(username, password);

            if (activeUserID > 0)
            {
                string userType = handler.GetUserType(activeUserID);
                if (!String.IsNullOrEmpty(userType))
                {
                    if (userType.Equals("COACH"))
                    {
                        Menu menu = new Menu(activeUserID);
                        menu.Show();
                        this.Close();
                        return;
                    } else
                    {
                        MessageBox.Show("This application is only for coaches");
                        return;
                    }
                }
            }

            MessageBox.Show("Username or Password are incorrect.");
        }
    }
}