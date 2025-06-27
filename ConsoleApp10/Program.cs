using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            DateClass date1 = new DateClass(1987, 5, 22);

            Console.WriteLine($"Текущая дата: {date1.Data}");
            Console.WriteLine($"Пдыдущирей день: {date1.PreviousDay()}");
            Console.WriteLine($"Следующий день: {date1.NextDay()}");

            //Console.Write("Введите год: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите месяц: ");
            //int month = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите день: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //DateClass date = new DateClass(year, month, day);

            //Console.WriteLine($"Текущая дата: {date.Data:dd.MM.yyyy}");
            //Console.WriteLine($"Пдыдущирей день: {date.PreviousDay():dd.MM.yyyy}");
            //Console.WriteLine($"Следующий день: {date.NextDay():dd.MM.yyyy}");

            Console.ReadKey();
        }
    }
}

