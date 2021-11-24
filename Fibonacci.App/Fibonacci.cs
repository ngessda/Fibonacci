using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.App
{
    class Fibonacci
    {
        private int index;
        private int result;
        public Fibonacci(int ix)
        {
            index = ix;
        }
        public int FibonacciNumberValue()
        {
            result = FibonacciNumberFinder(index);
            return result;
        }

        private int FibonacciNumberFinder(int ix)
        {
            if (ix < 1) 
            {
                return 0;
            }
            if (ix == 1) 
            {
                return 1;
            }
            return FibonacciNumberFinder(ix - 1) + FibonacciNumberFinder(ix - 2);
        }
    }
}
