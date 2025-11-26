using System;
using Tyuiu.KochetovAP.Sprint1.Task0.V23.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task0.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Кочетов А. П. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (15/5*4)+1 и печатает   *");
            Console.WriteLine("* результат на экране.                                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Выражение: (15/5*4)+1                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate();
            Console.WriteLine($"Результат вычисления: {result}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (15/5*4)+1 = (3*4)+1 = 12+1 = 13                                       *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}