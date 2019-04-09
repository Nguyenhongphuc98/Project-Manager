using BLL;
using DTO;
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
    public partial class CardDetail : Form
    {
        int _boardId;
        int _listId;
        string title;
        string des;
        CardBLL cardBLL = new CardBLL();
        CardDTO cardDTO;

        public CardDetail(int id)
        {
            InitializeComponent();
            this.descriptionText.LostFocus += DescriptionText_LostFocus;
            this.commentText.LostFocus += CommentText_LostFocus;
            this.StartPosition = FormStartPosition.CenterScreen;
            cardDTO = cardBLL.GetCard(id);
            this.CardName.Text = cardDTO.Title;
        }

        private void CommentText_LostFocus(object sender, EventArgs e)
        {
            if (commentText.Text == "")
            {
                commentText.Text = "Thêm bình luận...";
            }
        }

        private void DescriptionText_LostFocus(object sender, EventArgs e)
        {
            if (descriptionText.Text == "")
            {
                descriptionText.Text = "Thêm mô tả...";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AddMem_Click(object sender, EventArgs e)
        {
            MemberEdit editMember = new MemberEdit(this.Location.X + this.Width, this.Location.Y);
            editMember.Show();
        }

        private void EditLabel_Click(object sender, EventArgs e)
        {
            LabelEdit labelEdit = new LabelEdit(this.Location.X + this.Width, this.Location.Y + EditLabel.Location.Y);
            labelEdit.Show();
        }

        private void DueDate_Click(object sender, EventArgs e)
        {
            DateEdit dateEdit = new DateEdit(this.Location.X + this.Width, this.Location.Y + DueDate.Location.Y);
            dateEdit.Show();
        }

        private void CardName_MouseEnter(object sender, EventArgs e)
        {
            CardName.BackColor = Color.White;
            CardName.BorderStyle = BorderStyle.FixedSingle;
        }

        private void CardName_MouseLeave(object sender, EventArgs e)
        {
            CardName.BackColor = Color.WhiteSmoke;
            CardName.BorderStyle = BorderStyle.None;
        }

        private void descriptionText_MouseClick(object sender, MouseEventArgs e)
        {
            if (descriptionText.Text == "Thêm mô tả...")
            {
                descriptionText.Text = "";
            }
        }

        private void commentText_MouseClick(object sender, MouseEventArgs e)
        {
            if (commentText.Text == "Thêm bình luận...")
            {
                commentText.Text = "";
            }
        }

        private void CloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
