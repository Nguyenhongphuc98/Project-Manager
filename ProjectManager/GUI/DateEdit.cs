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
        public DateEdit(int X, int Y)
        {
            InitializeComponent();
            this.Location = new Point(X, Y);
            this.StartPosition = FormStartPosition.Manual;
          
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
