﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class BubbleSort
    {
        public static double bTime;
        public static long bMem;
        static public void BSort(int[] arr)
        {
            Stopwatch stp = new Stopwatch();
            stp.Start();
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
            stp.Stop();
            bTime = stp.Elapsed.TotalMilliseconds;
            bMem = GC.GetTotalMemory(false);

        }
    }
}
