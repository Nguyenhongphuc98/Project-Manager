using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChecklistBLL
    {
        public List<ChecklistDTO> GetAllChecklist()
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.GetAllChecklist();
        }

        public ChecklistDTO GetUser(int id)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.GetChecklist(id);
        }

        public bool InsertChecklist(ChecklistDTO checklist)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.InsertChecklist(checklist);
        }

        public bool UpdateChecklist(ChecklistDTO checklist)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.UpdateChecklist(checklist);
        }
    }
}
