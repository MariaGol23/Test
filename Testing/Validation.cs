using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Validation
    {
        public bool SymbolsCount(string str)
        {
            return str.Length >=3 && str.Length <=15;
        }

        public bool Positive(string str)
        {
            try
            {
                if (str.Contains(".") || str.Contains(","))
                    return false;
                var a = Convert.ToInt32(str);
                if (a < 0)
                    return false;
                return true;
            }
            catch
            {
                return false;

            }

        }

        public bool Email(string email)
        {

            var trimmedEmail = email.Trim();

            if (email.EndsWith(".") || trimmedEmail.EndsWith("."))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Year(string year)
        {
            if (year.StartsWith("0") || year.Length != 4)
                return false;

            return true;
        }
    }
}
