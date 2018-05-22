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
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            curposX = e.Location.X;
            curposY = e.Location.Y;
            button1.Location = new Point(curposX + button1.Size.Width/2, curposY - button1.Size.Height);
            button2.Location = new Point(curposX - button1.Size.Width, curposY - button1.Size.Height);
            button3.Location = new Point(curposX - button1.Size.Width, curposY + button1.Size.Height/2);
            button4.Location = new Point(curposX + button1.Size.Width / 2, curposY + button1.Size.Height/2);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            button1.Location = new Point()
        }
    }
}
