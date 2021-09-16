using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Calculator
{
    /// <summary>
    /// Allows basic operations
    /// </summary>
    class Calculator
    {
        public delegate int function(int a, int b);

        public static void operation(function function, int x, int y)
        {
            Console.WriteLine("The result is " + function(x, y));
        }
    }
}
