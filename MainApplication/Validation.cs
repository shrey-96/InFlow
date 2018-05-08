using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApplication;

namespace MainApplication
{
    public class Validation
    {
     
        public Validation()
        {
            // constructor does nothing
        }


        // check for special characters
        public bool SpecialCharCheck(string temp)
        {
            bool flag = true;
            Regex r = new Regex("^[a-zA-Z0-9]*$");

            if (r.IsMatch(temp))
                flag = false;

            return flag;
        }

        // validate discount and tax for numbers
        public string ValidatePercentage(string temp)
        {
            string result = "";
            int number = 0;

            // if parsing fails
            if(int.TryParse(temp, out number) == false)
            {
                result = "Invalid entry.. Should be number between 1 - 100";
            }

            if(number < 0 || number > 100)
            {
                result = "Invalid entry.. Should be number between 1 - 100";
            }

            return result;            
        }



        // validate phone number of the user
        public string ValidatePhone(string phoneNum)
        {
            string error_msg = "";
            // since phone number is optional mandatory, it's valid to be empty
            if (phoneNum.Length != 10)
            {
                error_msg = "Invalid phone number";
                return error_msg;
            }

            if (Regex.Match(phoneNum, @"^[0-9]{10}$").Success == false)
            {
                error_msg = "Phone number can't contain special characters";
            }

            return error_msg;
        }




        // check if the string is not blank, also check for numbers based on bool paramater
        public string IsNotBlank(string str, bool NumberAllowed)
        {
            string msg = "";

            // check is string i blank and set flag to false if it is
            if (str.Equals(""))
            {
                msg = "Field cannot be blank";
                return msg;
            }

            if (SpecialCharCheck(str))
            {
                msg = "Field cannot contain special characters";
                return msg;
            }

            if (NumberAllowed == false)
            {
                // check if string contains any number, set flag to false if it does
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        msg = "This field can't contain numbers\n";
                        break;
                    }
                }
            }

            return msg;
        }


        // validate email id of the user for proper format
        public string ValidateEmail(string email)
        {
            string error_msg = "";

            if (email.Contains("@") == false || email.Contains(".") == false || email.Contains(" "))
                error_msg = "Invalid email format. Should be in xyz@example.com format";


            return error_msg;
        }

        // show error
        public void Error(Control control, ErrorProvider ep, string msg)
        {
            try
            {
                ep.SetError(control, msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public string validatePasswordCriteria(string password)
        {
            string msg = "";

            // check if password meets the minimum length criteria
            if(password.Length < 8)
            {
                msg = "Password must be at least 8 characters long.";
                return msg;
            }

            // check if password contains both alphabets and numbers, and nothing else
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (r.IsMatch(password) == false)
            {
                msg = "password must contain both alphabets AND numbers only";               
            }

            return msg;
        }
    }
}
