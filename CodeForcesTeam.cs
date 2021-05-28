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
            //Team Codeforces.
            //constraint -> [a-z].
            int testcase = int.Parse(Console.ReadLine());
            int result = 0;
            while (testcase > 0)
            {
                
                string input = Console.ReadLine();
                string[] process = input.Split(' ');
 
            
                if(Convert.ToInt32(process[0]) + Convert.ToInt32(process[1])  + Convert.ToInt32(process[2]) > 1)
                {
                    result += 1;
                }
 
                testcase--;
            }
            Console.WriteLine(result);
 
 
            Console.ReadLine();
        }
    }
}
