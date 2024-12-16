using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Production
{
    /*
     * Private => property/function is accessable only inside the class
     * public => property/function is accessable inside the class and by any object
     * internal => class is accessable withen the same assembly
     * protected => property/function is accessable only inside the class and inherited classes
     * 
     * 
     * 
     * 
     * 
     */
    public class Product
    {
        private string _ProductName;
        public string ProductName {
            get
            {
                return _ProductName;
            }
            set
            {
                _ProductName = value;
            }
        }

        public string category;

        protected int Id { get; set; }


        public Product()
        {
            Console.WriteLine("From inside the default constructor");
        }

        public Product(string productName,int id)
        {
            this._ProductName = productName;
            this.Id = id;
        }

        public Product(string productName, string category, int id)
        {
            this.ProductName = productName;
            this.category = category;
            this.Id = id;
        }

        public void PrintProductDetails()
        {
            this.PerformCalculations(); 
            Console.WriteLine(this.ProductName);
            Console.WriteLine(this.category);
            Console.WriteLine(this.Id);
        }

        private void PerformCalculations()
        {
            Console.WriteLine(1 + 2);
        }

        public int PrintId()
        {
            return this.Id;
        }
    }
}
