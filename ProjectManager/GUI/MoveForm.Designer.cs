namespace GUI
{
    partial class MoveForm
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
            this.boardBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.listBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // boardBtn
            // 
            this.boardBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.boardBtn.color = System.Drawing.Color.SeaGreen;
            this.boardBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.boardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.boardBtn.ForeColor = System.Drawing.Color.White;
            this.boardBtn.Image = null;
            this.boardBtn.ImagePosition = 20;
            this.boardBtn.ImageZoom = 50;
            this.boardBtn.LabelPosition = 41;
            this.boardBtn.LabelText = "Board";
            this.boardBtn.Location = new System.Drawing.Point(11, 28);
            this.boardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boardBtn.Name = "boardBtn";
            this.boardBtn.Size = new System.Drawing.Size(263, 64);
            this.boardBtn.TabIndex = 0;
            // 
            // listBtn
            // 
            this.listBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.listBtn.color = System.Drawing.Color.SeaGreen;
            this.listBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.listBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.listBtn.ForeColor = System.Drawing.Color.White;
            this.listBtn.Image = null;
            this.listBtn.ImagePosition = 20;
            this.listBtn.ImageZoom = 50;
            this.listBtn.LabelPosition = 41;
            this.listBtn.LabelText = "List";
            this.listBtn.Location = new System.Drawing.Point(11, 123);
            this.listBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(263, 64);
            this.listBtn.TabIndex = 2;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Board";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "List";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 206);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(251, 109);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 197);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.boardBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoveForm";
            this.Text = "MoveForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoveForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton boardBtn;
        private Bunifu.Framework.UI.BunifuTileButton listBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}