using System;
using System.Collections.Generic;

namespace Actions.Plant {
   class Plant {
       public string PlantName { get; set; }
       public int Health { get; set; }
       public int Age { get; set; }

       public Plant(string name)
       {
           PlantName = name;
           Health = 1;  // Baby plants at minimum health Health
           Age = 1; 
       }

       public string DisplayProperties()
       {
           return "Name: "+ PlantName + " Health: " + Health + " Age: "+ Age;
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
               Age += 2;
           }
           else
           {
               Age += 1;
           }
       }

       private void SpeakToPlant()
       {
           Health += 1;
       }

    
       public void FullService()
       {
           WaterPlant();
           GiveNutrients();
           SpeakToPlant();
       }

        private void Flood()
        {
            Health -= 2;
        }

        private void HeatStorm()
        {
            Health -= 2;
        }

         private void SnowStorm()
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