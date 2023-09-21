using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KrigerAE.Sprint1.Task3.V16.Lib;

namespace Tyuiu.KrigerAE.Sprint1.Task3.V16
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Кригер Артур Эдуардович | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
            Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются введенные *");
            Console.WriteLine("* пользователем два вещественных числа(для справки: b = -x1 - x2).        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" Введите x1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Введите x2 ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            var res = ds.CoeffOfQuadraticEquation(x1, x2);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат вычесления {res}");
            Console.ReadKey();
        }
    }
}
