using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace HackerrankSolutionList
{
    class Program
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool DefineDosDeviceW(uint dwFlags, string lpDeviceName, string lpTargetPath);
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern bool MoveFileExW(string file, string newfile, uint dwflag);

        private const string dosdevname = "RIPlace";

        private const uint DDD_REMOVE_DEFINITION = 0x00000002;
        private const uint DDD_RAW_TARGET_PATH = 0x00000001;
        private const uint MOVEFILE_REPLACE_EXISTING = 0x00000001;
        private const uint MOVEFILE_WRITE_THROUGH = 0x00000008;
        private const string dosdevpath = @"\\.\" + dosdevname;



        static void Cleanup(string filedelete = null)
        {

            DefineDosDeviceW(DDD_REMOVE_DEFINITION | DDD_RAW_TARGET_PATH, dosdevname, string.Empty);
            try
            {
                File.Delete(filedelete);
            }
            catch
            {

            }
        }
        public static bool RIPlace(string sourcepath, string destination)
        {
            //masukkan kode ini ke main function jika diperlukan.
            const string dummyfile = @"D:\TARGET\JUSTTXT.txt";
            const string targetfile = @"D:\TARGET\source.txt";


            RIPlace(dummyfile, targetfile);

            Console.ReadLine();

            //
            if (!DefineDosDeviceW(DDD_RAW_TARGET_PATH, dosdevname, @"\??\" + destination)) {
                Console.WriteLine("pokoknya gabisa udh gausah banyak cincong");
                return false;
            } if (!MoveFileExW(sourcepath, dosdevpath, MOVEFILE_REPLACE_EXISTING | MOVEFILE_WRITE_THROUGH))
            {
                Console.Write("gabisa");
                Cleanup(); //THIS IMPORTANT
                return false;
            }
            return true;
        }
        //static int MaxToys(List<int> price,int budget)
        //{
        //    int max_value = 0;
        //    Array.Sort(price.ToArray());
        //    if(price.Count() < 1 || price.Count() < 0)
        //    {
        //        return max_value;
        //    }


        //}
        
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
            //ini metode alternatif walaupun mungkin sufficient tetapi ini adlaah metode yang paling sederhana.
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
            //for (int x = 0; x < 5; x++)
            //{


            //    for (int c = 0; c < 5; c++)
            //    {

            //        Console.WriteLine(matrix[x, c]); 
            //    }
            //}
          
            Console.ReadLine();

        }
        static int MaxValue(long result)
        {
            //fibonacci DP
            int[] memo = new int[result + 1];
            memo[0] = 1;
            memo[1] = 1;
            memo[2] = 2;
            for (int x = 3; x <= result; x++)
            {
                memo[x] = memo[x - 1] + memo[x - 2] + memo[x - 3];
            }
            return memo.Last();


        }
    }
}
