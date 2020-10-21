using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithms
{
    public class SortingAlgorithms
    {
        public static List<int> SelectionSort(int[] array)
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
        public static List<int> BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array.ToList();
        }


    }
}
