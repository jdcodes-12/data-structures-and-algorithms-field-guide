using System.Net.NetworkInformation;

namespace Algorithms.Sorting
{
    class SelectionSort { 
        static void Main(String[] args)
        {
            int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.Write("Unsorted List: ");
            DisplayList(numbers);
            RunSelectionSort(numbers);
            Console.Write("Sorted List: ");
            DisplayList(numbers);
        }

        static void DisplayList(int[] numbers)
        {
            
            int moves = 0;
            Console.Write("[");
            foreach (int number in numbers)
            {
                if (moves == numbers.Length - 1)
                    Console.Write(number);
                
                else
                {
                    Console.Write($"{number}, ");
                    moves++;
                }
            }
            Console.WriteLine("]");
        }

        static void RunSelectionSort(int[] unsortedArr)
        {
            int minIndex, i, j, temp;
            int n = unsortedArr.Length;

            for (i = 0; i < n; i++)
            {
                minIndex = i;
                for (j = i+1; j < n; j++)
                    if (unsortedArr[j] < unsortedArr[i])
                        minIndex = j;

                // Swap
                temp = unsortedArr[i];
                unsortedArr[i] = unsortedArr[minIndex];
                unsortedArr[minIndex] = temp;
            }
        }
    }
}