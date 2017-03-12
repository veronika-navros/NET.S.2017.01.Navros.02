using System;
using static System.Console;

namespace Task1.CUI
{
    class Program
    {
        static void Main()
        {
            //Input
            Write("Enter array of integers: ");
            string enterString = ReadLine();
            if (enterString != null)
            {
                string[] stringsArray = enterString.Split(' ');
                int[] array = new int[stringsArray.Length];

                //Parsing entered string into integer array
                try
                {
                    for (int i = 0; i < stringsArray.Length; i++)
                    {
                        array[i] = int.Parse(stringsArray[i]);
                    }
                }
                catch (FormatException)
                {
                    Clear();
                    WriteLine("A non-numeric character found");
                    ReadKey();
                    return;
                }

                //Sorting the array
                array = MergeSort.Sort(array);

                //Output
                Clear();
                WriteLine("Sorted array:");
                foreach (int element in array)
                {
                    Write(element + " ");
                }
                ReadKey();
            }
        }
    }
}
