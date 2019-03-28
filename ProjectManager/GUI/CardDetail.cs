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
        public CardDetail()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
    }
}
