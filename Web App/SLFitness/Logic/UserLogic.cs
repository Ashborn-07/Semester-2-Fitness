namespace SLFitness.Logic
{
    public class UserLogic
    {
        DataAccess data;

        public bool CheckUserInputRegistration(string username, string password, string email, string firstName, string lastName)
        {
            data = new DataAccess();
            if(data.CheckUserCreadentialsAndReturnID(username, password) != -1)
            {
                return false;
            }

            return data.CreateUser(username, password, email, firstName, lastName); ;
        }
    }
}
