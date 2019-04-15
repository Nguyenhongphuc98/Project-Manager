using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActivityBLL
    {
        public List<ActivityDTO> GetAllActivity()
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.GetAllActivity();
        }

        public List<ActivityDTO> GetAllActivity(int board_Id)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.GetAllActivity(board_Id);
        }
        public ActivityDTO GetActivity(int id)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.GetActivity(id);
        }

        public bool InsertActivity(ActivityDTO activity)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.InsertActivity(activity);
        }

        public bool InsertActivity(int idUser,int boardId ,string content, DateTime timeCreate)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.InsertActivity(idUser,boardId,content,timeCreate);
        }

        public bool UpdateActivity(ActivityDTO activity)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.UpdateActivity(activity);
        }
    }
}
