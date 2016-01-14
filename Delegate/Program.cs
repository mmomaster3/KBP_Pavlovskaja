using System;

namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {
            //объявление получателей
            Reciver US = new Reciver("Obama");
            Reciver Belarus = new Reciver("Lukashenko");
            Reciver Russia = new Reciver("Putin");

            //объявление новости
            News news = new News("Россия ввела санкции на импорт турецких варежек");
            News weather = new News("Сегодня солнечно, но облачно");
            News sport = new News("Кержаков опять не промазал по воротом с 10 метров");
            News happen = new News("Трое мужчин убили бабушку подушкой");
            News humer = new News("-Вы кто по говоскопу. -Я рыба. -А я...");

            //рассылка
            news.Spam += Belarus.Notify;
            weather.Spam += Belarus.Notify;
            happen.Spam += Belarus.Notify;
            news.Spam += Russia.Notify;
            sport.Spam += Russia.Notify;
            weather.Spam += Russia.Notify;
            humer.Spam += US.Notify;
            news.Send();
            weather.Send();
            sport.Send();
            happen.Send();
            humer.Send();

            Console.ReadKey();
        }
    }
}
