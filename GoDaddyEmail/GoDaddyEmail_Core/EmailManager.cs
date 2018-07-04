using GoDaddyEmail_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDaddyEmail_Core
{
    public class EmailManager
    {
        public static void SendEmail(ContactModel model, out string errorMessage)
        {
            IEmailTools emailTools = AppTools.InitEmailTools(false);

            if (emailTools.SendEmail(model.EmailTo, model.EmailBody) == false)
                errorMessage = "Error sending email";
            else
                errorMessage = string.Empty;
        }
    }
}
