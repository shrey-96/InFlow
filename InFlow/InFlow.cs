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

            db = new DataAccess();
            email = new Email();
            validation = new Validation(this);
            NewUser = new RegisterNewUser(this, db, validation);
            
            // instantiate email
         
        }
   

        // login button on main home page
        private void btn_login_Click(object sender, EventArgs e)
        {
            string un = box_username.Text;
            string password = box_password.Text;


            // email.EmailClient("tiwarishreyansh15@gmail.com", "One Time Password", "Your OTP is: 4524");
            email.SendOTP("tiwarishreyansh15@gmail.com");


            MessageBox.Show(">> " + un + " - " + password);
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
            if(NewUser.SignupNewUser())
                Panel_OTP.BringToFront();
        }

        // resend the otp to entered email address
        private void Label_ResendOTP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OTP Resent", "Success");
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
        }
    }
}
