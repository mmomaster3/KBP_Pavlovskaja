using System;

namespace Delegate
{
    class Reciver
    {
        public string Name;

        public Reciver(string name)
        {
            this.Name = name;
        }

        //уведомление
        public void Notify(string info)
        {
            Console.WriteLine("Президент {0} уведомлен ", Name, info);
        }
    }
}
