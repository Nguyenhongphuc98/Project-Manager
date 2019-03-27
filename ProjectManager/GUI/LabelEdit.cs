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
    public partial class LabelEdit : Form
    {
        public LabelEdit(int X, int Y)
        {
            InitializeComponent();
            this.Location = new Point(X, Y - this.Height);
            this.StartPosition = FormStartPosition.Manual;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrangeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PinkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
