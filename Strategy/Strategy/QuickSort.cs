using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class QuickSort : Strategy
    {
        private int Partition(ref int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        private void DoSort(ref int[] array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = this.Partition(ref array, start, end);
            this.DoSort(ref array, start, pivot - 1);
            this.DoSort(ref array, pivot + 1, end);
        }

        public override void Sort(ref int[] array)
        {
            this.DoSort(ref array, 0, array.Length-1);
        }
    }
}
