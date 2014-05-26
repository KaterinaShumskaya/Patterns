using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var strategy = new QuickSort();
            var array = new CustomArray(strategy);
            array.Sort();
            foreach (var el in array.Array)
            {
                Console.WriteLine(el);
            }

            Console.ReadKey();
        }
    }
}
