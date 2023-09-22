using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrigerAE.Sprint1.Task2.V30.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task2.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Кригер А.Э. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Кригер Артур Эдуардович | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Формулировка задания: Известно расстояние в километрах.                 *");
            Console.WriteLine("* Перевести расстояние в метры.                                           *");
            Console.WriteLine("* Что пользователь вводит ? Расстояние в километрах(вещественное число)   *");
            Console.WriteLine("* Что программа печатает на экране ?                                      *");
            Console.WriteLine("* Расстояние в метрах(вещественное число)                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите растояние в километрах");
            int distance = Convert.ToInt32(Console.ReadLine());


            var res = ds.ConvertKmToMetre(distance);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Расстояние в метрах {res}");
            Console.ReadKey();
        }
    }
}
