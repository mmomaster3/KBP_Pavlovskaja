using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen newPen = new Pen(Color.Red);
            Graphics formG = CreateGraphics();


            int sin;
            for (int i = 0; i < 10; i++)
            {
                sin = (int) Math.Sin(i);
                formG.DrawLine(newPen, 50, 300, sin, i);
            }
        }
    }
}
