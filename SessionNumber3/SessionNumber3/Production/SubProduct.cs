using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Production
{
    public class SubProduct : Product
    {
        public void printProduct()
        {
            Console.WriteLine(this.Id);
        }
    }
}
