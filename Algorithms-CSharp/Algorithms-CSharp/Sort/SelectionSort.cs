using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    /// <summary>
    /// Class including code to perform a Selection Sort.
    /// Efficiency: O(n^2)
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// Takes an unsorted array and performs a Selection Sort on it.
        /// </summary>
        /// <param name="input">Unsorted array to be processed within the sort.</param>
        /// /// <returns>Returns the sorted integer array.</returns>
        public int[] sort(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < input.Length; j++)
                {
                    if(input[j] < input[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if(minIndex != i)
                {
                    int temp = input[i];
                    input[i] = input[minIndex];
                    input[minIndex] = temp;
                }               
            }
            return input;
        }
    }
}
