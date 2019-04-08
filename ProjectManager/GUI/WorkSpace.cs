using BLL;
using DTO;
using GUI.CustomComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class WorkSpace : Form
    {
        private List<Harr.HarrProgressBar> _items = new List<Harr.HarrProgressBar>();
        ListSpace listSpace;
        CustomComponent.Create create;

        ListActivity listActivity;
        List<ActivityDTO> srcActivity;

        public WorkSpace()
        {
            InitializeComponent();
            listSpace = new ListSpace();
            listSpace.TopLevel = false;

            listActivity = new ListActivity();

            LoadListSpace();
            LoadBoard();
            LoadListActivity();
            LoadCard();
            LoadCreate();

            //TestInsertFunction();
        }

        public void TestInsertFunction()
        {
           BoardBLL boardBLL = new BoardBLL();
           if(boardBLL.InsertBoard(2, "Project Test from client", 1, false, "NULL")==true)
                MessageBox.Show("Success insert");
           else
                MessageBox.Show("Can't insert");

        }

        public void LoadListSpace()
        {
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

        public void LoadCard()
        {
            Card c = new Card(500, 100);
            this.listSpace.Controls.Add(c);
            c.Show();
        }

        public void LoadCreate()
        {
            create = new Create(this.listSpace.Width);
            this.listSpace.Controls.Add(create);
           // this.create.Hide();
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
            
            listActivity.Size = new Size(0,600);

            srcActivity = new List<ActivityDTO>();
            //srcActivity.Add(new DTO.ActivityDTO(1, 1, 1, 1, 1, "thêm 1 card vào todo", DateTime.Now));
            //srcActivity.Add(new DTO.ActivityDTO(1, 1, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            //srcActivity.Add(new DTO.ActivityDTO(2, 2, 1, 1, 1, "di chuyển card sang list done", DateTime.Now));
            //srcActivity.Add(new DTO.ActivityDTO(3, 3, 1, 1, 1, "thêm Quốc Tuyến vào card custom listbox", DateTime.Now));
            //srcActivity.Add(new DTO.ActivityDTO(4, 4, 1, 1, 1, "xóa card nothing", DateTime.Now));
            ActivityBLL abll = new ActivityBLL();
            srcActivity = abll.GetAllActivity();
            

            listActivity.DataSource = srcActivity;

            this.listSpace.Controls.Add(listActivity);
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            if (this.listActivity.Size.Width == 0)
                this.listActivity.MakeShow();
            else
                this.listActivity.MakeHide();
        }

        bool clickInfor = false;
        private void btnInfor_Click(object sender, EventArgs e)
        {
            clickInfor = !clickInfor;
            if (clickInfor)
            {
                this.pnWorkSpace.Controls.Clear();
                string path = Application.StartupPath;
                int index = path.IndexOf("bin");
                path = path.Substring(0, index);
                path += "src\\infor_team.png";

                this.pnWorkSpace.BackgroundImage = Image.FromFile(path);
                this.pnWorkSpace.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
                LoadListSpace();
        }

        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (create.Width==0)
                create.MakeShow();
            else
                create.MakeHide();
        }
    }
}
