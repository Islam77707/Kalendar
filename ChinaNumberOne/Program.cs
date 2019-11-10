using System;
using ChinaNumberOne;

namespace Omyt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свою дату рождения");
            Console.Write("Год = ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Месяц = ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("День = ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вот ваш знак задиака - {Proverka.Zodiac(year, month, day)}");
            Console.WriteLine($"Родились в год - {Proverka.Сalendar(year, month, day)}");
            Console.ReadKey();
        }

    }
}
