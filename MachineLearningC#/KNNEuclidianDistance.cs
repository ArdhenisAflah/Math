using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegresiLInear
{
    class Program
    {
        /// <summary>
        /// program ini menggunakan 2 inputan - 3 inputan bisa kalian improve di "bagian inputan"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //bagian inputan
            try
            {
                Console.WriteLine("Jumlah Column Data:");
                int jum = int.Parse(Console.ReadLine());


                float[] jumTraining1 = new float[jum];
                float[] jumTraining2 = new float[jum];
                float[] label = new float[jum];

                float[] jums1 = new float[jum];
                float[] jums2 = new float[jum];
                //sub bagian penampung inputan
                for (int x = 0; x < jumTraining1.Length; x++)
                {
                    Console.WriteLine("masukkan dataTraining1:");
                    jumTraining1[x] = float.Parse(Console.ReadLine());
                    Console.WriteLine("masukkan dataTraining2:");
                    jumTraining2[x] = float.Parse(Console.ReadLine());

                    Console.WriteLine("---LABEL---");
                    Console.WriteLine("Input The Label:");
                    label[x] = float.Parse(Console.ReadLine());

                    jums1[x] = jumTraining1[x];
                    jums2[x] = jumTraining2[x];
                }

                Console.WriteLine("Input Test Value(1) Here:");
                float test = float.Parse(Console.ReadLine());
                Console.WriteLine("Input Test Value(2) Here:");
                float test1 = float.Parse(Console.ReadLine());

                Console.WriteLine("K:");
                float k = float.Parse(Console.ReadLine());

                //Training your data.
                //Ex:
                double[] db = new double[jum];
                double[] de = new double[jum];
                for (int i = 0; i < jumTraining1.Length; i++)
                {
                    db[i] = Math.Sqrt((jumTraining1[i] - test) * (jumTraining1[i] - test) + (jumTraining2[i] - test1) * (jumTraining2[i] - test1));
                    Console.WriteLine(db[i]);
                    de[i] = db[i];
                    Console.ReadLine();

                }

                //ranking the data
                Array.Sort(db);

                int cv = 0;
                for (int j = 0; j < 3; j++)
                {
                    cv++;
                    Console.WriteLine("Ranking{0}:" + db[j], cv);
                }



                //end

                //Final Output

                //1.Isi Nilai baru ke array jumtraning1 dan jumtraining2 dari label 
              
                if (jumTraining1.Length % 2 == 0)
                {
                    //copy data
                    float[] IsBad = new  float[jum];
                    for (int j = 0; j < jum; j++)
                    {

                        IsBad[j] = jumTraining1[j] = label[j];




                    }
                    int sa = 0;
                    for(int cd = 0; cd < IsBad.Length; cd++)
                    {
                        sa++;
                        Console.WriteLine("---"+IsBad[cd]+"---");
                        Console.WriteLine("Perbandingannya");
                        if (de[cd] <= k)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Hasil Euclidian({sa}):" + de[cd]);
                            
                        }
                        else
                        {
                            continue;
                            Console.ResetColor();
                        }
                        Console.ResetColor();
                        Console.WriteLine("+++"+jums1[cd].ToString()+" "+jums2[cd].ToString()+"+++");
                       
                    }
                }
                else
                {
                    return;
                }

                //2.menghitung dominasi 

              

                Console.ReadLine();
             



            }
            catch (Exception e)
            {
                Console.WriteLine($"Error Occured:{e}");
                Console.ReadLine();
            }
        }


    }
}
