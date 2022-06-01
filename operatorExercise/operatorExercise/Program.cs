using System;

namespace operatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 5;

            int quotient = a /= b;
            int remainder = a %= b;

            Console.WriteLine($"18/5 is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {circleArea}");
           
        }
    }
}

