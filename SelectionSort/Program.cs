using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 88, 92, 64, 92, 18, 31, 84, 7, 30, 75 };

            int smallestIndex, smallestElement;

            //Print to the console the initial state of the array.
            PrintArray(array);

            //First loop that does the selection part of the algorithm and
            //builds the sorted part of the array.
            for (int i = 0; i < array.Length; i++)
            {
                //Assume the current index contains the smallestElement.
                smallestIndex = i;

                //Second loop that does the comparison part of the algorithm
                //starting the loop in the position right after the selected
                //by the first loop.
                for (int j = i + 1; j < array.Length; j++)
                {
                    //Compare the element stored in the smallestIndex against
                    //the one stored in the current iteration position.
                    //If it is smaller, we store the index.
                    if (array[j] < array[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                //Swap the smallestElement found with the current iteration
                //position value.
                smallestElement = array[smallestIndex];
                array[smallestIndex] = array[i];
                array[i] = smallestElement;
            }

            PrintArray(array);
        }


        //Iterates the array and prints each element to the console.
        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("");
        }
    }
}
