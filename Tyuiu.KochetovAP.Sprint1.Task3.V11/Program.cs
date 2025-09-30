using Tyuiu.KochetovAP.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KilikaevRV.Sprint1.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #1| Выполнил: Кочетов А.П | ИБКСБ-25-1";

                //Длинна строки 75 символов
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("Спринт #1");
                Console.WriteLine("Тема: Базовые навыки работы в C#");
                Console.WriteLine("Задание #3");
                Console.WriteLine("Вариант #12");
                Console.WriteLine("Выполнил: Кочетов Андрей Павлович | ИБКСБ-25-1");
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("УСЛОВИЕ:");
                Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.");
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


                Console.WriteLine(" ответ = " + ds.TriangleArea(x, y));


                Console.ReadKey();
            }
        }
    }
}