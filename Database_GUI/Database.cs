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

        public static List<People> GetPeople(string lastName)
        {
            var m = new SampleDBDataContext(Connection);
            
            var query = (from p in m.GetTable<People>()
                         where p.LastName == $"{lastName}"
                         select p).ToList();
            
            return query;
        }
    }
}

