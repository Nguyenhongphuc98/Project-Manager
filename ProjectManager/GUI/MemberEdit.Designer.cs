namespace GUI
{
    partial class MemberEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberEdit));
            this.flpMember = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CancelButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // flpMember
            // 
            this.flpMember.Location = new System.Drawing.Point(13, 40);
            this.flpMember.Name = "flpMember";
            this.flpMember.Size = new System.Drawing.Size(192, 170);
            this.flpMember.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.ActiveBorderThickness = 1;
            this.SaveButton.ActiveCornerRadius = 20;
            this.SaveButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.ActiveForecolor = System.Drawing.Color.White;
            this.SaveButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.ButtonText = "Lưu";
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleBorderThickness = 1;
            this.SaveButton.IdleCornerRadius = 20;
            this.SaveButton.IdleFillColor = System.Drawing.Color.White;
            this.SaveButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveButton.Location = new System.Drawing.Point(73, 218);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(69, 36);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.ActiveBorderThickness = 1;
            this.CancelButton.ActiveCornerRadius = 20;
            this.CancelButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CancelButton.ActiveForecolor = System.Drawing.Color.White;
            this.CancelButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.ButtonText = "Hủy";
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.CancelButton.IdleBorderThickness = 1;
            this.CancelButton.IdleCornerRadius = 20;
            this.CancelButton.IdleFillColor = System.Drawing.Color.White;
            this.CancelButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.CancelButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.CancelButton.Location = new System.Drawing.Point(73, 252);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(69, 36);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MemberEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 293);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.flpMember);
            this.Controls.Add(this.textBox1);
            this.Name = "MemberEdit";
            this.Text = "MemberEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMember;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveButton;
        private Bunifu.Framework.UI.BunifuThinButton2 CancelButton;
    }
}