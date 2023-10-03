﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikitenkoPF.Sprint2.Task0.V7.Lib;


namespace Tyuiu.NikitenkoPF.Sprint2.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 103;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Никитенко П.Ф. | РПСБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт # 2                                                          ");
            Console.WriteLine(" Тема: Операции сравнения                                             ");
            Console.WriteLine(" Задание #0                                                           ");
            Console.WriteLine(" Вариант #7                                                          ");
            Console.WriteLine(" Выполнил: Никитенко Павел Фёдорович | РПСБ-23-1                       ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                              ");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,      ");
            Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических выражений  ");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("  x = 103, y = 475                                                      ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Введите значение X: " + x);
            Console.WriteLine("Введите значение Y: " + y);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("************************************************************************");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
