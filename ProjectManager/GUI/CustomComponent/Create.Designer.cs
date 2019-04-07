namespace GUI.CustomComponent
{
    partial class Create
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lb_ = new System.Windows.Forms.Label();
            this.pnCreateBoard = new System.Windows.Forms.Panel();
            this.lbCreateBoard = new System.Windows.Forms.Label();
            this.lbDesCreateBoard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDesCreateTeam = new System.Windows.Forms.Label();
            this.lbCreateTeam = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDesAddMem = new System.Windows.Forms.Label();
            this.lbAddMem = new System.Windows.Forms.Label();
            this.pnCreateBoard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(265, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Create";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_
            // 
            this.lb_.AutoSize = true;
            this.lb_.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_.Location = new System.Drawing.Point(1, 24);
            this.lb_.Name = "lb_";
            this.lb_.Size = new System.Drawing.Size(265, 13);
            this.lb_.TabIndex = 1;
            this.lb_.Text = "___________________________________________";
            // 
            // pnCreateBoard
            // 
            this.pnCreateBoard.Controls.Add(this.lbDesCreateBoard);
            this.pnCreateBoard.Controls.Add(this.lbCreateBoard);
            this.pnCreateBoard.Location = new System.Drawing.Point(4, 40);
            this.pnCreateBoard.Name = "pnCreateBoard";
            this.pnCreateBoard.Size = new System.Drawing.Size(258, 77);
            this.pnCreateBoard.TabIndex = 2;
            this.pnCreateBoard.MouseHover += new System.EventHandler(this.pnCreateBoard_MouseHover);
            // 
            // lbCreateBoard
            // 
            this.lbCreateBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCreateBoard.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lbCreateBoard.Location = new System.Drawing.Point(0, 0);
            this.lbCreateBoard.Name = "lbCreateBoard";
            this.lbCreateBoard.Size = new System.Drawing.Size(258, 23);
            this.lbCreateBoard.TabIndex = 0;
            this.lbCreateBoard.Text = "Create Board";
            this.lbCreateBoard.MouseLeave += new System.EventHandler(this.lbCreateBoard_MouseLeave);
            this.lbCreateBoard.MouseHover += new System.EventHandler(this.lbCreateBoard_MouseHover);
            // 
            // lbDesCreateBoard
            // 
            this.lbDesCreateBoard.AllowDrop = true;
            this.lbDesCreateBoard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDesCreateBoard.ForeColor = System.Drawing.Color.Gray;
            this.lbDesCreateBoard.Location = new System.Drawing.Point(0, 23);
            this.lbDesCreateBoard.Name = "lbDesCreateBoard";
            this.lbDesCreateBoard.Size = new System.Drawing.Size(258, 54);
            this.lbDesCreateBoard.TabIndex = 1;
            this.lbDesCreateBoard.Text = "A board is made up of cards ordered on lists. Use it to manage projects, track in" +
    "formation, or organize anything.";
            this.lbDesCreateBoard.MouseLeave += new System.EventHandler(this.lbDesCreateBoard_MouseLeave);
            this.lbDesCreateBoard.MouseHover += new System.EventHandler(this.lbDesCreateBoard_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDesCreateTeam);
            this.panel2.Controls.Add(this.lbCreateTeam);
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 69);
            this.panel2.TabIndex = 2;
            // 
            // lbDesCreateTeam
            // 
            this.lbDesCreateTeam.AllowDrop = true;
            this.lbDesCreateTeam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDesCreateTeam.ForeColor = System.Drawing.Color.Gray;
            this.lbDesCreateTeam.Location = new System.Drawing.Point(0, 23);
            this.lbDesCreateTeam.Name = "lbDesCreateTeam";
            this.lbDesCreateTeam.Size = new System.Drawing.Size(258, 46);
            this.lbDesCreateTeam.TabIndex = 1;
            this.lbDesCreateTeam.Text = "A team is a group of boards and people. Use it to organize your company, side hus" +
    "tle, family, or friends.";
            this.lbDesCreateTeam.MouseLeave += new System.EventHandler(this.lbDesCreateTeam_MouseLeave);
            this.lbDesCreateTeam.MouseHover += new System.EventHandler(this.lbDesCreateTeam_MouseHover);
            // 
            // lbCreateTeam
            // 
            this.lbCreateTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCreateTeam.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lbCreateTeam.Location = new System.Drawing.Point(0, 0);
            this.lbCreateTeam.Name = "lbCreateTeam";
            this.lbCreateTeam.Size = new System.Drawing.Size(258, 23);
            this.lbCreateTeam.TabIndex = 0;
            this.lbCreateTeam.Text = "Create Team";
            this.lbCreateTeam.MouseLeave += new System.EventHandler(this.lbCreateTeam_MouseLeave);
            this.lbCreateTeam.MouseHover += new System.EventHandler(this.lbCreateTeam_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDesAddMem);
            this.panel3.Controls.Add(this.lbAddMem);
            this.panel3.Location = new System.Drawing.Point(0, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 59);
            this.panel3.TabIndex = 2;
            // 
            // lbDesAddMem
            // 
            this.lbDesAddMem.AllowDrop = true;
            this.lbDesAddMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbDesAddMem.ForeColor = System.Drawing.Color.Gray;
            this.lbDesAddMem.Location = new System.Drawing.Point(0, 23);
            this.lbDesAddMem.Name = "lbDesAddMem";
            this.lbDesAddMem.Size = new System.Drawing.Size(258, 36);
            this.lbDesAddMem.TabIndex = 1;
            this.lbDesAddMem.Text = "Add members to work together better";
            this.lbDesAddMem.MouseLeave += new System.EventHandler(this.lbDesAddMem_MouseLeave);
            this.lbDesAddMem.MouseHover += new System.EventHandler(this.lbDesAddMem_MouseHover);
            // 
            // lbAddMem
            // 
            this.lbAddMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAddMem.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lbAddMem.Location = new System.Drawing.Point(0, 0);
            this.lbAddMem.Name = "lbAddMem";
            this.lbAddMem.Size = new System.Drawing.Size(258, 23);
            this.lbAddMem.TabIndex = 0;
            this.lbAddMem.Text = "Add member";
            this.lbAddMem.MouseLeave += new System.EventHandler(this.lbAddMem_MouseLeave);
            this.lbAddMem.MouseHover += new System.EventHandler(this.lbAddMem_MouseHover);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnCreateBoard);
            this.Controls.Add(this.lb_);
            this.Controls.Add(this.lbTitle);
            this.Name = "Create";
            this.Size = new System.Drawing.Size(265, 277);
            this.pnCreateBoard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lb_;
        private System.Windows.Forms.Panel pnCreateBoard;
        private System.Windows.Forms.Label lbDesCreateBoard;
        private System.Windows.Forms.Label lbCreateBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDesCreateTeam;
        private System.Windows.Forms.Label lbCreateTeam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDesAddMem;
        private System.Windows.Forms.Label lbAddMem;
    }
}
