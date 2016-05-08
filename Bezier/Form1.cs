using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int x;
        public static int y;

        int n = 7;

        static Point start = new Point(100, 100); //100 //100
        static Point control1 = new Point(200, 100); // 200 100
        static Point control2 = new Point(350, 50); // 350 50
        static Point end1 = new Point(500, 100); //(500, 100);
        static Point control3 = new Point(600, 150); //(600, 150);
        static Point control4 = new Point(650, 250);//(650, 250);
        static Point end2 = new Point(500, 300);//

        public Point[] bezierPoints = new Point[] { start, control1, control2, end1, control3, control4, end2 };

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen penBezier = new Pen(Color.Red, 5);
            Pen penEllipse = new Pen(Color.Black);

            if (n != 7)
            {
                bezierPoints[n] = new Point(x, y);
                e.Graphics.DrawEllipse(penEllipse, bezierPoints[n].X, bezierPoints[n].Y - 5, 7, 7);
            }

            PictureBox p = sender as PictureBox;

            e.Graphics.DrawBeziers(penBezier, bezierPoints);

            e.Graphics.DrawEllipse(penEllipse, start.X, start.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, control1.X, control1.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, control2.X, control2.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, end1.X, end1.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, control3.X, control3.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, control4.X, control4.Y - 5, 7, 7);
            e.Graphics.DrawEllipse(penEllipse, end2.X, end2.Y - 5, 7, 7);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            label1.Text = x.ToString();
            label2.Text = y.ToString();

            if (n != 7)
            {
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            if (((bezierPoints[0].X - 5 <= x) && (x <= bezierPoints[0].X + 5)) && ((bezierPoints[0].Y - 5 <= y) && (y <= bezierPoints[0].Y + 5)))
                n = 0;
            if (((bezierPoints[1].X - 5 <= x) && (x <= bezierPoints[1].X + 5)) && ((bezierPoints[1].Y - 5 <= y) && (y <= bezierPoints[1].Y + 5)))
                n = 1;
            if (((bezierPoints[2].X - 5 <= x) && (x <= bezierPoints[2].X + 5)) && ((bezierPoints[2].Y - 5 <= y) && (y <= bezierPoints[2].Y + 5)))
                n = 2;
            if (((bezierPoints[3].X - 5 <= x) && (x <= bezierPoints[3].X + 5)) && ((bezierPoints[3].Y - 5 <= y) && (y <= bezierPoints[3].Y + 5)))
                n = 3;
            if (((bezierPoints[4].X - 5 <= x) && (x <= bezierPoints[4].X + 5)) && ((bezierPoints[4].Y - 5 <= y) && (y <= bezierPoints[4].Y + 5)))
                n = 4;
            if (((bezierPoints[5].X - 5 <= x) && (x <= bezierPoints[5].X + 5)) && ((bezierPoints[5].Y - 5 <= y) && (y <= bezierPoints[5].Y + 5)))
                n = 5;
            if (((bezierPoints[6].X - 5 <= x) && (x <= bezierPoints[6].X + 5)) && ((bezierPoints[6].Y - 5 <= y) && (y <= bezierPoints[6].Y + 5)))
                n = 6;


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            n = 7;
        }
    }
}