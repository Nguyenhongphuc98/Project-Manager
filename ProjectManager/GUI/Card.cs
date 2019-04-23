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
        ListSpace _listSpace;

        CardDTO cardDTO;
        CardInfoDTO cardInfoDTO;

        CardInfoBLL cardInfoBLL;
        CommentBLL commentBLL;

        
        List<int> listUserId = new List<int>();
        List<string> listNameUser = new List<string>();

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

        public Card(int X, int cardId, int index, ListSpace listSpace)
        {
            InitializeComponent();  
            _cardId = cardId;
            oX = X;
            oY = 3 + (index + 3) * this.Height;
            _listSpace = listSpace;
            //this.Region = GetRoundedRegion(this.Width, this.Height);
            
            cardInfoBLL = new CardInfoBLL();
            commentBLL = new CommentBLL();
            cardInfoDTO = cardInfoBLL.CardInfo(_cardId);

            listNameUser = cardInfoDTO.ListNameUser;
            CardName.Text = cardInfoDTO.Card.Title;
            cardDTO = cardInfoDTO.Card;
            dateCard.Text = cardDTO.DueDate.ToShortDateString();

            if (commentBLL.GetAllComments(_cardId).Count() != 0)
            {
                panel2.Visible = true;
                label3.Text = commentBLL.GetAllComments(_cardId).Count().ToString();
            }
            else panel2.Visible = false;
            checkBox1.Text = cardInfoDTO.ListCheckedlist.Count() + "/" + cardInfoDTO.ListChecklist.Count();
            if (cardDTO.Description == null || cardDTO.Description == "")
            {
                this.desPicture.Visible = false;
            }
            else this.desPicture.Visible = true;

            foreach (string name in listNameUser)
            {
                MemIcon member = new MemIcon(name, 25, 25);
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
            if (cardInfoDTO.ListChecklist.Count() != 0)
            {
                checkBox1.Visible = true;
            }
            else checkBox1.Visible = false;
        }

        //============================================================
       
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CardName.BackColor = System.Drawing.Color.DarkGray;
            cardDTO.Label = cardInfoDTO.Card.Label;
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
            CardDetail cardDetail = new CardDetail(_cardId, _listSpace);
            cardDetail.Show();
        }
    }
}
