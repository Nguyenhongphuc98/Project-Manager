using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChecklistDTO
    {
        int checklistId;
        int cardId;
        int checklistIndex;
        string title;
        byte status;

        public ChecklistDTO(int checklistId, int cardId, int checklistIndex, string title, byte status)
        {
            this.checklistId = checklistId;
            this.cardId = cardId;
            this.checklistIndex = checklistIndex;
            this.title = title;
            this.status = status;
        }

        public int ChecklistId { get => checklistId; set => checklistId = value; }
        public int CardId { get => cardId; set => cardId = value; }
        public int ChecklistIndex { get => checklistIndex; set => checklistIndex = value; }
        public string Title { get => title; set => title = value; }
        public byte Status { get => status; set => status = value; }
    }
}
