using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace ForTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 64;
            int exponent = 4;
            double correctness = 0.0001;
            var result = FindingTheRoot.NewtonMethod(number, exponent, correctness);
            Console.WriteLine("NewtonMethod:{0}", result);
            double resultPow = Math.Pow(number, 1 / exponent);
            Console.WriteLine("Math.Pow:{0}", resultPow);
            Console.ReadKey();
        }
    }
}
