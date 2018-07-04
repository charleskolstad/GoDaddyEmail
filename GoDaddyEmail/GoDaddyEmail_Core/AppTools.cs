using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoDaddyEmail_Core
{
    public class AppTools
    {
        internal static IEmailTools InitEmailTools(bool isTest)
        {
            if (isTest)
                return new FakeEmailTools();

            return new EmailTools();
        }
    }
}
