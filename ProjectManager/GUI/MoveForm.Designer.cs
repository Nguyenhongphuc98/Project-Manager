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
            this.positionBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.listBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.boardBtn.Location = new System.Drawing.Point(15, 35);
            this.boardBtn.Margin = new System.Windows.Forms.Padding(6);
            this.boardBtn.Name = "boardBtn";
            this.boardBtn.Size = new System.Drawing.Size(336, 79);
            this.boardBtn.TabIndex = 0;
            // 
            // positionBtn
            // 
            this.positionBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.positionBtn.color = System.Drawing.Color.SeaGreen;
            this.positionBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.positionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.positionBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.positionBtn.ForeColor = System.Drawing.Color.White;
            this.positionBtn.Image = null;
            this.positionBtn.ImagePosition = 20;
            this.positionBtn.ImageZoom = 50;
            this.positionBtn.LabelPosition = 41;
            this.positionBtn.LabelText = "Position";
            this.positionBtn.Location = new System.Drawing.Point(241, 151);
            this.positionBtn.Margin = new System.Windows.Forms.Padding(6);
            this.positionBtn.Name = "positionBtn";
            this.positionBtn.Size = new System.Drawing.Size(110, 79);
            this.positionBtn.TabIndex = 1;
            this.positionBtn.Click += new System.EventHandler(this.positionBtn_Click);
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
            this.listBtn.Location = new System.Drawing.Point(15, 151);
            this.listBtn.Margin = new System.Windows.Forms.Padding(6);
            this.listBtn.Name = "listBtn";
            this.listBtn.Size = new System.Drawing.Size(214, 79);
            this.listBtn.TabIndex = 2;
            this.listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Board";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "List";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 150);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // MoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 243);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBtn);
            this.Controls.Add(this.positionBtn);
            this.Controls.Add(this.boardBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MoveForm";
            this.Text = "MoveForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoveForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton boardBtn;
        private Bunifu.Framework.UI.BunifuTileButton positionBtn;
        private Bunifu.Framework.UI.BunifuTileButton listBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}