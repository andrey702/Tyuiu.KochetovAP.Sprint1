using Tyuiu.KochetovAP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KochetovAP.Sprint1.Task5.V7
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
                Console.WriteLine("Задание #5");
                Console.WriteLine("Вариант #7");
                Console.WriteLine("Выполнил: Кочетов Андрей Павлович | ИБКСБ-25-1");
                Console.WriteLine("********************************************************************************************************");
                Console.WriteLine("УСЛОВИЕ:");
                Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.");
                Console.WriteLine("и печатает результат на экране.");
                Console.WriteLine("");
                Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:");

                double f;
               

                Console.WriteLine("Введите значение f:");
                f = double.Parse(Console.ReadLine());
                

                Console.WriteLine("********************************************************************************************************");


                Console.WriteLine(" ответ =  ");


                Console.ReadKey();
            }
        }
    }
}