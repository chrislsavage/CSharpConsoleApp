using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Controller
    {
        Inventory myInventory = new Inventory();
        View view = new View();
        public void Run()
        {
            view.Introduction();
            Input(myInventory);
        }

        public void Input(Inventory inventory)
        {
            int input = Console.Read();
            switch (input)
            {
                case 1:
                    inventory.ListItems();
                    break;
                case 2:
                    view.AddItemName();
                    string name = Console.ReadLine();
                    view.AddItemPrice();
                    double price = Convert.ToDouble(Console.ReadLine());
                    inventory.AddItem(new Product { Name = name, Price = price });
                    break;
                case 3:
                     
                default:
                    Console.WriteLine("That is not an option. Please try again");
                    Run();
                    break;
            };
        }
    }
}
