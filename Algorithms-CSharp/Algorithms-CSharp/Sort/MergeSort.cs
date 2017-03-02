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
            if(input.Length < 2)
            {
                return input;
            }

            int[] arr1 = spliceArray(input, 0, input.Length / 2);
            int[] arr2 = spliceArray(input, (input.Length / 2) + 1, input.Length);

            arr1 = sort(arr1);
            arr2 = sort(arr2);

            return merge(arr1, arr2);
        }

        private int[] spliceArray(int[] input, int start, int end)
        {
            int[] newArray = new int[end - start];
            for(int i = start; i < end; i++)
            {
                newArray[i] = input[i];
            }
            return newArray;
        }

        private int[] merge(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length];
            int i = 0, iter = 0;
            for(i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                if(arr1[i] > arr2[i])
                {
                    arr3[iter] = arr2[i];
                    iter++;
                }
                else
                {
                    arr3[iter] = arr1[i];
                    iter++;
                }
            }
            for(int j = i; j < arr1.Length; j++)
            {
                arr3[iter] = arr1[j];
                iter++;
            }
            for(int j = i; j < arr2.Length; j++)
            {
                arr3[iter] = arr2[j];
                iter++;
            }
            return arr3;
        }

        //public int[] sort(int[] input)
        //{
        //    int[] inputB = input;
        //    splitMerge(input, inputB, 0, input.Length);
        //    return input;
        //}

        //private void splitMerge(int[] inputA, int[] inputB, int start, int end)
        //{
        //    if(end - start < 2)
        //    {
        //        return;
        //    }
        //    int mid = (end + start) / 2;
        //    splitMerge(inputA, inputB, start, mid);
        //    splitMerge(inputA, inputB, mid, end);

        //    merge(inputB, inputA, start, mid, end);
        //}

        //private void merge(int[] inputA, int[] inputB,int start, int mid, int end)
        //{
        //    int i = start, j = mid;
        //    for(int k = start; k < end; k++)
        //    {
        //        if(i < mid && (j >= end || inputA[i] < inputA[j]))
        //        {
        //            inputB[k] = inputA[i];
        //            i = i + 1;
        //        }
        //        else
        //        {
        //            inputB[k] = inputA[j];
        //            j = j + 1;
        //        }
        //    }
        //}
        
    }
}
