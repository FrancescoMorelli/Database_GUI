using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace Database_GUI
{
    public class Database
    {
        public static string DbPath { get; set; }
        public static string Connection { get; set; }


        public static bool LoadDatabase()
        {
            bool flag;

            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.InitialDirectory = Environment.CurrentDirectory;
                openFile.Filter = "SampleDB file (*.mdf) | *.mdf";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    DbPath = openFile.FileName;
                    Connection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={DbPath};Integrated Security = True;";
                    MessageBox.Show("Database loaded with success.");

                    return flag = true;
                }
                else
                {
                    MessageBox.Show("Database was not loaded, retry.");
                    return flag = false;
                }
            }
        }

        public static List<People> GetPeople(string searchValue, string columnName)
        {
            var db = new SampleDBDataContext(Connection);

            switch (columnName)
            {
                case "LastName":
                    var lastNameQuery = db.Peoples.Where(x => x.LastName == $"{searchValue}").ToList();
                    return lastNameQuery;

                case "FirstName":
                    var firstNameQuery = db.Peoples.Where(x => x.FirstName == $"{searchValue}").ToList();
                    return firstNameQuery;

                case "PhoneNumber":
                    var phoneNumberQuery = db.Peoples.Where(x => x.PhoneNumber == $"{searchValue}").ToList();
                    return phoneNumberQuery;

                default:
                    return null;
            }


            //var query = (from p in db.GetTable<People>()
            //             where p.LastName == $"{searchValue}"
            //             select p).ToList();

        }

        public static IEnumerable<string> GetTablesName()
        {
            var db = new SampleDBDataContext(Connection);

            var columnNames = from t in typeof(People).GetProperties()
                              select t.Name;

            return columnNames;
        }
    }
}

