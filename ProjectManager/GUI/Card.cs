using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class Card : UserControl
    {
        //====================================================
        int oX;
        int oY;
        int _cardId;

        CardDTO cardDTO;
        CardBLL cardBLL;
        LamViecBLL lamViecBLL;
        ChecklistBLL checklistBLL;
        CardUserBLL userBLL;

        List<CardUserDTO> userDTOs = new List<CardUserDTO>();
        List<int> listUserId = new List<int>();

        //====================================================

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect, // x-coordinate of upper-left corner
        //    int nTopRect, // y-coordinate of upper-left corner
        //    int nRightRect, // x-coordinate of lower-right corner
        //    int nBottomRect, // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);

        //public static System.Drawing.Region GetRoundedRegion(int controlWidth, int controlHeight)
        //{
        //    return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, controlWidth - 2, controlHeight - 2, 10, 10));
        //}

        public Card(int X, CardDTO card, int index)
        {
            InitializeComponent();
            _cardId = card.CardId;
            oX = X;
            oY = 3 + (index + 3) * this.Height;
            this.cardDTO = card;

            CardName.Text = card.Title;
            CardName.LostFocus += CardName_LostFocus;
            dateCard.Text = card.DueDate.ToShortDateString();

            checklistBLL = new ChecklistBLL();
            StatusCheckList status = checklistBLL.Getstatus(card.CardId);
            checkBox1.Text = status.finished + "/" + status.sum;

            if (card.Description == null || card.Description.Equals(""))
            {
                this.desPicture.Visible = false;
            }
                else this.desPicture.Visible = true;

            UserBLL userBLL = new UserBLL();
            List<String> listNameUser = userBLL.GetListNameUserWorkingFor(card.CardId);

            foreach (string name in listNameUser)
            {
                MemIcon member = new MemIcon(name, 25, 25);
                this.flowLayoutPanel3.Controls.Add(member);
            }



            switch (card.Label)
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

            if (status.sum != 0)
            {
                checkBox1.Visible = true;
            }
                else checkBox1.Visible = false;
        }

        public Card(int X,CardBase card)
        {
            InitializeComponent();
            _cardId = card.cardID;
            oX = X;
            oY = 3 + (card.index + 3) * this.Height;


            CardName.Text = card.cardName;
            CardName.LostFocus += CardName_LostFocus;
            dateCard.Text = card.dueDate.ToShortDateString();
            checkBox1.Text = card.checkedList + "/" + card.checkedList;

            if (card.des == null || card.des.Equals(""))
            {
                this.desPicture.Visible = false;
            }
            else
                this.desPicture.Visible = true;

           
            foreach (String nameUser in card.listNameUser)
            {
                MemIcon member = new MemIcon(nameUser, 25, 25);
                this.flowLayoutPanel3.Controls.Add(member);
            }
      

            switch (card.label)
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

            if (card.checkedList != 0)
            {
                checkBox1.Visible = true;
            }
            else checkBox1.Visible = false;
        }

        public Card(int X, int cardId, int index)
        {
            InitializeComponent();  
            _cardId = cardId;
            oX = X;
            oY = 3 + (index + 3) * this.Height;
            //this.Region = GetRoundedRegion(this.Width, this.Height);

            cardBLL = new CardBLL();
            lamViecBLL = new LamViecBLL();
            checklistBLL = new ChecklistBLL();
            userBLL = new CardUserBLL();

            listUserId = lamViecBLL.ListUserId(_cardId);

            CardName.Text = cardBLL.GetCardName(cardId);
            cardDTO = cardBLL.GetCard(cardId);
            CardName.LostFocus += CardName_LostFocus;
            dateCard.Text = cardDTO.DueDate.Day.ToString() + "/" + cardDTO.DueDate.Day.ToString() + "/" + cardDTO.DueDate.Day.ToString();
            checkBox1.Text = checklistBLL.GetAllCheckedlist(cardId).Count() + "/" + checklistBLL.GetAllChecklist(cardId).Count();

            if (cardDTO.Description == null || cardDTO.Description == "")
            {
                this.desPicture.Visible = false;
            }
            else this.desPicture.Visible = true;

            foreach (int userId in listUserId)
            {
                CardUserDTO userDTO = userBLL.GetUser(userId);
                userDTOs.Add(userDTO);
            }
            foreach (CardUserDTO userDTO in userDTOs)
            {
                MemIcon member = new MemIcon(userDTO.Name.Substring(0, 1), 25, 25);
                this.flowLayoutPanel3.Controls.Add(member);
            }

            if (cardDTO.Description.Equals(""))
            {
                this.desPicture.Visible = false;
            }
            else
            {
                this.desPicture.Visible = true;
            }

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

            if (checklistBLL.GetAllChecklist(cardId).Count() != 0)
            {
                checkBox1.Visible = true;
            }
            else checkBox1.Visible = false;
        }

        //============================================================
       
        private void CardName_LostFocus(object sender, EventArgs e)
        {
            cardDTO.Title = this.CardName.Text;
            cardBLL.UpdateCard(cardDTO);
        }
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CardName.BackColor = System.Drawing.Color.DarkGray;
           
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
            editButton.Visible = true;
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            this.CardName.BackColor = System.Drawing.Color.White;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CardEdit cardEdit = new CardEdit(this.oX, this.oY + this.Location.Y, this._cardId);
            cardEdit.Show();
        }

        private void editButton_MouseEnter(object sender, EventArgs e)
        {
            editButton.BackColor = Color.DarkGray;
        }

        private void editButton_MouseLeave(object sender, EventArgs e)
        {
            editButton.BackColor = Color.White;
        }

        private void Card_MouseClick(object sender, MouseEventArgs e)
        {
            CardDetail cardDetail = new CardDetail(_cardId);
            cardDetail.Show();
        }
    }
}
