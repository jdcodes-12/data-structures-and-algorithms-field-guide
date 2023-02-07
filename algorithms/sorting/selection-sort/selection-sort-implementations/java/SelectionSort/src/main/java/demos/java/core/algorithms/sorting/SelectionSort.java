/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package demos.java.core.algorithms.sorting;

/**
 *
 * @author jdcodes-12
 */
public class SelectionSort {

    public static void main(String[] args) {
      int[] numbers = { 101, 30, 9, 47, 62, 65, 89, 700, 640};
      System.out.print("Unsorted list: ");
      displayList(numbers);
      runSelectionSort(numbers);
      System.out.print("Sorted list: ");
      displayList(numbers);
    }
   
    private static void runSelectionSort(int[] numbers) {
        int n = numbers.length;
        int minIndex, i, j, temp;
        
        for (i = 0; i < n; i++){
            minIndex = i;
            for (j = i+1; j < n; j++){
                if (numbers[j] < numbers[minIndex]) {
                    minIndex = j;
                }
            }
            
            temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }
    }
 
    private static void displayList(int[] numbers) {
    
        int moves = 0;
        
        System.out.print("[");
        for (int number : numbers) {
            if (moves == numbers.length - 1) 
                System.out.print(number);
            else {
                System.out.print(number + ", ");
                moves++;
            }
        }
        System.out.println("]");
    }
}
