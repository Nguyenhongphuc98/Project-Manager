namespace GUI
{
    partial class DateEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateEdit));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dueDateHour = new System.Windows.Forms.NumericUpDown();
            this.dueDateMin = new System.Windows.Forms.NumericUpDown();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateMin)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Due Time";
            // 
            // datePicker
            // 
            this.datePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.datePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.datePicker.BorderRadius = 0;
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(13, 13);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(343, 51);
            this.datePicker.TabIndex = 22;
            this.datePicker.Value = new System.DateTime(2019, 4, 8, 10, 8, 42, 116);
            // 
            // dueDateHour
            // 
            this.dueDateHour.Location = new System.Drawing.Point(135, 144);
            this.dueDateHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.dueDateHour.Name = "dueDateHour";
            this.dueDateHour.Size = new System.Drawing.Size(55, 22);
            this.dueDateHour.TabIndex = 23;
            // 
            // dueDateMin
            // 
            this.dueDateMin.Location = new System.Drawing.Point(216, 144);
            this.dueDateMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.dueDateMin.Name = "dueDateMin";
            this.dueDateMin.Size = new System.Drawing.Size(54, 22);
            this.dueDateMin.TabIndex = 24;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.Location = new System.Drawing.Point(46, 275);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(128, 41);
            this.SaveBtn.TabIndex = 25;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.ActiveBorderThickness = 1;
            this.CancelBtn.ActiveCornerRadius = 20;
            this.CancelBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.CancelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.CancelBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.CancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.ButtonText = "Cancel";
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.CancelBtn.IdleBorderThickness = 1;
            this.CancelBtn.IdleCornerRadius = 20;
            this.CancelBtn.IdleFillColor = System.Drawing.Color.White;
            this.CancelBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.CancelBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.CancelBtn.Location = new System.Drawing.Point(201, 275);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(121, 41);
            this.CancelBtn.TabIndex = 26;
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // DateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 330);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.dueDateMin);
            this.Controls.Add(this.dueDateHour);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "DateEdit";
            this.Text = "DateEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DateEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dueDateHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private System.Windows.Forms.NumericUpDown dueDateHour;
        private System.Windows.Forms.NumericUpDown dueDateMin;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 CancelBtn;
    }
}