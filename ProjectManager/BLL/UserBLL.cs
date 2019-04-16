using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        public List<UserDTO> GetAllUsers()
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetAllUsers();
        }

        public UserDTO GetUser(int id)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetUser(id);
        }

        public UserDTO GetUser(string userName)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetUser(userName);
        }

        public bool InsertUser(UserDTO user)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.InsertUser(user);
        }

        public bool UpdateUser(UserDTO user)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.UpdateUser(user);
        }

        //phuc nguyen___________________________________
        public List<String> GetListNameUserWorkingFor(int cardId)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.GetListNameUserWorkingFor(cardId);
        }
    }
}
