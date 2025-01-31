using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public  delegate bool SortFuncDeledate(int X, int Y);
    public delegate bool SortFuncDeledate<T>(T X, T Y);
    internal class SortingAlgorithms
    {
        //private static void Swap(ref int X, ref int Y)
        //{
        //    int temp;

        //    temp = X;
        //    X = Y;
        //    Y = temp;

        //}

        private static void Swap<T>(ref T X, ref T Y)
        {
            T temp;

            temp = X;
            X = Y;
            Y = temp;

        }
        public static void BubbleSort<T>(T[] Arr, Func<T,T,bool> reference)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(Arr[j], Arr[j + 1]))
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }

        }
        //public static void BubbleSort(int[] Arr , SortFuncDeledate reference)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(Arr[j], Arr[j+1]))
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}

        //public static void BubbleSortAscending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingCondition.CompareGeter(Arr[j], Arr[j + 1]))
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}

        //public static void BubbleSortDEscending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (SortingCondition.CompareLesser(Arr[j], Arr[j + 1]))
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}
        //public static void BubbleSortAscending(int[] Arr)
        //{ 
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0;j<Arr.Length -i -1;j++)
        //            {
        //                if (Arr[j] > Arr[j+1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}

        //public static void BubbleSortDEscending(int[] Arr)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            for (int j = 0; j < Arr.Length - i - 1; j++)
        //            {
        //                if (Arr[j] < Arr[j + 1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}
    }
}
