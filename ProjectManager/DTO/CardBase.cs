using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardBase
    {
        public int cardID;
        public int index;
        public string cardName;
        public DateTime dueDate;
        public int checkList;
        public int checkedList;
        public String[] listNameUser;
        public String des;
        public int label;

        public CardBase(int cardID, int index, string cardName, DateTime dueDate, int checkList, int checkedList, string[] listNameUser, string des, int label)
        {
            this.cardID = cardID;
            this.index = index;
            this.cardName = cardName;
            this.dueDate = dueDate;
            this.checkList = checkList;
            this.checkedList = checkedList;
            this.listNameUser = listNameUser;
            this.des = des;
            this.label = label;
        }
    }
}
