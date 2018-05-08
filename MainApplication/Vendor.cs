using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;


namespace MainApplication
{
    public class Vendor
    {
        Homepage_userControl ui;
        Validation validation;
        DataAccess.DataAccess db;

        public Vendor(Homepage_userControl ui_, DataAccess.DataAccess db_)
        {
            ui = ui_;       // instance of interface
            db = db_;       // instance of database class
            
            // instance of validation class
            validation = new Validation();
        }

        public void NewVendor()
        {
            bool success = true;
            string error_msg = "";

            string vendorname = ui.box_vendorname.Text;
            string balance = ui.box_balance.Text;
            string address = ui.box_address.Text;
            string name = ui.box_contactName.Text;
            string phone = ui.box_phone.Text;
            string fax = ui.box_fax.Text;
            string email = ui.box_email.Text;
            string website = ui.box_website.Text;
            string paymentmethod = ui.box_paymentmethod.Text;
            string tax = ui.box_tax.Text;
            string discount = ui.box_discount.Text;

            // vendor name
            if ((error_msg = validation.IsNotBlank(vendorname, false)) != "")
                success = false;
            validation.Error(ui.box_vendorname, ui.ep, error_msg);

            // contact name
            if ((error_msg = validation.IsNotBlank(name, false)) != "")
                success = false;
            validation.Error(ui.box_contactName, ui.ep, error_msg);

            // phone number
            if ((error_msg = validation.ValidatePhone(phone)) != "")
                success = false;
            validation.Error(ui.box_phone, ui.ep, error_msg);

            // payment method
            if ((error_msg = validation.IsNotBlank(paymentmethod, false)) != "")
                success = false;
            validation.Error(ui.box_paymentmethod, ui.ep, error_msg);

            // discount
            if ((error_msg = validation.ValidatePercentage(discount)) != "")
                success = false;
            validation.Error(ui.box_discount, ui.ep, error_msg);

            // tax
            if ((error_msg = validation.ValidatePercentage(tax)) != "")
                success = false;
            validation.Error(ui.box_tax, ui.ep, error_msg);


            // if all validated, add to database
            if(success)
            {
                try
                {
                    // call store procedure to add venodr
                    db.AddNewVendor(vendorname, balance, address, name, phone, fax, email, website,
                        paymentmethod, tax, discount);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex, "error");
                }
            }


        }

    }
}
