using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MemberEdit : Form
    {
        int _cardId;
        CardUserBLL cardUserBLL = new CardUserBLL();
        BoardUserBLL boardUserBLL = new BoardUserBLL();
        List<int> userIds = new List<int>();
        List<CardUserDTO> cardUsers = new List<CardUserDTO>();
        public MemberEdit(int X, int Y, int cardId, int boardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            userIds = boardUserBLL.GetAllUserId(boardId);
            _cardId = cardId;
            foreach (int userId in userIds)
            {
                cardUsers.Add(cardUserBLL.GetUser(userId));
            }
            foreach(CardUserDTO user in cardUsers)
            {
                MemComponent memComponent = new MemComponent(user.UserId, user.Name, _cardId);
                this.flpMember.Controls.Add(memComponent);
            }
        }

        private void MemberEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
