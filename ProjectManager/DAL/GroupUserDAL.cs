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
        public List<GroupUserDTO> GetAllActivity()
        {
            List<GroupUserDTO> listActivity = new List<GroupUserDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);

                GroupUserDTO activity = new GroupUserDTO(groupId,userId);
                listActivity.Add(activity);
            }

            this.Close();
            return listActivity;
        }

        public GroupUserDTO GetActivity(int id)
        {
            GroupUserDTO activity;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);

                activity = new GroupUserDTO(groupId,userId);
                return activity;
            }

            this.Close();
            return null;
        }

        public bool InsertActivity(GroupUserDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.GroupId + "','" + activity.UserId + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateActivity(GroupUserDTO activity)
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
