using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шар
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите диаметр шара");
            double d = Double.Parse(Console.ReadLine());
            double S = Math.PI * Math.Pow(d, 2);
            double V = Math.PI * Math.Pow(d, 3) / 6;
            Console.WriteLine($"Площадь поверхности шара {S}, объем шара {V}");
        }
    }
}
