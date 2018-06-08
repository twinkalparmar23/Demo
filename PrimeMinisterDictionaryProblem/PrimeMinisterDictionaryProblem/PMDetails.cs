using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMinisterDictionaryProblem
{
    class PMDetails
    {
        public string Name { get; private set; }
        //public int Year { get; private set; }

        public PMDetails(string name)
        {
            this.Name = name;
            //this.Year = year;
        }

        public override string ToString()
        {
            return string.Format("{0}",Name);
        }
    }
}
