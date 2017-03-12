using System;
using System.Linq;

namespace Task1
{
    public class MergeSort
    {
        static int[] Merge(int[] array1, int[] array2)
        {
            int currentIndex1 = 0, currentIndex2 = 0;
            int[] mergedArray = new int[array1.Length + array2.Length];

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if (currentIndex2 < array2.Length && currentIndex1 < array1.Length)
                {
                    if (array1[currentIndex1] > array2[currentIndex2])
                    {
                        mergedArray[i] = array2[currentIndex2++];
                    }
                    else
                    {
                        mergedArray[i] = array1[currentIndex1++];
                    }
                }
                else if (currentIndex2 < array2.Length)
                {
                    mergedArray[i] = array2[currentIndex2++];
                }
                else
                {
                    mergedArray[i] = array1[currentIndex1++];
                }
            }
            return mergedArray;
        }

        public static int[] Sort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();

            if (array.Length == 1)
                return array;

            int middlePoint = array.Length / 2;
            return Merge(Sort(array.Take(middlePoint).ToArray()), Sort(array.Skip(middlePoint).ToArray()));
        }
    }
}
