using System.Collections;

// Ronda Rutherford
// Selection Sort
// 1-23-24

namespace GA_SelectionSort_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        } // Main
        static void SelectionSort<T>(T[] array)
        {
            // Get the length of the input array
            int arrayLength = array.Length;

            // Iterate through the array
            for (int i = 0; i < arrayLength - 1; i++)
            {
                // Assume the current index as the minimum
                int minIndex = i;

                // Find the minimum element in the remaining unsorted array; j is the unsorted index
                for (int j = i + 1; j < arrayLength - 1; j++)
                {
                    if ( Comparer<T>.Default.Compare(array[j], array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                } // for

                // Swap the found minimum element with the element at the current index
                T temporary = array[i];
                array[i] = array[minIndex]; 
                array[minIndex] = temporary;
            } // for
        } // SelectionSort
    } // class
} // namespace
