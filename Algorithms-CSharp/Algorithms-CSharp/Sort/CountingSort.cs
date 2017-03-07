using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_CSharp.Sort
{
    public class CountingSort
    {
        public int[] sort(int[] input)
        {
            int max = input[0], min = input[0];
            int[] tempArray = input;
            foreach(int item in tempArray)
            {
                if(item > max)
                {
                    max = item;
                }
                if(item <= min)
                {
                    min = item;
                }
            }
            int[] indexArray = new int[(max - min) + 1];
            foreach (int item in tempArray)
            {
                indexArray[item - min]++;
            }
            int indexToInsert = 0, currentIndex = 0, finishIndex = indexArray.Length;
            while(currentIndex != finishIndex)
            {
                int instanceCount = indexArray[currentIndex];
                for(int j = 0; j < instanceCount; j++)
                {
                    input[indexToInsert++] = currentIndex + min;
                }
                currentIndex++;
            }
            return input;
        }
    }
}
