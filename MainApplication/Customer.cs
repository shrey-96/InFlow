using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public class Customer
    {
        Homepage_userControl ui;
        Validation validation;
        DataAccess.DataAccess db;

        public Customer(Homepage_userControl ui_, DataAccess.DataAccess db_)
        {
            ui = ui_;       // instance of interface
            db = db_;       // instance of database class

            // instance of validation class
            validation = new Validation();
        }

        // add new customer
        public void NewCustomer()
        {
            bool success = true;
            string error_msg = "";

            string customername = ui.box_cname.Text;
            string balance = ui.box_cbalance.Text;
            string address = ui.box_caddress.Text;
            string name = ui.box_ccontactname.Text;
            string phone = ui.box_cphone.Text;
            string fax = ui.box_cfax.Text;
            string email = ui.box_cemail.Text;
            string website = ui.box_cwebsite.Text;
            string paymentmethod = ui.box_cpayment.Text;
            string tax = ui.box_ctax.Text;
            string discount = ui.box_cdiscount.Text;

            // customer name
            if ((error_msg = validation.IsNotBlank(customername, false)) != "")
                success = false;
            validation.Error(ui.box_cname, ui.ep, error_msg);

            // contact name
            if ((error_msg = validation.IsNotBlank(name, false)) != "")
                success = false;
            validation.Error(ui.box_ccontactname, ui.ep, error_msg);

            // phone number
            if ((error_msg = validation.ValidatePhone(phone)) != "")
                success = false;
            validation.Error(ui.box_cphone, ui.ep, error_msg);

            // payment method
            if ((error_msg = validation.IsNotBlank(paymentmethod, false)) != "")
                success = false;
            validation.Error(ui.box_cpayment, ui.ep, error_msg);

            // discount
            if ((error_msg = validation.ValidatePercentage(discount)) != "")
                success = false;
            validation.Error(ui.box_cdiscount, ui.ep, error_msg);

            // tax
            if ((error_msg = validation.ValidatePercentage(tax)) != "")
                success = false;
            validation.Error(ui.box_ctax, ui.ep, error_msg);


            int customerid = db.GetID("customerid");

            // if all validated, add to database
            if (success)
            {
                try
                {
                    // call store procedure to add venodr
                    db.AddNewCustomer(customerid, customername, balance, address, name, phone, fax, email, website,
                        paymentmethod, tax, discount);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex, "error");
                    return;
                }

                MessageBox.Show("Customer Added", "Success");
            }
        }


        // display vendor list
        public bool CustomerList()
        {
            bool success = true;
            DataTable datatable = new DataTable();

            try
            {
                SqlDataAdapter adapter = db.GetDataAdapter("select * from customer");
                adapter.Fill(datatable);
                ui.DG_Customer.DataSource = datatable;
                ui.DG_Customer.AutoResizeRows();
                ui.DG_Customer.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while filling customer list in the grid" + ex, "Error");
                success = false;
            }


            return success;
        }
    }
}
