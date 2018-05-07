using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainApplication;

namespace InFlow
{
    public partial class InFlow : Form
    {
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
            validation = new Validation(this);
            NewUser = new RegisterNewUser(this, db, validation);
        }


        // login button on main home page
        private void btn_login_Click(object sender, EventArgs e)
        {
            string un = box_username.Text;
            string password = box_password.Text;

            // check the credentials in the database
            string query = "select email from userinfo where username = '" + un + "' " +
                "and password = '" + password + "' COLLATE Latin1_General_CS_AS";

            string email = db.GetColumnData(query, "email");
            if (email == "")
            {
                Label_LoginError.Text = "Login failed. Invalid username or password. Try again.";
                return;
            }

            Label_LoginError.Text = "";



            MessageBox.Show("Login Successful", "Success");
            this.Hide();
            var form2 = new MainApplication.MainApplication(un);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }


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
                Panel_Login.BringToFront();
            }
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

            // clear the labels
            Label_LoginError.Text = "";
        }
    }
}
