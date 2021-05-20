public static int maximumToys(List<int> prices, int k)
    {
        
            int max_value = 0;
            prices.Sort();
            if (prices.Count() < 1 || prices.Count() < 0 || k == 0)
            {
               return 0;
            }

            for(int x =0; x < prices.Count(); x++){
                k -= prices[x];
                if(k < prices.Min()){
                    break;
                }
                max_value++;   
                }
                return max_value;
       }
           
        
