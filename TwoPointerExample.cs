using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerrankSolutionList
{
    class Program
    {
     static void Main(string[] args)
        {
            //find two numbers in a unsorted array that sum to a target X.
            //temukan/tentukan 2 bilangan di dalam array yang tidak berurutan yang ketika dijumlahkan hasilnya adalah X.

            int x = int.Parse(Console.ReadLine());

            int[] arr = { 1,-1, 2, 3, 5 };
            //tentukan left pointer dan right pointer
            int i = 0;
            int j = arr.Length - 1;
            int kiri = arr[i];
            int kanan = arr[j];

            //sort dlu arraynya(kalau belum sorted)
            Array.Sort(arr);

            while(kiri < arr.Length)
            {
                if (kiri+kanan < x)
                {
                    kiri = arr[i++];
                }else if(kiri+kanan > x)
                {
                    kanan = arr[j--];

                }
                else
                {
                    
                    break;
                }
            }
            Console.WriteLine(j+ " "+ i);
            Console.ReadLine();



        }
    
    }
}
