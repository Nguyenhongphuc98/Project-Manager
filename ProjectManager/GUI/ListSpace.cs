using BLL;
using DTO;
using GUI.CustomComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        List<ListUI> listUIs;
        List<ListDTO> listDTOs;
        
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

            this.listUIs = new List<ListUI>();
            this.listDTOs = new List<ListDTO>();

            LoadBaseInfor();
            LoadListOfThisBoard();
        }
        //======================================================

        void LoadBaseInfor()
        {
            this.lbNameProject.Text = this.title;
            if(this.background!="NULL")
            {
                //---------background is color---------------
                string[] value = background.Split(',');
                int r = Int32.Parse(value[0]);
                int g = Int32.Parse(value[1]);
                int b = Int32.Parse(value[2]);

                this.BackgroundImage = null;
                this.BackColor = Color.FromArgb(r, g, b);
            }

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

        public void LoadListOfThisBoard()
        {
            this.Controls.Clear();
            listDTOs.Clear();
            listUIs.Clear();

            ListBLL listBLL = new ListBLL();
            listDTOs = listBLL.GetAllList(this.idBoard);

            foreach(ListDTO l in listDTOs)
            {
                ListUI lsUI = new ListUI(l.ListId, l.IndexList, l.Title, l.Color);
                listUIs.Add(lsUI);
                this.Controls.Add(lsUI);
            }

            ListUIButtonCreate btnNewList = new ListUIButtonCreate(listDTOs.Count,this.idBoard);
            this.Controls.Add(btnNewList);
        }


    }
}
