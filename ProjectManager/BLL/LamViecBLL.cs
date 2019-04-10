using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LamViecBLL
    {
        public bool UpdateUser(int userId, int cardId)
        {
            LamViecDAL lvdal = new LamViecDAL();
            return lvdal.UpdateUser(userId, cardId);
        }
        public bool InsertUser(int userId, int cardId)
        {
            LamViecDAL lvdal = new LamViecDAL();
            return lvdal.InsertUser(userId, cardId);
        }
    }
}
