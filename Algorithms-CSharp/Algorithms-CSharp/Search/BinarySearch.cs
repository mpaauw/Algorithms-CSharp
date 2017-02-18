using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Search
{
    /// <summary>
    /// Class including code to perform a Binary Search.
    /// Efficiency: O(log n)
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// Takes an sorted array and performs a Binary Search on it.
        /// </summary>
        /// <param name="inputArray">Sorted array to be parsed during the search.</param>
        /// <param name="searchTerm">Term to be searched for within the array.</param>
        /// <returns>Returns a boolean value; true if the term is present within the array, false if otherwise.</returns>
        public bool search(int[] inputArray, int term, int min, int max)
        {
            int mid = (min + max) / 2;
            if(min > max)
            {
                return false;
            }
            else if(term == inputArray[mid])
            {
                return true;
            }
            else if(term < inputArray[mid])
            {
                return search(inputArray, term, min, mid - 1);
            }
            else
            {
                return search(inputArray, term, mid + 1, max);
            }
        } 
    }
}
