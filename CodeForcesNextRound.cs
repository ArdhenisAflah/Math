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
            string input = Console.ReadLine();
            string[] proses = input.Split(' ');
 
            
 
            //inputan setiap array.
            string Inputn = Console.ReadLine();
            string[] array = Inputn.Split(' ');
            int[] array1 = new int[int.Parse(proses[0])];
            //
            //base case
            for(int x =0; x < array.Length; x++)
            {
                array1[x] = int.Parse(array[x]);
            }
           int pos = int.Parse(proses[1]);
           int basis = int.Parse(array[pos-1]);
            //
            int count = 0;
           if (basis == 0 && array1.Sum() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
               for(int c =0; c < array1.Length; c++)
                {
                    if(array1[c] >= array1[pos - 1] && array1[c] > 0)
                    {
                        count++;
                        
                    }
                }
                Console.WriteLine(count);
            }
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
