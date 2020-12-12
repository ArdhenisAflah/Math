using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.TimeSeries;
using Microsoft.ML.Data;

namespace MAchine
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasikan
            int[] akun = {20,10,15,20,25,30,5,45,35,90,67 };

            //convert to list
            List<Account> widrawal = akun.Select(amount => new Account { Saldo=amount }).ToList();

            IEnumerable<int[]> ie = from val in Enumerable.Range(0,10) select akun;
            List<int> ls = new List<int>();
            ls.Select(x => ie.ToList() );

            ls.ForEach(Console.WriteLine);
            //widrawal == akun
            var ml = new MLContext();

            //we use tidspike for check spike in data (unsual number)

            var algorithm = ml.Transforms.DetectIidSpike(outputColumnName: nameof(Prediction.Output), inputColumnName: nameof(Account.Saldo), confidence: 99, pvalueHistoryLength: akun.Length / 2);

            
            IDataView amountdata = ml.Data.LoadFromEnumerable(widrawal);
            var pipeline = algorithm.Fit(amountdata).Transform(amountdata);

            List<Prediction> predictions = ml.Data.CreateEnumerable<Prediction>(pipeline, reuseRowObject: false).ToList();
        
            //display prediction

            foreach(Prediction prd in predictions)
            {
                ///<summary return 0 or 1 if a some data spike>
                double IsAnomaly = prd.Output[0];
                ///</summary>
                ///this for get value data
                double val = prd.Output[1];
                ///
                
                Console.WriteLine("Found Anomaly - {0}", IsAnomaly + Environment.NewLine + "Value Of Data: " + val);
            }
            Console.ReadLine();
        }
    }

    class Account
    {
        public float Saldo { get; set; } 
    }
    class Prediction
    {
        [VectorType]
        public double[] Output { get; set; }
    }

  
}
