using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            
            string[] spl = text.Split(' ');
            
            for(int x = 0; x < spl.Length; x++){
                string s =spl[x].Substring(1)+ spl[x].Substring(0,1)+"ay";
                
                
                
                Console.Write(s+" ");
            }
        }
    }
}
