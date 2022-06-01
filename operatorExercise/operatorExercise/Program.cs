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

            
        }
    }
}

