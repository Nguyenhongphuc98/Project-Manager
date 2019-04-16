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
            command.CommandText = "SELECT * FROM USERS ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                UserDTO user = new UserDTO(userId,username,password,name);
                listUser.Add(user);
            }

            this.Close();
            return listUser;
        }

        public UserDTO GetUser(int id)
        {
            UserDTO user;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE USER_ID = "+id;

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

        public UserDTO GetUser(string userName)
        {
            UserDTO user;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE USERNAME = '" + userName+"'";

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

        public bool InsertUser(UserDTO user)
        {
            this.ConnectToDatabase();

            string Query = "insert into USERS(USERNAME,PASSWORD,NAME) values('" + user.UserName + "','" + user.Password + "','" + user.Name + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateUser(UserDTO user)
        {
            this.ConnectToDatabase();

            string Query = "update USER set USER_ID='" + user.UserId + "',USERNAME = '" + user.UserName
                            + "',PASSWORD ='" + user.Password + "',NAME = '" + user.Name ;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
