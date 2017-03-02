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
            List<int> list1 = arr1.ToList();
            List<int> list2 = arr2.ToList();

            List<int> newList = new List<int>();
            while(list1.Count() > 0 && list2.Count() > 0)
            {
                if(list1[0] > list2[0])
                {
                    newList.Add(list2[0]);
                    list2.RemoveAt(0);
                }
                else
                {
                    newList.Add(list1[0]);
                    list1.RemoveAt(0);
                }
            }
            while(list1.Count() > 0)
            {
                newList.Add(list1[0]);
                list1.RemoveAt(0);
            }
            while(list2.Count() > 0)
            {
                newList.Add(list2[0]);
                list2.RemoveAt(0);
            }
            return newList.ToArray();
        }        
    }
}
