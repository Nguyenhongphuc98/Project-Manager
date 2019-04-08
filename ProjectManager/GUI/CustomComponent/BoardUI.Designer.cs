namespace GUI.CustomComponent
{
    partial class BoardUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardUI));
            this.lbNameBoard = new System.Windows.Forms.Label();
            this.pbStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNameBoard
            // 
            this.lbNameBoard.BackColor = System.Drawing.Color.Transparent;
            this.lbNameBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNameBoard.Font = new System.Drawing.Font("Minion Web", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameBoard.ForeColor = System.Drawing.Color.White;
            this.lbNameBoard.Location = new System.Drawing.Point(0, 0);
            this.lbNameBoard.Name = "lbNameBoard";
            this.lbNameBoard.Size = new System.Drawing.Size(237, 43);
            this.lbNameBoard.TabIndex = 0;
            this.lbNameBoard.Text = "Name of project";
            this.lbNameBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbStar
            // 
            this.pbStar.BackColor = System.Drawing.Color.Transparent;
            this.pbStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbStar.BackgroundImage")));
            this.pbStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbStar.Location = new System.Drawing.Point(206, 103);
            this.pbStar.Name = "pbStar";
            this.pbStar.Size = new System.Drawing.Size(19, 19);
            this.pbStar.TabIndex = 1;
            this.pbStar.TabStop = false;
            // 
            // BoardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbStar);
            this.Controls.Add(this.lbNameBoard);
            this.Name = "BoardUI";
            this.Size = new System.Drawing.Size(237, 125);
            this.MouseLeave += new System.EventHandler(this.BoardUI_MouseLeave);
            this.MouseHover += new System.EventHandler(this.BoardUI_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNameBoard;
        private System.Windows.Forms.PictureBox pbStar;
    }
}
