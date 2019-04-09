using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDAL:DatabaseAccess
    {
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> listUser = new List<UserDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                UserDTO activity = new UserDTO(userId,username,password,name);
                listUser.Add(activity);
            }

            this.Close();
            return listUser;
        }

        public UserDTO GetUser(int id)
        {
            UserDTO user;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                user = new UserDTO(userId, username, password, name);
                return user;
            }

            this.Close();
            return null;
        }

        public bool InsertUser(UserDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.UserId + "','" + activity.UserName + "','" + activity.Password + "','" + activity.Name + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateUser(UserDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set USER_ID='" + activity.UserId + "',USERNAME = '" + activity.UserName
                            + "',PASSWORD ='" + activity.Password + "',NAME = '" + activity.Name ;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
