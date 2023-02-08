using System.Net.NetworkInformation;

namespace Algorithms.Sorting
{
    class SelectionSort { 
        static void Main(String[] args)
        {
            int[] numbers = { 300, 275, 675, 90, 8, 5, 3, 2, 90, 91, 93, 800 };
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
            int minIndex, temp;
            int n = unsortedArr.Length;
            
            for (int i = 0; i < n - 1; i++)
            {
                minIndex = i;
                for (int j = i+1; j < n; j++)
                {
                    if (unsortedArr[j] < unsortedArr[minIndex])
                        minIndex = j;
                }

                temp = unsortedArr[minIndex];
                unsortedArr[minIndex] = unsortedArr[i];
                unsortedArr[i] = temp;
            }
        }
    }
}