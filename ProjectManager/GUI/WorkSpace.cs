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

        ListActivity listActivityUI;
        List<ActivityDTO> srcActivity;

        List<Board> boards;
        List<BoardUI> boardUIs;

        UserDTO user;

        //=======================================================

        public WorkSpace()
        {
            InitializeComponent();

            this.listActivityUI = new ListActivity();
            this.boardUIs = new List<BoardUI>();
            this.boards = new List<Board>();


            // LoadListSpace();
            // LoadBoard();
            LoadListActivity();
           // LoadCard();
            LoadCreate();

           // TestInsertFunction();

            LoadBoardUIs();

        }

        public WorkSpace(UserDTO user)
        {
            InitializeComponent();

            this.user = user;

            this.listActivityUI = new ListActivity();
            this.boardUIs = new List<BoardUI>();
            this.boards = new List<Board>();

            this.listActivityUI.MakeHide();

            // LoadListSpace();
            // LoadBoard();
            //LoadListActivity();
            // LoadCard();
            LoadCreate();

            // TestInsertFunction();

            LoadBoardUIs();

        }


        //===================================================
        public void LoadBoardUIs()
        {
            BoardBLL boardBLL = new BoardBLL();

            boards.Clear();
            this.pnWorkSpace.Controls.Clear();

            this.pnWorkSpace.Controls.Add(listActivityUI);
            this.pnWorkSpace.BackgroundImage = null;

            // boards = boardBLL.GetAllBoard();
            boards = boardBLL.GetAllBoard(user.UserId);

            foreach (Board bo in boards)
            {
                BoardUI b = new BoardUI(bo.BoardId,bo.Index,bo.GroupId,bo.Title,bo.Mode,bo.Star,bo.Background);
                boardUIs.Add(b);
               
                this.pnWorkSpace.Controls.Add(b);
            }

            BoardNoInfor boardNoInfor = new BoardNoInfor(this,boards.Count);
            this.pnWorkSpace.Controls.Add(boardNoInfor);
           
        }

        public void TestInsertFunction()
        {
           BoardBLL boardBLL = new BoardBLL();
           if(boardBLL.InsertBoard(2, "Project Test from client", 1, false, "NULL")==true)
                MessageBox.Show("Success insert");
           else
                MessageBox.Show("Can't insert");

        }

        public void AddListSpace(ListSpace lspace)
        {
            this.listSpace = lspace;
            this.listSpace.TopLevel = false;
        }

        public void LoadListSpace()
        {
            this.pnWorkSpace.Controls.Clear();
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
            Card c = new Card(600, 100, 1);

            this.listSpace.Controls.Add(c);
            c.Show();
        }

        public void LoadCreate()
        {
            create = new Create(this.pnWorkSpace.Width);
  
            try
            {
                //----------in list page-------------------
                this.listSpace.Controls.Add(create);
            }
            catch
            {
                //----------in home page-------------------
                this.pnWorkSpace.Controls.Add(create);
            }
           
           // this.create.Hide();
        }

        public void LoadListActivity()
        {

            //listActivityUI.Size = new Size(300, 0);

            srcActivity = new List<ActivityDTO>();          
            ActivityBLL abll = new ActivityBLL();

            srcActivity = abll.GetAllActivity(Global.id_Board);
            srcActivity.Reverse();

            listActivityUI.DataSource = srcActivity;

            try
            {
                //----------in list page-------------------
                this.listSpace.Controls.Add(listActivityUI);
            }
            catch
            {
                //----------in home page-------------------
                this.pnWorkSpace.Controls.Add(listActivityUI);
            }
            
        }

        //=======================================================
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


        //=======================================================
        private void btnNotify_Click(object sender, EventArgs e)
        {
            //dont have list space mean it in home page
            if (this.pnWorkSpace.GetChildAtPoint(new Point(1000,50))==null)
                return;

            //--------------------------------------------------------------
            LoadListActivity();
                try
                {
                    //-----------list page------------------
                    if (this.listSpace.Visible == true)
                        this.listSpace.Controls.Add(listActivityUI);
                    else
                        this.pnWorkSpace.Controls.Add(listActivityUI);
                }
                catch
                {
                    //-----------home page------------------
                    this.pnWorkSpace.Controls.Add(listActivityUI);
                }

                if (this.listActivityUI.Size.Width ==0)
                    this.listActivityUI.MakeShow();
                else
                {
                    this.listActivityUI.MakeHide();
                    this.pnWorkSpace.Controls.Remove(listActivityUI);
                }

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
                LoadBoardUIs();
        }

        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            this.pnWorkSpace.Controls.Add(create);
            try
            {
                if(this.listSpace.Visible==true)
                this.listSpace.Controls.Add(create);
            }
            catch { }

            if (create.Width==0)
                create.MakeShow();
            else
            {
                create.MakeHide();
                this.pnWorkSpace.Controls.Remove(create);
            }
               
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //this.pnWorkSpace.BackgroundImage = null;
            LoadBoardUIs();

            //reset board id
            Global.id_Board = -1;
        }

        private void WorkSpace_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Show();
        }
    }
}
