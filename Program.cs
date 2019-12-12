using System;
using System.Collections.Generic;

namespace Actions.Plant {
    class Program { 
        static void Main()
        {
            
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