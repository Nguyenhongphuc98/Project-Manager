using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ActivityDTO
    {
        int activityId;
        int boardId;
        int cardId;
        int listId;
        int userId;
        string content;
        DateTime timeCreate;

        public ActivityDTO(int activityId, int boardId, int cardId, int listId, int userId, string content, DateTime timeCreate)
        {
            this.activityId = activityId;
            this.boardId = boardId;
            this.cardId = cardId;
            this.listId = listId;
            this.userId = userId;
            this.content = content;
            this.timeCreate = timeCreate;
        }

        public int ActivityId { get => activityId; set => activityId = value; }
        public int BoardId { get => boardId; set => boardId = value; }
        public int CardId { get => cardId; set => cardId = value; }
        public int ListId { get => listId; set => listId = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Content { get => content; set => content = value; }
        public DateTime TimeCreate { get => timeCreate; set => timeCreate = value; }

        public override string ToString()
        {
            return content+"\n";
        }
    }
}
