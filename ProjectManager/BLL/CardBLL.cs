using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardBLL
    {
        public List<CardDTO> GetAllCard()
        {
            CardDAL adal = new CardDAL();
            return adal.GetAllCard();
        }
        public List<CardDTO> GetAllCard(int listId)
        {
            CardDAL adal = new CardDAL();
            return adal.GetAllCard(listId);
        }

        public CardDTO GetCard(int id)
        {
            CardDAL adal = new CardDAL();
            return adal.GetCard(id);
        }

        public String GetCardName(int id)
        {

            CardDAL cardDAL = new CardDAL();
            String title = cardDAL.GetCardName(id);
            return title;
        }

        public bool InsertCard(CardDTO card)
        {
            CardDAL adal = new CardDAL();
            return adal.InsertCard(card);
        }

        public bool UpdateCard(CardDTO card)
        {
            CardDAL adal = new CardDAL();
            return adal.UpdateCard(card);
        }

        public bool UpdateCardName(int _cardId)
        {
            return true;
        }

        public bool DeleteCard(CardDTO card)
        {
            CardDAL adal = new CardDAL();
            return adal.DeleteCard(card);
        }
    }
}
