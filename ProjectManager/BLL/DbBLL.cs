using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DbBLL
    {
        DatabaseAccess database = new DatabaseAccess();

        public bool ConnectToDatabase()
        {
            return database.ConnectToDatabase();
        }

        public void Close()
        {
           database.Close();
        }
    }
}
