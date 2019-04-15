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
    public partial class MoveForm : Form
    {
        int _cardId;
        CardBLL cardBLL = new CardBLL();
        CardDTO cardDTO;
        List<CardDTO> cardDTOs;
        ListBLL listBLL = new ListBLL();
        ListDTO listDTO;
        List<ListDTO> listDTOs;
        public MoveForm(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            _cardId = cardId;
            this.Height = 280;

            cardDTO = cardBLL.GetCard(_cardId);
            listDTO = listBLL.GetList(cardDTO.ListId);
            listDTOs = listBLL.GetAllList(listDTO.BoardId);
            cardDTOs = cardBLL.GetAllCard(cardDTO.ListId);
            listBtn.LabelText = listDTO.Title;
            positionBtn.LabelText = cardDTO.IndexCard.ToString();
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            this.Height = 425;
            cardDTO = cardBLL.GetCard(_cardId);
            listDTO = listBLL.GetList(cardDTO.ListId);
            listBtn.LabelText = listDTO.Title;
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            foreach (ListDTO list in listDTOs)
            {
                ListComponent listComponent = new ListComponent(list.Title, list.ListId,cardDTO);
                this.flowLayoutPanel1.Controls.Add(listComponent);
            }
        }

        private void positionBtn_Click(object sender, EventArgs e)
        {
            this.Height = 355;
            cardDTO = cardBLL.GetCard(_cardId);
            cardDTOs = cardBLL.GetAllCard(cardDTO.ListId);
            positionBtn.LabelText = cardDTO.IndexCard.ToString();
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            foreach (CardDTO card in cardDTOs)
            {
                posComponent posComponent = new posComponent(card.CardId, _cardId);
                this.flowLayoutPanel1.Controls.Add(posComponent);
            }
        }
    }
}
