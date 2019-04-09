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
    public partial class ListUI : UserControl
    {
        int id;
        int position;
        string title;
        int color;
        int margin;

        int heightsmall=298;
        int heightbig=338;

        //=======================================================
        public ListUI()
        {
            InitializeComponent();

            position= 0;
            margin = 5;

            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;
            ;
        }

        public ListUI(int index)
        {
            InitializeComponent();

            position = index;
            margin = 5;

            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;

            ZomOut();
            LoadBaseInfor();
        }

        public ListUI(int id,int index,string title,int color)
        {
            InitializeComponent();

            this.id = id;
            this.position = index;
            this.title = title;
            this.color = color;

            this.margin = 5;
            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;

            ZomOut();
            LoadBaseInfor();
        }

        //=======================================================
        void ZomOut()
        {
            this.btnNewCard.Visible = true;
            this.Height = heightsmall;

            this.btnClose.Visible = false;
            this.btnSave.Visible = false;
            this.tbTitleNewCard.Visible = false;
        }

        void Extend()
        {
            this.btnNewCard.Visible = false;
            this.Height = heightbig;

            this.btnClose.Visible = true;
            this.btnSave.Visible = true;
            this.tbTitleNewCard.Visible = true;
        }
         
        public void LoadBaseInfor()
        {
            this.lbListName.Text = this.title;
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            Extend();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ZomOut();
        }
    }
}
