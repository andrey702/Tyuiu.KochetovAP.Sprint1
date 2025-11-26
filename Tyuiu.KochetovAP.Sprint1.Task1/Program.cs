using System;
using Tyuiu.KochetovAP.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task1.V11
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле 5*x/(6*y) и печатает его на экране.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.Calculate(x, y);
                Console.WriteLine($"Результат вычисления 5*{x}/(6*{y}) = {result:F3}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль! Значение y не может быть равно 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА:                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"* Формула: 5*x/(6*y)                                                    *");
            Console.WriteLine($"* Введенные значения: x = {x}, y = {y}                                  *");
            if (y != 0)
            {
                double manualCalc = 5 * x / (6 * y);
                Console.WriteLine($"* Ручной расчет: 5*{x}/(6*{y}) = {manualCalc:F3}                      *");
            }
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}