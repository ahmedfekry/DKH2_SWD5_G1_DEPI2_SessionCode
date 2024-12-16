using SessionNumber3.Animals;
using SessionNumber3.Interface;
using SessionNumber3.Production;
using System;

namespace SessionNumber3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class => blueprint

            /* Object Oriented Programming
             * 
             * 1- Inheritance => the child class inherits all the parent function and properties
             *  you can use the sealed keyword to enforce that no one can inherit from your class
             *  
             * 2- Encapsulation
             * 3- polymorphism
             * 
             * 
             * 
             * 
             */

            //Product obj = new Product("Pruct name", "cloths", 12);

            //obj.PrintProductDetails();

            //Animal animal = new Animal();
            //animal.Name = "Dog";
            //animal.Age = 15;

            //animal.CanEat();
            //animal.CanSleep();

            //Pets cat = new Pets();
            //cat.Name = "Dog";
            //cat.Age = 15;

            //cat.CanEat();
            //cat.CanSleep();
            //cat.CanPlayWithKids();

            //Animal animal = new Animal();
            //animal.Name = "Donky";
            //animal.CanEat();



            //Animal cat = new Pets("Cute cat", 12);
            //cat.Name = "Cute Cat";
            //cat.Age = 10;
            //cat.CanEat();


            BarAnimal barAnimal = new Horse();
            barAnimal.CanSwim();
            barAnimal.CanBreathUnderWater();

            Console.WriteLine("==================================");

            BarAnimal secondBarAnimal = new Aligator();
            secondBarAnimal.CanSwim();
            secondBarAnimal.CanBreathUnderWater();
            //cat.CanSleep();
            //cat.CanPlayWithKids();

            // "is-a" relationship
            //if (cat is Animal)
            //{
            //    Console.WriteLine("Yes can is animal");
            //}

            //cat.CanWalk();


            //WildAnimals cangro = new WildAnimals();
            //cangro.Name = "Wild Cangro";
            //cangro.Age = 10;
            //cangro.CanWalk(2);

            // Method overloading 
            // 1- multiple methods with the same name but with different paramters
            // 2- happens in the compile time

            // method overriding
            //1- multiple methods with the same name and paramters
            //2- happens in the run time 

            //Console.WriteLine();

            //Console.WriteLine("==============================");

            //WildAnimals Lion = new WildAnimals();
            //Lion.Name = "Carzy Lion";
            //Lion.Age = 10;
            //Lion.CanEat();
            //Lion.CanSleep();
            //Lion.CanEatHumans();

            Bird bird = new Bird();

            bird.CanWalk();
            bird.Breath();


        }
    }
}
