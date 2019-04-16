using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        int userId;
        string username;
        string password;
        string name;

        public UserDTO( string username, string password, string name)
        {     
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public UserDTO(int userId, string username, string password, string name)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.name = name;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }

    }
}
