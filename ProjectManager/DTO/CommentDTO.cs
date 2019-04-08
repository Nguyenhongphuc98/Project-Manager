using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CommentDTO
    {
        int cardId;
        int userId;
        string content;
        DateTime time;
        int cmtIndex;

        public CommentDTO(int cardId, int userId, string content, DateTime time, int cmtIndex)
        {
            this.cardId = cardId;
            this.userId = userId;
            this.content = content;
            this.time = time;
            this.cmtIndex = cmtIndex;
        }

        public int UserId { get => userId; set => userId = value; }
        public int CardId { get => cardId; set => cardId = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Time { get => time; set => time = value; }
        public int CmtIndex { get => cmtIndex; set => cmtIndex = value; }

    }
}
