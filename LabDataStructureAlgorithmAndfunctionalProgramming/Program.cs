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
            bool showMenu = true;
            while (showMenu)
            {  
                showMenu = Algoritmer.MainMenu();

            }




        }

      
    }
}











