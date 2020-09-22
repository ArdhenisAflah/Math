using System;
using System.Text.RegularExpressions; 

public class HelloWorld
{
    static public void Main ()
    {
        //Target
        string ex1 = "1243";
        string ex2 = "6842";
        
        //Algorithm Matrix simple
        
        string sx1 = ex1.Replace(ex1.Substring(1,3)," ");
        
        
      string sx2 =ex2.Replace("842"," ");
      string sx3 = Regex.Replace(ex1, "[143]", " ");
      string sx4 = Regex.Replace(ex2, "[642]", " ");
      string sx5 = Regex.Replace(ex1, "[123]", " ");
      string sx6 = Regex.Replace(ex2, "[682]", " ");
      string sx7 = Regex.Replace(ex1,"[124]", " ");
      string sx8 = Regex.Replace(ex2, "[684]", " ");
        
        //)Convert Section
       int sp1 = Convert.ToInt32(sx1);
      int  sp2 = Convert.ToInt32(sx2);
      int sp3  = Convert.ToInt32(sx3);
      int sp4 = Convert.ToInt32(sx4);
      int sp5 = Convert.ToInt32(sx5);
      int sp6 = Convert.ToInt32(sx6);
      int sp7 = Convert.ToInt32(sx7);
      int sp8 = Convert.ToInt32(sx8);
      
       //display Section
       
      Console.WriteLine(sp1 + sp2);
      Console.WriteLine(sp3 + sp4);
      Console.WriteLine(sp5 + sp6);
      Console.WriteLine(sp7 + sp8);

    }

}
