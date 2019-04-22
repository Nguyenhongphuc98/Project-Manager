using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CommentBLL
    {
        public List<CommentDTO> GetAllComments()
        {
            CommentDAL cmtDAL = new CommentDAL();
            return cmtDAL.GetAllComments();
        }
        public List<CommentDTO> GetAllComments(int cardId)
        {
            CommentDAL cmtDAL = new CommentDAL();
            return cmtDAL.GetAllComments(cardId);
        }

        public CommentDTO GetComment(int id)
        {
            CommentDAL cmtDAL = new CommentDAL();
            return cmtDAL.GetComment(id);
        }

        public bool InsertComment(CommentDTO comment)
        {
            CommentDAL cmtDAL = new CommentDAL();
            return cmtDAL.InsertComment(comment);
        }

        public bool UpdateComment(CommentDTO comment)
        {
            CommentDAL cmtDAL = new CommentDAL();
            return cmtDAL.UpdateComment(comment);
        }
    }
}
