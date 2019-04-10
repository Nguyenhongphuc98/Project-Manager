using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LamViecDAL:DatabaseAccess
    {
        public bool UpdateUser(int userId, int cardId)
        {
            this.ConnectToDatabase();

            string Query = "update LAMVIEC set USER_ID ='" + userId + "' where CARD_ID ='" + cardId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }

        public bool InsertUser(int userId, int cardId)
        {
            this.ConnectToDatabase();

            string Query = "insert into LAMVIEC(CARD_ID, USER_ID) values('"+cardId + "','" + userId + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
