using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardUserDAL : DatabaseAccess
    {
        public List<CardUserDTO> GetAllUser()
        {
            List<CardUserDTO> listCardUser = new List<CardUserDTO>();

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                CardUserDTO user = new CardUserDTO(userId, userName, password, name);
                listCardUser.Add(user);
            }

           // this.Close();
            return listCardUser;
        }

        public CardUserDTO GetUser(int id)
        {
            CardUserDTO user;

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE USER_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                user = new CardUserDTO(userId, userName, password, name);
                return user;
            }

           // this.Close();
            return null;
        }

        public bool InsertUser(CardUserDTO user)
        {
            // this.ConnectToDatabase();

            string Query = "insert into USERS values('" + user.UserId + "','" + user.UserName + "','" + user.Password + "','" + user.Name + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


           // this.Close();
            return true;
        }

        public bool UpdateUser(CardUserDTO user)
        {
            // this.ConnectToDatabase();

            string Query = "update CARD set USER_ID='" + user.UserId + "',USERNAME = '" + user.UserName + "',PASSWORD = '" + user.Name + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


           // this.Close();
            return true;
        }
    }
}
