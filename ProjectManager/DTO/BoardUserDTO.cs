using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BoardUserDTO
    {
        int boardId;
        int userId;

        public BoardUserDTO(int boardId, int userId)
        {
            this.boardId = boardId;
            this.userId = userId;
        }

        public BoardUserDTO(int listId, int boardId, int userId)
        {
            this.userId = userId;
            this.boardId = boardId;
        }

        public int BoardId { get => boardId; set => boardId = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
