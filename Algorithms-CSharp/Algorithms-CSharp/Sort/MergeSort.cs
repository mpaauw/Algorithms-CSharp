using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    /// <summary>
    /// Class including code to perform a Merge Sort.
    /// Efficiency: O(n log(n))
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// Takes an unsorted array and performs a Merge Sort on it.
        /// </summary>
        /// <param name="input">Unsorted array to be processed within the sort.</param>
        /// <returns>Returns the sorted integer array.</returns>
        public int[] sort(int[] input)
        {
            if(input.Length < 2)
            {
                return input;
            }
            return merge(sort(input.Take(input.Length / 2).ToArray()), sort(input.Skip(input.Length / 2).ToArray()));
        }

        /// <summary>
        /// Method which takes two unsorted arrays and merges them.
        /// </summary>
        /// <param name="arr1">First array to be used in merge.</param>
        /// <param name="arr2">Second array to be used in merge.</param>
        /// <returns>Returns an array of sorted integers comprised of elements from both input arrays.</returns>
        private int[] merge(int[] arr1, int[] arr2)
        {
            int[] mergedArr = new int[arr1.Length + arr2.Length];

            int iter1 = 0, iter2 = 0, mergedIter = 0;
            while(iter1 < arr1.Length && iter2 < arr2.Length)
            {
                if(arr1[iter1] > arr2[iter2])
                {
                    mergedArr[mergedIter] = arr2[iter2];
                    iter2++;
                    mergedIter++;
                }
                else
                {
                    mergedArr[mergedIter] = arr1[iter1];
                    iter1++;
                    mergedIter++;
                }
            }
            while(iter1 < arr1.Length)
            {
                mergedArr[mergedIter] = arr1[iter1];
                iter1++;
                mergedIter++;
            }
            while(iter2 < arr2.Length)
            {
                mergedArr[mergedIter] = arr2[iter2];
                iter2++;
                mergedIter++;
            }
            return mergedArr;
        }        
    }
}
