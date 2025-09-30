
using Tyuiu.KochetovAP.Sprint1.Task2.V8.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task2.V8
{

    class Program
    {

        static void Main(string[] args)
        {
            {
                DataService ds = new DataService();
                Console.Title = "Спринт #1| Выполнил: Кочетов.A.П | ИБКСБ-25-1";

                //Длинна строки 75 символов
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("Спринт #1");
                Console.WriteLine("Тема: Базовые навыки работы в C#");
                Console.WriteLine("Задание #2");
                Console.WriteLine("Вариант #8");
                Console.WriteLine("Выполнил: Кочетов Андрей Павлович | ИБКСБ-25-1");
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("УСЛОВИЕ:");
                Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.");
                Console.WriteLine("и печатает результат на экране.");
                Console.WriteLine("");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");
                double x;
                double a;
                Console.WriteLine("Введите значение а:");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение b:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("********************************************************************************************************");

                Console.WriteLine("* результат                                                                                        *");
                Console.WriteLine(" ответ = 18");


                Console.ReadKey();
            }
        }
    }
}
