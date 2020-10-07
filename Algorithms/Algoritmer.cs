using System;

namespace Algorithms
{
    public class Algoritmer
    {

        #region Swapping 2 values from userinput
        public static void Swap()
        {
            int positionX, positionY;
            int[] numberArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            Console.WriteLine("To swap Position of array enter 2 numbers");
            Console.WriteLine("Position 1");
            positionX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Position 2");
            positionY = Convert.ToInt32(Console.ReadLine());

            try
            {
                int temp;
                temp = numberArray[positionX];
                numberArray[positionX] = numberArray[positionY];
                numberArray[positionY] = temp;

                foreach (var item in numberArray)
                {
                    Console.WriteLine("[ {0} ]", item);
                }
                Console.WriteLine("Ändrade positioner i arrayn var {0} och {1}", positionX, positionY);
            }
            catch (Exception x)
            {
                Console.WriteLine("Värderna sträcker sig utanför arrayns storlek ", x);

            }
            // apply lambda to not destory original array?
        }
        #endregion

        #region Randomize an array of 10 spaces
        public static void Randomize()
        {
            Random rnd = new Random();
            int[] array = new int[10];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
            }

            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
        }
        #endregion


        #region choose the size of array then loop
        public static void Prepare()    // behöver väl ingen input till metoden? allt kan skötas i metoden?
        {
            Random rnd = new Random();
            int arraySize;
            int[] array;

            try
            {
                Console.WriteLine("How big do you want your array to be please input a integer");
                arraySize = Convert.ToInt32(Console.ReadLine());
                array = new int[arraySize];

                for (int i = 0; i < array.Length; i++)
                {
                    // i also max the range number the same as the input array size! so it randoms up to that number
                    array[i] = rnd.Next(1, arraySize);
                }

                foreach (int item in array)
                {
                    Console.WriteLine("[ {0} ]", item);
                }
            }
            catch
            {
                Console.WriteLine("No strings allowed!!");
            }
        }

        #endregion
        #region menu

        public static bool MainMenu()
        {
            // Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Swap");
            Console.WriteLine("2) Randomize");
            Console.WriteLine("3) Prepare");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nSelect an option: ");


            switch (Console.ReadLine())
            {
                case "1":
                    Swap();
                    return true;
                case "2":
                    Randomize();
                    return true;
                case "3":
                    Prepare();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

        #endregion Menu
    }
}
