 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class GroupMemberDTO
    {
        int groupId;
        int userId;

        public GroupMemberDTO(int groupId, int userId)
        {
            this.userId = userId;
            this.groupId = groupId;
        }

        public int UserId { get => userId; set => userId = value; }
        public int GroupId { get => groupId; set => groupId = value; }

    }
}
