using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardInfoDAL:DatabaseAccess
    {
        CardDTO card;
        CardUserDTO user;
        
        List<string> listNameUser = new List<string>();
        List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();
        List<ChecklistDTO> listCheckedlist = new List<ChecklistDTO>();
        List<CommentDTO> listComment = new List<CommentDTO>();


        public CardInfoDTO CardInfo(int id)
        {
            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD WHERE CARD_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int listId = reader.GetInt32(1);
                int indexCard = reader.GetInt32(2);
                string title = reader.GetString(3);
                string description = reader.GetString(4);
                int label = reader.GetInt32(5);
                DateTime dueDate = (reader.IsDBNull(6)) ? DateTime.MinValue : (reader.GetDateTime(6));
                float status = reader.GetInt64(7);

                card = new CardDTO(cardId, listId, indexCard, title, description, label, dueDate, status);
            }

            reader.Close();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + id + "' AND STATUS = '" + 1 + "'";

            MySqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                int checklistId = reader1.GetInt32(0);
                int cardId = reader1.GetInt32(1);
                int checklistIndex = reader1.GetInt32(2);
                string title = reader1.GetString(3);
                byte status = reader1.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listCheckedlist.Add(checklist);
            }

            reader1.Close();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + id + "'";

            MySqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                int checklistId = reader2.GetInt32(0);
                int cardId = reader2.GetInt32(1);
                int checklistIndex = reader2.GetInt32(2);
                string title = reader2.GetString(3);
                byte status = reader2.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listChecklist.Add(checklist);
            }

            reader2.Close();
            command.CommandText = "SELECT * FROM USERS WHERE USER_ID = " + id;

            MySqlDataReader reader3 = command.ExecuteReader();
            while (reader3.Read())
            {
                int userId = reader3.GetInt32(0);
                string username = reader3.GetString(1);
                string password = reader3.GetString(2);
                string name = reader3.GetString(3);

                user = new CardUserDTO(userId, username, password, name);
            }

            reader3.Close();
            command.CommandText = "SELECT u.NAME "
                                  + " FROM USERS u, LAMVIEC l "
                                  + " WHERE u.USER_ID = l.USER_ID and CARD_ID = " + id;

            MySqlDataReader reader4 = command.ExecuteReader();
            while (reader4.Read())
            {
                string name = reader4.GetString(0).Substring(0,1);
                listNameUser.Add(name);
            }

            reader4.Close();

            command.CommandText = "SELECT * FROM COMMENT WHERE CARD_ID = '" + id + "'";

            MySqlDataReader reader5 = command.ExecuteReader();
            while (reader5.Read())
            {
                int userId = reader5.GetInt32(1);
                string content = reader5.GetString(2);
                DateTime time = reader5.GetDateTime(3);
                int cmtIndex = reader5.GetInt32(4);

                CommentDTO comment = new CommentDTO(id, userId, content, time, cmtIndex);
                listComment.Add(comment);
            }

            reader5.Close();
            this.Close();

            CardInfoDTO cardInfoDTO = new CardInfoDTO(this.card, this.listNameUser, this.listChecklist, this.listCheckedlist, this.user, this.listComment);
            return cardInfoDTO;
        }

        
    }
}
