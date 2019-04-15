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
        public List<int> SearchId(int cardId)
        {
            List<int> listUserId = new List<int>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM LAMVIEC WHERE CARD_ID = " + cardId;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(1);

                listUserId.Add(userId);
            }

            this.Close();
            return listUserId;
        }
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
