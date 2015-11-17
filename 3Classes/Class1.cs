using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Classes
{
    abstract class Class1
    {
        public Class1(string name)
        {
            this.name = name;
        }

        public abstract void MidSalary();
        public string name;
        public double salary;
    }

    class HoursSal : Class1
    {
        public int stat = 0;

        public HoursSal(string name, int stat):base(name)
        {
         //   this.name = name;
            this.stat = stat;
        }

        public override void MidSalary()
        {
            salary = 20.8 * 8 * stat;
        }
    }

    class FixedSal : Class1
    {
        public int fix;
        public FixedSal(string name, int fix):base(name)
        {
           // this.name = name;
            this.fix = fix;
        }

        public override void MidSalary()
        {
            salary = fix;
        }
    }
}
