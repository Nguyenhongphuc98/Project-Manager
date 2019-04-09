using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupUserDTO
    {
        int groupId;
        int userId;

        public GroupUserDTO(int groupId, int userId)
        {
            this.userId = userId;
            this.groupId = groupId;
        }

        public int GroupId { get => groupId; set => groupId = value; }
        public int UserId { get => userId; set => userId = value; }

    }
}
