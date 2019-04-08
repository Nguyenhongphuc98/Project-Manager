using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace GUI.CustomComponent
{
    public partial class BoardCreate : Form
    {
        List<string> srcTeam;
        List<string> srcMode;

        public BoardCreate():base()
        {
            
            InitializeComponent();

            srcTeam = new List<string>() { "No Team" };
            srcMode = new List<string>() { "Private", "Public" };

            cbTeam.DataSource = srcTeam;
            cbMode.DataSource = srcMode;
        }


        //===================================================

        private void pnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
