 static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input += 1;
            double[] result = new double[input+1];
            int s = 0;
            for(int x =1; x<input; x++)
            {
                result[x] = x;  
            }
            //
            for (int x = 1; x < input; x++)
            {
                result[x] = result[x] * result[x];
            }
           
                Console.WriteLine(result.Sum());
            
            //
           
            Console.ReadLine();
        }
