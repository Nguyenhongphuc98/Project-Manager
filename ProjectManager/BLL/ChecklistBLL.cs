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
        public List<ChecklistDTO> GetAllChecklist(int cardId)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.GetAllChecklist(cardId);
        }

        public ChecklistDTO GetChecklist(int id)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.GetChecklist(id);
        }
        public ChecklistDTO GetChecklist(string title)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.GetChecklist(title);
        }

        public bool InsertChecklist(int cardId, int checklistIndex, string title, byte status)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.InsertChecklist(cardId, checklistIndex, title, status);
        }
        public bool UpdateChecklist(ChecklistDTO checklist)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.UpdateChecklist(checklist);
        }
        public bool UpdateChecklist(int cardId, int checklistIndex, string title, byte status)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.UpdateChecklist(cardId, checklistIndex, title, status);
        }

        public bool DeleteChecklist(int id)
        {
            ChecklistDAL cldal = new ChecklistDAL();
            return cldal.DeleteChecklist(id);
        }
    }
}
