namespace GUI
{
    partial class LabelEdit
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
            this.PinkButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.OrangeButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PinkButton
            // 
            this.PinkButton.BackColor = System.Drawing.Color.Fuchsia;
            this.PinkButton.Location = new System.Drawing.Point(95, 74);
            this.PinkButton.Name = "PinkButton";
            this.PinkButton.Size = new System.Drawing.Size(41, 23);
            this.PinkButton.TabIndex = 11;
            this.PinkButton.UseVisualStyleBackColor = false;
            this.PinkButton.Click += new System.EventHandler(this.PinkButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(95, 45);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(41, 23);
            this.BlueButton.TabIndex = 10;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // OrangeButton
            // 
            this.OrangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeButton.Location = new System.Drawing.Point(95, 16);
            this.OrangeButton.Name = "OrangeButton";
            this.OrangeButton.Size = new System.Drawing.Size(41, 23);
            this.OrangeButton.TabIndex = 9;
            this.OrangeButton.UseVisualStyleBackColor = false;
            this.OrangeButton.Click += new System.EventHandler(this.OrangeButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.Lime;
            this.GreenButton.Location = new System.Drawing.Point(12, 74);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(41, 23);
            this.GreenButton.TabIndex = 8;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.BackColor = System.Drawing.Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(12, 45);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(41, 23);
            this.YellowButton.TabIndex = 7;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Red;
            this.RedButton.Location = new System.Drawing.Point(12, 16);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(41, 23);
            this.RedButton.TabIndex = 6;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // LabelEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 113);
            this.ControlBox = false;
            this.Controls.Add(this.PinkButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.OrangeButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.RedButton);
            this.Name = "LabelEdit";
            this.Text = "LabelEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PinkButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button OrangeButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button RedButton;
    }
}