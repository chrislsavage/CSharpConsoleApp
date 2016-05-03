using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface Consoler
        // interfaces can only contain function declarations
    {

    }

    class Program
    {
        View view = new View();
        Inventory myInventory = new Inventory();
        static void Main(string[] args)
        {
            Program.view.Introduction();
            int input = Console.Read();
            
        }

        static void Input(int num)
        {
            switch (input)
            {
                case 1:
                    myInventory.ListItems();
                    break;
                default:
                    Console.WriteLine("That is not an option. Please try again")


            }
        }
    }
}

