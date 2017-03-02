using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    public class QuickSort
    {
        public int[] sort(int[] input, int low, int high)
        {
            if(low < high)
            {
                int p = partition(input, low, high);
                sort(input, low, p - 1);
                sort(input, p + 1, high);
            }
            return input;
        }

        private int partition(int[] input, int low, int high)
        {
            int pivot = input[high];
            int i = low - 1;
            for(int j = low; j < high - 1; j++)
            {
                if(input[j] <= pivot)
                {
                    i = i + 1;
                    int innerSwap = input[i];
                    input[i] = input[j];
                    input[j] = innerSwap;
                }
            }
            int outerSwap = input[i + 1];
            input[i + 1] = input[high];
            input[high] = outerSwap;
            return i + 1; 
        }
    }
}
