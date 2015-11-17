using System.Drawing;

namespace Lab9_InheritanceForm
{
    class Point
    {
        protected int x;

        public Point(int x)
        {
            X = x;
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
               x = (x >= 0) ? value : 0;
            }
        }

        //public int Z
        //{
        //    get
        //    {
        //        return z;
        //    }
        //    set
        //    {
        //        z = value;
        //    }
        //}

        //public string Print()
        //{
        //    return string.Format("point({0}, {1})",x,z);
            
        //}
    }

    class ColorPoint : Point
    {
        public Color clr;

        //public ColorPoint(int X):base (X)
        //{
        //    X = 200;
        //}

        public ColorPoint(int X, Color c) : base(X)
        {
            clr = c;
        }
    }
}
