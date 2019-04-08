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
    public partial class BoardNoInfor : UserControl
    {
        int margin = 15;

        public BoardNoInfor()
        {
            InitializeComponent();
        }

        public BoardNoInfor(int index)
        {
            InitializeComponent();

            this.Top = 50 + (this.Height + margin) * (index / 4);
            this.Left = 50 + (this.Width + margin) * (index % 4);
        }


        //==================================================

        private void lbCreateBoard_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(253, 83, 8);
        }

        private void lbCreateBoard_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(251, 153, 2);
        }

        //==================================================
        private void lbCreateBoard_Click(object sender, EventArgs e)
        {
            BoardCreate boardCreate = new BoardCreate();
            this.Parent.BackColor = Color.Gray;
            boardCreate.ShowDialog();
            this.Parent.BackColor = Color.White;
        }
    }
}
