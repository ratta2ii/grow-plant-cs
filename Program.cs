using System;
using System.Collections.Generic;

namespace Actions.Plant {
    class Program { 
        static void Main()
        {
            Console.WriteLine("I am a new plant object, displaying one property");
            Plant ficus = new Plant("Ficus");
            Console.WriteLine(ficus.PlantName);

            Console.WriteLine("I am the displayed properties method");
            Console.WriteLine(ficus.DisplayProperties());
            Console.WriteLine("-------------------------------");

            Console.WriteLine("I am calling the full service method");
            Console.WriteLine(ficus.FullService());
            Console.WriteLine(ficus.DisplayProperties());

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Random Number below");
            Console.WriteLine(ficus.ThrowRandomStorm());     
            
        }
    }
}