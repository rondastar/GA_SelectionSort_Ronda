# GA_SelectionSort_Ronda

Selection Sort Pseudocode:

Save the length of the array

Iterate through the array from the first element to the next to last element.
Save the index of the current element as the minimum index.

Iterate through the unsorted array from the element after the current element to the last element.
If the value in the index of the unsorted array is less than the minimum index, 
assign the current index in the unsorted array as the minimum index.
When the inner loop ends, the minimum index will be the index of the lowest value in the unsorted array. 

In the outer loop, swap the values of the minimum index and the current index in the array. 
A placeholder variable is needed for the swap. The swap places the minimum value of the unsorted section 
of the array at the end of the sorted section of the array. The value that was at the current index is 
moved to the index that previously held the minimum value in the unsorted array, so that no values are lost.


