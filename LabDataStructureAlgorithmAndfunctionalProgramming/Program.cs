using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Algorithms;


namespace LabDataStructureAlgorithmAndfunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {            
            int arraySize;
            int[] array;
            
            Console.WriteLine("Mata in en array Storlek");        
            arraySize = Convert.ToInt32(Console.ReadLine());                       
            array  = Algoritmer.Prepare(arraySize);

            // insertion sort
            Console.WriteLine("InsertionSort");
            Algoritmer.Pointer del = Algoritmer.InsertionSort;
            Algoritmer.DisplayRuningTime(del, array);

            //bubble sort
            Console.WriteLine("bubbleSort");
            Algoritmer.Pointer de2 = Algoritmer.BubbleSort;
            Algoritmer.DisplayRuningTime(de2, array);

            //selectionSort
            Console.WriteLine("SelectionSort");
            Algoritmer.Pointer de3 = Algoritmer.SelectionSort;
            Algoritmer.DisplayRuningTime(de3, array);







            /*        bool showMenu = true;
                    while (showMenu)
                    {
                        showMenu =MainMenu();

                    } */

        }


        #region menu

     /*   public static bool MainMenu()
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
                   Algoritmer.Swap();
                    return true;
                case "2":
                   // Randomize();
                    return true;
                case "3":
             //       Prepare();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        } */

        #endregion Menu

    }
}











