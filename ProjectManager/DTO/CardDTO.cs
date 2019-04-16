 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardDTO
    {
        int cardId;
        int listId;
        int indexCard;
        string title;
        string description;
        int label;
        DateTime dueDate;
        float status;

        public CardDTO(int cardId, int listId, int indexCard, string title, string description, int label, DateTime duedate, float status)
        {
            this.cardId = cardId;
            this.listId = listId;
            this.indexCard = indexCard;
            this.title = title;
            this.description = description;
            this.label = label;
            this.dueDate = dueDate;
            this.status = status;
        }

        public int CardId { get => cardId; set => cardId = value; }
        public int ListId { get => listId; set => listId = value; }
        public int IndexCard { get => indexCard; set => indexCard = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int Label { get => label; set => label = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public float Status { get => status; set => status = value; }
    }
}
