using System;
using System.Collections.Generic;

namespace Actions.Plant {
   class Plant {
       public string PlantName { get; set; }
       public int Health { get; set; }
       public int Size { get; set; }

       public Plant(string name)
       {
           PlantName = name;
           Health = 1;  // Baby plants at 50% Health
           Size = 1; 
       }

       public string DisplayProperties()
       {
           return "Name: "+ PlantName + " Health: " + Health + " Size: "+ Size;
       }

       private void WaterPlant()
       {
             Health++; 
       }

       private void GiveNutrients()
       {
           Health += 2;
           if (Health > 5)
           { 
               Size += 2;
           }
           else
           {
               Size += 1;
           }
       }

       private void SpeakToPlant()
       {
           Health += 1;
       }

       public bool FullService()
       {
           WaterPlant();
           GiveNutrients();
           SpeakToPlant();
           return true; //WTF
       }

        private void Flood()
        {
            Health -= 2;
        }

        private void HeatStorm()
        {
            Health -= 2;
        }

        public void ThrowRandomStorm()
        {
           int ourRandomNumber = RandomNumber();
           if (ourRandomNumber == 1)
           {
               Flood();
           }
           else if (ourRandomNumber == 2)
           {
               HeatStorm();
           }
           else
           {
               SnowStorm();
           }
        
        }

        public static int RandomNumber()
        {
            Random randomObject = new Random();
            int RandomNumber  = randomObject.Next(1, 4);
            return RandomNumber;
        }

        
   } 
}