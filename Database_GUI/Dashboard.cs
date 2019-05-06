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
        public Func<string, List<People>> GetPeopleRecords = Database.GetPeople;
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
                list_Search.DataSource = GetPeopleRecords(txt_Search.Text);

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
            }
        }

        public void PopulateTableRowBox()
        {

        }
    }
}
