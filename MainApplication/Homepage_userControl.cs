using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class Homepage_userControl : UserControl
    {
        Vendor vendor;
        DataAccess.DataAccess db;

        public Homepage_userControl(DataAccess.DataAccess db_)
        {
            InitializeComponent();
            panel_homepage.BringToFront();
            db = db_;
            vendor = new Vendor(this, db);
        }


        //____________________________________________________________________________________________________________
        //_________________________HOVER DISPLAY HIDE FUNCTIONALITY___________________________________________________
        //____________________________________________________________________________________________________________

        // vendor options
        private void DisplayVendorOption(object sender, EventArgs e)
        {
            HoverHandling(label_NewVendor, label_vendorlist, false);
        }

        // purchase options
        private void ShowPurchaseOptions(object sender, EventArgs e)
        {
            HoverHandling(Label_NewOrder, label_orderList, false);
        }

        // customer options
        private void DisplayCustomerOptions(object sender, EventArgs e)
        {
            HoverHandling(label_newCustomer, label_customerList, false);
        }

        // sales options
        private void DisplaySalesOptions(object sender, EventArgs e)
        {
            HoverHandling(label_newSales, label_salesList, false);
        }

        // display controls passed as parameters
        private void HoverHandling(Control ob1, Control ob2, bool showOnlyInventory)
        {

            // vendor
            label_NewVendor.Visible = false;
            label_vendorlist.Visible = false;

            // purchase
            Label_NewOrder.Visible = false;
            label_orderList.Visible = false;

            // inventory
            label_currentStock.Visible = showOnlyInventory;
            label_adjustStock.Visible = showOnlyInventory;
            label_reorderStock.Visible = showOnlyInventory;
            label_newProduct.Visible = showOnlyInventory;
            label_workOrder.Visible = showOnlyInventory;

            // sales 
            label_newSales.Visible = false;
            label_salesList.Visible = false;

            // customer
            label_newCustomer.Visible = false;
            label_customerList.Visible = false;

            if (showOnlyInventory == false)
            {
                ob1.Visible = true;
                ob2.Visible = true;
            }

        }

        // inventory options
        private void DisplayInventoryOptions(object sender, EventArgs e)
        {
            HoverHandling(null, null, true);
        }

        //____________________________________________________________________________________________________________
        //____________________________________________________________________________________________________________
        //____________________________________________________________________________________________________________


        // add new vendor click on home page
        private void Event_AddNewVendor(object sender, EventArgs e)
        {
            panel_newVendor.BringToFront();
        }

        // Save/Add vendor click
        private void Btn_SaveVendor_Click(object sender, EventArgs e)
        {
            // new vendor method call
            vendor.NewVendor();

        }
    }
}
