﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class InsertionSort
    {
        public static double bTime;
        public static long bMem;
        static public void insertionsort(int[] arr)
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();

            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;

            }
            stp.Stop();
            bTime = stp.Elapsed.TotalMilliseconds;
            bMem = GC.GetTotalMemory(false);
        }
    }
}