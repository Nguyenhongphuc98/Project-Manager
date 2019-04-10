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
    public partial class MemComponent : UserControl
    {
        int _cardId;
        CardUserDTO _user;
        LamViecBLL lamViec;
        public MemComponent(CardUserDTO userDTO, int cardId)
        {
            InitializeComponent();
            this.BackColor = Color.Silver;
            this.memTxt.Text = userDTO.Name;
            lamViec = new LamViecBLL();
            _user = userDTO;
            _cardId = cardId;
        }

        private void MemComponent_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void MemComponent_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void MemComponent_MouseClick(object sender, MouseEventArgs e)
        {
            lamViec.InsertUser(_user.UserId, _cardId);
        }
    }
}
