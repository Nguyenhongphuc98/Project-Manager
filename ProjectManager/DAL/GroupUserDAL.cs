using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupUserDAL:DatabaseAccess
    {
        public List<GroupUserDTO> GetAllGroupUser()
        {
            List<GroupUserDTO> listGroupUser = new List<GroupUserDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);

                GroupUserDTO activity = new GroupUserDTO(groupId,userId);
                listGroupUser.Add(activity);
            }

            this.Close();
            return listGroupUser;
        }

        public GroupUserDTO GetGroupUser(int id)
        {
            GroupUserDTO groupUser;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);

                groupUser = new GroupUserDTO(groupId,userId);
                return groupUser;
            }

            this.Close();
            return null;
        }

        public bool InsertGroupUser(GroupUserDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.GroupId + "','" + activity.UserId + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateGroupUser(GroupUserDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set GROUP_ID='" + activity.GroupId + "',USER_ID = '" + activity.UserId;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
