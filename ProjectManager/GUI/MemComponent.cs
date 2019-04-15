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
        int _userId;
        string _userName;
        LamViecBLL lamViec;
        List<int> listUserId;
        public MemComponent(int userId, string userName, int cardId)
        {
            InitializeComponent();
            this.BackColor = Color.Silver;
            this.memTxt.Text = userName;

            _cardId = cardId;
            _userId = userId;
            _userName = userName;
            lamViec = new LamViecBLL();
            listUserId = lamViec.ListUserId(_cardId);
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
            if (listUserId.Contains(_userId))
            {
                MessageBox.Show("This member already in this task", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lamViec.InsertUser(_userId, _cardId);
                listUserId = lamViec.ListUserId(_cardId);
            }
        }
    }
}
