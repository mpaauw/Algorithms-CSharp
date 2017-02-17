using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    /// <summary>
    /// 
    /// </summary>
    class SelectionSort
    {
        public void sort(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < input.Length; j++)
                {
                    if(input[j] < input[i])
                    {
                        minIndex = j;
                    }
                }
                int temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }
        }
    }
}
