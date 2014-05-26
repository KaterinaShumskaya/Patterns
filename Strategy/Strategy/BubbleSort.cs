using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class BubbleSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var v = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = v;
                    }
                }
            }
        }
    }
}
