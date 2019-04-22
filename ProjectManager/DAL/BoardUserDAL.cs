using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BoardUserDAL : DatabaseAccess
    {
        public List<int> GetAllUsersId(int boardId)
        {
            List<int> listUserId = new List<int>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM BOARD_USER WHERE BOARD_ID = '" + boardId + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(1);

                listUserId.Add(userId);
            }

            reader.Close();
            this.Close();
            return listUserId;
        }
        
    }
}
