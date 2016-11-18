using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
       public static Stopwatch sw = Stopwatch.StartNew();
        public static void Main(string[] args) {
            int[] A = new int[100000];

          
           
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);


            populateArray(A);
            Console.WriteLine("Berfore sorting : ");
            PrintArray(A);
            // sort the array
            Console.WriteLine();
            insertionSort(A);
            Console.WriteLine();
            Console.WriteLine("After Sorting");

            PrintArray(A);

            sw.Stop();

            Console.WriteLine("Time taken: {0}s", sw.Elapsed.TotalSeconds);

        }

        /**
         * This method will sort the integer array using insertion sort in C#
         * algorithm
         * 
         * 
         */
        private static void insertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int valueToSort = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > valueToSort)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = valueToSort;
            }
        }

        public static void PrintArray(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }


        }

    

        public static void populateArray(int[] A)
        {
            Random rnd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(1000);
            }
        }
    }
}
