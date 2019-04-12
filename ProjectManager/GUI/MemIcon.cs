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
    }
}
