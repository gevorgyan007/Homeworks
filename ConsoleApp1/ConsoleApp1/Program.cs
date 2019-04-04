using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            Random r = new Random();

            for (int i = 0; i < x.Length; i++)
                //x[i] = int.Parse(Console.ReadLine());
                x[i] = r.Next(15);

            Quicksort.mergeSort(x, 0, x.Length - 1);


            Console.WriteLine("Bubble sort is {0}", 1);
            Console.WriteLine("Insertion sort is {0}", 2);
            Console.WriteLine("Quick sort is {0}", 3);

            int k = int.Parse(Console.ReadLine());
            if (k == 1) BubbleSort.BSort(x);
            else if (k == 2) Quicksort.mergeSort(x, 0, x.Length - 1);
            else if (k == 3) InsertionSort.insertionsort(x);
            void printArr(int[] arr)
            {
                int m = arr.Length;
                for (int i = 0; i < m; ++i)
                    Console.Write(arr[i] + " ");

                Console.Write("\n");
            }
            printArr(x);
            double[] time = { BubbleSort.bTime, InsertionSort.bTime, Quicksort.bTime };
            int num = 0;
            double min = time[0];
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] != 0)
                {
                    num = i;
                    min = time[i];
                    break;
                }
            }
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] < min && time[i] != 0)
                {

                    min = time[i];
                    num = i;
                }
            }
            Console.WriteLine("Sorting runtime are : ");
            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] != 0)
                {
                    if (i == num)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(time[i] + "ms, ");
                        Console.ResetColor();
                    }
                    else
                        Console.Write(time[i] + "ms, ");

                }
            }

            Console.ReadKey();
        }
    }
}
