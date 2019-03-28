﻿using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CustomComponent
{
    public partial class ListActivity : ListBox
    {
        public ListActivity()
        {
            InitializeComponent();
            DrawMode = DrawMode.OwnerDrawFixed;

            ItemHeight = 60;          

            this.Width = 300;
            this.Height = 600;

            this.Top = 37;
            this.Left = 800;
        }

        public ListActivity(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            const TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;

            if (e.Index >= 0)
            {
                e.DrawBackground();
                e.Graphics.DrawRectangle(System.Drawing.Pens.Red, 2, e.Bounds.Y + 2, 50, 50); // Simulate an icon.
                Image icon = Image.FromFile("D:\\IT\\2019\\Bảo trì\\Project-Manager\\ProjectManager\\GUI\\src\\message.png");
                e.Graphics.DrawImage(icon, new Rectangle(2, e.Bounds.Y, 50, 50));

                var textRect = e.Bounds;
                textRect.X += 60;
                textRect.Width -= 60;
                textRect.Height = 40;
                string itemText = DesignMode ? "ListActivity" : Items[e.Index].ToString();

                Font font = new Font("Times New Roman", 12.0f,FontStyle.Italic);
              
                TextRenderer.DrawText(e.Graphics, itemText,font, textRect, e.ForeColor, TextFormatFlags.WordBreak);

                var textTime = new Rectangle(textRect.X, textRect.Y+30, e.Bounds.Width-60, 20);
                ActivityDTO activity = Items[e.Index] as ActivityDTO;
                string timeText = (activity.TimeCreate).ToString();
                TextRenderer.DrawText(e.Graphics, timeText, e.Font, textTime, e.ForeColor, flags);
                e.DrawFocusRectangle();
            }
        }
    }
}
