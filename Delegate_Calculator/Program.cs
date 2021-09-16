using System;

namespace Delegate_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.operation(Add, 5, 6);
            Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
