using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class JaggedArray
    {
        public static void sort(int[][] array, bool isPositive, int choice)
        {
            for (int j = array.Length - 1; j >= 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    int isTrue = 0;
                    if (array[i] == null)
                    {
                        if (isPositive)
                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                        else
                            continue;
                    }
                    else
                        if (array[i + 1] == null)
                        {
                            if (isPositive)
                                continue;
                            else
                                JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);

                        }

                        else
                        {
                            switch (choice)
                            {
                                case 1:
                                    isTrue = JaggedArray.CompareSumArrays(ref array[i], ref array[i + 1]);
                                    if (isPositive)
                                    {
                                        if (isTrue == 1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    else
                                    {
                                        if (isTrue == -1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    break;
                                case 2:
                                    isTrue = JaggedArray.CompareMaxArraysElements(ref array[i], ref array[i + 1]);
                                    if (isPositive)
                                    {
                                        if (isTrue == 1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    else
                                    {
                                        if (isTrue == -1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    break;
                                case 3:
                                    isTrue = JaggedArray.CompareMinArraysElements(ref array[i], ref array[i + 1]);
                                    if (isPositive)
                                    {
                                        if (isTrue == 1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    else
                                    {
                                        if (isTrue == -1)
                                            JaggedArray.SwapArrays(ref array[i], ref array[i + 1]);
                                    }
                                    break;
                            }
                        }
                }
            }
        }
        private static void SwapArrays(ref int[] a, ref int[] b)
        {
            int[] swap = a;
            a = b;
            b = swap;
        }

        private static int CompareSumArrays(ref int[] a, ref int[] b)
        {
            if (a.Sum() > b.Sum())
                return 1;
            if (a.Sum() == b.Sum())
                return 0;
            return -1;
        }

        private static int CompareMaxArraysElements(ref int[] a, ref int[] b)
        {
            if (a.Max() > b.Max())
                return 1;
            if (a.Max() == b.Max())
                return 0;
            return -1;
        }

        private static int CompareMinArraysElements(ref int[] a, ref int[] b)
        {
            if (a.Min() > b.Min())
                return 1;
            if (a.Min() == b.Min())
                return 0;
            return -1;
        }
    }
}
