using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListBLL
    {
        public List<ListDTO> GetAllList(int id_board)
        {
            ListDAL listDAL = new ListDAL();
            return listDAL.GetAllList(id_board);
        }

        public ListDTO GetList(int id)
        {
            ListDAL listDAL = new ListDAL();
            return listDAL.GetList(id);
        }

        public bool InsertList(ListDTO list)
        {
            ListDAL listDAL = new ListDAL();
            return listDAL.InsertList(list);
        }

        public bool UpdateList(ListDTO list)
        {
            ListDAL listDAL = new ListDAL();
            return listDAL.UpdateList(list);
        }
    }
}
