using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LamViecDTO
    {
        int cardId;
        int userId;

        public LamViecDTO(int cardId, int userId)
        {
            this.cardId = cardId;
            this.userId = userId;
        }

        public int CardId { get => cardId; set => cardId = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
