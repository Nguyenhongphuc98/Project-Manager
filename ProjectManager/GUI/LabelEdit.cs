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
    public partial class LabelEdit : Form
    {
        CardDTO cardDTO;
        CardBLL cardBLL = new CardBLL();
        public LabelEdit(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            cardDTO = cardBLL.GetCard(cardId);
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 1;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 4;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 2;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 5;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 3;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            cardDTO.Label = 6;
            cardBLL.UpdateCard(cardDTO);
            this.Close();
        }
    }
}
