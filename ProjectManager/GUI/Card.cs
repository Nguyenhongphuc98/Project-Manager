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
        CardBLL cardBLL;
        CardDTO cardDTO;

        //====================================================

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static System.Drawing.Region GetRoundedRegion(int controlWidth, int controlHeight)
        {
            return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, controlWidth - 2, controlHeight - 2, 10, 10));
        }

        public Card(int X, int cardId, int index)
        {
            InitializeComponent();  
            _cardId = cardId;
            oX = X;
            oY = 3 + (index + 3) * this.Height;
            this.Region = GetRoundedRegion(this.Width, this.Height);
            cardBLL = new CardBLL();
            CardName.Text = cardBLL.GetCardName(cardId);
            cardDTO = cardBLL.GetCard(cardId);
            CardName.LostFocus += CardName_LostFocus;

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

            this.Location = new Point(oX, oY);
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
            cardDTO.Label = cardBLL.GetCard(_cardId).Label;
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
