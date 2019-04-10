using System.Windows.Forms;
using System;
using System.Collections.Generic;
using BLL;
using DTO;

namespace GUI.CustomComponent
{
    public partial class BoardCreate : Form
    {
        List<string> srcTeam;
        List<string> srcMode;
        
        int index;
        string background;

        public BoardCreate(int index):base()
        {
            
            InitializeComponent();

            this.index = index;
            this.background = "NULL";

            srcTeam = new List<string>() { "No Team" };
            srcMode = new List<string>() { "Private", "Public" };

            cbTeam.DataSource = srcTeam;
            cbMode.DataSource = srcMode;
        }


        //===================================================

        private void pnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BoardBLL boardBLL = new BoardBLL();
            ActivityBLL activityBLL = new ActivityBLL();

            String title = tbTitle.Text;
            int mode = cbMode.SelectedIndex;
            bool star = false;

            if(string.IsNullOrEmpty(tbTitle.Text))
            {
                MessageBox.Show("Tiêu đề không được để trống!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.background == "NULL")
            {
                DialogResult r = MessageBox.Show("Bạn có muốn lưu ảnh nền mặc định?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(r==DialogResult.OK)
                {
                    if (cbTeam.SelectedIndex == 0)
                    {
                        //----no team---------
                        boardBLL.InsertBoard(this.index, title, mode, star, this.background);
                        //add board for this user in user_board
                        int boardID = boardBLL.GetMaxID();
                        boardBLL.AddUser(Global.user.UserId, boardID);
                        activityBLL.InsertActivity(Global.user.UserId, boardID, Global.user.Name + " Has create new board: " + title, DateTime.Now);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                   
            }
            else
            {
                if (cbTeam.SelectedIndex == 0)
                {
                    //----no team---------
                    boardBLL.InsertBoard(this.index, title, mode, star, this.background);
                    //add board for this user in user_board
                    int boardID = boardBLL.GetMaxID();
                    boardBLL.AddUser(Global.user.UserId, boardID);
                    activityBLL.InsertActivity(Global.user.UserId,boardID ,Global.user.Name + " Has create new board: " + title, DateTime.Now);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }


            
        }

        private void btnBlue_Green_Click(object sender, EventArgs e)
        {
            this.background = "3,146,206";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.background = "102,176,50";
        }

        private void btnYellow_Green_Click(object sender, EventArgs e)
        {
            this.background = "208,234,43";
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            this.background = "106,115,123";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            this.background = "255,204,51";
        }
    }
}
