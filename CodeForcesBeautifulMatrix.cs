using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace HackerrankSolutionList
{
    class Program
    {

      
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            int rowTarget = 2;
            int columnTarget = 2;

            int rows = 0;
            int columns = 0;

            for (int x = 0; x < 5; x++)
            {
                string d = Console.ReadLine();
                string[] proses = d.Split(' ');

                for (int c = 0; c < 5; c++)
                {
                  if(int.Parse(proses[c]) == 1)
                    {
                        rows = x;
                        columns = c;
                    }
                   matrix[x, c] = int.Parse(proses[c]);
                }
            }
            //ini metode cepat(cukup cepat wkwkw) kalau mau lebih cepat tinggal cek pas matrix = 1 copy rows sama column nya trus lakuin kauyak dibawah.
            Console.WriteLine(Math.Abs(rowTarget - rows) + Math.Abs(columnTarget - columns));
            //ini metode alternatif walaupun mungkin sufficient tetapi ini adlaah metode yang paling sederhana(perlu ditingkatkan sedikit lagi untuk Optimasi).
            int rowChanged = 0;
            int ColumnChanged = 0;
            bool stop1 = false;
            bool stop2 = false;
            for (; ; )
            {
                if (stop1 == true && stop2 == true)
                {
                    Console.WriteLine(ColumnChanged+rowChanged);
                    break;
                    return;
                }
                    if (rows < rowTarget)
                {
                    rows = rows + 1;
                  
                    
                    rowChanged++;




                }
                else
                {
                    stop1 = true;
                }
                if(columns < columnTarget)
                {
                    columns = columns + 1;
                    ColumnChanged++;
                }
                else
                {
                    stop2 = true;
                }

                
                
            }
            bool stopp1 = false;
            bool stopp2 = false;
            for (; ; )
            {
               
                    if (stopp1 == true && stopp2 == true)
                    {
                        Console.WriteLine(ColumnChanged + rowChanged);
                        break;
                        return;
                    }
                    
                
                if (rows > rowTarget)
                {
                    rows = rows - 1;
                    rowChanged++;


                }
                else{
                    stopp1 = true;
                }
                if (columns > columnTarget)
                {
                    columns = columns - 1;
                    ColumnChanged++;


                }
                else
                {
                    stopp2 = true;
                }

            }
            
            Console.ReadLine();

        }
      
    }
}
