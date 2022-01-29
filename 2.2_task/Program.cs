using System;

namespace _2._2_task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите координаты вершины прямоугольника");
            Console.Write("X1 = ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты противопожной вершины прямоугольника");
            Console.Write("X2 = ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double P = 2 * Math.Abs(X2 - X1)+2* Math.Abs(Y2-Y1);
            double S = Math.Abs((X2 - X1) * (Y2 - Y1));
            
            Console.WriteLine("Периметр прямоугольника = {0}", P);
            Console.WriteLine("Площадь прямоугольника = {0}", S);
        }
    }
}
