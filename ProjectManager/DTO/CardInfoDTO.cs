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
        List<string> listNameUser = new List<string>();
        int countChecklist;
        int countCheckedlist;
        int countCmt;
        CardUserDTO user;

        public CardInfoDTO(CardDTO card, List<String> listNameUser, int countChecklist,
                           int countCheckedlist, CardUserDTO user, int countCmt)
        {
            this.card = card;
            this.listNameUser = listNameUser;
            this.countChecklist = countChecklist;
            this.countCheckedlist = countCheckedlist;
            this.user = user;
            this.countCmt = countCmt;
        }

        public CardDTO Card { get => card; set => card = value; }
        public List<string> ListNameUser { get => listNameUser; set => listNameUser = value; }
        public int CountChecklist { get => countChecklist; set => countChecklist = value; }
        public int CountCheckedlist { get => countCheckedlist; set => countCheckedlist = value; }
        public CardUserDTO User { get => user; set => user = value; }
        public int CountCmt { get => countCmt; set => countCmt = value; }
    }
}
