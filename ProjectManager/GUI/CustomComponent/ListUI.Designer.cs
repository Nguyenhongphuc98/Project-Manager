namespace GUI.CustomComponent
{
    partial class ListUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListUI));
            this.pnLists = new System.Windows.Forms.FlowLayoutPanel();
            this.lbListName = new System.Windows.Forms.Label();
            this.btnNewCard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbTitleNewCard = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // pnLists
            // 
            this.pnLists.AutoScroll = true;
            this.pnLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.pnLists.Location = new System.Drawing.Point(5, 52);
            this.pnLists.Margin = new System.Windows.Forms.Padding(4);
            this.pnLists.Name = "pnLists";
            this.pnLists.Size = new System.Drawing.Size(345, 270);
            this.pnLists.TabIndex = 0;
            // 
            // lbListName
            // 
            this.lbListName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.lbListName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(57)))), ((int)(((byte)(77)))));
            this.lbListName.Location = new System.Drawing.Point(0, 0);
            this.lbListName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbListName.Name = "lbListName";
            this.lbListName.Size = new System.Drawing.Size(355, 48);
            this.lbListName.TabIndex = 1;
            this.lbListName.Text = "List name";
            this.lbListName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewCard
            // 
            this.btnNewCard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnNewCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewCard.BorderRadius = 5;
            this.btnNewCard.ButtonText = "Add another card";
            this.btnNewCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCard.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewCard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNewCard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewCard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNewCard.Iconimage")));
            this.btnNewCard.Iconimage_right = null;
            this.btnNewCard.Iconimage_right_Selected = null;
            this.btnNewCard.Iconimage_Selected = null;
            this.btnNewCard.IconMarginLeft = 0;
            this.btnNewCard.IconMarginRight = 0;
            this.btnNewCard.IconRightVisible = true;
            this.btnNewCard.IconRightZoom = 0D;
            this.btnNewCard.IconVisible = true;
            this.btnNewCard.IconZoom = 50D;
            this.btnNewCard.IsTab = false;
            this.btnNewCard.Location = new System.Drawing.Point(0, 368);
            this.btnNewCard.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewCard.Name = "btnNewCard";
            this.btnNewCard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btnNewCard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(85)))), ((int)(((byte)(23)))));
            this.btnNewCard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewCard.selected = false;
            this.btnNewCard.Size = new System.Drawing.Size(355, 48);
            this.btnNewCard.TabIndex = 2;
            this.btnNewCard.Text = "Add another card";
            this.btnNewCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCard.Textcolor = System.Drawing.Color.White;
            this.btnNewCard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCard.Click += new System.EventHandler(this.btnNewCard_Click);
            // 
            // tbTitleNewCard
            // 
            this.tbTitleNewCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitleNewCard.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTitleNewCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitleNewCard.HintForeColor = System.Drawing.Color.Empty;
            this.tbTitleNewCard.HintText = "Enter a title for this card";
            this.tbTitleNewCard.isPassword = false;
            this.tbTitleNewCard.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTitleNewCard.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTitleNewCard.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTitleNewCard.LineThickness = 3;
            this.tbTitleNewCard.Location = new System.Drawing.Point(0, 318);
            this.tbTitleNewCard.Margin = new System.Windows.Forms.Padding(5);
            this.tbTitleNewCard.Name = "tbTitleNewCard";
            this.tbTitleNewCard.Size = new System.Drawing.Size(355, 49);
            this.tbTitleNewCard.TabIndex = 3;
            this.tbTitleNewCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(85)))), ((int)(((byte)(23)))));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 5;
            this.btnClose.ButtonText = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 0;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 60D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(136, 373);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(85)))), ((int)(((byte)(23)))));
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(85)))), ((int)(((byte)(23)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(79)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 5;
            this.btnSave.ButtonText = "Add Card";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 30D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(7, 373);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(189)))), ((int)(((byte)(79)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add Card";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ListUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbTitleNewCard);
            this.Controls.Add(this.btnNewCard);
            this.Controls.Add(this.lbListName);
            this.Controls.Add(this.pnLists);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListUI";
            this.Size = new System.Drawing.Size(355, 416);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnLists;
        private System.Windows.Forms.Label lbListName;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewCard;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTitleNewCard;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
    }
}
