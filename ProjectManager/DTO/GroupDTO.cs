using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupDTO
    {
        int groupId;
        string name;
        string description;

        public GroupDTO(int groupId, string name, string description)
        {
            this.groupId = groupId;
            this.name = name;
            this.description = description;
        }

        public int GroupId { get => groupId; set => groupId = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

    }
}
