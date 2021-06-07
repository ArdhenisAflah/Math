using System;
					
public class Program
{
	

     public static void Main()
	 {            int input = int.Parse(Console.ReadLine());
                  int[] ds = new int[4];
	            
            while (input > 0)
            {

                string s = Console.ReadLine();
                string[] dss = s.Split(' ');
				
                ds[0] += int.Parse(dss[0].ToString());
                ds[1] += int.Parse(dss[1].ToString());
                ds[2] += int.Parse(dss[2].ToString());

                input--;
            }
	  
	      
            if (ds[0] == 0 && ds[1] == 0 && ds[2] == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
}
}


