using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Supermarket
{
    public class CustomValid
    {
        public static bool isValidEmai(string Email)

        {

            Regex TheRegExpression;


            string TheRegExTest = @"[2-9]\d{2}-\d{3}-\d{4}";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(Email))

            {

                return true;

            }

            else

            {

                return false;

            }
        }

        public static bool isValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool isValidPass(string pass)
        {

            Regex TheRegExpression;


            string TheRegExTest = @"(^.{7}$)";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(pass))

            {

                return true;

            }

            else

            {

                return false;

            }
        }

        public static bool isValidName(string pass)
        {

            Regex TheRegExpression;


            string TheRegExTest = @"(^[a-zA-Z\(\)''-'\s]{1,250}$)";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(pass))

            {

                return true;

            }

            else

            {

                return false;

            }
        }

        public static bool isValidPhone(string pass)
        {

            Regex TheRegExpression;


            string TheRegExTest = @"(((?:\(?[2-9](?(?=1)1[02-9]|(?(?=0)0[1-9]|\d{2}))\)?\D{0,3})(?:\(?[2-9](?(?=1)1[02-9]|\d{2})\)?\D{0,3})\d{4}))";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(pass))

            {

                return true;

            }

            else

            {

                return false;

            }
        }

        public static bool isValidLocation(string pass)
        {

            Regex TheRegExpression;


            string TheRegExTest = @"(^[a-zA-Z\(\)'-'\s]{1,250}$)";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(pass))

            {

                return true;

            }

            else

            {

                return false;

            }
        }

        public static bool isValidDecimalPoint(string pass)
        {

            try
            {
                decimal num=Decimal.Parse(pass);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool isValidInt(string pass)
        {

            try
            {
                decimal num = int.Parse(pass);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool isValidUPC(string pass)
        {
            Regex TheRegExpression;


            string TheRegExTest = @"(^[0-9]{12}$)";


            TheRegExpression = new Regex(TheRegExTest);


            if (TheRegExpression.IsMatch(pass))

            {

                return true;

            }

            else

            {

                return false;

            }
        }
    }
}
