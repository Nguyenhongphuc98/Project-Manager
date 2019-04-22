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
        int _boardId;
        CardDTO cardDTO;
        CardBLL cardBLL;
        ListBLL listBLL;

        public ListComponent(string name, int id ,CardDTO card)
        {
            InitializeComponent();

            cardBLL = new CardBLL();
            listBLL = new ListBLL();

            this.nameTxt.Text = name;
            _id = id;
            cardDTO = card;
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
            ActivityBLL activityBLL = new ActivityBLL();
            cardDTO.ListId = _id;
            cardBLL.UpdateCard(cardDTO);
            activityBLL.InsertActivity(Global.user.UserId, listBLL.GetList(cardDTO.ListId).BoardId, Global.user.Name + " Has move card to list: " + listBLL.GetList(cardDTO.ListId).Title, DateTime.Now);
        }
    }
}
