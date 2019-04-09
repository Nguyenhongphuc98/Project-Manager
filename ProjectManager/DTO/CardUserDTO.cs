using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardUserDTO
    {
        int userId;
        string userName;
        string password;
        string name;

        public CardUserDTO(int userId, string userName, string password, string name)
        {
            this.userId = userId;
            this.userName = userName;
            this.password = password;
            this.name = name;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }

    }
}
