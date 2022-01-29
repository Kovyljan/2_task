using System;

namespace _2._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            double L_circle = Convert.ToDouble(Console.ReadLine());
            double R_circle = L_circle / (2 * Math.PI);
            double S_circle = Math.PI * R_circle * R_circle;

            Console.WriteLine("Радиус круга = {0}", R_circle);
            Console.WriteLine("Площадь круга = {0}", S_circle);
        }
    }
}
