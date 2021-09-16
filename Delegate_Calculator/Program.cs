using System;

namespace Delegate_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.operation(Sub, 5, 6);
            Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
