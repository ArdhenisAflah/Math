static void Main(string[] args)
        {

            //untuk soal nanti diupload di github.
            //complexity = i think the worst case is O(n log n) for loop is linear i think just O(n) and the domination is Array.Sort... QuickSort ALgorithm.
            
            int changer = int.Parse(Console.ReadLine());
            
            int rumus = 2 * changer - 1;
            int[] energi = new int[rumus];

            for(int x = rumus-1; x > -1; x--) 
            {
                energi[x] = int.Parse(Console.ReadLine());
                

            }
            Array.Sort(energi);
            //Array.Reverse(energi);
           
            for (int x = 0; x < energi.Length; x++)
            {
              
                

                if (energi[x] < 0 && changer > 0)
                {
                    changer -= 1;

                    energi[x] = Math.Abs(energi[x]);

                }
                else
                {

                }

            }

            Console.WriteLine(energi.Sum());


            Console.ReadLine();


           
        }
