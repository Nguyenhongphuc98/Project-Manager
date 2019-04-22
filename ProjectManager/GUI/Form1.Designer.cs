namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbuserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.tbPassWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbuserName
            // 
            this.tbuserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbuserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbuserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbuserName.HintForeColor = System.Drawing.Color.Empty;
            this.tbuserName.HintText = "User name";
            this.tbuserName.isPassword = false;
            this.tbuserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.tbuserName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbuserName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.tbuserName.LineThickness = 2;
            this.tbuserName.Location = new System.Drawing.Point(342, 75);
            this.tbuserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbuserName.Name = "tbuserName";
            this.tbuserName.Size = new System.Drawing.Size(278, 44);
            this.tbuserName.TabIndex = 0;
            this.tbuserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Font = new System.Drawing.Font("Minion Web", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 0D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(475, 198);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(84)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(145, 43);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Minion Web", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogin.BackgroundImage")));
            this.pbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogin.Location = new System.Drawing.Point(0, 0);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(321, 371);
            this.pbLogin.TabIndex = 2;
            this.pbLogin.TabStop = false;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPassWord.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassWord.HintText = "PassWord";
            this.tbPassWord.isPassword = true;
            this.tbPassWord.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.tbPassWord.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPassWord.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.tbPassWord.LineThickness = 2;
            this.tbPassWord.Location = new System.Drawing.Point(342, 127);
            this.tbPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(278, 44);
            this.tbPassWord.TabIndex = 1;
            this.tbPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassWord.OnValueChanged += new System.EventHandler(this.tbPassWord_OnValueChanged);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(430, 279);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(100, 15);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "Đăng nhập thất bại";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.Location = new System.Drawing.Point(572, 346);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(59, 16);
            this.lbRegister.TabIndex = 3;
            this.lbRegister.Text = "Register";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderRadius = 0;
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
            this.btnClose.IconZoom = 70D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(611, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(59)))), ((int)(((byte)(0)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Textcolor = System.Drawing.Color.White;
            this.btnClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 371);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pbLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbuserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbuserName;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.PictureBox pbLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassWord;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbRegister;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
    }
}

