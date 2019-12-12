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
         Health = 1;  // Baby plants at minimum health
         Age = 1; 
       }

       public string DisplayProperties()
       {
         return "Name: "+ PlantName + " Health: " + Health + " Age: "+ Age;
       }

       private void WaterPlant(string currentStorm)
       {  
         string currentStorm = ThrowRandomStorm();
         if (currentStorm == "flood") 
         {
           Health -= 2;  
         }
         if (currentStorm == "heat storm")
         {
           Health += 2;   
         }
         else
         {
           Health += 1;
         }    
         
       }

       private void GiveNutrients()
       {
         string currentStorm = ThrowRandomStorm(); 
         if (currentStorm == "flood")
         {
           return false;  
         } 
         else if (currentStorm == "snow storm")
         {
           Health++;
         }
         else 
         {
           Health += 2;  
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
          if (Health > 8)
          {
            Health -= 1;  
          }
          else
          {
            Health -= 2;
          }  
          
        }

        private void HeatStorm()
        {
          if (Health > 8)
          {
            Health -= 1;  
          }
          else
          {
            Health -= 2;
          }
        }

         private void SnowStorm()
        {
          if (Health > 8)
          {
            Health -= 1;  
          }
          else
          {
            Health -= 2;
          }
        }
        public string ThrowRandomStorm()
        {
           int ourRandomNumber = RandomNumber();
           if (ourRandomNumber == 1)
           {
             Flood();
             return "flood";
           }
           else if (ourRandomNumber == 2)
           {
             HeatStorm();
             return "heat storm";
           }
           else
           {
             SnowStorm();
             return "snow storm";
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