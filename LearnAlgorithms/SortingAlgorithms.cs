using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithms
{
    public class SortingAlgorithms
    {
        public List<int> SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]<array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array.ToList();
        }

    }
}
