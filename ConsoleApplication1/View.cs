using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class View
    {
        public void List()
        {
            Console.WriteLine("Choose an Numbered Option");
            Console.WriteLine("1) List Inventory");
            Console.WriteLine("2) Add Inventory");
            Console.WriteLine("3) Delete Inventory");
            Console.WriteLine("4) End");
        }

         public void AddItemName()
        {
            Console.WriteLine("What is the name of the product to add?");
        }

        public void AddItemPrice()
        {
            Console.WriteLine("What is the price of the product?");
        }

        public void Delete()
        {
            Console.WriteLine("Which item would you like to delete?");
        }

        public void End()
        {
            Console.WriteLine("End Program");
        }

        public void Error()
        {
            Console.WriteLine("That is not an option. Please try again");
        }
    }
}
