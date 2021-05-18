using System;
using System.Linq;
using System.Collections.Generic;
using System.Text; 
 
 
 static void Main(string[] args)
        {
            /* Problem: Berbalas Pantun.
             * Tingkatan: Penyisihan-(mudah)
             * bahasa:c#
             * Event:Gemastik 2017
             * 0(n) -> big o notation just my guess ehehee 


             */
            int[] A6 = new int[2];
            int[] B6 = new int[2];
            //A6 first
            for(int x =0; x < A6.Length; x++)
            { Console.WriteLine("A6");
                A6[x] = int.Parse(Console.ReadLine());
            }
            //B6
            for (int x = 0; x < B6.Length; x++)
            {
                Console.WriteLine("B6");
                B6[x] = int.Parse(Console.ReadLine());
            }

            //logic
            var sum1 = A6.Sum();
            var sum2 = B6.Sum();
            var all = sum1 + sum2;

            Console.WriteLine("Output:{0} ", all * 2); //kenapa dikali 2 ? karena dikasus ini N default adalah 2(sesuai ukuran array)
            Console.ReadLine();


        }
