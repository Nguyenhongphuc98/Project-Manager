namespace GUI
{
    partial class CardEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardEdit));
            this.cardName = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ChangeDeadline = new System.Windows.Forms.Button();
            this.ChangeMember = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Button();
            this.checkList = new System.Windows.Forms.CheckBox();
            this.cmtNum = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.cmtPic = new System.Windows.Forms.PictureBox();
            this.desPic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CardLabel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmtPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardName
            // 
            this.cardName.Location = new System.Drawing.Point(5, 42);
            this.cardName.Name = "cardName";
            this.cardName.Size = new System.Drawing.Size(326, 22);
            this.cardName.TabIndex = 41;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(5, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 40;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChangeDeadline
            // 
            this.ChangeDeadline.Location = new System.Drawing.Point(343, 108);
            this.ChangeDeadline.Name = "ChangeDeadline";
            this.ChangeDeadline.Size = new System.Drawing.Size(137, 55);
            this.ChangeDeadline.TabIndex = 38;
            this.ChangeDeadline.Text = "Thay đổi ngày hết hạn";
            this.ChangeDeadline.UseVisualStyleBackColor = true;
            this.ChangeDeadline.Click += new System.EventHandler(this.ChangeDeadline_Click);
            // 
            // ChangeMember
            // 
            this.ChangeMember.Location = new System.Drawing.Point(343, 58);
            this.ChangeMember.Name = "ChangeMember";
            this.ChangeMember.Size = new System.Drawing.Size(137, 36);
            this.ChangeMember.TabIndex = 37;
            this.ChangeMember.Text = "Thay thành viên";
            this.ChangeMember.UseVisualStyleBackColor = true;
            this.ChangeMember.Click += new System.EventHandler(this.ChangeMember_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.Location = new System.Drawing.Point(343, 14);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(137, 30);
            this.ChangeLabel.TabIndex = 36;
            this.ChangeLabel.Text = "Chỉnh sửa nhãn";
            this.ChangeLabel.UseVisualStyleBackColor = true;
            this.ChangeLabel.Click += new System.EventHandler(this.ChangeLabel_Click);
            // 
            // checkList
            // 
            this.checkList.AutoSize = true;
            this.checkList.Enabled = false;
            this.checkList.Location = new System.Drawing.Point(266, 3);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(50, 21);
            this.checkList.TabIndex = 35;
            this.checkList.Text = "0/0";
            this.checkList.UseVisualStyleBackColor = true;
            // 
            // cmtNum
            // 
            this.cmtNum.AutoSize = true;
            this.cmtNum.Location = new System.Drawing.Point(32, 9);
            this.cmtNum.Name = "cmtNum";
            this.cmtNum.Size = new System.Drawing.Size(16, 17);
            this.cmtNum.TabIndex = 34;
            this.cmtNum.Text = "0";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(39, 6);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(73, 20);
            this.dateTime.TabIndex = 33;
            this.dateTime.Text = "datetime";
            // 
            // cmtPic
            // 
            this.cmtPic.Enabled = false;
            this.cmtPic.Image = ((System.Drawing.Image)(resources.GetObject("cmtPic.Image")));
            this.cmtPic.Location = new System.Drawing.Point(0, 3);
            this.cmtPic.Name = "cmtPic";
            this.cmtPic.Size = new System.Drawing.Size(29, 26);
            this.cmtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmtPic.TabIndex = 31;
            this.cmtPic.TabStop = false;
            // 
            // desPic
            // 
            this.desPic.Enabled = false;
            this.desPic.Image = ((System.Drawing.Image)(resources.GetObject("desPic.Image")));
            this.desPic.Location = new System.Drawing.Point(176, 3);
            this.desPic.Name = "desPic";
            this.desPic.Size = new System.Drawing.Size(27, 25);
            this.desPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.desPic.TabIndex = 30;
            this.desPic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tiêu đề";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.desPic);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.checkList);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(326, 40);
            this.flowLayoutPanel1.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Location = new System.Drawing.Point(39, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 34);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmtPic);
            this.panel2.Controls.Add(this.cmtNum);
            this.panel2.Location = new System.Drawing.Point(209, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(51, 35);
            this.panel2.TabIndex = 31;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(87, 117);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(244, 46);
            this.flowLayoutPanel2.TabIndex = 60;
            // 
            // CardLabel
            // 
            this.CardLabel.Location = new System.Drawing.Point(5, 7);
            this.CardLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(151, 10);
            this.CardLabel.TabIndex = 61;
            // 
            // CardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 170);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cardName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ChangeDeadline);
            this.Controls.Add(this.ChangeMember);
            this.Controls.Add(this.ChangeLabel);
            this.Name = "CardEdit";
            this.Text = "CardEdit";
            this.Activated += new System.EventHandler(this.CardEdit_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CardEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cmtPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cardName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ChangeDeadline;
        private System.Windows.Forms.Button ChangeMember;
        private System.Windows.Forms.Button ChangeLabel;
        private System.Windows.Forms.CheckBox checkList;
        private System.Windows.Forms.Label cmtNum;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.PictureBox cmtPic;
        private System.Windows.Forms.PictureBox desPic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel CardLabel;
    }
}