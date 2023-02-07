#include <iostream>

static void runSelectionSort(int*, int);
static void displayList(int[], int);

int main() {
	int numbers[] = {900, 32, 75, 84, 35, 33, 21, 8, 9, 2, 1};
	int size = sizeof(numbers) / sizeof(numbers[0]);
	std::cout << "Unsorted List: ";
	displayList(numbers, size);
	runSelectionSort(numbers, size);
	std::cout << "Sorted List: ";
	displayList(numbers, size);
}

static void runSelectionSort(int* numbersArray, int size) {
	
	for (int i = 0; i < size - 1; i++) {
		int minIndex = i;
		for (int j = i + 1; j < size; j++) {
			if (numbersArray[j] < numbersArray[minIndex]) {
				minIndex = j;
			}
		}
		
		int temp = numbersArray[minIndex];
		numbersArray[minIndex] = numbersArray[i];
		numbersArray[i] = temp;
	}
}

static void displayList(int numbers[], int size) {
	int moves = 0;

	std::cout << "[";
	for (int i = 0; i < size; i++) {
		if (moves == size - 1)
			std::cout << numbers[i];
		else {
			std::cout << numbers[i] << ", ";
			moves++;
		}
	}
	std::cout << "]\n";
}