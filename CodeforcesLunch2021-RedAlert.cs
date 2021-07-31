using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Test
{
	public static void Main()
	{
	    
	    try{
	    int t = int.Parse(Console.ReadLine());
            while(t > 0)
            {
                string s = Console.ReadLine();
                string[] arr = s.Split(' ');
                int[] crr = new int[3];
                
                
                for(int x =0; x < 3; x++){
                    crr[x] = int.Parse(arr[x]);
                }
                int[] A = new int[crr[0]];
                
            
                string sa = Console.ReadLine();
                string[] arra = sa.Split(' ');
                for(int x =0; x < A.Length; x++){
                    
                    A[x] = int.Parse(arra[x]);
                }
                
                
                int summing = 0;
                string sana = "NO";
                bool tree = false;
                for(int x =0; x < A.Length; x++){
                    
                    if(A[x] > 0){
						
                        summing += A[x];
                    }else{
						if(summing < crr[1]){
							summing = 0;
						}else{
                        summing-=crr[1];
						}
                    }
                    if(summing > crr[2]){
                       sana = "YES";
                  
                   break;
                    
                    }
                    
                }
                
                    Console.WriteLine(sana);
                 
                    
                 
                
				
			    t--;

        }
	   }catch(Exception d){
	       
	   }
	}
}

