using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber6Notification
{
    /*
     * 1- Delegate: A delegate is a type that represents 
     *  references to methods with a particular parameter 
     *  list and return type. (type-safe function pointer)
     *  
     * 2- Generic Delegate: A generic delegate is a delegate that accepts 
     *    any method with and paramters and return type based on initilization.
     *    public delegate T Delegate<T>(T a, T b, ....);
     *    Delegate<int> addDelegate = new Delegate<int>(math.Add);
     *    
     * 3- BuiltIn Delegates: 
     *      a- Action: A delegate that takes parameters up to 16 and all is Generic
     *                  and does not return a value (void).
     *          Action<int,int> add = new Action<int,int>(math.Add);
     *      b- Func: A delegate that takes parameters up to 
     *               16 and all is Generic and returns a value that is generic.
     *         Func<int,int,int> add = new Func<int,int,int>(math.Add);
     *         
     * 4- Callback Delegate: A delegate that is used to notify the caller
     *               ( call a function in the caller) when an event happens.
     *               
     * 5- Multicast Delegate: A delegate that can hold the reference of multiple
     *                          functions
     * 
     * 6- You can -= & += to remove and add a function to a delegate
     *      and it is alternative to Delegate.Combine and Delegate.Remove
     *      
     * 7- Event : An event is a way to notify the caller when an event happens
     *            it is a callback mechanism and it adds Add_Delegate 
     *            and Remove_Delegate methods
     *            
     * 9- EventArgs: A class that is used to pass the data from the event/callee
     *              to the caller class.
     * 
     * 10- EventHandler: built-in delegate that is used to notify the caller
     *                  and accepts an object and and class the extends EventArgs
     * 
     */
    internal class Car
    {
        public string DriverName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        private bool isExploded = false;

        //public delegate void NotifyDriver(object obj, CarEventArgs eventArgs);

        //(object obj, EventArgs eventArgs) notifyDriver;
        //Add_Delegate
        //Remove_Delegate
        public EventHandler<CarEventArgs> _IsAboutToExplode;
        public EventHandler<CarEventArgs>  _CarExploded;

        //public void RegisterNotifier(NotifyDriver notifier)
        //{
        //    notifyDriver += notifier;
        //    //notifyDriver = Delegate.Combine(notifier, notifyDriver) as NotifyDriver;    
        //}

        //public void UnRegisterNotifier(NotifyDriver notifier)
        //{
        //    notifyDriver -= notifier;
        //}

        //public void Add_NotifyDriver(NotifyDriver notifier)
        //{
        //    notifyDriver += notifier;
        //}

        //public void Remove_NotifyDriver(NotifyDriver notifier)
        //{
        //    notifyDriver -= notifier;
        //}

        public Car(string name, int currentSpeed, int MaxSpeed)
        {
            this.DriverName = name;
            this.CurrentSpeed = currentSpeed;
            this.MaxSpeed = MaxSpeed;
        }

        public void Accelerate(int delta)
        {
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero");
            }

            if (isExploded)
            {
                _CarExploded?
                 .Invoke(this,
                         new CarEventArgs( "The car has exploded",
                         DateTime.Now));  
            }
            // 90 
            if (MaxSpeed - CurrentSpeed == 10)
            {
                _IsAboutToExplode?
                  .Invoke(this,
                          new CarEventArgs("You are about to reach the maximum speed",
                          DateTime.Now)); 
            }

            if (CurrentSpeed + delta > MaxSpeed)
            {
                this.isExploded = true;
            }
            else
            {
                CurrentSpeed += delta;
                Console.WriteLine($"Current Speed is {CurrentSpeed}");
            }
        }
    }
}
