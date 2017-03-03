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
            int n = input.Length;
            bool swapped = false;
            do
            {
                for(int i = 1; i <= n - 1; i++)
                {
                    if(input[i - 1] > input[i])
                    {
                        int temp = input[i - 1];
                        input[i - 1] = input[i];
                        input[i] = temp;
                        swapped = true;
                    }
                }
                n -= 1;
            } while (!swapped);
            return input;
        }
    }
}
