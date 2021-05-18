 //hackerrank problem.. ez level.
 
 public static void plusMinus(List<int> arr)
    {
        decimal negatif = 0;
decimal zero = 0;
decimal positif = 0;
        for(int i=0; i<arr.Count(); i++)
        {
            //Printing negative elements
            if(arr[i] < 0)
            {
                negatif = negatif +1;
            }if(arr[i] ==0){
                zero = zero +1;
            }if(arr[i] > 0){
                positif = positif +1;
            }
        }
         Decimal dd1 =Decimal.Divide(positif,arr.Count());
          Decimal dd2 =Decimal.Divide(negatif,arr.Count());
           Decimal dd3 =Decimal.Divide(zero,arr.Count());
          Console.WriteLine(dd1.ToString("N6"));
          Console.WriteLine(dd2.ToString("N6"));
          Console.WriteLine(dd3.ToString("N6"));

    }
