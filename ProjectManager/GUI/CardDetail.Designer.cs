namespace GUI
{
    partial class CardDetail
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
            this.CardName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.List = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addTask = new System.Windows.Forms.Button();
            this.panelTasks = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddMem = new System.Windows.Forms.Button();
            this.EditLabel = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DueDate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardName
            // 
            this.CardName.Location = new System.Drawing.Point(13, 13);
            this.CardName.Name = "CardName";
            this.CardName.Size = new System.Drawing.Size(491, 22);
            this.CardName.TabIndex = 0;
            this.CardName.Text = "Card name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "trong danh sách";
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(129, 38);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(30, 17);
            this.List.TabIndex = 2;
            this.List.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thành viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhãn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày hết hạn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(249, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "hết hạn lúc";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(147, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 21);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Circle_icon;
            this.pictureBox1.Location = new System.Drawing.Point(16, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mô tả:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 190);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(324, 48);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Thêm mô tả...";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(15, 268);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 21);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Việc cần làm";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 296);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(324, 10);
            this.progressBar1.TabIndex = 16;
            // 
            // addTask
            // 
            this.addTask.Location = new System.Drawing.Point(15, 341);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(87, 29);
            this.addTask.TabIndex = 17;
            this.addTask.Text = "Thêm việc";
            this.addTask.UseVisualStyleBackColor = true;
            // 
            // panelTasks
            // 
            this.panelTasks.Location = new System.Drawing.Point(15, 312);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(324, 23);
            this.panelTasks.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thêm bình luận";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 417);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 49);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "Thêm bình luận...";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 472);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 29);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Lưu";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddMem
            // 
            this.AddMem.Location = new System.Drawing.Point(391, 68);
            this.AddMem.Name = "AddMem";
            this.AddMem.Size = new System.Drawing.Size(113, 38);
            this.AddMem.TabIndex = 22;
            this.AddMem.Text = "Thành viên";
            this.AddMem.UseVisualStyleBackColor = true;
            this.AddMem.Click += new System.EventHandler(this.AddMem_Click);
            // 
            // EditLabel
            // 
            this.EditLabel.Location = new System.Drawing.Point(391, 112);
            this.EditLabel.Name = "EditLabel";
            this.EditLabel.Size = new System.Drawing.Size(113, 38);
            this.EditLabel.TabIndex = 23;
            this.EditLabel.Text = "Nhãn";
            this.EditLabel.UseVisualStyleBackColor = true;
            this.EditLabel.Click += new System.EventHandler(this.EditLabel_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(391, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 38);
            this.button4.TabIndex = 24;
            this.button4.Text = "Việc cần làm";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(391, 200);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(113, 38);
            this.DueDate.TabIndex = 25;
            this.DueDate.Text = "Ngày hết hạn";
            this.DueDate.UseVisualStyleBackColor = true;
            this.DueDate.Click += new System.EventHandler(this.DueDate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Thêm vào thẻ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Thao tác";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(391, 341);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 21);
            this.checkBox3.TabIndex = 29;
            this.checkBox3.Text = "Theo dõi";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // CardDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 509);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EditLabel);
            this.Controls.Add(this.AddMem);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelTasks);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardName);
            this.Name = "CardDetail";
            this.Text = "CardDetail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Panel panelTasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AddMem;
        private System.Windows.Forms.Button EditLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}