using System;
					
public class Program
{
	public static void Main()
	{
		
		//decimal n,m,a;
		double n1 =0;
		double m1 =0;
		double a1 =0;
		long lebar =0;
		long panjang =0;
	    
	    string line = Console.ReadLine();
	    string[] data = line.Split(' ');
	    
	    n1 = long.Parse(data[0]);
	    m1 = long.Parse(data[1]);
	    a1 = long.Parse(data[2]);
	    if(n1 == 1 && m1 == 1 && a1 == 1){
	        Console.WriteLine(1);
	    }else{
	    lebar = (long)Math.Ceiling(n1 / a1);
	    panjang = (long)Math.Ceiling(m1 / a1);
	    Console.WriteLine(lebar * panjang);
	    }
		
	}
}
