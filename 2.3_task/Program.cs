using System;

namespace _2._3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой вершины треугольника");
            Console.Write("X1 = ");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1 = ");
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты второй вершины треугольника");
            Console.Write("X2 = ");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2 = ");
            double Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты третей вершины треугольника");
            Console.Write("X3 = ");
            double X3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y3 = ");
            double Y3 = Convert.ToDouble(Console.ReadLine());

            double P =  Math.Sqrt(Math.Pow((X2 - X1),2)+ Math.Pow((Y2-Y1),2)) + Math.Sqrt(Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2)) + Math.Sqrt(Math.Pow((X1 - X3), 2) + Math.Pow((Y1 - Y3), 2));
            double p = P/2; 
            double S = Math.Sqrt(p*(p- Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2))) *(p- Math.Sqrt(Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2))) *(p- Math.Sqrt(Math.Pow((X1 - X3), 2) + Math.Pow((Y1 - Y3), 2))));

            Console.WriteLine("Периметр прямоугольника = {0}", P);
            Console.WriteLine("Площадь прямоугольника = {0}", S);
            
        }
    }
}
