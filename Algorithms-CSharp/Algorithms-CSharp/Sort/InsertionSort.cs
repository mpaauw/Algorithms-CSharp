using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    /// <summary>
    /// Class including code to perform an Insertion Sort.
    /// Efficiency: O(n^2)
    /// </summary>
    class InsertionSort
    {
        /// <summary>
        /// Takes an unsorted array and performs an Insertion Sort on it.
        /// </summary>
        /// <param name="input">Unsorted array to be processed within the sort.</param>
        /// <returns>Returns the sorted integer array.</returns>
        public int[] sort(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                int j = i;
                while((j > 0) && (input[j] < input[j - 1]))
                {
                    int temp = input[j];
                    input[j] = input[j - 1];
                    input[j - 1] = temp;
                    j -= 1;
                }
            }
            return input;
        }
    }
}
