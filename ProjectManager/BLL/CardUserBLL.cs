using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CardUserBLL
    {
        public List<CardUserDTO> GetAllUser()
        {
            CardUserDAL udal = new CardUserDAL();
            return udal.GetAllUser();
        }

        public CardUserDTO GetUser(int id)
        {
            CardUserDAL udal = new CardUserDAL();
            return udal.GetUser(id);
        }

        public bool InsertUser(CardUserDTO user)
        {
            CardUserDAL udal = new CardUserDAL();
            return udal.InsertUser(user);
        }

        public bool UpdateCard(CardUserDTO user)
        {
            CardUserDAL udal = new CardUserDAL();
            return udal.UpdateUser(user);
        }
    }
}
