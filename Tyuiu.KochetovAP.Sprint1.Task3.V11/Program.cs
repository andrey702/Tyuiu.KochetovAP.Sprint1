using System;
using Tyuiu.KochetovAP.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task3.V11
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Расчет: Напишите программу, которая вычисляет площадь треугольника,    *");
            Console.WriteLine("* если известны координаты его углов. Ответ округлите до 3 знаков.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите координаты углов:");

            Console.Write("x1 -> ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y1 -> ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x2 -> ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y2 -> ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("x3 -> ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("y3 -> ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.TriangleArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Площадь треугольника: {result} кв.см");

            Console.ReadKey();
        }
    }
}