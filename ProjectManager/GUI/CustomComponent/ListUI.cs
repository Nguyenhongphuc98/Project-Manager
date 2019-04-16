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
using System.Windows.Forms;

namespace GUI.CustomComponent
{
    public partial class ListUI : UserControl
    {
        int id;
        int position;
        string title;
        int color;
        int margin;

        int heightsmall=298;
        int heightbig=338;

        List<CardDTO> cardDTOs;
        List<Card> cards;

        //=======================================================
        public ListUI()
        {
            InitializeComponent();

            position= 0;
            margin = 5;

            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;
        }

        public ListUI(int index)
        {
            InitializeComponent();

            position = index;
            margin = 5;

            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;

            ZomOut();
            LoadBaseInfor();
        }

        public ListUI(int id,int index,string title,int color)
        {
            InitializeComponent();

            this.id = id;
            this.position = index;
            this.title = title;
            this.color = color;

            this.margin = 5;
            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;

            ZomOut();
            LoadBaseInfor();
            LoadCards();
        }

        //=======================================================
        void ZomOut()
        {
            this.btnNewCard.Visible = true;
            this.Height = heightsmall;

            this.btnClose.Visible = false;
            this.btnSave.Visible = false;
            this.tbTitleNewCard.Visible = false;
        }

        void Extend()
        {
            this.btnNewCard.Visible = false;
            this.Height = heightbig;

            this.btnClose.Visible = true;
            this.btnSave.Visible = true;
            this.tbTitleNewCard.Visible = true;
        }
         
        public void LoadBaseInfor()
        {
            this.lbListName.Text = this.title;
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            Extend();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ZomOut();
        }
        public void LoadCards()
        {
            //this.pnLists.Controls.Clear();
            //CardBLL cardBLL = new CardBLL();
            //cardDTOs = cardBLL.GetAllCard(this.id);
            //foreach (CardDTO card in cardDTOs)
            //{
            //    Card cards = new Card(0, card.CardId, card.IndexCard);
            //    this.pnLists.Controls.Add(cards);
            //}    

            this.pnLists.Controls.Clear();
            CardBLL cardBLL = new CardBLL();
            cardDTOs = cardBLL.GetAllCard(this.id);
           for(int i=0;i<cardDTOs.Count;i++)
            {
                CardDTO c = cardDTOs[i];
                Card cards = new Card(0,c,i);
                this.pnLists.Controls.Add(cards);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitleNewCard.Text))
            {
                MessageBox.Show("Please enter title before add card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                CardBLL cardBLL = new CardBLL();
                CardDTO cardDTO = new CardDTO(cardBLL.GetAllCard().Count()+1, this.id, cardDTOs.Count()+1, tbTitleNewCard.Text, "", 1, 0);
                cardBLL.InsertCard(cardDTO);
            }
            LoadCards();
        }
    }
}
