using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomComponent
{
    public partial class ListUI : UserControl
    {
        int position;
        int margin;

        public ListUI()
        {
            InitializeComponent();

            position= 0;
            margin = 5;

            this.Top = 40;
            this.Left = 10 + (this.Width + margin) * this.position;
            ;
        }
    }
}
