using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisterDictionaryProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var pm = new Dictionary<int, PMDetails>
            {
                {1998, new PMDetails("Atal Bihari Vajpayi")},
                {2014, new PMDetails("Narendra Modi")},
                {2004, new PMDetails("Manmohan singh")},
            };

            foreach (var p in pm)
                Console.WriteLine(p);

            PMDetails pr = pm[2004];
            Console.WriteLine("prime minister of 2004 is " + pr.ToString());

            pm.Add(2017, new PMDetails("Modi"));
            
            Console.WriteLine("after adding current pm:");
            foreach (var p in pm)
                Console.WriteLine(p);

            Console.WriteLine("\nafter sorting:");
            var list = pm.Keys.ToList();
            list.Sort();

            foreach (var item in list)
                Console.WriteLine("{0}:{1}", item, pm[item]);

            Console.WriteLine("\n read only dictionary");
            IReadOnlyDictionary<int, PMDetails> rpm = pm;
            foreach (var p in rpm)
                Console.WriteLine(p);
            

           
            
        }
    }
}
