﻿using System;
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
    class SelectionSort
    {
        /// <summary>
        /// Takes an unsorted integer array and performs a Selection Sort on it.
        /// </summary>
        /// <param name="input">Unsorted int array to be sorted.</param>
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