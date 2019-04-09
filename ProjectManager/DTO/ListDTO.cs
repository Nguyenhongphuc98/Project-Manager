using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ListDTO
    {
        int listId;
        int boardId;
        int indexList;
        string title;
        int color;

        public ListDTO( int boardId, int indexList, string title, int color)
        {
            this.boardId = boardId;
            this.indexList = indexList;
            this.title = title;
            this.color = color;
        }

        public ListDTO(int listId, int boardId, int indexList, string title, int color)
        {
            this.listId = listId;
            this.boardId = boardId;
            this.indexList = indexList;
            this.title = title;
            this.color = color;
        }

        public int ListId { get => listId; set => listId = value; }
        public int BoardId { get => boardId; set => boardId = value; }
        public int IndexList { get => indexList; set => indexList = value; }
        public string Title { get => title; set => title = value; }
        public int Color { get => color; set => color = value; }

        public override string ToString()
        {
            return title+"\n";
        }
    }
}
