using System;

namespace First_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.WriteLine("Enter value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} * {b} equals {AddNumbers(a,b)}");
        }

        public static int AddNumbers(int a,int b)
        {
                return a * b;
        }
    }
}
