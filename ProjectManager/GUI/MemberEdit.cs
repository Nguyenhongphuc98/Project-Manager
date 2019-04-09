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
        List<CardUserDTO> cardUsers;
        CardBLL cardBLL;
        CardDTO cardDTO;
        public MemberEdit(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            cardUsers = cardUserBLL.GetAllUser();
            foreach (CardUserDTO cardUser in cardUsers)
            {
                CheckBox member = new CheckBox();
                member.Text = cardUser.Name;
                this.flpMember.Controls.Add(member);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            cardBLL = new CardBLL();
            cardDTO = cardBLL.GetCard(_cardId);
        }
    }
}
