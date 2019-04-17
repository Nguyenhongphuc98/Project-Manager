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
        int _cardId;
        int _boardId;

        CardDTO cardDTO;
        ListDTO listDTO;
        ChecklistDTO checklistDTO;
        CommentDTO commentDTO;

        CardBLL cardBLL = new CardBLL();
        ListBLL listBLL = new ListBLL();
        ChecklistBLL checklistBLL = new ChecklistBLL();
        LamViecBLL lamViecBLL = new LamViecBLL();
        CardUserBLL userBLL = new CardUserBLL();
        CommentBLL commentBLL = new CommentBLL();
        ActivityBLL activityBLL;

        List<ChecklistDTO> checklistDTOs;
        List<CheckBox> tasks = new List<CheckBox>();
        List<CardUserDTO> userDTOs = new List<CardUserDTO>();
        List<int> listUsers = new List<int>();
        List<CommentDTO> commentDTOs;

        public CardDetail(int id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _cardId = id;
            cardDTO = cardBLL.GetCard(_cardId);

            switch (cardDTO.Label)
            {
                case 1:
                    this.cardLabel.BackColor = Color.Red;
                    break;
                case 2:
                    this.cardLabel.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.cardLabel.BackColor = Color.Green;
                    break;
                case 4:
                    this.cardLabel.BackColor = Color.Orange;
                    break;
                case 5:
                    this.cardLabel.BackColor = Color.Blue;
                    break;
                case 6:
                    this.cardLabel.BackColor = Color.Fuchsia;
                    break;
                default:
                    this.cardLabel.BackColor = Color.Transparent;
                    break;
            }
            this.CardName.Text = cardDTO.Title;
            this.descriptionText.Text = cardDTO.Description;
            this.checkDueDate.Text = cardDTO.DueDate.Date.ToString();

            AddMember();

            checklistDTOs = checklistBLL.GetAllChecklist(id);
            if (checklistDTOs.Count() != 0)
            {
                this.checklistPn.Visible = true;
                this.progressBar1.Visible = true;
                this.progressBar1.Maximum = checklistDTOs.Count();
                taskFlpanel.Controls.Clear();
                checklistDTOs = checklistBLL.GetAllChecklist(_cardId);
                foreach (ChecklistDTO checklist in checklistDTOs)
                {
                    CheckBox task = new CheckBox();
                    task.Font = new Font(task.Font.FontFamily, 10.0f);
                    task.Text = checklist.Title;
                    if (checklist.Status == 1)
                    {
                        task.Checked = true;
                        this.progressBar1.Increment(1);
                    }
                    else task.Checked = false;
                    taskFlpanel.Controls.Add(task);
                    tasks.Add(task);
                }
            }
            else checklistPn.Visible = false;

            this.descriptionText.LostFocus += DescriptionText_LostFocus;
            this.commentText.LostFocus += CommentText_LostFocus;

            listDTO = listBLL.GetList(cardDTO.ListId);
            this.List.Text = listDTO.Title;
            _boardId = listDTO.BoardId;

            commentDTOs = commentBLL.GetAllComments(_cardId);
            foreach (CommentDTO comment in commentDTOs)
            {
                UserComment userComment = new UserComment(userBLL.GetUser(comment.UserId).Name.Substring(0, 1), comment.Content);
                cmtPanel.Controls.Add(userComment);
            }
        }

        private void AddMember()
        {
            this.memberFlp.Controls.Clear();
            listUsers = lamViecBLL.ListUserId(_cardId);
            userDTOs.Clear();

            foreach (int userId in listUsers)
            {
                CardUserDTO userDTO = userBLL.GetUser(userId);
                userDTOs.Add(userDTO);
            }
            foreach (CardUserDTO userDTO in userDTOs)
            {
                MemIcon member = new MemIcon(userDTO.Name.Substring(0, 1));
                this.memberFlp.Controls.Add(member);
            }
        }

        private void CommentText_LostFocus(object sender, EventArgs e)
        {
            if (commentText.Text == "")
            {
                commentText.Text = "Thêm bình luận...";
            }
            else
            {

            }
        }

        private void DescriptionText_LostFocus(object sender, EventArgs e)
        {
            if (descriptionText.Text == "")
            {
                descriptionText.Text = "Thêm mô tả...";
            }
        }


        private void AddMem_Click(object sender, EventArgs e)
        {
            MemberEdit editMember = new MemberEdit(this.Location.X + this.Width, this.Location.Y, _cardId, _boardId);
            editMember.Show();
        }

        private void EditLabel_Click(object sender, EventArgs e)
        {
            LabelEdit labelEdit = new LabelEdit(this.Location.X + this.Width, this.Location.Y + EditLabel.Location.Y, _cardId);
            labelEdit.Show();
        }

        private void DueDate_Click(object sender, EventArgs e)
        {
            DateEdit dateEdit = new DateEdit(this.Location.X + this.Width, this.Location.Y + DueDate.Location.Y, _cardId);
            dateEdit.Show();
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            MoveForm moveForm = new MoveForm(this.Location.X + this.Width, this.Location.Y + moveBtn.Location.Y, _cardId);
            moveForm.Show();
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

        private void ChecklistBtn_Click(object sender, EventArgs e)
        {
            checklistPn.Visible = true;
            progressBar1.Visible = true;
            taskFlpanel.Controls.Clear();
            checklistDTOs = checklistBLL.GetAllChecklist(_cardId);
            foreach (ChecklistDTO checklist in checklistDTOs)
            {
                CheckBox task = new CheckBox();
                task.Font = new Font(task.Font.FontFamily, 10.0f);
                task.Text = checklist.Title;
                if (checklist.Status == 1)
                {
                    task.Checked = true;
                }
                else task.Checked = false;
                taskFlpanel.Controls.Add(task);
                tasks.Add(task);
            }
        }

        private void addTask_Click(object sender, EventArgs e)
        {
            ChecklistEdit checklist = new ChecklistEdit(this.Location.X + this.Width, this.Location.Y + ChecklistBtn.Location.Y, _cardId);
            checklist.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            checklistBLL.DeleteChecklist(_cardId);
            taskFlpanel.Visible = false;
            tasks.Clear();
        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            cardDTO.Description = descriptionText.Text;

            AddMember();

            progressBar1.Value = 0;
            progressBar1.Maximum = checklistDTOs.Count();
            foreach (CheckBox task in tasks)
            {
                if (task.Checked == true)
                {
                    progressBar1.Increment(1);
                    checklistDTO = checklistBLL.GetChecklist(task.Text);
                    checklistDTO.Status = 1;
                    checklistBLL.UpdateChecklist(checklistDTO);
                }
                else if (task.Checked == false)
                {
                    checklistDTO = checklistBLL.GetChecklist(task.Text);
                    checklistDTO.Status = 0;
                    checklistBLL.UpdateChecklist(checklistDTO);
                }
            }

            cardDTO.Title = this.CardName.Text;
            switch (cardDTO.Label)
            {
                case 1:
                    this.cardLabel.BackColor = Color.Red;
                    break;
                case 2:
                    this.cardLabel.BackColor = Color.Yellow;
                    break;
                case 3:
                    this.cardLabel.BackColor = Color.Green;
                    break;
                case 4:
                    this.cardLabel.BackColor = Color.Orange;
                    break;
                case 5:
                    this.cardLabel.BackColor = Color.Blue;
                    break;
                case 6:
                    this.cardLabel.BackColor = Color.Fuchsia;
                    break;
                default:
                    this.cardLabel.BackColor = Color.Transparent;
                    break;
            }
            checkDueDate.Text = cardDTO.DueDate.ToString();
            descriptionText.Text = cardDTO.Description;
            if (followCheck.Checked == true)
            {
                followPic.Visible = true;
            }
            else followPic.Visible = false;
            if (checklistDTOs.Count() != 0)
            {
                checklistPn.Visible = true;
                progressBar1.Visible = true;
            }
            else checklistPn.Visible = false;

            cardBLL.UpdateCard(cardDTO);

            listDTO = listBLL.GetList(cardDTO.ListId);
            List.Text = listDTO.Title;
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            if (commentText.Text != null)
            {
                activityBLL = new ActivityBLL();
                //UserComment userComment = new UserComment(Global.user.Name.Substring(0,1), commentText.Text);
                //this.cmtPanel.Controls.Add(userComment);
                commentDTO = new CommentDTO(_cardId, Global.user.UserId, commentText.Text, DateTime.Now, 1);
                commentBLL.InsertComment(commentDTO);
            }
            foreach (CommentDTO comment in commentDTOs)
            {
                cmtPanel.Controls.Clear();
                UserComment userComment = new UserComment(userBLL.GetUser(comment.UserId).Name.Substring(0, 1), comment.Content);
                cmtPanel.Controls.Add(userComment);
            }
            activityBLL.InsertActivity(Global.user.UserId, _boardId, Global.user.Name + " Has comment to card " + cardDTO.Title, DateTime.Now);
        }
    }
}
