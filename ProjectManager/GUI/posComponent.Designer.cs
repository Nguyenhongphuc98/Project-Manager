namespace GUI
{
    partial class posComponent
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
            this.pos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pos
            // 
            this.pos.AutoSize = true;
            this.pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos.Location = new System.Drawing.Point(3, 12);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(53, 20);
            this.pos.TabIndex = 0;
            this.pos.Text = "label1";
            // 
            // posComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.pos);
            this.Name = "posComponent";
            this.Size = new System.Drawing.Size(63, 49);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.posComponent_MouseClick);
            this.MouseEnter += new System.EventHandler(this.posComponent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.posComponent_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pos;
    }
}
