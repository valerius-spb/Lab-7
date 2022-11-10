using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetParamsCube(double a, out double v, out double s)
        {
            s = 6 * Math.Pow(a, 2); //МЕТОД
            v = Math.Pow(a, 3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону куба");
            double a = Convert.ToDouble(Console.ReadLine());

            //переменные для записи
            double v;
            double s;

            //Вызов метода
            GetParamsCube(a, out v, out s);
            Console.WriteLine("Площадь куба равна {0:.00} ", s);
            Console.WriteLine("Объём куба равен {0:.00} ", v);
            Console.ReadKey();
        }
    }
}
