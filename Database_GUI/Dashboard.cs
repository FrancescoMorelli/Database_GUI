using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_GUI
{
    public partial class Dashboard : Form
    {
        public Func<string,string, List<People>> GetPeopleRecords = Database.GetPeople;
        public Func<bool> LoadDb = Database.LoadDatabase;

        public Dashboard()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tab_Search);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text != "")
            {
                list_Search.DataSource = GetPeopleRecords(txt_Search.Text, cmBox_Search.Text);

                // FullInfo is a manual implemented property in the People class,
                // that returns FirstName LastName and EmailAddress
                list_Search.DisplayMember = "FullInfo";
            }
            else
                MessageBox.Show("Please enter a value.");

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            if (LoadDb())
            {
                tabControl1.TabPages.Add(tab_Search);
                tabControl1.TabPages.Remove(tab_Load);
                PopulateTableRowBox();
            }
        }

        public void PopulateTableRowBox()
        {
            var tableList = Database.GetTablesName().ToList();

            // Loop starts at 2 to get the People column names
            // such as FirstName, LastName, EmailAddress, PhoneNumber
            for (var i = 2; i < tableList.Count; i++)
            {
                cmBox_Search.Items.Add(tableList[i]);
            }

            cmBox_Search.Refresh();
        }
    }
}
