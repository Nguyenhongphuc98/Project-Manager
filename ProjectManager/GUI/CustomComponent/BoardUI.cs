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
    public partial class BoardUI : UserControl
    {
        public BoardUI()
        {
            InitializeComponent();
            this.pbStar.Visible = false;
        }

        public BoardUI(int index)
        {
            InitializeComponent();
            this.Top = 50 + this.Height * (index / 4);
            this.Left = 50 + this.Width * (index % 4);
            this.pbStar.Visible = false;
        }

        private void BoardUI_MouseHover(object sender, EventArgs e)
        {
            this.pbStar.Visible = true;
        }

        private void BoardUI_MouseLeave(object sender, EventArgs e)
        {
            this.pbStar.Visible = false;
        }
    }
}
