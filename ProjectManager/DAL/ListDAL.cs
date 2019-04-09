using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListDAL:DatabaseAccess
    {
        public List<ListDTO> GetAllList()
        {
            List<ListDTO> listList = new List<ListDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int listId = reader.GetInt32(0);
                int boardId = reader.GetInt32(1);
                int indexList = reader.GetInt32(2);
                string title = reader.GetString(3);
                int color = reader.GetInt32(4);

                ListDTO activity = new ListDTO(listId,boardId,indexList,title,color);
                listList.Add(activity);
            }

            this.Close();
            return listList;
        }

        public ListDTO GetList(int id)
        {
            ListDTO listobj;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int listId = reader.GetInt32(0);
                int boardId = reader.GetInt32(1);
                int indexList = reader.GetInt32(2);
                string title = reader.GetString(3);
                int color = reader.GetInt32(4);

                listobj = new ListDTO(listId,boardId,indexList,title,color);
                return listobj;
            }

            this.Close();
            return null;
        }

        public bool InsertActivity(ListDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.ListId + "','" + activity.BoardId + "','" + activity.IndexList + "','" + activity.Title + "','" + activity.Color +"');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateActivity(ListDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set LIST_ID='" + activity.ListId + "',BOARD_ID = '" + activity.BoardId
                            + "',INDEX_LIST ='" + activity.IndexList + "',TITLE = '" + activity.Title + "',COLOR = '" + activity.Color;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
