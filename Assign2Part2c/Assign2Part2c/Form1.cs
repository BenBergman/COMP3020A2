using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assign2Part2c
{
    public partial class Form1 : Form
    {
        Graphics surface;
        Pen pen1 = new Pen(Color.Black, 1.0f);
        public int x = -1, y = -1;

        public Form1()
        {
            InitializeComponent();
            surface = this.CreateGraphics();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (true/*e.Button == MouseButtons.Left*/)
            {
                x = e.X;
                y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int x2 = e.X, y2 = e.Y, temp;
            if (x != -1 && y != -1 /*&& e.Button == MouseButtons.Left*/)
            {

                if (x2 < x)
                {
                    temp = x2;
                    x2 = x;
                    x = temp;
                }
                if (y2 < y)
                {
                    temp = y2;
                    y2 = y;
                    y = temp;
                }

                Rectangle recOne = new Rectangle(x, y, x2 - x, y2 - y);
                surface.DrawRectangle(pen1, recOne);

                x = -1; y = -1;
            }
        }
    }
}
