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
    public partial class ListComponent : UserControl
    {
        int _id;
        CardDTO cardDTO;
        CardBLL cardBLL;
        public ListComponent(string name, int id ,CardDTO card)
        {
            InitializeComponent();
            this.nameTxt.Text = name;
            _id = id;
            cardDTO = card;
            cardBLL = new CardBLL();
        }

        private void ListComponent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void ListComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ListComponent_MouseClick(object sender, MouseEventArgs e)
        {
            cardDTO.ListId = _id;
            cardBLL.UpdateCard(cardDTO);
        }
    }
}
