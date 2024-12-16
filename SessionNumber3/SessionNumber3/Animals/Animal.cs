using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    public  class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal() {
            Console.WriteLine("This is the defualt constructor in the Animal class");
        }

        public Animal(string name,int age) {
            this.Name = name;
            this.Age = age;
            //Console.WriteLine("From the parent class");
        }

        public virtual void CanEat() {
            Console.WriteLine(this.Name + " is eating");
        }
        public void CanSleep() { 
            Console.WriteLine(this.Name + " is sleeping");
        }

        public void CanWalk()
        {
            Console.WriteLine("Can Walk on 4 legs");
        }

        public void CanWalk(int numberOfLegs)
        {
            Console.WriteLine($"Can walk on {numberOfLegs} legs");
        }
    }
}
