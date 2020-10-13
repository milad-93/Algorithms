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
        private static StringBuilder messages = new StringBuilder(); // can use anywhere
        private static  int[] array; // can use anywhere

        static void Main(string[] args)
        {                         
             DeclareArray();            
             DisplayMenu();
          
          
        }

        private static void DeclareArray() //calling class algoritm creating int[] array  stored static in class reachable.
        {       
            int arraySize;
            try
            {
                Console.Write("Input Size of an array: ");
                arraySize = Convert.ToInt32(Console.ReadLine());
                array = Algoritmer.Prepare(arraySize);
                Console.Clear();
                Console.WriteLine("ArraySize = [{0}] \n", arraySize);
            }
            catch
            {              
                Console.WriteLine("Input must be an integer\n");
                DeclareArray();
            }
            
          
        }


        #region using delegate Functions from Algoritmer class
        private static void UseInsertionSort() // delegate invoke with runningtime
        {
            messages.AppendLine("---[InsertionSort]---");
            Console.WriteLine(messages);
            Algoritmer.SingleValuepointer delegate1 = Algoritmer.InsertionSort;
            Algoritmer.DisplayRuningTime(delegate1, array);
            messages.Clear();
        }

        private static void UseBubbleSort() // delegate invoke with runningtime
        {
            messages.AppendLine("---[BubbleSort]---");
            Console.WriteLine(messages);
            Algoritmer.SingleValuepointer delegate2 = Algoritmer.BubbleSort;
            Algoritmer.DisplayRuningTime(delegate2, array);
            messages.Clear();
        }

        private static void UseSelectionSort() // delegate invoke with runningtime
        {
            messages.AppendLine("---[SelectionSort]---");
            Console.WriteLine(messages);
            Algoritmer.SingleValuepointer delegate3 = Algoritmer.SelectionSort;
            Algoritmer.DisplayRuningTime(delegate3, array);
            messages.Clear();

        }
        private static void UseMergeSort() // delegate invoke with runningtime
        {
             messages.AppendLine("---[MergeSort]---");
             Console.WriteLine(messages);
             Algoritmer.MultiValuePointer delegate4 = Algoritmer.Sort;
             Algoritmer.DisplayRuningTime(delegate4, array);
             messages.Clear();

        }
        private static void UseQuickSort() // delegate invoke with runningtime
        {
            messages.AppendLine("---[QuickSort]---");
            Console.WriteLine(messages);
            Algoritmer.MultiValuePointer delegate5 = Algoritmer.QuickSort;
            Algoritmer.DisplayRuningTime(delegate5, array);
            messages.Clear();
        }

        public static void UseLambdaSort() //lambda sort in place // MÅSTE FIXAS
        {
            messages.AppendLine("---[Lamda Sort]---");
            Console.WriteLine(messages);
            Algoritmer.SingleValuepointer delegate6 = Algoritmer.LambdaSort;
            Algoritmer.DisplayRuningTime(delegate6,array);
            messages.Clear();


        }
        #endregion

        #region Menu
        private static void DisplayMenu()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();

            }
            Console.Clear();
        }
        private static bool MainMenu() //Menu
           {
                  
            Console.WriteLine("How do you want to sort the Array?");
            Console.WriteLine("1) InsertionSort");
            Console.WriteLine("2) BubbleSort");
            Console.WriteLine("3) SelectionSort");
            Console.WriteLine("4) MergeSort");
            Console.WriteLine("5) QuickSort");
            Console.WriteLine("6) LambdaSort");
            Console.WriteLine("7) Declare another arraySize?");          
            Console.WriteLine("8) Exit");
            Console.Write("\r\nSelect an option: ");
            

            switch (Console.ReadLine())
               {
                  
                case "1":
                   // INSERTIONSORT
                    UseInsertionSort();
                    return true;
                   
                case "2":
                    //BUBBLESORT
                    UseBubbleSort();                 
                    return true;
                   
                case "3":
                    //SELECTIONSORT
                    UseSelectionSort();

                    return true;
                
                case "4":
                    //MergeSort
                    UseMergeSort();
                    return true;

                case "5":
                    //quickSort
                    UseQuickSort();
                    return true;
                
                case "6":
                    //lambda sort
                    UseLambdaSort(); 
                    return true;
                case "7":
                    DeclareArray(); // declaring new array then calling menu again                                 
                    DisplayMenu();
                    return true;
                case "8":
                   
                    return false; //Exit

                default:
                       return true;
               }

            
           } 

        #endregion Menu

    }
}











