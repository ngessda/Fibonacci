using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci(9);
            Console.WriteLine(fib.FibonacciNumberValue());
            Console.ReadKey();
        }
    }
}
