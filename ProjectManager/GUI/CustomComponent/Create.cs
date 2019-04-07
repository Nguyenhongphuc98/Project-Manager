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
    public partial class Create : UserControl
    {
        public Create()
        {
            InitializeComponent();
            this.Top = 40;
            this.Left = 500;
        }

        public Create(int width)
        {
            InitializeComponent();
            this.Top = 40;
            this.Left = width - this.Width-30;
        }

        private void pnCreateBoard_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 143, 202);
        }

        //====================================================================

        void MouseHoverCreateBoard()
        {
            this.lbCreateBoard.BackColor = Color.FromArgb(41, 143, 202);
            this.lbDesCreateBoard.BackColor = Color.FromArgb(41, 143, 202);

            this.lbCreateBoard.ForeColor = Color.FromArgb(255, 255, 255);
            this.lbDesCreateBoard.ForeColor = Color.FromArgb(255, 255, 255);
        }

        void MouseLeaveCreateBoard()
        {
            this.lbCreateBoard.BackColor = Color.FromArgb(255, 255, 255);
            this.lbDesCreateBoard.BackColor = Color.FromArgb(255, 255, 255);

            this.lbCreateBoard.ForeColor = Color.FromArgb(23, 57, 77);
            this.lbDesCreateBoard.ForeColor = Color.Gray;
        }

        //====================================================================

        void MouseHoverCreateTeam()
        {
            this.lbCreateTeam.BackColor = Color.FromArgb(41, 143, 202);
            this.lbDesCreateTeam.BackColor = Color.FromArgb(41, 143, 202);

            this.lbCreateTeam.ForeColor = Color.FromArgb(255, 255, 255);
            this.lbDesCreateTeam.ForeColor = Color.FromArgb(255, 255, 255);
        }

        void MouseLeaveCreateTeam()
        {
            this.lbCreateTeam.BackColor = Color.FromArgb(255, 255, 255);
            this.lbDesCreateTeam.BackColor = Color.FromArgb(255, 255, 255);

            this.lbCreateTeam.ForeColor = Color.FromArgb(23, 57, 77);
            this.lbDesCreateTeam.ForeColor = Color.Gray;
        }

        //====================================================================

        void MouseHoverAddMem()
        {
            this.lbAddMem.BackColor = Color.FromArgb(41, 143, 202);
            this.lbDesAddMem.BackColor = Color.FromArgb(41, 143, 202);

            this.lbAddMem.ForeColor = Color.FromArgb(255, 255, 255);
            this.lbDesAddMem.ForeColor = Color.FromArgb(255, 255, 255);
        }

        void MouseLeaveAddMem()
        {
            this.lbAddMem.BackColor = Color.FromArgb(255, 255, 255);
            this.lbDesAddMem.BackColor = Color.FromArgb(255, 255, 255);

            this.lbAddMem.ForeColor = Color.FromArgb(23, 57, 77);
            this.lbDesAddMem.ForeColor = Color.Gray;
        }

        //====================================================================
        private void lbCreateBoard_MouseHover(object sender, EventArgs e)
        {
            MouseHoverCreateBoard();
        }

        private void lbDesCreateBoard_MouseHover(object sender, EventArgs e)
        {
            MouseHoverCreateBoard();
        }

        private void lbDesCreateBoard_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveCreateBoard();
        }

        private void lbCreateBoard_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveCreateBoard();
        }

        //====================================================================
        private void lbCreateTeam_MouseHover(object sender, EventArgs e)
        {
            MouseHoverCreateTeam();
        }

        private void lbDesCreateTeam_MouseHover(object sender, EventArgs e)
        {
            MouseHoverCreateTeam();
        }

        private void lbCreateTeam_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveCreateTeam();
        }

        private void lbDesCreateTeam_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveCreateTeam();
        }

        //====================================================================

        private void lbAddMem_MouseHover(object sender, EventArgs e)
        {
            MouseHoverAddMem();
        }

        private void lbDesAddMem_MouseHover(object sender, EventArgs e)
        {
            MouseHoverAddMem();
        }

        private void lbAddMem_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveAddMem();
        }

        private void lbDesAddMem_MouseLeave(object sender, EventArgs e)
        {
            MouseLeaveAddMem();
        }
    }
}
