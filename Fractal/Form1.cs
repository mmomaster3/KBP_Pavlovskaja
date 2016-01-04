using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Fractal
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(Color.Red, 2);
            Graphics draw = CreateGraphics();
            for (;;)
            {
                draw.DrawLine(myPen, 100, i, 200, 200);
                i += 5;
                label1.Refresh();
                label1.Text = i.ToString();
                Thread.Sleep(5);
                
                if (i == 3000) { i = 0; break; }
            }
        }
    }
}
