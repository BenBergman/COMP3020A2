using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assign2Part2a
{
    public partial class Form1 : Form
    {
        String input = "";
        int width;
        int height;
        int sizeDir = 1;

        public Form1()
        {
            InitializeComponent();
            width = 200;
            height = 200;
            this.Size = new System.Drawing.Size(width, height);

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            //MessageBox.Show("Form.KeyPress: '" + e.KeyChar.ToString() + "' pressed.");
            if (input == "")
            {
                if (e.KeyChar == '+' || e.KeyChar == '-')
                {
                    //MessageBox.Show("Form.KeyPress: '" + e.KeyChar.ToString() + "' pressed.");
                    input = e.KeyChar.ToString();
                    if (e.KeyChar == '+')
                    {
                        sizeDir = 1;
                    }
                    else
                    {
                        sizeDir = -1;
                    }
                }
                else if (e.KeyChar == 'r')
                {
                    //reset window size
                    //MessageBox.Show("Reset window");
                    width = 200;
                    height = 200;
                    this.Size = new System.Drawing.Size(width, height);
                }
            }
            else
            {
                if (e.KeyChar == 'h' || e.KeyChar == 'w')
                {
                    //perform resize
                    //MessageBox.Show("Command: " + input + e.KeyChar.ToString() );

                    if (e.KeyChar == 'h')
                    {
                        height += sizeDir * 2;
                    }
                    else
                    {
                        width += sizeDir * 2;
                    }
                    this.Size = new System.Drawing.Size(width, height);
                }
                input = "";
            }
        }
    }
}
