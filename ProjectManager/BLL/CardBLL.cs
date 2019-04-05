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
            return adal.GetAllActivity();
        }

        public CardDTO GetCard(int id)
        {
            CardDAL adal = new CardDAL();
            return adal.GetActivity(id);
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
    }
}
