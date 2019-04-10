using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BoardUserBLL
    {
        public List<int> GetAllUserId(int id_board)
        {
            BoardUserDAL boardUserDAL = new BoardUserDAL();
            return boardUserDAL.GetAllUsersId(id_board);
        }
    }
}
