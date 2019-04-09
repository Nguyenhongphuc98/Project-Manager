namespace GUI
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberName = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.PictureBox();
            this.cmtPicture = new System.Windows.Forms.PictureBox();
            this.desPicture = new System.Windows.Forms.PictureBox();
            this.datePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CardName = new System.Windows.Forms.TextBox();
            this.CardLabel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateCard = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmtPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.memberName);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(309, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 39);
            this.panel1.TabIndex = 17;
            // 
            // memberName
            // 
            this.memberName.AutoSize = true;
            this.memberName.BackColor = System.Drawing.Color.Transparent;
            this.memberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberName.Location = new System.Drawing.Point(11, 7);
            this.memberName.Name = "memberName";
            this.memberName.Size = new System.Drawing.Size(23, 25);
            this.memberName.TabIndex = 0;
            this.memberName.Text = "L";
            // 
            // editButton
            // 
            this.editButton.Image = ((System.Drawing.Image)(resources.GetObject("editButton.Image")));
            this.editButton.Location = new System.Drawing.Point(407, 2);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(28, 25);
            this.editButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editButton.TabIndex = 16;
            this.editButton.TabStop = false;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            this.editButton.MouseEnter += new System.EventHandler(this.editButton_MouseEnter);
            this.editButton.MouseLeave += new System.EventHandler(this.editButton_MouseLeave);
            // 
            // cmtPicture
            // 
            this.cmtPicture.Enabled = false;
            this.cmtPicture.Image = ((System.Drawing.Image)(resources.GetObject("cmtPicture.Image")));
            this.cmtPicture.Location = new System.Drawing.Point(3, 2);
            this.cmtPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmtPicture.Name = "cmtPicture";
            this.cmtPicture.Size = new System.Drawing.Size(29, 26);
            this.cmtPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmtPicture.TabIndex = 15;
            this.cmtPicture.TabStop = false;
            // 
            // desPicture
            // 
            this.desPicture.Enabled = false;
            this.desPicture.Image = ((System.Drawing.Image)(resources.GetObject("desPicture.Image")));
            this.desPicture.Location = new System.Drawing.Point(158, 2);
            this.desPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.desPicture.Name = "desPicture";
            this.desPicture.Size = new System.Drawing.Size(27, 25);
            this.desPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.desPicture.TabIndex = 14;
            this.desPicture.TabStop = false;
            // 
            // datePicture
            // 
            this.datePicture.Enabled = false;
            this.datePicture.Image = ((System.Drawing.Image)(resources.GetObject("datePicture.Image")));
            this.datePicture.Location = new System.Drawing.Point(3, 2);
            this.datePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePicture.Name = "datePicture";
            this.datePicture.Size = new System.Drawing.Size(29, 26);
            this.datePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.datePicture.TabIndex = 13;
            this.datePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(11, 18);
            this.CardName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(381, 22);
            this.CardName.TabIndex = 22;
            // 
            // CardLabel
            // 
            this.CardLabel.Location = new System.Drawing.Point(11, 4);
            this.CardLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(155, 10);
            this.CardLabel.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(253, 2);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "0/0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "0";
            // 
            // dateCard
            // 
            this.dateCard.AutoSize = true;
            this.dateCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCard.Location = new System.Drawing.Point(38, 0);
            this.dateCard.Name = "dateCard";
            this.dateCard.Size = new System.Drawing.Size(73, 20);
            this.dateCard.TabIndex = 18;
            this.dateCard.Text = "datetime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.desPicture);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 47);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.datePicture);
            this.flowLayoutPanel2.Controls.Add(this.dateCard);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(38, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 30);
            this.flowLayoutPanel2.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmtPicture);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(191, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 29);
            this.panel2.TabIndex = 25;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.CardName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CardLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(438, 182);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Card_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmtPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.PictureBox editButton;
        private System.Windows.Forms.PictureBox cmtPicture;
        private System.Windows.Forms.PictureBox desPicture;
        private System.Windows.Forms.PictureBox datePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.Panel CardLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
    }
}
