using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Classes
{
    class SqrException : Exception
    {
        private string _Message;

        public SqrException(string message)
        {
            _Message = message;
        }

        public override string ToString()
        {
            return _Message;
        }
    }
    class CheckArray
    {
        double[,] mas;

        public int LengthN;
        public int LengthM;

        public bool errflag;
        public bool sqr;

        public CheckArray(int n, int m)
        {
            mas = new double[n, m];
            if (n == m) { Console.WriteLine("Массив квадратный"); sqr = true; }
            else { sqr = false; }
            LengthN = n;
            LengthM = m;
        }

        private bool ok(int index1, int index2)
        {
            if (index1 >= 0 & index1 < LengthN)
            {
                if (index2 >= 0 & index2 < LengthM)
                { return true; }
                else { return false; }
            }
            else { return false; }
        }

        public double this[int index1, int index2]
        {
            get
            {
                if (ok(index1, index2)) { errflag = false; return mas[index1, index2]; }
                else { errflag = true; return 0; }

            }
            set
            {
                if (ok(index1, index2)) { errflag = false; mas[index1, index2] = value; }
                else { errflag = true; }
            }
        }

        //public override bool Equals(object obj)
        //{ CheckArray MasB = (CheckArray)obj;
        // //  if (this !=null & MasB!= null)
        //        if (this.mas.GetLength(0) != MasB.mas.GetLength(0) || this.mas.GetLength(1) != MasB.mas.GetLength(1)) { throw new Exception("Матриццы не сравнить"); }
        //    for (int i = 0; i < this.mas.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < this.mas.GetLength(1); j++)
        //        {
        //            if (this.mas[i, j] != MasB.mas[i, j]) { return false; }
        //        }
        //    }
        //    return true;
        //}

        public static bool operator ==(CheckArray masA, CheckArray MasB)
        {
            //return masA.Equals(MasB);
        //    if (masA!= null & MasB != null)
                if (masA.mas.GetLength(0) != MasB.mas.GetLength(0) || masA.mas.GetLength(1) != MasB.mas.GetLength(1)) { throw new IndexOutOfRangeException(); }
            for (int i = 0; i < masA.mas.GetLength(0); i++)
            {
                for (int j = 0; j < masA.mas.GetLength(1); j++)
                {
                    if (masA.mas[i, j] != MasB.mas[i, j]) { return false; }
                }
            }
            return true;
        }

        //public override int GetHashCode()
        //{
        //    return this.GetHashCode();
        //}
        public static bool operator !=(CheckArray masA, CheckArray MasB)
        {
           // return !(masA.Equals(MasB));
            if (masA.mas.GetLength(0) != MasB.mas.GetLength(0) || masA.mas.GetLength(1) != MasB.mas.GetLength(1)) { throw new IndexOutOfRangeException(); }
            for (int i = 0; i < masA.mas.GetLength(0); i++)
            {
                for (int j = 0; j < masA.mas.GetLength(1); j++)
                {
                    if (masA.mas[i, j] == MasB.mas[i, j]) { return false; }
                }
            }
            return true;
        }

        public bool IZiro()
        {
            if(!this.sqr) { throw new SqrException("Массива не квадратный!"); }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] != 0) { return false; }
                }
            }
            return true;
        }

        public bool IDiagonal()
        {
            if (!this.sqr) { throw new SqrException("Массива не квадратный!"); }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i != j && mas[i, j] == 0) { return true; }
                }
            }
            return false;
        }

        public bool IOne()
        {
            if (!this.sqr) { throw new SqrException("Массива не квадратный!"); }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j && mas[i, j] != 1)
                    {
                        return false;
                    }
                    if (i != j && mas[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool ISemetric()
        {
            if (!this.sqr) { throw new SqrException("Массива не квадратный!"); }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i != j && mas[i, j] == mas[j, i]) { return true; }
                }
            }
            return false;
        }

        public bool ITriangle()
        {
            if (!this.sqr) { throw new SqrException("Массива не квадратный!"); }
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i < j && mas[i, j] == 0) { Console.Write("Матрицца верхне"); return true; }
                    if (i > j && mas[i, j] == 0) { Console.Write("Матрицца нижни"); return true; }
                }
            }
            return false;
        }

        //258 Шилдт
    }
}
