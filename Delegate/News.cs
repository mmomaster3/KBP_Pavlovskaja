using System;

namespace Delegate
{
    public delegate void BoomNotify(string name); //объявление делегата

    class News
    {
        public event BoomNotify Spam;
        public string Name;

        public News(string name)
        {
            this.Name = name;
        }

        //отправка
        public void Send()
        {
            Console.WriteLine("\nНовость {0} отправлена", Name);
            if (Spam != null)
            {
                Spam(Name);
            }
        }


    }
}
