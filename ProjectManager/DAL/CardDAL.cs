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
        public List<CardDTO> GetAllCard()
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
                //DateTime dueDate = reader.GetDateTime(6);
                float status = reader.GetInt64(7);

                CardDTO card = new CardDTO(cardId, listId, indexCard, title, description, label, status);
                listCard.Add(card);
            }

            this.Close();
            return listCard;
        }
        public List<CardDTO> GetAllCard(int _listId)
        {
            List<CardDTO> listCard = new List<CardDTO>();

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD WHERE LIST_ID = " + _listId;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int cardId = reader.GetInt32(0);
                int listId = reader.GetInt32(1);
                int indexCard = reader.GetInt32(2);
                string title = reader.GetString(3);
                string description = reader.GetString(4);
                int label = reader.GetInt32(5);
                //DateTime dueDate = reader.GetDateTime(6);
                float status = reader.GetInt64(7);

                CardDTO card = new CardDTO(cardId, listId, indexCard, title, description, label, status);
                listCard.Add(card);
            }

            this.Close();
            return listCard;
        }

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
                //DateTime dueDate = reader.GetDateTime(6);
                float status = reader.GetInt64(7);

                card = new CardDTO(cardId, listId, indexCard, title, description, label, status);
                return card;
            }

            this.Close();
            return null;
        }

        public String GetCardName(int id)
        {
            CardDTO card;

            this.ConnectToDatabase();

            MySqlCommand command = this.mySQLConnection.CreateCommand();
            command.CommandText = "SELECT * FROM CARD WHERE CARD_ID = " + id;

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader.GetString(3);
                return title;
            }

            this.Close();
            return null;
        }

        

        public bool InsertCard(CardDTO card)
        {
            this.ConnectToDatabase();

            string Query = "insert into CARD(CARD_ID,LIST_ID,INDEX_CARD,TITLE,DESCRIPTION,LABEL,STATUS) values('" + card.CardId + "','" + card.ListId + "','" + card.IndexCard + "','" + card.Title + "','" + card.Description + "','" + card.Label + "','" + card.Status + "')";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }

        public bool UpdateCard(CardDTO card)
        {
            this.ConnectToDatabase();

            string Query = "update CARD set LIST_ID = '" + card.ListId
                            + "',INDEX_CARD ='" + card.IndexCard + "',TITLE = '" + card.Title + "',DESCRIPTION = '" + card.Description
                            + "',LABEL = '" + card.Label + "',STATUS='" + card.Status + "' WHERE CARD_ID ='" + card.CardId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();


            this.Close();
            return true;
        }
        public bool DeleteCard(CardDTO card)
        {
            this.ConnectToDatabase();

            string Query = "delete from CARD where CARD_ID = '" + card.CardId + "'";

            //This is command class which will handle the query and connection object.  
            MySqlCommand command = new MySqlCommand(Query, mySQLConnection);

            command.ExecuteNonQuery();

            this.Close();
            return true;
        }
    }
}
