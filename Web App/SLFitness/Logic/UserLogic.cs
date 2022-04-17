namespace SLFitness.Logic
{
    public class UserLogic
    {
        private DataAccess data = new DataAccess();

        public bool CheckUserInputRegistration(string username, string password, string email, string firstName, string lastName)
        {
            
            if(data.CreadentailsCheck(username, password) != null)
            {
                return false;
            }

            return data.CreateUser(username, password, email, firstName, lastName); ;
        }
    }
}
