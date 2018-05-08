using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;


namespace MainApplication
{
    public partial class MainApplication : Form
    {
        private string username;
        private int TabCount;
        public string connectionstring;
        DataAccess.DataAccess db;


        public MainApplication(string username)
        {
            InitializeComponent();
            this.username = username;
            TabCount = -1;                  // it will become 0 when incremented in the NewTabEvent
            

            // get connection string and connect this app to database

            connectionstring = ConfigurationManager.ConnectionStrings["DB_ConnectionString"].ConnectionString;
            db = new DataAccess.DataAccess(connectionstring);

            Btn_NewTab_Click(null, null);   // call new tab to add user controls
            //connectionstring = constring;


        }

        private void Btn_NewTab_Click(object sender, EventArgs e)
        {
            Tabs.TabPages.Add("Homepage");
          //  DataAccess.DataAccess db;

            // select the tab to be able to add HomePage controls
            Tabs.SelectTab(++TabCount);
            //  db = new DataAccess.DataAccess(connectionstring);
            Tabs.SelectedTab.Controls.Add(new Homepage_userControl(db));  // add controls
        }

    }
}
