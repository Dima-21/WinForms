using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {

        int curposX;
        int curposY;
        Point b1;
        Point b2;
        Point b3;
        Point b4;
        public Form1()
        {
            InitializeComponent();
            b1.X = 10; b1.Y = -10;
            b2.X = b2.Y = -10;
            b3.X = -10; b3.Y = 10;
            b4.X = b4.Y = 10;
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
            {
                curposX = e.Location.X;
                curposY = e.Location.Y;
                button1.Location = new Point(curposX + button1.Size.Width / 2, curposY - button1.Size.Height);
                button2.Location = new Point(curposX - button1.Size.Width, curposY - button1.Size.Height);
                button3.Location = new Point(curposX - button1.Size.Width, curposY + button1.Size.Height / 2);
                button4.Location = new Point(curposX + button1.Size.Width / 2, curposY + button1.Size.Height / 2);
            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(
               button1.Location.X + b1.X,
                button1.Location.Y + b1.Y);
            if (button1.Location.X > this.ClientSize.Width - button1.Size.Width)
               b1.X = -10;
            if (button1.Location.Y < 0)
                b1.Y = 10;
            if (button1.Location.X < curposX)
                b1.X = 10;
            if (button1.Location.Y > curposY - button1.Size.Height)
                b1.Y = -10;

            button2.Location = new Point(
               button2.Location.X + b2.X,
                button2.Location.Y + b2.Y);
            if (button2.Location.X < 0)
                b2.Y = b2.X = 10;
            if (button2.Location.Y < 0)
                b2.Y = 10;
            if (button2.Location.X > curposX - button2.Size.Width)
                b2.Y = b2.X = -10;
            if (button2.Location.Y > curposY - button2.Size.Height)
                b2.Y = -10;

            button3.Location = new Point(
               button3.Location.X + b3.X,
                button3.Location.Y + b3.Y);
            if (button3.Location.X < 0)
                b3.X = 10;
            if (button3.Location.Y < curposY)
                b3.Y = 10;
            if (button3.Location.X > curposX)
                b3.X = -10;
            if (button3.Location.Y > this.ClientSize.Height - button3.Height)
                b3.Y = -10;

            button4.Location = new Point(
               button4.Location.X + b4.X,
                button4.Location.Y + b4.Y);
            if (button4.Location.X < curposX)
                b4.X = 10;
            if (button4.Location.Y < curposY)
                b4.Y = 10;
            if (button4.Location.X > this.ClientSize.Width - button4.Width)
                b4.X = -10;
            if (button4.Location.Y > this.ClientSize.Height - button4.Height)
                b4.Y = -10;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                timer1.Enabled = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                timer1.Enabled = true;
            }
        }
    }
}
