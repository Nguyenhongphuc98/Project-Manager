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
    public partial class WorkSpace : Form
    {
        ListSpace listSpace;

        public WorkSpace()
        {
            InitializeComponent();
            LoadListSpace();
        }

        public void LoadListSpace()
        {
            listSpace = new ListSpace();
            listSpace.TopLevel = false;

            this.pnWorkSpace.Controls.Add(listSpace);
            listSpace.Show();
        }
    }
}
