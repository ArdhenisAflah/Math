using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

  static void Main(string[] args)
        {
            //Gemstone Hackerrank.
            //constraint -> [a-z].

            var chars = new[] { 'a', 'b', 'c', 'd', 'e'};
            List<string> ss = new List<string>();
            ss.Add("abcdde");
            ss.Add("baccd");
            ss.Add("eeabg");


            string result = "";
            for (int x = 1; x < ss.Count(); x++) {
                foreach (var d in chars.Where(ss[x].Contains))
                {
                    result += d;
                }
            }
            //check duplicate chars.
            var set = new HashSet<string>();
            var duplicate = result.Where(x => !set.Add(x.ToString()));
           

            foreach(var d in duplicate)
            {
                Console.WriteLine(d);
            }

                


            Console.ReadLine();

           

}
