using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BoardBLL
    {
        public List<Board> GetAllBoard()
        {
            BoardDAL board = new BoardDAL(); 
            return board.GetAllBoard();
        }

        public List<Board> GetAllBoard(int idUser)
        {
            BoardDAL board = new BoardDAL();
            return board.GetAllBoard(idUser);
        }

        public Board GetBoard(int id)
        {
            BoardDAL board = new BoardDAL();
            return board.GetBoard(id);
        }



        public bool InsertBoard( int groupId, int index, string title,
                int mode, bool star, String background)
        {
            BoardDAL board = new BoardDAL();
            int _star = star ? 1 : 0;
            return board.InsertBoard(groupId,index,title,mode,_star,background);
        }

        public bool InsertBoard(int index, string title,
                int mode, bool star, String background)
        {
            BoardDAL board = new BoardDAL();
            int _star = star ? 1 : 0;
            return board.InsertBoard( index, title, mode, _star, background);
        }

        public bool UpdateBoard(int boardId, int groupId, int index, string title,
                int mode, bool star, String background)
        {
            BoardDAL board = new BoardDAL();
            return board.UpdateBoard(boardId, groupId, index, title, mode, star, background);
        }

        public bool DeleteBoard(int id)
        {
            BoardDAL board = new BoardDAL();
            return board.DeleteBoard(id);
        }
    }
}
