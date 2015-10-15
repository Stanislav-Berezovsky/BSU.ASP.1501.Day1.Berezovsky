using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class FindingTheRoot
    {
        public static double NewtonMethod(double number, int exponent, double correctness)
        {
            if (number < 0 && exponent % 2 == 0)
            {
                return double.NaN;
            }
            else
                if (exponent == 0)
                {
                    return 1;
                }
                else
                {
                    double x = number;
                    double xk = 0;
                    while (correctness < Math.Abs(x - xk))
                    {
                        xk = x;
                        x = 1.0 / exponent * ((exponent - 1) * xk + number / Math.Pow(xk, exponent - 1));
                    }
                    return x;
                }
        }
    }
}
