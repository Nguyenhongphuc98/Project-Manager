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
    public partial class CardEdit : Form
    {
        public CardEdit(int X, int Y)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeLabel_Click(object sender, EventArgs e)
        {
            LabelEdit labelEdit = new LabelEdit(this.Location.X, this.Location.Y);
            labelEdit.Show(); 
        }

        private void ChangeMember_Click(object sender, EventArgs e)
        {
            EditMember editMember = new EditMember(this.Location.X + this.Width, this.Location.Y);
            editMember.Show();
        }

        private void MoveTo_Click(object sender, EventArgs e)
        {
            MoveCard moveCard = new MoveCard(this.Location.X + this.Width, this.Location.Y);
            moveCard.Show();
        }

        private void CopyTo_Click(object sender, EventArgs e)
        {
            CopyCard copyCard = new CopyCard(this.Location.X + this.Width, this.Location.Y);
            copyCard.Show();
        }

        private void ChangeDeadline_Click(object sender, EventArgs e)
        {
            EditDate editDate = new EditDate(this.Location.X + this.Width, this.Location.Y);
            editDate.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
