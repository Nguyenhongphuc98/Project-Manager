using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class BoardDAL :DatabaseAccess
    {


        public List<Board> GetAllBoard()
        {
            List<Board> listBoard = new List<DTO.Board>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * from BOARD";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int boardId = reader.GetInt32(0);
                int groupId;
                try
                {
                    groupId = reader.GetInt32(1);
                }
                catch
                {
                    groupId = 0;
                }
                int index=reader.GetInt32(2);
                string title= reader.GetString(3);
                int mode=reader.GetInt32(4);
                bool star= reader.GetBoolean(5);
                String background= reader.GetString(6);

                Board b = new Board(boardId, groupId, index, title, mode, star, background);
                listBoard.Add(b);
            }

            this.Close();
            return listBoard;
        }

        public List<Board> GetAllBoard(int idUser)
        {
            List<Board> listBoard = new List<DTO.Board>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT BOARD.*"
                                  +" from BOARD, BOARD_USER "
                                  +" where BOARD.BOARD_ID = BOARD_USER.BOARD_ID "
                                  +" and BOARD_USER.USER_ID ="+idUser;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int boardId = reader.GetInt32(0);
                int groupId;
                try
                {
                    groupId = reader.GetInt32(1);
                }
                catch
                {
                    groupId = 0;
                }
                int index = reader.GetInt32(2);
                string title = reader.GetString(3);
                int mode = reader.GetInt32(4);
                bool star = reader.GetBoolean(5);
                String background = reader.GetString(6);

                Board b = new Board(boardId, groupId, index, title, mode, star, background);
                listBoard.Add(b);
            }

            this.Close();
            return listBoard;
        }

        public Board GetBoard(int id)
        {
            Board b;
            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * from BOARD where BOARD_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int boardId = reader.GetInt32(0);
                int groupId = reader.GetInt32(1);
                int index = reader.GetInt32(2);
                string title = reader.GetString(3);
                int mode = reader.GetInt32(4);
                bool star = reader.GetBoolean(5);
                String background = reader.GetString(6);

                b = new Board(boardId, groupId, index, title, mode, star, background);
                this.Close();
                return b;
            }

            this.Close();
            return null;
        }

        public bool InsertBoard(int groupId, int index, string title ,
                int mode, int star , String background )
        {
            this.ConnectToDatabase();

            string Query = "insert into BOARD(GROUP_ID,INDEX_BOARD,TITLE,MODE,STAR,BACKGROUND) values('" + groupId + "','" + index + "','" + title + "','" + mode+ "','" + star + "','" + background +"');";
            
            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);
            
            command.ExecuteNonQuery();
            
            
            this.Close();
            return true;
        }

        public bool InsertBoard(int index, string title,
                int mode, int star, String background)
        {
            this.ConnectToDatabase();

            string Query = "insert into BOARD(INDEX_BOARD,TITLE,MODE,STAR,BACKGROUND) values('"  + index + "','" + title + "','" + mode + "','" + star + "','" + background + "');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateBoard(int boardId, int groupId, int index, string title,
                int mode, bool star, String background)
        {
            this.ConnectToDatabase();

            string Query = "update BOARD set GROUP_ID='"+groupId + "',INDEX_BOARD = '" + index 
                            + "',TITLE ='" + title + "',MODE = '" + mode + "',STAR = '" + star 
                            + "',BACKGROUND = '" + background + "' where BOARD_ID ='"+boardId +"'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool DeleteBoard(int id)
        {
            this.ConnectToDatabase();

            string Query = "delete from BOARD where BOARD_ID='" + id + "';";

            MySqlCommand command = new MySqlCommand(Query, this.mySQLConnection);

            command.ExecuteReader();
           
            this.Close();
            return true;
        }
    }
}
