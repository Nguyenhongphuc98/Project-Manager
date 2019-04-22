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
        List<UserDTO> userDTOs;

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
            this.cbListUser.Visible = false;

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

            //-------load menu bar---------------------
            //this.Controls.Add(lbNameProject);
            //this.Controls.Add(btnInvite);
            //this.Controls.Add(btnMode);
            //this.Controls.Add(btnPersonal);
            //this.Controls.Add(btnStar);
            this.Controls.Add(pnMenu);

            //-------load lits---------------------
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

        //======================================================
        private void btnInvite_Click(object sender, EventArgs e)
        {
            UserBLL userBLL = new UserBLL();
            userDTOs = userBLL.GetAllUsers();
            List<string> lsNameUser = new List<string>() { "No user"};

            foreach(UserDTO user in userDTOs)
            {
                lsNameUser.Add(user.Name);
            }

            cbListUser.DataSource = lsNameUser;

            this.cbListUser.Visible = true;
        }

        private void cbListUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListUser.SelectedIndex != 0)
            {
                BoardBLL boardBLL = new BoardBLL();
                ActivityBLL activityBLL = new ActivityBLL();
                try
                {
                    boardBLL.AddUser(userDTOs[cbListUser.SelectedIndex - 1].UserId, this.idBoard);
                    activityBLL.InsertActivity(Global.user.UserId, this.idBoard, Global.user.Name + " Add " + userDTOs[cbListUser.SelectedIndex - 1].Name + " to " + this.title,DateTime.Now);
                    MessageBox.Show("Add succedd"+ userDTOs[cbListUser.SelectedIndex - 1].Name + " to " + this.title, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch { MessageBox.Show(cbListUser.SelectedText + "already exist in this board!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            else
            {
                this.cbListUser.Visible = false;
            }
        }

        private void ListSpace_Activated(object sender, EventArgs e)
        {
            LoadListOfThisBoard();
        }
    }
}
