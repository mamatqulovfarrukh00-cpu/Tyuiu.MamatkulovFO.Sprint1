using Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;
using Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.System;



    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Маматкулов Фаррух| ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #17                                                            *");
            Console.WriteLine("* Выполнил:  Маматкулов Фаррух | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значание длины параллелепипеда (целое число) => ");
            int valueOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значание ширины параллелепипеда (целое число) => ");
            int valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значание высоты параллелепипеда (целое число) => ");
            int valueThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.CalculateSideSquareParallelepiped(valueOne, valueTwo, valueThree);
            Console.WriteLine($"Площадь боковой поверхности параллелепипеда равна => ");
            Console.ReadKey();
        }
    }

