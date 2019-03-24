﻿namespace GUI
{
    partial class ListSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSpace));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbNameProject = new System.Windows.Forms.Label();
            this.btnStar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPersonal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPublic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbdash1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvite = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.lbdash1);
            this.pnMenu.Controls.Add(this.btnInvite);
            this.pnMenu.Controls.Add(this.btnPublic);
            this.pnMenu.Controls.Add(this.btnPersonal);
            this.pnMenu.Controls.Add(this.btnStar);
            this.pnMenu.Controls.Add(this.lbNameProject);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1200, 40);
            this.pnMenu.TabIndex = 0;
            // 
            // lbNameProject
            // 
            this.lbNameProject.AutoSize = true;
            this.lbNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameProject.Location = new System.Drawing.Point(16, 7);
            this.lbNameProject.Name = "lbNameProject";
            this.lbNameProject.Size = new System.Drawing.Size(185, 25);
            this.lbNameProject.TabIndex = 0;
            this.lbNameProject.Text = "Dự án đường sắt";
            // 
            // btnStar
            // 
            this.btnStar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStar.BackColor = System.Drawing.Color.Transparent;
            this.btnStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStar.BorderRadius = 7;
            this.btnStar.ButtonText = "";
            this.btnStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStar.DisabledColor = System.Drawing.Color.Gray;
            this.btnStar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStar.Iconimage")));
            this.btnStar.Iconimage_right = null;
            this.btnStar.Iconimage_right_Selected = null;
            this.btnStar.Iconimage_Selected = null;
            this.btnStar.IconMarginLeft = 0;
            this.btnStar.IconMarginRight = 0;
            this.btnStar.IconRightVisible = true;
            this.btnStar.IconRightZoom = 0D;
            this.btnStar.IconVisible = true;
            this.btnStar.IconZoom = 30D;
            this.btnStar.IsTab = false;
            this.btnStar.Location = new System.Drawing.Point(207, 2);
            this.btnStar.Name = "btnStar";
            this.btnStar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnStar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(157)))), ((int)(((byte)(180)))));
            this.btnStar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStar.selected = false;
            this.btnStar.Size = new System.Drawing.Size(33, 33);
            this.btnStar.TabIndex = 1;
            this.btnStar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStar.Textcolor = System.Drawing.Color.White;
            this.btnStar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPersonal
            // 
            this.btnPersonal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonal.BorderRadius = 7;
            this.btnPersonal.ButtonText = "Personal";
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.DisabledColor = System.Drawing.Color.Gray;
            this.btnPersonal.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPersonal.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPersonal.Iconimage")));
            this.btnPersonal.Iconimage_right = null;
            this.btnPersonal.Iconimage_right_Selected = null;
            this.btnPersonal.Iconimage_Selected = null;
            this.btnPersonal.IconMarginLeft = 0;
            this.btnPersonal.IconMarginRight = 0;
            this.btnPersonal.IconRightVisible = true;
            this.btnPersonal.IconRightZoom = 0D;
            this.btnPersonal.IconVisible = false;
            this.btnPersonal.IconZoom = 60D;
            this.btnPersonal.IsTab = false;
            this.btnPersonal.Location = new System.Drawing.Point(248, 3);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPersonal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(157)))), ((int)(((byte)(180)))));
            this.btnPersonal.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPersonal.selected = false;
            this.btnPersonal.Size = new System.Drawing.Size(72, 33);
            this.btnPersonal.TabIndex = 1;
            this.btnPersonal.Text = "Personal";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPersonal.Textcolor = System.Drawing.Color.White;
            this.btnPersonal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPublic
            // 
            this.btnPublic.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPublic.BackColor = System.Drawing.Color.Transparent;
            this.btnPublic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPublic.BorderRadius = 7;
            this.btnPublic.ButtonText = "Public";
            this.btnPublic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublic.DisabledColor = System.Drawing.Color.Gray;
            this.btnPublic.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPublic.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPublic.Iconimage")));
            this.btnPublic.Iconimage_right = null;
            this.btnPublic.Iconimage_right_Selected = null;
            this.btnPublic.Iconimage_Selected = null;
            this.btnPublic.IconMarginLeft = 0;
            this.btnPublic.IconMarginRight = 0;
            this.btnPublic.IconRightVisible = true;
            this.btnPublic.IconRightZoom = 0D;
            this.btnPublic.IconVisible = false;
            this.btnPublic.IconZoom = 60D;
            this.btnPublic.IsTab = false;
            this.btnPublic.Location = new System.Drawing.Point(345, 4);
            this.btnPublic.Name = "btnPublic";
            this.btnPublic.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPublic.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(157)))), ((int)(((byte)(180)))));
            this.btnPublic.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPublic.selected = false;
            this.btnPublic.Size = new System.Drawing.Size(58, 33);
            this.btnPublic.TabIndex = 1;
            this.btnPublic.Text = "Public";
            this.btnPublic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPublic.Textcolor = System.Drawing.Color.White;
            this.btnPublic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lbdash1
            // 
            this.lbdash1.AutoSize = true;
            this.lbdash1.Location = new System.Drawing.Point(238, 12);
            this.lbdash1.Name = "lbdash1";
            this.lbdash1.Size = new System.Drawing.Size(9, 13);
            this.lbdash1.TabIndex = 1;
            this.lbdash1.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "|";
            // 
            // btnInvite
            // 
            this.btnInvite.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInvite.BackColor = System.Drawing.Color.Transparent;
            this.btnInvite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvite.BorderRadius = 7;
            this.btnInvite.ButtonText = "Invite";
            this.btnInvite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvite.DisabledColor = System.Drawing.Color.Gray;
            this.btnInvite.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInvite.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInvite.Iconimage")));
            this.btnInvite.Iconimage_right = null;
            this.btnInvite.Iconimage_right_Selected = null;
            this.btnInvite.Iconimage_Selected = null;
            this.btnInvite.IconMarginLeft = 0;
            this.btnInvite.IconMarginRight = 0;
            this.btnInvite.IconRightVisible = true;
            this.btnInvite.IconRightZoom = 0D;
            this.btnInvite.IconVisible = false;
            this.btnInvite.IconZoom = 60D;
            this.btnInvite.IsTab = false;
            this.btnInvite.Location = new System.Drawing.Point(422, 4);
            this.btnInvite.Name = "btnInvite";
            this.btnInvite.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInvite.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(157)))), ((int)(((byte)(180)))));
            this.btnInvite.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInvite.selected = false;
            this.btnInvite.Size = new System.Drawing.Size(61, 33);
            this.btnInvite.TabIndex = 1;
            this.btnInvite.Text = "Invite";
            this.btnInvite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInvite.Textcolor = System.Drawing.Color.White;
            this.btnInvite.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ListSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 520);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListSpace";
            this.Text = "ListSpace";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label lbNameProject;
        private Bunifu.Framework.UI.BunifuFlatButton btnStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbdash1;
        private Bunifu.Framework.UI.BunifuFlatButton btnInvite;
        private Bunifu.Framework.UI.BunifuFlatButton btnPublic;
        private Bunifu.Framework.UI.BunifuFlatButton btnPersonal;
    }
}