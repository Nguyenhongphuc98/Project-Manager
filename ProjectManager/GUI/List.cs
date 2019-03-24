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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        
        private void AddJob_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            panel1.Controls.Add(card);
            panel1.Height += card.Height;
            this.Height += card.Height;
            AddJob.Location = new Point(AddJob.Location.X, AddJob.Location.Y + card.Height);
        }
    }
}
