namespace GUI.CustomComponent
{
    partial class BoardNoInfor
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
            this.lbCreateBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCreateBoard
            // 
            this.lbCreateBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCreateBoard.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateBoard.ForeColor = System.Drawing.Color.White;
            this.lbCreateBoard.Location = new System.Drawing.Point(0, 0);
            this.lbCreateBoard.Name = "lbCreateBoard";
            this.lbCreateBoard.Size = new System.Drawing.Size(237, 125);
            this.lbCreateBoard.TabIndex = 0;
            this.lbCreateBoard.Text = "Create new board ...";
            this.lbCreateBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCreateBoard.Click += new System.EventHandler(this.lbCreateBoard_Click);
            this.lbCreateBoard.MouseEnter += new System.EventHandler(this.lbCreateBoard_MouseEnter);
            this.lbCreateBoard.MouseLeave += new System.EventHandler(this.lbCreateBoard_MouseLeave);
            // 
            // BoardNoInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(153)))), ((int)(((byte)(2)))));
            this.Controls.Add(this.lbCreateBoard);
            this.Name = "BoardNoInfor";
            this.Size = new System.Drawing.Size(237, 125);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCreateBoard;
    }
}
