using System;
using System.Linq;

namespace Task1
{
    /// <summary>
    /// Implements the merge sort method for one-dimensional integer array
    /// </summary>
    public class MergeSort
    {
        #region Public Members

        /// <summary>
        /// Sorts the specified one-dimensional iteger array
        /// </summary>
        /// <param name="array">One-dimensional integer array for sorting</param>
        /// <returns> The sorted one-dimensional integer array </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int[] Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 1)
            {
                return array;
            }

            int middlePoint = array.Length / 2;
            return Merge(Sort(array.Take(middlePoint).ToArray()), Sort(array.Skip(middlePoint).ToArray()));
        }

        #endregion

        #region Private members

        /// <summary>
        /// Merges two sorted one-dimensional integer arrays into one 
        /// </summary>
        /// <param name="array1">The first one-dimensional integer array to merge</param>
        /// <param name="array2">The second one-dimensional integer array to merge</param>
        /// <returns>Sorted one-dimensional integer array consisting of elements of two source arrays</returns>
        /// <exception cref="ArgumentNullException"></exception>
        static int[] Merge(int[] array1, int[] array2)
        {
            if (array1 == null || array2 == null)
            {
                throw new ArgumentNullException();
            }

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

        #endregion
    }
}