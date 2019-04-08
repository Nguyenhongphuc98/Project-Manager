using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GroupDAL:DatabaseAccess
    {
        public List<GroupDTO> GetAllActivity()
        {
            List<GroupDTO> listActivity = new List<GroupDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                string name = reader.GetString(1);
                string desription = reader.GetString(2);

                GroupDTO activity = new GroupDTO(groupId,name,desription);
                listActivity.Add(activity);
            }

            this.Close();
            return listActivity;
        }

        public GroupDTO GetActivity(int id)
        {
            GroupDTO activity;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                string name = reader.GetString(1);
                string desription = reader.GetString(2);

                activity = new GroupDTO(groupId, name, desription);
                return activity;
            }

            this.Close();
            return null;
        }

        public bool InsertActivity(GroupDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.GroupId + "','" + activity.Name + "','" + activity.Description + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateActivity(GroupDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set GROUP_ID='" + activity.GroupId + "',NAME = '" + activity.Name
                            + "',DESCRIPTION ='" + activity.Description ;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
