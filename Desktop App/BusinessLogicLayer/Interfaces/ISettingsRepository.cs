using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ISettingsRepository
    {
        public void UpdateUserInfo(int id, string username, string email, string firstName, string lastName, byte[] image);
    }
}
