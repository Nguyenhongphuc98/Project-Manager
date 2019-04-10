using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.CustomComponent
{
    public partial class ListUIButtonCreate : UserControl
    {
        int margin = 5;
        int heightSmall = 44;
        int heightBig = 82;
        int index;
        int idBoard;

        //===========================================
        public ListUIButtonCreate( int index,int idBoard)
        {
            InitializeComponent();

            ZoomOut();

            this.index = index;
            this.idBoard = idBoard;

            this.margin = 5;
            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * index;

            this.LostFocus += ListUIButtonCreate_LostFocus;
        }

        //===========================================
        void ZoomOut()
        {
            this.tbNameList.Visible = false;
            this.btnSave.Visible = false;
            this.btnClose.Visible = false;
            this.Height = heightSmall;

            this.btnCreateNewList.Visible = true;
        }

        //===========================================
        private void ListUIButtonCreate_LostFocus(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btnCreateNewList_Click(object sender, EventArgs e)
        {
            this.btnCreateNewList.Visible = false;
            this.Height = heightBig;

            this.tbNameList.Visible = true;
            this.btnSave.Visible = true;
            this.btnClose.Visible = true;
        }

        private void tbNameList_Leave(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListBLL listBLL = new ListBLL();

            if (string.IsNullOrEmpty(tbNameList.Text))
            {
                MessageBox.Show("Please enter title before save list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            ListDTO l = new ListDTO(this.idBoard,this.index,tbNameList.Text,1);
            bool r=listBLL.InsertList(l);

            ActivityBLL activityBLL = new ActivityBLL();
            activityBLL.InsertActivity(Global.user.UserId, this.idBoard, Global.user.Name + " Has create new list: " + this.tbNameList.Text, DateTime.Now);

            ((ListSpace)this.Parent).LoadListOfThisBoard();
        }
    }
}
