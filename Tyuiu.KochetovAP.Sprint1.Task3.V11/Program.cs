using Tyuiu.KochetovAP.Sprint1.Task3.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task3.V11
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
                Console.WriteLine("Вариант #11");
                Console.WriteLine("Выполнил: Кочетов Андрей Павлович | ИБКСБ-25-1");
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("УСЛОВИЕ:");
                Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.");
                Console.WriteLine("и печатает результат на экране.");
                Console.WriteLine("");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");

                double x1;
                double y1;
                double x2;
                double y2;
                double x3;
                double y3;

                Console.WriteLine("Введите значение x1:");
                x1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение y1:");
                y1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение x2:");
                x2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение y2:");
                y2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение x3:");
                x3 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение y3:");
                y3 = double.Parse(Console.ReadLine());


                Console.WriteLine("********************************************************************************************************");


                Console.WriteLine(" ответ = " + ds.TriangleArea(x1, y1, x2, y3, x3, y3));


                Console.ReadKey();
            }
        }
    }
}
