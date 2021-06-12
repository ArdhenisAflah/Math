using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutionList
{
    class Program
    {
    static void Main(string[] args)
        {
            //Is Subsequence.
            //leetcode problem 392 - Easy.
            /* string t.Length ~500.000 and s is <= 100
             * return True if all t char exist with order in string s
             *using two pointer method 
             */

            string s = Console.ReadLine();
            string t = Console.ReadLine();

            //inisialisasi 2 pointer.
            int j = 0;
            int i = 0;
            int count = 0;
            int left_pointer = s[j]; //short string
            int right_pointer = t[i]; //long string

            while(j < s.Length)
            {
                
                if(i >= t.Length-1)
                {
                    right_pointer = t[0];
                    left_pointer = s[j++];
                }
               if(left_pointer == right_pointer)
                {
                    count++;
                    left_pointer = s[j++];
                    right_pointer = t[0];
                }
                else
                {
                    right_pointer = t[i++];
                }
               
            }
            
            if(count == s.Length)
            {
                Console.WriteLine(true);
               
            }
            else
            {
                Console.WriteLine(false);
               
            }

            Console.ReadLine();
        }
    
    
    }
}
