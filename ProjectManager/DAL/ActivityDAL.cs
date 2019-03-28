using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ActivityDAL:DatabaseAccess
    {
        public List<ActivityDTO> GetAllActivity()
        {
            List<ActivityDTO> listActivity = new List<ActivityDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int activityId = reader.GetInt32(0);
                int boardId = reader.GetInt32(1);
                int cardId = reader.GetInt32(2);
                int listId = reader.GetInt32(3);
                int userId = reader.GetInt32(4);
                string content = reader.GetString(5);
                DateTime timecreate = reader.GetDateTime(6);

                ActivityDTO activity = new ActivityDTO(activityId, boardId, cardId, listId, userId, content, timecreate);
                listActivity.Add(activity);
            }

            this.Close();
            return listActivity;
        }

        public ActivityDTO GetActivity(int id)
        {
            ActivityDTO activity;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM ACTIVITY WHERE ACTIVITY_ID = "+id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int activityId = reader.GetInt32(0);
                int boardId = reader.GetInt32(1);
                int cardId = reader.GetInt32(2);
                int listId = reader.GetInt32(3);
                int userId = reader.GetInt32(4);
                string content = reader.GetString(5);
                DateTime timecreate = reader.GetDateTime(6);

                activity = new ActivityDTO(activityId, boardId, cardId, listId, userId, content, timecreate);
                return activity;
            }

            this.Close();
            return null;
        }

        public bool InsertActivity(ActivityDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "insert into ACTIVITY values('" + activity.BoardId + "','" + activity.CardId + "','" + activity.ListId + "','" + activity.UserId + "','" + activity.Content + "','" + activity.TimeCreate +"');";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateActivity(ActivityDTO activity)
        {
            this.ConnectToDatabase();

            string Query = "update ACTIVITY set BOARD_ID='" + activity.BoardId + "',CARD_ID = '" + activity.CardId
                            + "',LIST_ID ='" + activity.ListId + "',USER_ID = '" + activity.UserId + "',CONTENT = '" + activity.Content
                            + "', 	TIME_CREATE = '" + activity.TimeCreate + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
