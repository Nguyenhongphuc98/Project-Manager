using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardInfoBLL
    {
        CardDTO card;
        String cardName;
        List<int> listUserId = new List<int>();
        List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();
        List<ChecklistDTO> listCheckedlist = new List<ChecklistDTO>();
        CardUserDTO user;

        public CardInfoDTO CardInfo(int id)
        {
            CardInfoDAL adal = new CardInfoDAL();
            return adal.CardInfo(id);
        }

        //public bool ConnectDatabase()
        //{
        //    CardInfoDAL adal = new CardInfoDAL();
        //    return adal.ConnectToDatabase();
        //}
        //public void CloseDatabase()
        //{
        //    CardInfoDAL adal = new CardInfoDAL();
        //    adal.Close();
        //}

        //public CardDTO GetCard(int id)
        //{
        //    CardInfoDAL adal = new CardInfoDAL();
        //    return adal.GetCard(id);
        //}

        //public String GetCardName(int id)
        //{

        //    CardInfoDAL cardDAL = new CardInfoDAL();
        //    return cardDAL.GetCardName(id);
        //}
        //public List<int> ListUserId(int cardId)
        //{
        //    CardInfoDAL lvdal = new CardInfoDAL();
        //    return lvdal.ListUserId(cardId);
        //}
        //public List<ChecklistDTO> GetAllChecklist(int cardId)
        //{
        //    CardInfoDAL cldal = new CardInfoDAL();
        //    return cldal.GetAllChecklist(cardId);
        //}
        //public List<ChecklistDTO> GetAllCheckedlist(int cardId)
        //{
        //    CardInfoDAL cldal = new CardInfoDAL();
        //    return cldal.GetAllCheckedlist(cardId);
        //}
        //public CardUserDTO GetUser(int id)
        //{
        //    CardInfoDAL userDAL = new CardInfoDAL();
        //    return userDAL.GetUser(id);
        //}

    }
}
