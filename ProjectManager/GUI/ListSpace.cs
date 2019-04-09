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
    public partial class ListSpace : Form
    {
        int mode;
        int idBoard;
        int idGroup;
        string title;
        string background;
        
        //==================================================
        public int Mode
        {
            get { return this.mode; }
            set { this.mode = value; }
        }

        public int Board
        {
            get { return this.idBoard; }
            set { this.idBoard = value; }
        }

        public int Group
        {
            get { return this.idGroup; }
            set { this.idGroup = value; }
        }

        public string Ttle
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Background
        {
            get { return this.background; }
            set { this.background = value; }
        }

        //======================================================
        public ListSpace()
        {
            InitializeComponent();
        }

        public ListSpace(int mode,int idBoard,int idGr,string title,string bg)
        {
            InitializeComponent();
            this.mode = mode;

            this.idBoard = idBoard;
            this.idGroup = idGr;
            this.title = title;
            this.background = bg;

            LoadBaseInfor();
        }
        //======================================================

        void LoadBaseInfor()
        {
            this.lbNameProject.Text = this.title;

            switch(this.mode)
            {
                case 0:
                    this.btnMode.Text = "Public";
                    break;
                case 1:
                    this.btnMode.Text = "Team";
                    break;
                default:
                    this.btnMode.Text = "Private";
                    break;
            }
           
        }
    }
}
