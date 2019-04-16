using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommentDAL:DatabaseAccess
    {
        public List<CommentDTO> GetAllComments()
        {
            List<CommentDTO> listComment = new List<CommentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COMMENT ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);
                string content = reader.GetString(2);
                DateTime time = reader.GetDateTime(3);
                int cmtIndex = reader.GetInt32(4);

                CommentDTO comment = new CommentDTO(cardId,userId,content,time,cmtIndex);
                listComment.Add(comment);
            }

            this.Close();
            return listComment;
        }
        public List<CommentDTO> GetAllComments(int cardId)
        {
            List<CommentDTO> listComment = new List<CommentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COMMENT WHERE CARD_ID = '" + cardId + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(1);
                string content = reader.GetString(2);
                DateTime time = reader.GetDateTime(3);
                int cmtIndex = reader.GetInt32(4);

                CommentDTO comment = new CommentDTO(cardId,userId,content,time,cmtIndex);
                listComment.Add(comment);
            }

            this.Close();
            return listComment;
        }

        public CommentDTO GetComment(int id)
        {
            CommentDTO comment;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM COMMENT WHERE COMMENT_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);
                string content = reader.GetString(2);
                DateTime time = reader.GetDateTime(3);
                int cmtIndex = reader.GetInt32(4);

                comment = new CommentDTO(cardId, userId, content, time, cmtIndex);
                return comment;
            }

            this.Close();
            return null;
        }

        public bool InsertComment(CommentDTO comment)
        {
            this.ConnectToDatabase();
            string Query = "insert into COMMENT values('" + comment.CardId + "','" + 
                comment.UserId + "','" + comment.Content + "','" + comment.Time.Date + "','" +
                comment.CmtIndex +"');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateComment(CommentDTO comment)
        {
            this.ConnectToDatabase();

            string Query = "update COMMENT set CARD_ID='" + comment.CardId + "',USER_ID = '" + comment.UserId
                            + "',CONTENT ='" + comment.Content + "',TIME = '" + comment.Time + "',INDEX_CMT = '" + comment.CmtIndex;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
