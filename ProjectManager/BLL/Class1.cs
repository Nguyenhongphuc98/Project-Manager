using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class Class1
    {
        DatabaseAccess databaseAccess = new DAL.DatabaseAccess();

        public void Connect()
        {
            databaseAccess.ConnectToDatabase();
        }
    }
}
