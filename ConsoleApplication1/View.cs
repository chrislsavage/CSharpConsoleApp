using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class View
    {
        static void Introduction()
        {
            Console.WriteLine("Product Inventory:");
            Console.WriteLine("");
            Console.WriteLine("Choose an Numbered Option");
            Console.WriteLine("1) List Inventory");
            Console.WriteLine("2) Add Inventory");
            Console.WriteLine("3) Delete Inventory");
        }

        static void AddItemName()
        {
            Console.WriteLine("What is the name of the product to add?");
        }
    }
}
