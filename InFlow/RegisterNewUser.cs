using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InFlow
{
    public class RegisterNewUser
    {
        DataAccess db;
        InFlow ui;
        Validation validation;

        public RegisterNewUser(InFlow ui_ ,DataAccess db_, Validation validation_)
        {
            db = db_;
            ui = ui_;
            validation = validation_;
        }

        // check if the username is already taken by some other user
        public bool UsernameExist(string username)
        {
            bool exist = false;

            string query = "select username from userinfo where username = '" + username + "'";
            string result = db.GetColumnData(query, "username");
            if(result != "")
            {
                exist = true;                
            }

            return exist;
        }

        // validate all the fields and sign the new user up
        public bool SignupNewUser()
        {
            bool success = true;
            bool userexist = false;
            bool validemail = true;
            string error_msg = "";

            string firstname = ui.box_firstname.Text;
            string lastname = ui.box_lastname.Text;
            string phone = ui.box_phone.Text;
            string email = ui.box_emailid.Text;
            string username = ui.box_selectusername.Text;
            string password = ui.box_selectpassword.Text;

            // validate firtname
            if ((error_msg = validation.IsNotBlank(firstname, false)) != "")
                success = false;
            validation.Error(ui.box_firstname, error_msg);



            // validate lastname
            if ((error_msg = validation.IsNotBlank(lastname, false)) != "")
                success = false;
            validation.Error(ui.box_lastname, error_msg);


            // validate phone
            if ((error_msg = validation.ValidatePhone(phone)) != "")
                success = false;
            validation.Error(ui.box_phone, error_msg);


            // valdate email id
            if ((error_msg = validation.ValidateEmail(email)) != "")
            {
                validemail = false;
                success = false;
            }
            validation.Error(ui.box_emailid, error_msg);

            // check if email id is already taken by someone
            if(validemail)
            {
                string msg = "";
                if (CheckEmailExistence(email))
                {
                    msg = "This email id already exist";
                    success = false;
                }

                validation.Error(ui.box_emailid, msg);
            }


            // validate username field and make sure it does not exist
            if (UsernameExist(username))
            {              
                success = false;
                userexist = true;
            }
            else
            if ((error_msg = validation.IsNotBlank(username, true)) != "")
                success = false;

            // set error if user does not exist and the field is blank
            if (!userexist)
                validation.Error(ui.box_selectusername, error_msg);
           


            // validate password field
            if ((error_msg = validation.validatePasswordCriteria(password)) != "")
                success = false;
            validation.Error(ui.box_selectpassword, error_msg);


            // add user to database if validated
            if(success)
            {
                success = db.AddNewUser(username, password, firstname, lastname, phone, email);
                if (success == false)
                    MessageBox.Show("Error while adding patient. Try again.");
            }


            return success;
        }

        // check if email exist in the database
        private bool CheckEmailExistence(string email)
        {
            bool exist = false;
            string query = "select email from userinfo where email = '" + email + "'";
            string result = db.GetColumnData(query, "email");

            if (result != "")
                exist = true;

            return exist;
        }

     
    }
}
