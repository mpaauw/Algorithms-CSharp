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

            int[] arr1 = input.Take(input.Length / 2).ToArray();
            int[] arr2 = input.Skip(input.Length / 2).ToArray();

            arr1 = sort(arr1);
            arr2 = sort(arr2);

            return merge(arr1, arr2);
        }

        private int[] spliceArray(int[] input, int start, int end)
        {
            int[] newArray = new int[(end - start) + 1];
            int iter = 0;
            for(int i = start; i < end - 1; i++)
            {
                newArray[iter] = input[i];
                iter++;
            }
            return newArray;
        }

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
