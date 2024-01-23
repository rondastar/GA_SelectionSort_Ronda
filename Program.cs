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
            // test selection sort with int array
            int[] intArray = { 91, 72, 23, 14, 55, 96, 27, 88, 19, 10, 71, 42, 33, 64, 5 };
            PrintArray(intArray);
            SelectionSort(intArray);
            PrintArray(intArray);

            // test selection sort with char array
            char[] charArray = { 'z', 'b', 'f', 'y', 'd', 'c', 'k', 'w', 'r' };
            PrintArray(charArray);
            SelectionSort(charArray);
            PrintArray(charArray);

            // test selection sort with string array
            string[] stringArray = { "This", "is", "a", "grammatical", "sentence,", "but", "it", "won't", "be." };
            PrintArray(stringArray);
            SelectionSort(stringArray);
            PrintArray(stringArray);
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
                for (int j = i + 1; j < arrayLength; j++)
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

        static void PrintArray<T>(T[] array)
        {
            Console.Write("Array: ");
            foreach (T item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    } // class
} // namespace
