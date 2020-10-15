using System;
using System.Collections.Generic;
using System.Text;

namespace LearnAlgorithms
{
    public class SearchAlgorithms
    {

        public static int LinearSearch(int[] array,int input)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
