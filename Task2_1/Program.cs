﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static double GetArea(double x, double y, double z)
        {

            double p = ((x + y + z) / 2);
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return s; //Метод
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника"); // Данные
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());


            double s1 = GetArea(a1, b1, c1); //Вызов метода

            Console.WriteLine("Введите стороны второго треугольника"); // Данные
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());

            double s2 = GetArea(a2, b2, c2); //Вызов метода

            if (s1 > s2)
                Console.WriteLine("{0:.00}>{1:.00} Площадь первого треугольника больше", s1, s2);
            else
                if (s1 < s2)
                Console.WriteLine("{0:.00}<{1:.00} Площадь второго треугольника больше", s1, s2);
            else
                Console.WriteLine("{0:.00}={1:.00} Площади равны", s1, s2);
            Console.ReadKey();
        }
    }
}
