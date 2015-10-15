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
                                    isTrue = JaggedArray.CompareSumArrays(array[i], array[i + 1]);
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
                                    isTrue = JaggedArray.CompareMaxArraysElements(array[i], array[i + 1]);
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
                                    isTrue = JaggedArray.CompareMinArraysElements(array[i], array[i + 1]);
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

        private static int CompareSumArrays(int[] a, int[] b)
        {

            int aSum = a.Sum();
            int bSum = b.Sum();
            if (aSum > bSum)
                return 1;
            if (aSum == bSum)
                return 0;
            return -1;
        }

        private static int CompareMaxArraysElements(int[] a, int[] b)
        {
            int aMax = a.Max();
            int bMax = b.Max();
            if (aMax > bMax)
                return 1;
            if (aMax == bMax)
                return 0;
            return -1;
        }

        private static int CompareMinArraysElements(int[] a, int[] b)
        {
            int aMin = a.Min();
            int bMin = b.Min();
            if (aMin > bMin)
                return 1;
            if (aMin == bMin)
                return 0;
            return -1;
        }
    }
}
