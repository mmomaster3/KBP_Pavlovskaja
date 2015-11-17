using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Classes
{
    class TriangleExeption : Exception
    {
        public TriangleExeption(String message)
        {
            _Message = message;
        }

        private String _Message;

        public override string ToString()
        {
            return _Message;
        }
    }
    class Triangle
    {
        //public Triangle(double a, double b, double c)
        public Triangle( double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new TriangleExeption("Стороны отрицательные!");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new TriangleExeption("Одна из сторон больше двух других!");
          //  this.a = a;
            this.b = b;
            this.c = c;
        }
       public Triangle ()
        {
            a = 5;
            b = 4;
            c = 3;   
        }
        public double C {
            get { return c; }
            set
            {
                c = value;
            }
            
        }
        public double B { get; set; }
        public double A { get { return a; } set {if (value<=0)  throw new TriangleExeption("Стороны отрицательные!"); else a=value; } }
        private double a, b, c = 0;

        public double Perim()
        { return a + b+ c; }

        public double Area()
        {
            double p = Perim() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Median()
        { return (2 * (a * a) + 2 * (b * b) - (c * c)) / 2; }

        public override string ToString()
        {
            string triangleInfo = "Треугольник со сторонами " + a
                + ", " + b+ " и " + c;

            return triangleInfo;
        }
        //metanit.com
    }

    class tr2 : Triangle
    {public tr2():base(){}
    }
}
