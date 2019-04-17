namespace GUI
{
    partial class CardDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDetail));
            this.followCheck = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.commentText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cardLabel = new System.Windows.Forms.Panel();
            this.checkDueDate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CardName = new System.Windows.Forms.TextBox();
            this.activityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.AddMem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditLabel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ChecklistBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DueDate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addTask = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.followPic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DesPanel = new System.Windows.Forms.Panel();
            this.checklistPn = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.taskFlpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.commentButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmtPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.memberFlp = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Panel();
            this.moveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.followPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.DesPanel.SuspendLayout();
            this.checklistPn.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.memberFlp.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // followCheck
            // 
            this.followCheck.AutoSize = true;
            this.followCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followCheck.Location = new System.Drawing.Point(462, 300);
            this.followCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.followCheck.Name = "followCheck";
            this.followCheck.Size = new System.Drawing.Size(68, 17);
            this.followCheck.TabIndex = 54;
            this.followCheck.Text = "Theo dõi";
            this.followCheck.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "Thao tác";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Thêm vào thẻ";
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(24, 40);
            this.commentText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentText.Multiline = true;
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(402, 41);
            this.commentText.TabIndex = 46;
            this.commentText.Text = "Thêm bình luận...";
            this.commentText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.commentText_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Thêm bình luận";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 25);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(401, 8);
            this.progressBar1.TabIndex = 42;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(5, 2);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 21);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Việc cần làm";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(24, 37);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(402, 40);
            this.descriptionText.TabIndex = 40;
            this.descriptionText.Text = "Thêm mô tả...";
            this.descriptionText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.descriptionText_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mô tả:";
            // 
            // cardLabel
            // 
            this.cardLabel.BackColor = System.Drawing.Color.Red;
            this.cardLabel.Location = new System.Drawing.Point(213, 89);
            this.cardLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(29, 17);
            this.cardLabel.TabIndex = 37;
            // 
            // checkDueDate
            // 
            this.checkDueDate.AutoSize = true;
            this.checkDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDueDate.Location = new System.Drawing.Point(32, 156);
            this.checkDueDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkDueDate.Name = "checkDueDate";
            this.checkDueDate.Size = new System.Drawing.Size(79, 17);
            this.checkDueDate.TabIndex = 36;
            this.checkDueDate.Text = "hết hạn lúc";
            this.checkDueDate.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nhãn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Thành viên";
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List.Location = new System.Drawing.Point(2, 0);
            this.List.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(30, 17);
            this.List.TabIndex = 32;
            this.List.Text = "List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "trong danh sách";
            // 
            // CardName
            // 
            this.CardName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardName.Location = new System.Drawing.Point(5, 2);
            this.CardName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(320, 19);
            this.CardName.TabIndex = 30;
            this.CardName.Text = "Card name";
            this.CardName.MouseEnter += new System.EventHandler(this.CardName_MouseEnter);
            this.CardName.MouseLeave += new System.EventHandler(this.CardName_MouseLeave);
            // 
            // activityPanel
            // 
            this.activityPanel.Location = new System.Drawing.Point(24, 37);
            this.activityPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(401, 69);
            this.activityPanel.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Hoạt động";
            // 
            // AddMem
            // 
            this.AddMem.ActiveBorderThickness = 1;
            this.AddMem.ActiveCornerRadius = 20;
            this.AddMem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.AddMem.ActiveForecolor = System.Drawing.Color.White;
            this.AddMem.ActiveLineColor = System.Drawing.SystemColors.Window;
            this.AddMem.BackColor = System.Drawing.SystemColors.Control;
            this.AddMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddMem.BackgroundImage")));
            this.AddMem.ButtonText = "Thành viên";
            this.AddMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMem.ForeColor = System.Drawing.Color.Black;
            this.AddMem.IdleBorderThickness = 1;
            this.AddMem.IdleCornerRadius = 20;
            this.AddMem.IdleFillColor = System.Drawing.SystemColors.Window;
            this.AddMem.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.AddMem.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.AddMem.Location = new System.Drawing.Point(462, 54);
            this.AddMem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AddMem.Name = "AddMem";
            this.AddMem.Size = new System.Drawing.Size(101, 32);
            this.AddMem.TabIndex = 58;
            this.AddMem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddMem.Click += new System.EventHandler(this.AddMem_Click);
            // 
            // EditLabel
            // 
            this.EditLabel.ActiveBorderThickness = 1;
            this.EditLabel.ActiveCornerRadius = 20;
            this.EditLabel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.EditLabel.ActiveForecolor = System.Drawing.Color.White;
            this.EditLabel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EditLabel.BackColor = System.Drawing.SystemColors.Control;
            this.EditLabel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditLabel.BackgroundImage")));
            this.EditLabel.ButtonText = "Nhãn";
            this.EditLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditLabel.IdleBorderThickness = 1;
            this.EditLabel.IdleCornerRadius = 20;
            this.EditLabel.IdleFillColor = System.Drawing.Color.White;
            this.EditLabel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.EditLabel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EditLabel.Location = new System.Drawing.Point(462, 84);
            this.EditLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(101, 32);
            this.EditLabel.TabIndex = 59;
            this.EditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditLabel.Click += new System.EventHandler(this.EditLabel_Click);
            // 
            // ChecklistBtn
            // 
            this.ChecklistBtn.ActiveBorderThickness = 1;
            this.ChecklistBtn.ActiveCornerRadius = 20;
            this.ChecklistBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ChecklistBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ChecklistBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ChecklistBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ChecklistBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChecklistBtn.BackgroundImage")));
            this.ChecklistBtn.ButtonText = "Việc cần làm";
            this.ChecklistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChecklistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChecklistBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ChecklistBtn.IdleBorderThickness = 1;
            this.ChecklistBtn.IdleCornerRadius = 20;
            this.ChecklistBtn.IdleFillColor = System.Drawing.Color.White;
            this.ChecklistBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ChecklistBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ChecklistBtn.Location = new System.Drawing.Point(462, 110);
            this.ChecklistBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ChecklistBtn.Name = "ChecklistBtn";
            this.ChecklistBtn.Size = new System.Drawing.Size(101, 32);
            this.ChecklistBtn.TabIndex = 60;
            this.ChecklistBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChecklistBtn.Click += new System.EventHandler(this.ChecklistBtn_Click);
            // 
            // DueDate
            // 
            this.DueDate.ActiveBorderThickness = 1;
            this.DueDate.ActiveCornerRadius = 20;
            this.DueDate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.DueDate.ActiveForecolor = System.Drawing.Color.White;
            this.DueDate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.DueDate.BackColor = System.Drawing.SystemColors.Control;
            this.DueDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DueDate.BackgroundImage")));
            this.DueDate.ButtonText = "Ngày hết hạn";
            this.DueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.DueDate.IdleBorderThickness = 1;
            this.DueDate.IdleCornerRadius = 20;
            this.DueDate.IdleFillColor = System.Drawing.Color.White;
            this.DueDate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.DueDate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.DueDate.Location = new System.Drawing.Point(462, 137);
            this.DueDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(101, 32);
            this.DueDate.TabIndex = 61;
            this.DueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DueDate.Click += new System.EventHandler(this.DueDate_Click);
            // 
            // addTask
            // 
            this.addTask.ActiveBorderThickness = 1;
            this.addTask.ActiveCornerRadius = 20;
            this.addTask.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.addTask.ActiveForecolor = System.Drawing.Color.White;
            this.addTask.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.addTask.BackColor = System.Drawing.SystemColors.Control;
            this.addTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTask.BackgroundImage")));
            this.addTask.ButtonText = "Thêm việc";
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTask.ForeColor = System.Drawing.Color.SeaGreen;
            this.addTask.IdleBorderThickness = 1;
            this.addTask.IdleCornerRadius = 20;
            this.addTask.IdleFillColor = System.Drawing.Color.White;
            this.addTask.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.addTask.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.addTask.Location = new System.Drawing.Point(24, 100);
            this.addTask.Margin = new System.Windows.Forms.Padding(24, 33, 24, 33);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(70, 35);
            this.addTask.TabIndex = 62;
            this.addTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.ActiveBorderThickness = 1;
            this.SaveButton.ActiveCornerRadius = 20;
            this.SaveButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.ActiveForecolor = System.Drawing.Color.White;
            this.SaveButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.ButtonText = "Lưu";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleBorderThickness = 1;
            this.SaveButton.IdleCornerRadius = 20;
            this.SaveButton.IdleFillColor = System.Drawing.Color.White;
            this.SaveButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.Location = new System.Drawing.Point(463, 194);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(101, 32);
            this.SaveButton.TabIndex = 63;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // followPic
            // 
            this.followPic.Enabled = false;
            this.followPic.Image = ((System.Drawing.Image)(resources.GetObject("followPic.Image")));
            this.followPic.Location = new System.Drawing.Point(36, 2);
            this.followPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.followPic.Name = "followPic";
            this.followPic.Size = new System.Drawing.Size(16, 15);
            this.followPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.followPic.TabIndex = 64;
            this.followPic.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 8);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 14);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 13);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 66;
            this.pictureBox4.TabStop = false;
            // 
            // DesPanel
            // 
            this.DesPanel.Controls.Add(this.label5);
            this.DesPanel.Controls.Add(this.descriptionText);
            this.DesPanel.Controls.Add(this.pictureBox3);
            this.DesPanel.Location = new System.Drawing.Point(2, 193);
            this.DesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DesPanel.Name = "DesPanel";
            this.DesPanel.Size = new System.Drawing.Size(433, 90);
            this.DesPanel.TabIndex = 67;
            // 
            // checklistPn
            // 
            this.checklistPn.Controls.Add(this.deleteBtn);
            this.checklistPn.Controls.Add(this.taskFlpanel);
            this.checklistPn.Controls.Add(this.checkBox2);
            this.checklistPn.Controls.Add(this.progressBar1);
            this.checklistPn.Controls.Add(this.addTask);
            this.checklistPn.Location = new System.Drawing.Point(2, 287);
            this.checklistPn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checklistPn.Name = "checklistPn";
            this.checklistPn.Size = new System.Drawing.Size(433, 138);
            this.checklistPn.TabIndex = 68;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(369, 3);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(56, 19);
            this.deleteBtn.TabIndex = 64;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // taskFlpanel
            // 
            this.taskFlpanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.taskFlpanel.Location = new System.Drawing.Point(24, 38);
            this.taskFlpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taskFlpanel.Name = "taskFlpanel";
            this.taskFlpanel.Size = new System.Drawing.Size(401, 57);
            this.taskFlpanel.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.commentButton);
            this.panel3.Controls.Add(this.cmtPanel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.commentText);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(2, 429);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 190);
            this.panel3.TabIndex = 69;
            // 
            // commentButton
            // 
            this.commentButton.ActiveBorderThickness = 1;
            this.commentButton.ActiveCornerRadius = 20;
            this.commentButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.commentButton.ActiveForecolor = System.Drawing.Color.White;
            this.commentButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.commentButton.BackColor = System.Drawing.SystemColors.Control;
            this.commentButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commentButton.BackgroundImage")));
            this.commentButton.ButtonText = "Bình luận";
            this.commentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.commentButton.IdleBorderThickness = 1;
            this.commentButton.IdleCornerRadius = 20;
            this.commentButton.IdleFillColor = System.Drawing.Color.White;
            this.commentButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.commentButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.commentButton.Location = new System.Drawing.Point(24, 81);
            this.commentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(62, 32);
            this.commentButton.TabIndex = 76;
            this.commentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // cmtPanel
            // 
            this.cmtPanel.AutoScroll = true;
            this.cmtPanel.Location = new System.Drawing.Point(24, 119);
            this.cmtPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmtPanel.Name = "cmtPanel";
            this.cmtPanel.Size = new System.Drawing.Size(401, 68);
            this.cmtPanel.TabIndex = 57;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.activityPanel);
            this.panel5.Location = new System.Drawing.Point(2, 623);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(433, 113);
            this.panel5.TabIndex = 71;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkDueDate);
            this.panel4.Controls.Add(this.cardLabel);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.flowLayoutPanel4);
            this.panel4.Controls.Add(this.memberFlp);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CardName);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 187);
            this.panel4.TabIndex = 72;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.List);
            this.flowLayoutPanel4.Controls.Add(this.followPic);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(134, 37);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(129, 16);
            this.flowLayoutPanel4.TabIndex = 66;
            // 
            // memberFlp
            // 
            this.memberFlp.Controls.Add(this.flowLayoutPanel5);
            this.memberFlp.Controls.Add(this.panel6);
            this.memberFlp.Location = new System.Drawing.Point(31, 76);
            this.memberFlp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberFlp.Name = "memberFlp";
            this.memberFlp.Size = new System.Drawing.Size(153, 50);
            this.memberFlp.TabIndex = 65;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel5.TabIndex = 69;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Location = new System.Drawing.Point(6, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(0, 0);
            this.panel6.TabIndex = 68;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(550, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 20);
            this.CloseButton.TabIndex = 73;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseClick);
            // 
            // moveBtn
            // 
            this.moveBtn.ActiveBorderThickness = 1;
            this.moveBtn.ActiveCornerRadius = 20;
            this.moveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.moveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.moveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.moveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.moveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("moveBtn.BackgroundImage")));
            this.moveBtn.ButtonText = "Di chuyển";
            this.moveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.moveBtn.IdleBorderThickness = 1;
            this.moveBtn.IdleCornerRadius = 20;
            this.moveBtn.IdleFillColor = System.Drawing.Color.White;
            this.moveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.moveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.moveBtn.Location = new System.Drawing.Point(462, 164);
            this.moveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(101, 32);
            this.moveBtn.TabIndex = 74;
            this.moveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.DesPanel);
            this.flowLayoutPanel2.Controls.Add(this.checklistPn);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 11);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(449, 774);
            this.flowLayoutPanel2.TabIndex = 75;
            // 
            // CardDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(578, 788);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.ChecklistBtn);
            this.Controls.Add(this.AddMem);
            this.Controls.Add(this.followCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CardDetail";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.followPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.DesPanel.ResumeLayout(false);
            this.DesPanel.PerformLayout();
            this.checklistPn.ResumeLayout(false);
            this.checklistPn.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.memberFlp.ResumeLayout(false);
            this.memberFlp.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox followCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel cardLabel;
        private System.Windows.Forms.CheckBox checkDueDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.FlowLayoutPanel activityPanel;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 AddMem;
        private Bunifu.Framework.UI.BunifuThinButton2 EditLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 ChecklistBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DueDate;
        private Bunifu.Framework.UI.BunifuThinButton2 addTask;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private System.Windows.Forms.PictureBox followPic;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel DesPanel;
        private System.Windows.Forms.Panel checklistPn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel CloseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 moveBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel taskFlpanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.FlowLayoutPanel memberFlp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel cmtPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 commentButton;
    }
}