using System;
using System.ComponentModel.Design;
using System.Diagnostics;

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
                array[i] = rnd.Next(0, 10 * array.Length); // 10 times
            }

        }

        #region searching algos

        public static void BubbleSort(int[] array)  // bubble sort takes an array as input calls swap func  0(n2)
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

        #region MergeSort
        public static void Sort(int[] array, int right, int left)
        {
            int mid;
            if (right > left)     //low >= high is the base case, i.e. there is 0 or 1 item   
            {
                mid = (right + left) / 2;
                Sort(array, left, mid);          // divide numbers into two halves   and 
                Sort(array, (mid + 1), right);   //recursively sort them   
                Merge(array, left, (mid + 1), right);    // conquer ,merge two sorts halves
            }
        }

        public static void Merge(int[] array, int left, int mid, int right)  //a recursive function to merge numbers[left,mid] and numbers[mid+1,right] into numbers[left,right]
        {
            int[] temp = new int[25];    // temp is a temporary array to store result
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right)) //merging when tow halves have unsorted items
            {
                if (array[left] <= array[mid])
                    temp[tmp_pos++] = array[left++];
                else
                    temp[tmp_pos++] = array[mid++];
            }
            while (left <= left_end) temp[tmp_pos++] = array[left++]; //remaining items are copied into temp
            while (mid <= right) temp[tmp_pos++] = array[mid++];
            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right]; right--; 

            }
            //Merged result are copied back //into array[]
        }

        #endregion MergeSort


        public static void QuickSort(int[] array, int left, int right) // uses the function Partition
        {
            if (left > right || left < 0 || right < 0) return;

            int index = Partition(array, left, right);

            if (index != -1)
            {
                QuickSort(array, left, index - 1);
                QuickSort(array, index + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            if (left > right) return -1;

            int end = left;

            int pivot = array[right];    // choose last one to pivot, easy to code
            for (int i = left; i < right; i++)
            {
                if (array[i] < pivot)
                {
                    Swap(array, i, end);
                    end++;
                }
            }

            Swap(array, end, right);

            return end;
        }
        #endregion Algorithms

        #region Delegates      
        public delegate void Pointer(int[] array);
        public delegate void Multi(int[] array, int left, int right);

        //bubbleSort, insertionSort, selectionSort
        public void DisplayRuningTime(Pointer pointer, int[] array)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            pointer(array);
            sWatch.Stop();
            TimeSpan tS = sWatch.Elapsed;

            Console.WriteLine(string.Format("Sorted Array: [{0}].", string.Join(", ", array)));
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                tS.Hours, tS.Minutes, tS.Seconds, tS.Milliseconds);
        }
        #endregion Delegates

        //quick, merge sort
        public void DisplayRuningTime(Multi multi, int[] array)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            multi(array,0, array.Length -1);
            sWatch.Stop();
            TimeSpan tS = sWatch.Elapsed;

            Console.WriteLine(string.Format("Sorted Array: [{0}].", string.Join(", ", array)));
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                tS.Hours, tS.Minutes, tS.Seconds, tS.Milliseconds);
        }


        //Example
        //   public delegate void myDelegate(object source, EventArgs args);
        // public event myDelegate delegated;
        // https://www.youtube.com/watch?v=jQgwEsJISy0&t=1194s






    }

}