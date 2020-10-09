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
                // object of my DLL   
            Algoritmer Algoritmer = new Algoritmer();    
            // MENU FROM dll       
          
            int x, y;
            int[] numberArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            Console.WriteLine("To swap Position of array enter 2 numbers");
            Console.WriteLine("Position 1");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Position 2");
            y = Convert.ToInt32(Console.ReadLine());
            Algoritmer.Swap(numberArray, x, y);


            




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











