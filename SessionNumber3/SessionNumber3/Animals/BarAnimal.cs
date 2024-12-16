using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    // abstract class => it is a special class that defines contracts for the child classes
    /*
     * 1- can have default implementation for the functions
     * 2- can have abstract methods and the drived classes mush implment it 
     * 
     * 
     * 
     * 
     */
    public abstract class BarAnimal
    {
        public int fasla { get; set; }
        public void CanSwim()
        {
            Console.WriteLine("I can Swim");
        }

        public abstract void CanBreathUnderWater();

    }
}
