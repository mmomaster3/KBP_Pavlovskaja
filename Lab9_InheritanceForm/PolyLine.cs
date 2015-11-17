using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_InheritanceForm
{
    class PolyLine : Line
    {
        int z;
        public PolyLine(int x, int y, int z):base(x,y)
        {
            Z = z;
        }

        public int Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }
    }
}
