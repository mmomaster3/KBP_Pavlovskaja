using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab9_InheritanceForm
{
    class Line : Point
    {
        protected int y;

        public Line(int x,int y) : base(y)
        {
            X = x;
            Y = y;
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
    }

    class ColorLine : Line
    {
        public Color clr;
        public ColorLine(int X, int Y, Color c):base(X, Y)
        {
            clr = c;
        }
    }
}
