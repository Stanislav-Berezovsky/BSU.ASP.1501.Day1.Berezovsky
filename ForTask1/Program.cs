using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;

namespace ForTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 256;
            int exponent = 4;
            double correctness = 0.0001;
            var result = NewtonMethod.FindingTheRoot(number, exponent, correctness);
            Console.WriteLine("NewtonMethod:{0}", result);
            double resultPow = Math.Pow(number, 1 / exponent);
            Console.WriteLine("Math.Pow:{0}", resultPow);

            var array = new int[4][];
            array[0] = new int[] { 3, 4, 2 };
            array[1] = new int[] { 19, 7 };
            array[2] = new int[] { 3, 24, 12, 13 };
            array[3] = new int[] { 37 };
            bool isPositive = true;
            int choice = 3;



            JaggedArray.sort(array, isPositive, choice);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        Console.Write("{0}\t", array[i][j]);
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("пустой массив");
            }

            Console.ReadKey();
        }
    }
}
