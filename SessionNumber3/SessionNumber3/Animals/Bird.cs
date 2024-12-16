using SessionNumber3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Animals
{
    internal class Bird : Animal, IAnimal,ICreature
    {
        public int GetNumberOfLegs()
        {
            return 2;
        }

        public string MakeSound()
        {
            return "Sow sow sow";
        }
        
        public string Breath()
        {
            return "I can Breath in the air only";
        }
    }
}
