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
    public partial class DateEdit : Form
    {
        ListBLL listBLL;
        CardBLL cardBLL = new CardBLL();
        CardDTO cardDTO;
        public DateEdit(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            cardDTO = cardBLL.GetCard(cardId);
            this.datePicker.Value = cardDTO.DueDate.Date;
            this.dueDateHour.Value = cardDTO.DueDate.TimeOfDay.Hours;
            this.dueDateMin.Value = cardDTO.DueDate.TimeOfDay.Minutes;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ActivityBLL activityBLL = new ActivityBLL();
            listBLL = new ListBLL();
            TimeSpan time = new TimeSpan(Convert.ToInt32(this.dueDateHour.Value), Convert.ToInt32(this.dueDateMin.Value), 0);
            cardDTO.DueDate = DateTime.MinValue;
            cardDTO.DueDate = datePicker.Value;
            cardDTO.DueDate = cardDTO.DueDate + time;
            cardBLL.UpdateDate(cardDTO);
            activityBLL.InsertActivity(Global.user.UserId, Global.id_Board, Global.user.Name + " Has change date of card " + cardDTO.Title, DateTime.Now);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DateEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
