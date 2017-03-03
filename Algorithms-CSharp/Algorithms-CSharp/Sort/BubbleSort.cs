using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    public class BubbleSort
    {
        public int[] sort(int[] input)
        {
            bool swapped = true;
            int j = 0;
            while (swapped)
            {
                swapped = false;
                j++;
                for(int i = 0; i < input.Length - j; i++)
                {
                    if(input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            return input;
        }
    }
}
