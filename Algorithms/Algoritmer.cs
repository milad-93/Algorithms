using System;

namespace Algorithms
{
    public class Algoritmer
    {
        // this method takes an array and 2 positions as input and swaps the positions of the values
        public static void Swap(int[] array, int positionX, int positionY)
        {
            {
                int temp;
                temp = array[positionX];
                array[positionX] = array[positionY];
                array[positionY] = temp;
            }

        }

        public static int[] Prepare(int arraySize)    // takes an integer input and creates an array with that size and returns and sends it to the randomize function and fill it with values
        {
            int[] array = new int[arraySize];
            Randomize(array);
            return array;
        }

        public static void Randomize(int[] array) // takes an array and randomize its values.
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10 * array.Length);
            }

        }

        #region searching algos

        public static void BubbleSort(int[] array)  // bubble sort takes an array as input calls swap func
        {

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        Swap(array, j + 1, j);  // calls swap function sends 3 values
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            int Min = 0;  //Step 1 − Set MIN to location 0 
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[Min] > array[j])
                    {
                        Min = j; // keeps track of the index for the minimum value.
                    }
                }
                Swap(array, i, Min);   // calls the swap function and sends 3 value

            }
        }

        public static void InsertionSort(int[] array) // takes an array as input
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j;
                var insertionValue = array[i];
                for (j = i; j > 0; j--)
                {
                    if (array[j - 1] > insertionValue)
                    {
                        array[j] = array[j - 1];
                    }
                }
                array[j] = insertionValue;
            }

        }

        public static void MergeSort(int[] array)
        {

        }





        #endregion





    }

}