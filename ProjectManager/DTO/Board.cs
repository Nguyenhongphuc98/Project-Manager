using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Board
    {
        private int boardId;
        private int groupId;
        private int index;
        private string title;
        private int mode; //0-public 1-team 2-private
        private bool star;
        private String background;


        public int BoardId { get => boardId; set => boardId = value; }
        public int GroupId { get => groupId; set => groupId = value; }
        public int Index { get => index; set => index = value; }
        public string Title { get => title; set => title = value; }
        public int Mode { get => mode; set => mode = value; }
        public bool Star { get => star; set => star = value; }
        public string Background { get => background; set => background = value; }

        public Board(int boardId, int groupId, int index, string title, int mode, bool star, string background)
        {
            this.boardId = boardId;
            this.groupId = groupId;
            this.index = index;
            this.title = title;
            this.mode = mode;
            this.star = star;
            this.background = background;
        }
    }
}
