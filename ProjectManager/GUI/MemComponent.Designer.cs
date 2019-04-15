namespace GUI
{
    partial class MemComponent
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
            this.memTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memTxt
            // 
            this.memTxt.AutoSize = true;
            this.memTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memTxt.Location = new System.Drawing.Point(13, 10);
            this.memTxt.Name = "memTxt";
            this.memTxt.Size = new System.Drawing.Size(53, 20);
            this.memTxt.TabIndex = 0;
            this.memTxt.Text = "label1";
            // 
            // MemComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memTxt);
            this.Name = "MemComponent";
            this.Size = new System.Drawing.Size(223, 40);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MemComponent_MouseClick);
            this.MouseEnter += new System.EventHandler(this.MemComponent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MemComponent_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memTxt;
    }
}
