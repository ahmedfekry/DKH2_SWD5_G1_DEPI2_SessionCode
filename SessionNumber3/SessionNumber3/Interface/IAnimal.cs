using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Interface
{
    // interface => is special class contains only definations/contacts for the methods
    /*
     * 1- class the implement the interface must implement all the contacts in the interface
     * 2- class can implement multiple interfaces
     * 3- can have defualt implement (but it is not recommended)
     * 
     * 
     * 
     * 
     */
    internal interface IAnimal
    {
        public int GetNumberOfLegs();
        public string MakeSound(); 

    }
}
