

    
public class Solution {
    public bool IsSubsequence(string s, string t) {
        //inisialisasi 2 pointer.
            
            //link problem : https://leetcode.com/problems/is-subsequence/
         if(s == String.Empty){
             return true;
         }else if(t == String.Empty){
             return false;
         }
            int left_pointer = 0; //short string
            int right_pointer = 0; //long string

            while(right_pointer < t.Length)
            {
                
                
               if(s[left_pointer] == t[right_pointer])
                {
                   
                    left_pointer++;
                    if(left_pointer >= s.Length){
                        return true;
                    }
                }
                
                    right_pointer++;
                
               
            }
            return false;
            

            
        
    
    
    }
}
