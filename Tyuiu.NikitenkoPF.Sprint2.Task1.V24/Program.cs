using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikitenkoPF.Sprint2.Task1.V24.Lib;

namespace Tyuiu.NikitenkoPF.Sprint2.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 325;
            int b = 325;
            int c = 242;
            int d = 324;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Никитенко П.Ф. | РПСБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт # 2                                                          ");
            Console.WriteLine(" Тема: Операции сравнения                                             ");
            Console.WriteLine(" Задание #1                                                           ");
            Console.WriteLine(" Вариант #24                                                          ");
            Console.WriteLine(" Выполнил: Никитенко Павел Фёдорович | РПСБ-23-1                       ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                              ");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      ");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении) и  ");
            Console.WriteLine("логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("  a = 325, b = 325, c = 242, d = 324                                    ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Введите значение A: " + a);
            Console.WriteLine("Введите значение B: " + b);
            Console.WriteLine("Введите значение C: " + c);
            Console.WriteLine("Введите значение D: " + d);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
    }
}
