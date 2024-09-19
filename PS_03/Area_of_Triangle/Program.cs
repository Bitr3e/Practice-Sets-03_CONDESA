using System;

namespace Area_of_Triangle
{
    // function that computes the area of a triangle using Heron’s formula
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter side-A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Enter side-B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Enter side-C: ");
            double C = double.Parse(Console.ReadLine());

            double area = Calculation(A, B, C);
            Console.Write($"The Area of the triangle is: {area}");

        }

        static double Calculation(double A, double B, double C)
        {
            double SemiPar = (A + B + C) / 2;
            double area = Math.Sqrt(SemiPar * (SemiPar - A) * (SemiPar - B) * (SemiPar - C));
            
            return area;
        }
        
    }
}