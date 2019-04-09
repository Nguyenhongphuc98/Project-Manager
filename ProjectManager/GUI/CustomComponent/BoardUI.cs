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
        int id;
        int mode;
        int index;
        int group;
        string title;
        string background;

        int margin = 15;

        //=========================================================
        public BoardUI()
        {
            InitializeComponent();
            this.pbStar.Visible = false;
        }

        public BoardUI(int index,int mode)
        {
            InitializeComponent();

            this.index = index;
            this.mode = mode;

            this.Top = 50 + (this.Height + margin) * (index / 3);
            this.Left = 50 + (this.Width + margin) * (index % 3);

            this.pbStar.Visible = false;
        }

        public BoardUI(int id,int index,int group,string title,int mode,bool star,string background)
        {
            InitializeComponent();

            this.id = id;
            this.index = index;
            this.mode = mode;
            this.group = group;
            this.title = title;
            this.background = background;

            this.Top = 50 + (this.Height + margin) * (index / 3) ;
            this.Left = 50 + (this.Width + margin )* (index % 3) ;

            this.pbStar.Visible = star;
            this.lbNameBoard.Text = title;
            this.lbNameBoard.ForeColor = Color.Gray;

            if (background == "NULL")
            {
                //----get default background--------------------
                //string path = Application.StartupPath;
                //int i = path.IndexOf("bin");

                //path = path.Substring(0, i);
                //path += "src\\background_board.jpg";

                //this.BackgroundImage = Image.FromFile(path);
            }
            else
            {
                //---------background is color---------------
                string[] value = background.Split(',');
                int r = Int32.Parse(value[0]);
                int g = Int32.Parse(value[1]);
                int b = Int32.Parse(value[2]);

                this.BackgroundImage = null;
                this.BackColor = Color.FromArgb(r, g, b);
            }
               
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

        private void BoardUI_Click(object sender, EventArgs e)
        {
            ListSpace listSpace = new ListSpace(this.mode, this.id, this.group, this.title, this.background);
            
            //ws->pnws->ls->lists->card;
            ((WorkSpace)this.Parent.Parent).AddListSpace(new ListSpace(this.mode, this.id, this.group, this.title, this.background));
            ((WorkSpace)this.Parent.Parent).LoadListSpace();
        }
    }
}
