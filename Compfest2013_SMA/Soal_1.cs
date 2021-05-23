using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

class Program
    {
     static void Main(string[] args)
        {
            //Kelereng.
            /*batas memori: 32 mb.
             * batas waktu : 2 detik.
             * :]
             */

            int t = int.Parse(Console.ReadLine());


            Int64 temp = 0;
            Int64 result = 0;
            for (int x = 0; x < t; x++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                int q = int.Parse(Console.ReadLine());
                if (k < q)
                {
                    k += n;
                    n = 0;
                    result = Enumerable.Range(1, k).Aggregate(1, (p, item) => p * item);
                    if (q == k)
                    {

                        Console.WriteLine(result);

                    }
                    else
                    {
                        result = k / (k - q);
                        Console.WriteLine(result);
                    }
                }
                else
                {
                    result = Enumerable.Range(1, k).Aggregate(1, (p, item) => p * item);
                    if (q == k)
                    {

                        Console.WriteLine(result);

                    }
                    else
                    {
                        temp = k - q;
                        temp = Enumerable.Range(1, (int)temp).Aggregate(1, (p, item) => p * item);
                        result = result / temp;
                        Console.WriteLine(result);
                    }
                }

            }
           
            Console.ReadLine();

         }  

   }
