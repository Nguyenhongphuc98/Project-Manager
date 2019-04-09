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
            command.CommandText = "SELECT * FROM GROUPUSER ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int groupId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);

                GroupUserDTO groupuser = new GroupUserDTO(groupId,userId);
                listGroupUser.Add(groupuser);
            }

            this.Close();
            return listGroupUser;
        }

        public GroupUserDTO GetGroupUser(int id)
        {
            GroupUserDTO groupUser;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM GROUPUSER WHERE GROUPUSER_ID = "+id;

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

        public bool InsertGroupUser(GroupUserDTO groupuser)
        {
            this.ConnectToDatabase();

            string Query = "insert into GROUPUSER values('" + groupuser.GroupId + "','" + groupuser.UserId + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateGroupUser(GroupUserDTO groupuser)
        {
            this.ConnectToDatabase();

            string Query = "update GROUPUSER set GROUP_ID='" + groupuser.GroupId + "',USER_ID = '" + groupuser.UserId;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
