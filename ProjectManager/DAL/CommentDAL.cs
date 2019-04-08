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
        public List<CommentDTO> GetAllActivity()
        {
            List<CommentDTO> listActivity = new List<CommentDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);
                string content = reader.GetString(2);
                DateTime time = reader.GetDateTime(3);
                int cmtIndex = reader.GetInt32(4);

                CommentDTO activity = new CommentDTO(cardId,userId,content,time,cmtIndex);
                listActivity.Add(activity);
            }

            this.Close();
            return listActivity;
        }

        public CommentDTO GetActivity(int id)
        {
            CommentDTO activity;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int userId = reader.GetInt32(1);
                string content = reader.GetString(2);
                DateTime time = reader.GetDateTime(3);
                int cmtIndex = reader.GetInt32(4);

                activity = new CommentDTO(cardId, userId, content, time, cmtIndex);
                return activity;
            }

            this.Close();
            return null;
        }

        public bool InsertActivity(CommentDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.CardId + "','" + activity.UserId + "','" + activity.Content + "','" + activity.Time + "','" + activity.CmtIndex +"');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateActivity(CommentDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set CARD_ID='" + activity.CardId + "',USER_ID = '" + activity.UserId
                            + "',CONTENT ='" + activity.Content + "',TIME = '" + activity.Time + "',INDEX_CMT = '" + activity.CmtIndex;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
