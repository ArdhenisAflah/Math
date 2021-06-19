using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Timers;
using System.Diagnostics;

namespace DynamicProgramming
{
    class Program
    {
       
      
        static void Main(string[] args)
        {
            //Tzaph dan tipe barisan.


            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            Stopwatch d =new Stopwatch();
            d.Start();
            string[] process = s.Split(' ');

            int[] store = new int[N];
            int[] temp = new int[N];

            for(int x =0; x < N; x++)
            {
                store[x] = int.Parse(process[x]);
               
            }
            for (int x = 0; x < N; x++)
            {
                temp[x] = store[x];

            }


            
            if (store.Sum() / store[0] == N)
            {
                d.Stop();
                Console.WriteLine(d.Elapsed);
                Console.WriteLine("EQUAL");
            }
           
            else
            {
                Array.Sort(store);
                if (temp.SequenceEqual(store))
                {
                    d.Stop();
                    Console.WriteLine(d.Elapsed);
                    Console.WriteLine("NONDECREASING");
                    
                }
                else if(temp.SequenceEqual(store.Reverse()))
                {
                    d.Stop();
                    Console.WriteLine(d.Elapsed);
                    Console.WriteLine("NONINCREASING");
                }
                else
                {
                    d.Stop();
                    Console.WriteLine(d.Elapsed);
                    Console.WriteLine("NONE");
                   
                }
            }
            //
            Console.ReadLine();
           
        }
    }
  }

