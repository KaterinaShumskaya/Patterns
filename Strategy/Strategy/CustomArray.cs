using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CustomArray
    {
        private readonly Strategy _strategy;

        private int[] _array;
 
        public CustomArray(Strategy strategy)
        {
            _strategy = strategy;
            _array = new[] {5,7,2,6,10,1,3,8,9};
        }

        public void Sort()
        {
            _strategy.Sort(ref _array);
        }

        public int[] Array
        {
            get
            {
                return _array;
            }
        }
    }
}
