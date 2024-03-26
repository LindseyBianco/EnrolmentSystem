using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystem
{
    class Utility
    {
        // Part 02 - Sorting and Searching Specifications
        // Part 02.01 - Searching

        // sequential search linear
        /// <summary>
        /// Performs a linear search on an array to find the index of a target element.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable.</typeparam>
        /// <param name="inputArray">The array to search through.</param>
        /// <param name="target">The target element to find.</param>
        /// <returns>The index of the target element if found, otherwise -1.</returns>
        public static int LinearSearchArray<T>(T[] inputArray, T target) where T : IComparable<T>
        {
            int index = 0;
            bool found = false;

            while (!found && index < inputArray.Length)
            {
                if (target.CompareTo(inputArray[index]) == 0)
                    found = true;
                else index++;
            }
            if (index < inputArray.Length)
                return index;
            else
                return -1;
        }

        // binary search method
        /// <summary>
        /// Performs a binary search on a sorted array to find the index of a target element.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array, must implement IComparable.</typeparam>
        /// <param name="inputArray">The sorted array to search in.</param>
        /// <param name="target">The target element to find.</param>
        /// <returns>The index of the target element in the array, or -1 if not found.</returns>
        public static int BinarySearchArray<T>(T[] inputArray, T target) where T : IComparable<T>
        {
            Array.Sort(inputArray);
            int min = 0;
            int mid;
            int max = inputArray.Length - 1;

            do
            {
                mid = (min + max) / 2;
                int comparison = inputArray[mid].CompareTo(target);
                
                if (comparison == 0)
                    return mid;
                else if (comparison < 0)
                    min = mid + 1;
                else
                    max = mid - 1;
            } while (min <= max);

            return -1;
        }

        public static void BubbleSortAscending<T>(T[] inputArry) where T : IComparable<T>
        {
            for (int j = 0; j < inputArry.Length - 1; j++)
            {
                for (int i = 0; i < inputArry.Length - 1; i++)
                {
                    if (inputArry[i].CompareTo(inputArry[i + 1]) > 0)
                    {
                        T temp = inputArry[i + 1];
                        inputArry[i + 1] = inputArry[i];
                        inputArry[i] = temp;
                    }
                }
            }
        }
    }
}
