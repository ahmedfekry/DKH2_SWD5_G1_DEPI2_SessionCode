using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    internal class Pets : Animal
    {

        // derived constructor
        public Pets(string name,int age) : base(name,age) {
            //Console.WriteLine("From the child class");
        }

        public Pets(string name)
        {
            this.Name = name;
        }

        public override void CanEat()
        {
            Console.WriteLine(this.Name + " Can Eat vegitables");
        }

        public void CanPlayWithKids()
        {
            Console.WriteLine(this.Name + " is Playing with kids");
        }


    }
}
