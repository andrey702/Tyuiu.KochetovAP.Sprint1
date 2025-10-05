using Tyuiu.KochetovAP.Sprint1.Task7.V28.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила : Кочетов А.П | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание # 7                                                           *");
Console.WriteLine("* Вариант #28                                                            *");
Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x;
Console.WriteLine("Введите значение x:");
x = double.Parse(Console.ReadLine());

double y;
Console.WriteLine("Введите значение y:");
y = double.Parse(Console.ReadLine());


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine(ds.Calculate(x, y));
Console.ReadLine();