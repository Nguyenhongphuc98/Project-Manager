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
        public List<ListDTO> GetAllList(int id_board)
        {
            List<ListDTO> listList = new List<ListDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM LIST where BOARD_ID = "+ id_board;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int listId = reader.GetInt32(0);
                int boardId = reader.GetInt32(1);
                int indexList = reader.GetInt32(2);
                string title = reader.GetString(3);
                int color = reader.GetInt32(4);

                ListDTO list = new ListDTO(listId,boardId,indexList,title,color);
                listList.Add(list);
            }

            reader.Close();
            this.Close();
            return listList;
        }

        public ListDTO GetList(int id)
        {
            ListDTO listobj;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM LIST WHERE LIST_ID = "+id;

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

            reader.Close();
            this.Close();
            return null;
        }

        public bool InsertList(ListDTO list)
        {
            this.ConnectToDatabase();

            string Query = "insert into LIST(BOARD_ID,INDEX_LIST,TITLE,COLOR) values('" + list.BoardId + "','" + list.IndexList + "','" + list.Title + "','" + list.Color +"');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateList(ListDTO list)
        {
            this.ConnectToDatabase();

            string Query = "update LIST set " + "',BOARD_ID = '" + list.BoardId
                            + "',INDEX_LIST ='" + list.IndexList + "',TITLE = '" + list.Title + "',COLOR = '" + list.Color
                            + " where LIST_ID='" + list.ListId;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
