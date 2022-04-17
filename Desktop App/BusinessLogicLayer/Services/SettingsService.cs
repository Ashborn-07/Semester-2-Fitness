using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLayer
{
    public class SettingsService
    {
        private ISettingsRepository repository;

        public SettingsService(ISettingsRepository repository)
        {
            this.repository = repository;
        }

        public void UpdateUserInfo(User user)
        {
            string pattern  = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-]+)\.([a-zA-Z]{2,5})$";

            RegexOptions option = RegexOptions.Multiline;

            if (Regex.IsMatch(user.Email, pattern, option))
            {
                MemoryStream memoryStream = new MemoryStream();
                user.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                byte[] img = memoryStream.ToArray();

                repository.UpdateUserInfo(user.Id, user.UserName, user.Email, user.FirstName, user.LastName, img);
            }

            throw new ApplicationException("Email input is not valid. It should have \"@, .com, .nl\" etc.");
        }
    }
}
