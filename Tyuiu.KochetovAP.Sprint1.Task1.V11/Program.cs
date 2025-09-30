
using Tyuiu.KochetovAP.Sprint1.Task1.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            //Длинна строки 75 символов
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("Спринт #1");
            Console.WriteLine("Тема: Базовые навыки работы в C#");
            Console.WriteLine("Задание #1");
            Console.WriteLine("Вариант #11");
            Console.WriteLine("Выполнил: Кочетов андрей Павлович | ИБКСБ-25-1");
            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле 5*x/(6*y) и печатает его на экране.");
            Console.WriteLine("и печатает результат на экране.");
            Console.WriteLine("");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
            double x;
            double y;
            Console.WriteLine("Введите значение x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("********************************************************************************************************");
            Console.WriteLine("* 5*x/(6*y)                                                                                            *");
            Console.WriteLine("* результат                                                                                            *");
            Console.WriteLine(" ответ = " + ds.Calculate(x, y));


            Console.ReadKey();

        }
    }
}
