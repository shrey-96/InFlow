using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InFlow
{
    public partial class InFlow : Form
    {
        Email email;
        DataAccess db;
        RegisterNewUser NewUser;
        Validation validation;

        public InFlow()
        {
            InitializeComponent();
            box_username.Focus();
            Panel_Login.BringToFront();

            // instantiate all the classes
            db = new DataAccess();
            email = new Email();
            validation = new Validation(this);
            NewUser = new RegisterNewUser(this, db, validation);
        }
   

        // login button on main home page
        private void btn_login_Click(object sender, EventArgs e)
        {
            string un = box_username.Text;
            string password = box_password.Text;

            string query = "select email from userinfo where username = '" + un + "' " +
                "and password = '" + password + "'";

            string email = db.GetColumnData(query, "email");
            if(email == "")
            {
                Label_LoginError.Text = "Login failed. Invalid username or password. Try again.";
                return;
            }

            Label_LoginError.Text = "";


            //check if email is verified
            query = "select verified from userinfo where username = '" + un + "'";
            string result = db.GetColumnData(query, "verified");
            if(result == "1")
            {
                MessageBox.Show("Login Successful", "Success");
            }
            else
            {
                box_hiddenEmail.Text = email;
                box_hiddenOTP.Text = this.email.SendOTP(email).ToString();
                Panel_OTP.BringToFront();
            }
            
        }

        //// show error
        //private void Error(Control control, string msg)
        //{
        //    try
        //    {
        //        ep.SetError(control, msg);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex);
        //    }
        //}

        // sign up button press on main home page
        private void btn_signup_Click(object sender, EventArgs e)
        {
            Panel_Signup.BringToFront();
        }


        // get user details, validate them, go to OTP panel once done
        private void Btn_RegisterUser_Click(object sender, EventArgs e)
        {
            if (NewUser.SignupNewUser())
            {
                MessageBox.Show("Congratulations, you are successfully registered!", "Success");
                string user_email = box_hiddenEmail.Text;
                Panel_OTP.BringToFront();
                box_hiddenOTP.Text = "" +  email.SendOTP(user_email);
            }
        }

        // resend the otp to entered email address
        private void Label_ResendOTP_Click(object sender, EventArgs e)
        {
            string user_email = box_hiddenEmail.Text;
            box_hiddenOTP.Text = "" + email.SendOTP(user_email);
            MessageBox.Show("OTP successfully sent", "Success");
        }


        // check if the username if already taken
        private void username_availability(object sender, EventArgs e)
        {
            string error_msg = "";
            if(NewUser.UsernameExist(box_selectusername.Text))
            {
                error_msg = "Username already exist";
                validation.Error(box_selectusername, error_msg);
                return;
            }

            validation.Error(box_selectusername, error_msg);
        }


        public void ClearAllFields()
        {
            // clear fields on signup page
            box_firstname.Clear();
            box_lastname.Clear();
            box_emailid.Clear();
            box_selectusername.Clear();
            box_selectpassword.Clear();
            box_phone.Clear();

            // clear main login page
            box_username.Clear();
            box_password.Clear();

            // clear one time password
            Box_OTP.Clear();

            // clear hidden email box
            box_hiddenEmail.Clear();
            box_hiddenOTP.Clear();

            // clear the labels
            Label_LoginError.Text = "";
        }


        // validate that the otp is correct and verify the user
        private void Btn_ConfirmOTP_Click(object sender, EventArgs e)
        {
            string userinput = Box_OTP.Text;
            string email = box_hiddenEmail.Text;
            string OTP = box_hiddenOTP.Text;

            // check if userinput matches with the otp
            if (OTP == userinput)
            {
                NewUser.verified(email);
                MessageBox.Show("Your email has been successfully verified!", "Success");
                ClearAllFields();
                Panel_Login.BringToFront();
            }
            else
                MessageBox.Show("Invalid OTP", "Error");
        }
    }
}
