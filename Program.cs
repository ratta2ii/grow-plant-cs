using System;
using System.Collections.Generic;

namespace Actions.Plant {
    class Program { 
        static void Main()
        {

            Console.WriteLine("Choose how you would like to care for your plant today: Press 1 for FEED; Press 2 for WATER, or Press 3 for FULL SERVICE.");
            int userPick = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I am the user pick: " + userPick);

            Console.WriteLine("I am a new plant object, displaying one property");
            Plant ficus = new Plant("Ficus");
            Console.WriteLine(ficus.PlantName);
            ficus.FullService();
            Console.WriteLine("-------------------------------");

            Console.WriteLine("I am the DisplayProperties method");
            Console.WriteLine(ficus.DisplayProperties());
            Console.WriteLine("-------------------------------");

            Console.WriteLine("I am calling the FullService method");
            ficus.FullService();
            Console.WriteLine(ficus.DisplayProperties());

            Console.WriteLine("-------------------------------");
            Console.WriteLine("I am the ThrowRandomStorm method");
            ficus.ThrowRandomStorm();   
            Console.WriteLine(ficus.DisplayProperties());  
            
        }
    }
}