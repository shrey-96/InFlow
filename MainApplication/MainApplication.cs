using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class MainApplication : Form
    {
        private string username;
        private int TabCount;

        public MainApplication(string username)
        {
            InitializeComponent();
            this.username = username;
            TabCount = -1;                  // it will become 0 when incremented in the NewTabEvent
            Btn_NewTab_Click(null, null);   // call new tab to add user controls
        }

        private void Btn_NewTab_Click(object sender, EventArgs e)
        {
            Tabs.TabPages.Add("Homepage");

            // select the tab to be able to add HomePage controls
            Tabs.SelectTab(++TabCount);            
            Tabs.SelectedTab.Controls.Add(new Homepage_userControl());  // add controls
         //   Tabs.b
        }

       
    }
}
