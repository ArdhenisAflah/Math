static void Main(string[] args)
        {
            //pertama tama buatlah jagged array dan isi sesuai problem.
            int[][] aktivitas = new int[4][];
            //rentang waktu a.i - a.x
            aktivitas[0] = new int[2] { 1, 3 };
            aktivitas[1] = new int[2] { 2, 6 };
            aktivitas[2] = new int[2] { 5, 7 };
            aktivitas[3] = new int[2] { 8, 9 };

            //base case
            // int[] result = new int[4];
            int result = 0;
            int TimeStart = 0;
            //end base case.
            Array.Sort(aktivitas[0]);
            foreach(var dd in aktivitas)
            {
                Console.WriteLine("Hasil Sorting: "+dd[1]);

            }
            for(int x = 0; x< aktivitas.Length; x++)
            {
                if(aktivitas[x][0] >= TimeStart)
                {
                    result += 1;

                    TimeStart = aktivitas[x][1];

                }
                
            }
            Console.WriteLine(result);
           

            Console.ReadLine();


           
        }
