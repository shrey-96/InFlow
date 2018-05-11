using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                    return;
                }

                MessageBox.Show("Vendor Added", "Success");
            }


        }

        // display vendor list
        public bool VendorList()
        {
            bool success = true;
            DataTable datatable = new DataTable();

            try
            {
                SqlDataAdapter adapter = db.GetDataAdapter("select * from vendor");
                adapter.Fill(datatable);                
                ui.DG_Vendor.DataSource = datatable;
                ui.DG_Vendor.AutoResizeRows();
                ui.DG_Vendor.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while filling vendor list in the grid" + ex, "Error");
                success = false;
            }


            return success;
        }

        public void NewVendorList()
        {
            MessageBox.Show("count : " + ui.DG_Vendor.RowCount + "  column: " + ui.DG_Vendor.ColumnCount);
           for(int i = 0; i < ui.DG_Vendor.RowCount; i++)
            {

            }
        }

        public string select(string column)
        {
            string select = "select " + column + " from vendor";
            return select;
        }

        // update vendor list
        public bool UpdateVendorList()
        {
            bool success = true;
            ui.DG_Vendor.EndEdit(); //very important step

            SqlDataAdapter da =  db.GetDataAdapter("select * from vendors");
            DataTable data;
            if((data = GetDataGridValue(ui.DG_Vendor)) == null)
            {
                success = false;
            }

            
            try
            {
                if (success)
                {
                    
                    da.UpdateCommand = new SqlCommandBuilder(da).GetUpdateCommand();
                    da.Update(data);
                    MessageBox.Show("Successfully saved", "Success");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving vendor" + ex, "Error");
                success = false;
            }

            return success;
        }

        // get values from datagrid and store in datatables
        private DataTable GetDataGridValue(DataGridView grid)
        {
            DataTable myDT;
            myDT = (DataTable)grid.DataSource;
            return myDT;
        }
    }
}
