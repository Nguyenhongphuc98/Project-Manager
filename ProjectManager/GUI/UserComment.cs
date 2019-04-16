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
    public partial class UserComment : UserControl
    {
        public UserComment(string name, string text)
        {
            InitializeComponent();
            this.MemberName.Text = name;
            this.comment.Text = text;
        }
    }
}
