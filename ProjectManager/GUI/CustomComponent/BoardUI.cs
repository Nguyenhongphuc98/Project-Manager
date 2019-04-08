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
        int mode;
        int margin = 15;

        public BoardUI()
        {
            InitializeComponent();
            this.pbStar.Visible = false;
        }

        public BoardUI(int index)
        {
            InitializeComponent();

            this.Top = 50 + (this.Height + margin) * (index / 4);
            this.Left = 50 + (this.Width + margin) * (index % 4);

            this.pbStar.Visible = false;
        }

        public BoardUI(int index,string title,int mode,bool star,string background)
        {
            InitializeComponent();

            this.Top = 50 + (this.Height + margin) * (index / 4) ;
            this.Left = 50 + (this.Width + margin )* (index % 4) ;

            this.pbStar.Visible = star;
            this.lbNameBoard.Text = title;

            if (background != "NULL")
                this.BackgroundImage = Image.FromFile(background);
        }   

        //============================================================

        private void BoardUI_MouseHover(object sender, EventArgs e)
        {
            this.pbStar.Visible = true;
            this.lbNameBoard.ForeColor = Color.White;
        }

        private void BoardUI_MouseLeave(object sender, EventArgs e)
        {
            this.pbStar.Visible = false;
            this.lbNameBoard.ForeColor = Color.Silver;
        }
    }
}
