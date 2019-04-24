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
        public CardInfoDTO CardInfo(int id)
        {
            CardInfoDAL adal = new CardInfoDAL();
            return adal.CardInfo(id);
        }
        
    }
}
