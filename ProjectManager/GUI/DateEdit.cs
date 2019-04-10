﻿using BLL;
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
        CardBLL cardBLL = new CardBLL();
        CardDTO cardDTO;
        public DateEdit(int X, int Y, int cardId)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
            cardDTO = cardBLL.GetCard(cardId);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            cardDTO.DueDate = bunifuDatepicker1.Value;
            cardBLL.UpdateDate(cardDTO);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
