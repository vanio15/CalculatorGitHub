using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Sub(3, 4));
            Console.WriteLine(Div(4, 4));
            Console.WriteLine(Mul(2, 2));
            Console.ReadKey();
        }

        static int Add(int a,int b)
        {
            return a + b;

        }
        static int Sub(int a, int b)
        {
            return a - b;

        }
        static int Mul(int a, int b)
        {
            return a * b;

        }
        static int Div(int a, int b)
        {
            return a / b;

        }
    }
}
