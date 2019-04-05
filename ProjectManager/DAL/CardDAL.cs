using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardDAL : DatabaseAccess
    {
        public List<CardDTO> GetAllActivity()
        {
            List<CardDTO> listCard = new List<CardDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD ";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int listId = reader.GetInt32(1);
                int indexCard = reader.GetInt32(2);
                string title = reader.GetString(3);
                string description = reader.GetString(4);
                int label = reader.GetInt32(5);
                DateTime dueDate = reader.GetDateTime(6);
                float status = reader.GetInt64(7);

                CardDTO card = new CardDTO(cardId, listId, indexCard, title, description, label, dueDate, status);
                listCard.Add(card);
            }

            this.Close();
            return listCard;
        }

        public CardDTO GetActivity(int id)
        {
            CardDTO card;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD WHERE CARD _ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int listId = reader.GetInt32(1);
                int indexCard = reader.GetInt32(2);
                string title = reader.GetString(3);
                string description = reader.GetString(4);
                int label = reader.GetInt32(5);
                DateTime dueDate = reader.GetDateTime(6);
                float status = reader.GetInt64(5);

                card = new CardDTO(cardId, listId, indexCard, title, description, label, dueDate, status);
                return card;
            }

            this.Close();
            return null;
        }

        public bool InsertCard(CardDTO card)
        {
            this.ConnectToDatabase();

            string Query = "insert into CARD values('" + card.CardId + "','" + card.ListId + "','" + card.IndexCard + "','" + card.Title + "','" + card.Description + "','" + card.Label + "', '" + card.DueDate + "','" + card.Status + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateCard(CardDTO card)
        {
            this.ConnectToDatabase();

            string Query = "update CARD set CARD_ID='" + card.CardId + "',LIST_ID = '" + card.ListId
                            + "',INDEX_CARD ='" + card.IndexCard + "',TITLE = '" + card.Title + "',DESCRIPTION = '" + card.Description
                            + "',LABEL = '" + card.Label + "',DUE_DATE'" + card.DueDate + "'STATUS'" + card.Status + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
    }
}
