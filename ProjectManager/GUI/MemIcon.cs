using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MemIcon : UserControl
    {
        public MemIcon(string memberName)
        {
            InitializeComponent();
            this.MemberName.Text = memberName;
        }
        public MemIcon(string memberName, int width, int height)
        {
            InitializeComponent();
            this.MemberName.Text = memberName;
            this.Size = new Size(width, height);
            this.pictureBox1.Size = this.Size;
            this.MemberName.Font = new Font("Microsoft Sans Serif" ,width - 16);
        }
    }
}
