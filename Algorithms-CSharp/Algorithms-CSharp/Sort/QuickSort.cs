using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    /// <summary>
    /// Class including code to perform a Quick Sort.
    /// Efficiency: O(n^2)
    /// Algorithm implemented using the Lomuto partition scheme.
    /// </summary>
    public class QuickSort
    {
        /// <summary>
        /// Takes an unsorted array, with low and high markers, and performs a Quick Sort on it.
        /// </summary>
        /// <param name="input">Unsorted array to be processed within the sort.</param>
        /// <param name="low">Int value representing low marker within array.</param>
        /// <param name="high">Int value representing high marker within array.</param>
        /// <returns>Returns the sorted integer array.</returns>
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

        /// <summary>
        /// Algorithm used to find a pivot point within the array to be used when sorting.
        /// </summary>
        /// <param name="input">Unsorted array to be processed.</param>
        /// <param name="low">Int value representing low marker within array.</param>
        /// <param name="high">Int value representing high marker within array.</param>
        /// <returns>Returns an int value representing a new pivot index within the array.</returns>
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
