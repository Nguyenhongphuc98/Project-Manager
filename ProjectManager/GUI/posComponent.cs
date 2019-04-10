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

namespace GUI
{
    public partial class posComponent : UserControl
    {
        int _cardId;
        CardDTO cardDTO, cardComponent;
        CardBLL cardBLL = new CardBLL();
        public posComponent(int cardId, int curCardId)
        {
            InitializeComponent();
            _cardId = curCardId;
            cardComponent = cardBLL.GetCard(cardId);
            this.pos.Text = cardComponent.IndexCard.ToString();
        }

        private void posComponent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void posComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void posComponent_MouseClick(object sender, MouseEventArgs e)
        {
            cardDTO = cardBLL.GetCard(_cardId);
            cardDTO.IndexCard = cardComponent.IndexCard;
            cardBLL.UpdateCard(cardDTO);
        }
    }
}
