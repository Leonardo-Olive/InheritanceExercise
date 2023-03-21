using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            //DONE  give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            //DONE  give this class 4 members that are specific to Bird
            //DONE  Set this class to inherit from your Animal Class

            //DONE  Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            //DONE  Set this class to inherit from your Animal Class




            /* DONE Create an object of your Bird class
             * DONE  give values to your members using the object of your Bird class
             *  
             * DONE Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.Color = "Black";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 2.5;

            /*DONE Create an object of your Reptile class
             *DONE   give values to your members using the object of your Reptile class
             *  
             * DONE Creatively display the class member values 
             */

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, lizard }
;
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Breed: {animal.Breed}");
                Console.WriteLine($"It is {animal.Age} years old.");
                Console.WriteLine($"It has {animal.LegCount} legs.");
                Console.WriteLine($"It is a {animal.Type}.");
                Console.WriteLine($"");
            }
            
        }
    }
}
