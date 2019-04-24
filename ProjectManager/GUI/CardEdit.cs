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
    public partial class CardEdit : Form
    {
        int _cardId;

        ListSpace _listSpace;
        CardBLL cardBLL = new CardBLL();
        CardDTO cardDTO;
        CardInfoDTO cardInfoDTO;

        CardInfoBLL cardInfoBLL;
        CommentBLL commentBLL;

        List<string> listNameUser = new List<string>();
        public CardEdit(int X, int Y, int cardId, ListSpace listSpace)
        {
            InitializeComponent();
            _cardId = cardId;
            _listSpace = listSpace;
            cardDTO = cardBLL.GetCard(_cardId);
            cardInfoBLL = new CardInfoBLL();
            commentBLL = new CommentBLL();
            cardInfoDTO = cardInfoBLL.CardInfo(_cardId);
            listNameUser = cardInfoDTO.ListNameUser;
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.CenterScreen;

            switch (cardDTO.Label)
            {
                case 1:
                    this.CardLabel.BackColor = Color.Red;
                    break;
                case 2:
                    this.CardLabel.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.CardLabel.BackColor = Color.Green;
                    break;
                case 4:
                    this.CardLabel.BackColor = Color.Orange;
                    break;
                case 5:
                    this.CardLabel.BackColor = Color.Blue;
                    break;
                case 6:
                    this.CardLabel.BackColor = Color.Fuchsia;
                    break;
                default:
                    this.CardLabel.BackColor = Color.Transparent;
                    break;
            }
            this.cardName.Text = cardDTO.Title;
            this.dateTime.Text = cardDTO.DueDate.ToShortDateString();
            if (cardDTO.Description == null || cardDTO.Description == "")
            {
                this.desPic.Visible = false;
            }
            else this.desPic.Visible = true;
            if (commentBLL.GetAllComments(_cardId).Count() != 0)
            {
                panel2.Visible = true;
                cmtNum.Text = commentBLL.GetAllComments(_cardId).Count().ToString();
            }
            else panel2.Visible = false;
            if (cardInfoDTO.CountChecklist != 0)
            {
                this.checkList.Visible = true;
                this.checkList.Text = cardInfoDTO.CountCheckedlist + "/" + cardInfoDTO.CountChecklist;
            }
            else this.checkList.Visible = false;
            foreach (string name in listNameUser)
            {
                MemIcon member = new MemIcon(name, 25, 25);
                this.flowLayoutPanel2.Controls.Add(member);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cardName.Text))
            {
                cardDTO.Title = cardName.Text;
                cardBLL.UpdateCard(cardDTO);
            }
            this.Close();
        }

        private void ChangeLabel_Click(object sender, EventArgs e)
        {
            LabelEdit labelEdit = new LabelEdit(this.Location.X + this.Width - 140, this.Location.Y - 130, _cardId);
            labelEdit.Show();
        }

        private void ChangeMember_Click(object sender, EventArgs e)
        {
            MemberEdit editMember = new MemberEdit(this.Location.X + this.Width, this.Location.Y, _cardId, Global.id_Board);
            editMember.Show();
        }

        private void ChangeDeadline_Click(object sender, EventArgs e)
        {
            DateEdit editDate = new DateEdit(this.Location.X + this.Width, this.Location.Y, _cardId);
            editDate.Show();
        }

        private void CardEdit_Activated(object sender, EventArgs e)
        {
            cardInfoDTO = cardInfoBLL.CardInfo(_cardId);
            cardDTO = cardInfoDTO.Card;

            switch (cardDTO.Label)
            {
                case 1:
                    this.CardLabel.BackColor = Color.Red;
                    break;
                case 2:
                    this.CardLabel.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.CardLabel.BackColor = Color.Green;
                    break;
                case 4:
                    this.CardLabel.BackColor = Color.Orange;
                    break;
                case 5:
                    this.CardLabel.BackColor = Color.Blue;
                    break;
                case 6:
                    this.CardLabel.BackColor = Color.Fuchsia;
                    break;
                default:
                    this.CardLabel.BackColor = Color.Transparent;
                    break;
            }
            this.cardName.Text = cardDTO.Title;
            this.dateTime.Text = cardDTO.DueDate.ToShortDateString();
            if (cardDTO.Description == null || cardDTO.Description == "")
            {
                this.desPic.Visible = false;
            }
            else this.desPic.Visible = true;
            if (commentBLL.GetAllComments(_cardId).Count() != 0)
            {
                panel2.Visible = true;
                cmtNum.Text = commentBLL.GetAllComments(_cardId).Count().ToString();
            }
            else panel2.Visible = false;
            if (cardInfoDTO.CountChecklist != 0)
            {
                this.checkList.Visible = true;
                this.checkList.Text = cardInfoDTO.CountCheckedlist + "/" + cardInfoDTO.CountChecklist;
            }
            else this.checkList.Visible = false;
            this.flowLayoutPanel2.Controls.Clear();
            foreach (string name in listNameUser)
            {
                MemIcon member = new MemIcon(name);
                this.flowLayoutPanel2.Controls.Add(member);
            }
        }

        private void CardEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            _listSpace.LoadListOfThisBoard();
            GC.Collect();
        }
    }
}
