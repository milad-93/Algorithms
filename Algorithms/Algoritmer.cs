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
     
        public static int[] Prepare(int arraySize)    // takes an integer input and creates an array with that size and sends it to the randomize function and fill it with values
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







    }

}