using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    public class MergeSort
    {
        public int[] sort(int[] input)
        {
            int[] inputB = input;
            splitMerge(input, inputB, 0, input.Length);
            return input;
        }

        private void splitMerge(int[] inputA, int[] inputB, int start, int end)
        {
            if(end - start < 2)
            {
                return;
            }
            int mid = (end + start) / 2;
            splitMerge(inputA, inputB, start, mid);
            splitMerge(inputA, inputB, mid, end);

            //return?:
            merge(inputB, inputA, start, mid, end);
        }

        private void merge(int[] inputA, int[] inputB,int start, int mid, int end)
        {
            int i = start, j = mid;
            for(int k = start; k < end; k++)
            {
                if(i < mid && (j >= end || inputA[i] < inputA[j]))
                {
                    inputB[k] = inputA[i];
                    i = i + 1;
                }
                else
                {
                    inputB[k] = inputA[j];
                    j = j + 1;
                }
            }
        }
        
    }
}
