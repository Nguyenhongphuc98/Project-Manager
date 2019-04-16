using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardInfoDTO
    {
        CardDTO card;
        String cardName;
        List<int> listUserId = new List<int>();
        List<ChecklistDTO> listChecklist = new List<ChecklistDTO>();
        List<ChecklistDTO> listCheckedlist = new List<ChecklistDTO>();
        CardUserDTO user;

        public CardInfoDTO(CardDTO card, String cardName, List<int> listUserId, List<ChecklistDTO> listChecklist,
                           List<ChecklistDTO> listCheckedlist, CardUserDTO user)
        {
            this.card = card;
            this.cardName = cardName;
            this.listUserId = listUserId;
            this.listChecklist = listChecklist;
            this.listCheckedlist = listCheckedlist;
            this.user = user;
        }

        public CardDTO Card { get => card; set => card = value; }
        public String CardName { get => cardName; set => cardName = value; }
        public List<int> ListUserId { get => listUserId; set => listUserId = value; }
        public List<ChecklistDTO> ListChecklist { get => listChecklist; set => listChecklist = value; }
        public List<ChecklistDTO> ListCheckedlist { get => listCheckedlist; set => listCheckedlist = value; }
        public CardUserDTO User { get => user; set => user = value; }
    }
}
