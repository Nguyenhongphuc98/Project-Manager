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

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
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

            this.Close();
            return listChecklist;
        }

        public ChecklistDTO GetChecklist(int id)
        {
            ChecklistDTO checklist;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM USERS WHERE CHECKLIST_ID = " + id;

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

            this.Close();
            return null;
        }

        public bool InsertChecklist(ChecklistDTO checklist)
        {
            this.ConnectToDatabase();

            string Query = "insert into CHECKLIST values('" + checklist.ChecklistId + "','" + checklist.CardId + "','" + checklist.ChecklistIndex + "','" + checklist.Title + "','" + checklist.Status + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateChecklist(ChecklistDTO checklist)
        {
            this.ConnectToDatabase();

            string Query = "update CHECKLIST set CHECKLIST_ID='" + checklist.ChecklistId + "',CARD_ID = '" + checklist.CardId + "',INDEX_CHECKLIST = '" + checklist.ChecklistIndex + "',TITLE = '" + checklist.Title + "',STATUS = '" + checklist.Status + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
