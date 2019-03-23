using DTO;
using GUI.CustomComponent;
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
        ListActivity listActivity;

        public WorkSpace()
        {
            InitializeComponent();
            LoadListSpace();
            LoadListActivity();
        }

        public void LoadListSpace()
        {
            listSpace = new ListSpace();
            listSpace.TopLevel = false;

            this.pnWorkSpace.Controls.Add(listSpace);
            listSpace.Show();
        }

        public void LoadListActivity()
        {
            listActivity = new ListActivity();
            List<Activity> srcActivity = new List<Activity>();
            srcActivity.Add(new Activity(1, 1, 1, 1, 1, "thêm 1 card vào todo", DateTime.Now));
            srcActivity.Add(new Activity(1, 1, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(2, 2, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(3, 3, 1, 1, 1, "thêm Quốc Tuyến vào card custom listbox", DateTime.Now));
            srcActivity.Add(new Activity(4, 4, 1, 1, 1, "xóa card nothing", DateTime.Now));
            srcActivity.Add(new Activity(5, 5, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(5, 6, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(5, 7, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(5, 99, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(5, 78, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            srcActivity.Add(new Activity(5, 15, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));

            listActivity.DataSource = srcActivity;

            this.listSpace.Controls.Add(listActivity);
            //listActivity.Show();
        }
    }
}
