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
    public partial class ChecklistEdit : Form
    {
        ListBLL listBLL;
        CardBLL cardBLL;
        int _cardId;
        ChecklistBLL checklistBLL = new ChecklistBLL();
        List<ChecklistDTO> checklistDTOs;
        
        public ChecklistEdit(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            _cardId = cardId;
            checklistDTOs = checklistBLL.GetAllChecklist(_cardId);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            checklistBLL.InsertChecklist(_cardId,checklistDTOs.Count(),ChecklistTitle.Text,0);
            ActivityBLL activityBLL = new ActivityBLL();
            //listBLL = new ListBLL();
            activityBLL.InsertActivity(Global.user.UserId, Global.id_Board, Global.user.Name + " Has create new checklist " + ChecklistTitle.Text, DateTime.Now);
            this.Close();
        }
    }
}
