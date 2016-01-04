using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class my
    {
        public string mystring;//поле класса
        public void Myfunc(string s)
        {
            // Вывод значения поля mystring, а также аргумента, переданного методу. 
            Console.WriteLine(mystring + s);
        }
    }
    class Programы
    {
        //объявление делегата
        delegate void MyDelegate(string s);
        static void Main(string[] args)
        {
            Class1 a = new Class1();
            // Создадим экземпляр тестового класса.
            my A = new my();
            // Создадим экземпляр делегата, содержащего, помимо ссылки на сам метод, также ссылку
            // на объект, для которого будет вызван метод. 
            MyDelegate del = new MyDelegate(A.Myfunc);
            // Изменяем значение поля тестового объекта.
            A.mystring = "Hello, World!";
            // Вызовем метод через делегат.
            del(" -  from  Delegate");
            // Эквивалентен следующему вызову
            // A.Myfunc(" - from Instance Delegate");
            // Снова изменим значение поля тестового объекта.
            A.mystring = "Good bye, World!";
            // Снова обратимся к методу.
            del(" - from Delegate");

            Console.ReadKey();
        }
    }
}
