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
        private List<Harr.HarrProgressBar> _items = new List<Harr.HarrProgressBar>();
        ListSpace listSpace;
        ListActivity listActivity;

        public WorkSpace()
        {
            InitializeComponent();
            LoadListSpace();
            LoadBoard();
            LoadListActivity();
        }

        public void LoadListSpace()
        {
            listSpace = new ListSpace();
            listSpace.TopLevel = false;

            this.pnWorkSpace.Controls.Add(listSpace);
            listSpace.Show();
        }

        public void LoadBoard()
        {
            this.flowLayoutPanel1.DragEnter += new DragEventHandler(flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel1.DragDrop += new DragEventHandler(flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel2.DragEnter += new DragEventHandler(flowLayoutPanel1_DragEnter);
            this.flowLayoutPanel2.DragDrop += new DragEventHandler(flowLayoutPanel1_DragDrop);

            Size s = new Size(flowLayoutPanel1.Width, 50);
            Harr.HarrProgressBar pgb;

            pgb = new Harr.HarrProgressBar();
            pgb.Padding = new Padding(5);
            pgb.Text = "1";
            pgb.BackColor = Color.Red;
            pgb.Size = s;
            pgb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this._items.Add(pgb);
            this.flowLayoutPanel2.Controls.Add(pgb);

            pgb = new Harr.HarrProgressBar();
            pgb.Padding = new Padding(5);
            pgb.Text = "2";
            pgb.BackColor = Color.Blue;
            pgb.Size = s;
            pgb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this._items.Add(pgb);
            this.flowLayoutPanel2.Controls.Add(pgb);
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            Harr.HarrProgressBar data = (Harr.HarrProgressBar)e.Data.GetData(typeof(Harr.HarrProgressBar));
            FlowLayoutPanel _destination = (FlowLayoutPanel)sender;
            FlowLayoutPanel _source = (FlowLayoutPanel)data.Parent;

            if (_source != _destination)
            {
                // Add control to panel
                _destination.Controls.Add(data);
                data.Size = new Size(_destination.Width, 50);

                // Reorder
                Point p = _destination.PointToClient(new Point(e.X, e.Y));
                var item = _destination.GetChildAtPoint(p);
                int index = _destination.Controls.GetChildIndex(item, false);
                _destination.Controls.SetChildIndex(data, index);

                // Invalidate to paint!
                _destination.Invalidate();
                _source.Invalidate();
            }
            else
            {
                // Just add the control to the new panel.
                // No need to remove from the other panel, this changes the Control.Parent property.
                Point p = _destination.PointToClient(new Point(e.X, e.Y));
                var item = _destination.GetChildAtPoint(p);
                int index = _destination.Controls.GetChildIndex(item, false);
                _destination.Controls.SetChildIndex(data, index);
                _destination.Invalidate();
            }
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
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
