using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class DatabaseAccess
    {
        private string databaseName;
        private string userName;
        private string passWord;

        public string DatabaseName { get => databaseName; set => databaseName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        protected MySqlConnection mySQLConnection = null;

        public DatabaseAccess()
        {
            this.databaseName = "ProjectManager";
            this.userName = "thinhnnd";
            this.passWord = "admin123";
        }

        public bool ConnectToDatabase()
        {
            if (mySQLConnection == null)
            {
                if (String.IsNullOrEmpty(this.databaseName))
                    return false;

                string conStr= string.Format("Server=65.52.172.214; database={0}; UID={1}; password={2}", databaseName,userName,passWord);
                mySQLConnection = new MySqlConnection(conStr);
                mySQLConnection.Open();
            }
            return false;
        }

        public void Close()
        {
            mySQLConnection.Close();
        }
    }
}
