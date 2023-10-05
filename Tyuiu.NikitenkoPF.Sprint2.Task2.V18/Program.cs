using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikitenkoPF.Sprint2.Task2.V18.Lib;

namespace Tyuiu.NikitenkoPF.Sprint2.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Никитенко П.Ф. | РПСБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт # 2                                                          ");
            Console.WriteLine(" Тема: Оператор if – полная и короткая форма записи                    ");
            Console.WriteLine(" Задание #2                                                           ");
            Console.WriteLine(" Вариант #18                                                          ");
            Console.WriteLine(" Выполнил: Никитенко Павел Фёдорович | РПСБ-23-1                       ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                              ");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и  ");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области. ");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                      ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("   Схема                                                     ");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Введите значение X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("************************************************************************");
            if (res)
            {
                Console.WriteLine("Точка находиться в заштрихованной области");

            }
            else
            {
                Console.WriteLine("Точка не находиться в заштрихованной области");
            }
            
            Console.ReadKey();
        }
    }
}
