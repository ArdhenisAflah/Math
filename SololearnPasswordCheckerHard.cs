using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] special = {'!','@','#','$','%','&','*'};
            
            string input = Console.ReadLine();
            int special2 = 0;
            
            var e = Regex.Replace(input,"[A-Za-z0-9]","");
            
            for(int x = 0; x < special.Length; x++){
                if(input.Contains(special[x])){
                    special2 += 1;
                }
            }
            bool check = false;
            while(e.Length > 0){
                int counter = 0;
                
                
                for(int x = 0; x < e.Length; x++){
                if(e[0] == e[x]){
                    counter++;
                    if(counter >= 2){
                        check = true;
                        break;
                    }
                }
                    
                }
                e = e.Replace(e[0].ToString(),string.Empty);
            }
            
            if(input.Length >= 7){
                var count = input.Count((x) => char.IsDigit(x));
                
                
                
                if(count >= 2){
                    if(special2 >= 2 || check == true){
                        Console.WriteLine("Strong");
                    }
                    else{
                        Console.WriteLine("Weak");
                    }
                }
                
                else{
                    Console.WriteLine("Weak");
                }
            }
            else{
                Console.WriteLine("Weak");
            }
            
            
            
        }
    }
}
