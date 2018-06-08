using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictionaryOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] array =
            {
                "Boat",
                "House",
                "cat",
                "river",
                "cupboard"
            };
        
           

            foreach (string a in array)
                Console.WriteLine(a);

            
            array[1] = "home";
            Console.Write("\nafter replacing second word:\n");
            foreach (string a in array)
                Console.WriteLine(a);

            Console.WriteLine("\n words with 7 characters:\n");
            string[] all7chars = Array.FindAll(array, x => x.Length == 7);
            foreach (string item in all7chars)
                Console.WriteLine(item);

            Console.WriteLine("\n");

            //for (i = 0; i < array.Length; i++)
            //{
            //    array[i] = array[i] + "s";
            //}

            Console.Write("\nplurals:\n");
            foreach (var p in array)
                Console.WriteLine(p + "s");

            
            //foreach (string a in array)
            //    Console.WriteLine(a);

            Array.Reverse(array);
            Console.WriteLine("\nReverse array:");
            foreach (string a in array)
                Console.WriteLine(a);


            Console.WriteLine("\nword at 3rd position:" + array[2]);
            Console.WriteLine("\nlength of list:" + array.Length);


            var comparer = new lengthcompare();
            Array.Sort(array,comparer);
            Console.WriteLine("\nascending oreder:");
            foreach (string a in array)
                Console.WriteLine(a);


        }

        class lengthcompare : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
    }
}
