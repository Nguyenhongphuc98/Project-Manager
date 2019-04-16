using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChecklistDAL : DatabaseAccess
    {
        public List<ChecklistDTO> GetAllChecklist()
        {
            List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST ";

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

           // this.Close();
            return listChecklist;
        }
        public List<ChecklistDTO> GetAllChecklist(int _cardId)
        {
            List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
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

           // this.Close();
            return listChecklist;
        }
        public List<ChecklistDTO> GetAllCheckedlist(int _cardId)
        {
            List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CARD_ID = '" + _cardId + "' AND STATUS = '" + 1 +"'";

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

           // this.Close();
            return listChecklist;
        }

        public ChecklistDTO GetChecklist(int id)
        {
            ChecklistDTO checklist;

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE CHECKLIST_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                return checklist;
            }

           // this.Close();
            return null;
        }
        public ChecklistDTO GetChecklist(string _title)
        {
            ChecklistDTO checklist;

            // this.ConnectToDatabase();

            MySqlCommand command = mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CHECKLIST WHERE TITLE = '" + _title + "'";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int checklistId = reader.GetInt32(0);
                int cardId = reader.GetInt32(1);
                int checklistIndex = reader.GetInt32(2);
                string title = reader.GetString(3);
                byte status = reader.GetByte(4);
                checklist = new ChecklistDTO(checklistId, cardId, checklistIndex, title, status);
                return checklist;
            }

           // this.Close();
            return null;
        }

        public bool InsertChecklist(int cardId, int checklistIndex, string title, byte status)
        {
            // this.ConnectToDatabase();

            string Query = "insert into CHECKLIST(CARD_ID,INDEX_CHECKLIST,TITLE,STATUS) values('" + cardId + "','" + checklistIndex + "','" + title + "','" + status + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


           // this.Close();
            return true;
        }
        public bool UpdateChecklist(ChecklistDTO checklist)
        {
            // this.ConnectToDatabase();

            string Query = "update CHECKLIST set INDEX_CHECKLIST = '" + checklist.ChecklistIndex + "',TITLE = '" + checklist.Title + "',STATUS = '" + checklist.Status + "' WHERE CARD_ID =" + checklist.CardId;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


           // this.Close();
            return true;
        }
        public bool UpdateChecklist(int cardId, int checklistIndex, string title, byte status)
        {
            // this.ConnectToDatabase();

            string Query = "update CHECKLIST set INDEX_CHECKLIST = '" + checklistIndex + "',TITLE = '" + title + "',STATUS = '" + status + "' WHERE CARD_ID =" + cardId;

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


           // this.Close();
            return true;
        }

        public bool DeleteChecklist(int cardId)
        {
            // this.ConnectToDatabase();

            string Query = "delete from CHECKLIST where CARD_ID = '" + cardId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

           // this.Close();
            return true;
        }
    }
}
