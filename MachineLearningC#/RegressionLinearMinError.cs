using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegresiLInear
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] bebas = new float[4];
            Console.WriteLine("--Regresi Linear--");
            
            Console.WriteLine("Masukkan DataTraining(variabel bebas): ");
            
            for (int x = 0; x < bebas.Length; x++)
            {
                bebas[x] = int.Parse(Console.ReadLine());
            }

            //copy data bebas ke bebas1
            float[] bebas1 = new float[4];
            for(int x =0; x < bebas.Length; x++)
            {
                bebas1[x] = bebas[x];
            }
            //end

            float[] terikat = new float[4];
            Console.WriteLine("Masukkan DataTraining(variabel terikat): ");

            for (int v = 0; v < terikat.Length; v++)
            {
                terikat[v] = int.Parse(Console.ReadLine());
            }
            //copy data terikat ke terikat1
            float[] terikat1 = new float[4];
            for(int cx = 0; cx < terikat.Length; cx++)
            {
                terikat1[cx] = terikat[cx];
            }
            
            
            //end

            //cari rata rata bebas dan terikat
           
            
                //get total bebas
                float total = bebas.Sum();

                //get total terikat
                float total2 = terikat.Sum();

            //get rata rata
            float rata = total / bebas.Length;
            //get rata rata 
            float rata2 = total2 / terikat.Length;

            Console.WriteLine("rata rata variabel bebas: {0}", rata);
            Console.WriteLine($"rata rata variabel terikat: {rata2}");

            //Kurangi setiap data variabel bebas dan variabel terikat dengan hasil rata rata
        
            for (int z = 0; z < bebas.Length; z++)
            {
               bebas[z] =  bebas[z] - rata;
            }
          
            for (int jz = 0; jz < terikat.Length; jz++)
            {
              terikat[jz] = terikat[jz] - rata2; 
            }
            //kalikan hasil sebelumnya

            float[] hasilkali = new float[4];
            for(int zx = 0; zx < bebas.Length; zx++)
            {
                hasilkali[zx] = bebas[zx] * terikat[zx];
            }
            //tampilkan hasil kurang
            foreach (float fs in bebas) {

                Console.WriteLine($"sebelum kuadrat: {fs}");

              
            }
            //hasil kuadrat
            
            foreach(float fd in bebas)
            {
               
                Console.WriteLine($"sudah kuadrat:{fd}");
            }
            //total (nilai M) M = /(bebas/bawah)
        


            //total (nilai M) M = (atas)
            foreach (float hasilKali in hasilkali) 
            {
                Console.WriteLine("Total Kali: {0}",hasilKali);
            }
            var hasilkalii = hasilkali.Sum();
            for(int c = 0; c < bebas.Length; c++)
            {
                bebas[c] = bebas[c] * bebas[c];
            }
            Console.WriteLine($"M= {hasilkalii}");
            Console.WriteLine($"M= {bebas.Sum()}");

            var Final = hasilkalii / bebas.Sum();
            Console.WriteLine($"Final M ={Final}");

            var final2 = rata2 - Final * rata;
            Console.WriteLine($"b = {rata2} - {Final} * {rata} ");
            
            Console.WriteLine("Final Equation: {0}", Final.ToString()+" * x + "+final2.ToString());
            Console.WriteLine("ket: x = input/variabel bebas");

            Console.WriteLine("-----------------------------------------------------------------");
            
            //display error value
            for(int er = 0; er < bebas1.Length; er++)
            {
               
                Console.WriteLine($"Output Test: { Final * bebas1[er] + final2}");
                Console.WriteLine("Predict Error:{0}", (Final * bebas1[er] + final2) - terikat1[er] );

            }
          

            Console.ReadLine();
        }
    }
}
