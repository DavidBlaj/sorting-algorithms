using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        public static Stopwatch stopwatch = Stopwatch.StartNew();
        static void Main(string[] args)
        {

            Random r = new Random();
            int[] integers = new int[10000];
            Console.Write("Numbers before sorting  -->  ");
            for (int i = 0; i < integers.Length; i++)
            {
                integers[i] = r.Next(1 , 101);

                Console.Write(integers[i]  + " ");
            }
          
            // Displaying the values generated automatically
            

            Console.WriteLine();

            // Displaying the values genereted automatically sorted ascending
            Console.Write("Numbers after sorting  -->   ");
            initializeInsertionSort(integers);

            for (int i = 0; i < integers.Length; i++)
            {
                Console.Write(integers[i] + " ");
            }

            Console.WriteLine();
          
            stopwatch.Stop();
            Console.WriteLine("Running time : {0}s " ,stopwatch.Elapsed.TotalSeconds);
            Console.ReadKey();

        }



        public static void initializeInsertionSort(int[] integers)
        {
            
            for (int i = 1; i < integers.Length; i++)
            {

                int j = i;
                int B = integers[i];

                while ((j > 0) && (integers[j - 1] > B))
                {
                    integers[j] = integers[j - 1];
                    j--;
                }
                integers[j] = B;
            }

        }
    }
}



