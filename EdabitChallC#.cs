using System;

//Edabit Chall ATMPIN Level:Medium
public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
      try{
        
        int s = int.Parse(pin);
        
        if(s.ToString().Length == 4 && s > 0 || s.ToString().Length == 6 && s > 0){
            return true;
        }else{
            return false;
        }
     }
        catch(Exception d){
            return false;
        }
    }
}
