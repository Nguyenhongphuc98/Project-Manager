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

            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + id + "' AND STATUS = '" + 1 + "'";
            
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listCheckedlist.Add(checklist);
            }

            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + id + "'";
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listChecklist.Add(checklist);
            }

            command.CommandText = "SELECT * FROM USERS WHERE USER_ID = " + id;
            
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                user = new CardUserDTO(userId, username, password, name);
            }
            
            command.CommandText = "SELECT u.NAME "
                                  + " FROM USERS u, LAMVIEC l "
                                  + " WHERE u.USER_ID = l.USER_ID and CARD_ID = " + id;
            
            while (reader.Read())
            {
                string name = reader.GetString(0);
                listNameUser.Add(name);
            }

            this.Close();

            CardInfoDTO cardInfoDTO = new CardInfoDTO(this.card, this.listNameUser, this.listChecklist, this.listCheckedlist, this.user);
            return cardInfoDTO;
        }


        /*
        public CardDTO GetCard(int id)
        {
            CardDTO card;

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

                card = new CardDTO(cardId, listId, indexCard, title, description, label, dueDate ,status);
                return card;
            }

            this.Close();
            return null;
        }

        public String GetCardName(int id)
        {
            CardDTO card;

            //this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD WHERE CARD_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader.GetString(3);
                return title;
            }

            //this.Close();
            return null;
        }
        public List<int> ListUserId(int cardId)
        {
            List<int> listUserId = new List<int>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM LAMVIEC WHERE CARD_ID = " + cardId;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(1);

                listUserId.Add(userId);
            }

            this.Close();
            return listUserId;
        }
        public List<ChecklistDTO> GetAllCheckedlist(int _cardId)
        {
            List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();

            //this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + _cardId + "' AND STATUS = '" + 1 + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listChecklist.Add(checklist);
            }

            //this.Close();
            return listChecklist;
        }
        public List<ChecklistDTO> GetAllChecklist(int _cardId)
        {
            List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();

            //this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + _cardId + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                ChecklistDTO checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                listChecklist.Add(checklist);
            }

            //this.Close();
            return listChecklist;
        }
        public CardUserDTO GetUser(int id)
        {
            CardUserDTO user;

            //this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE USER_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string name = reader.GetString(3);

                user = new CardUserDTO(userId, username, password, name);
                return user;
            }

            //this.Close();
            return null;
        }
        */
    }
}
