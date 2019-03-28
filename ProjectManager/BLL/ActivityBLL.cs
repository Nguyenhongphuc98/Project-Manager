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

        public bool UpdateActivity(ActivityDTO activity)
        {
            ActivityDAL adal = new ActivityDAL();
            return adal.UpdateActivity(activity);
        }
    }
}
