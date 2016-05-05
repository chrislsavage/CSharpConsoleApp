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
            view.List();
            Input(myInventory);
        }

        public void Input(Inventory inventory)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    inventory.ListItems();
                    Run();
                    break;
                case "2":
                    view.AddItemName();
                    string name = Console.ReadLine();
                    view.AddItemPrice();
                    string strPrice = Console.ReadLine();
                    decimal price = Convert.ToDecimal(decimal.Parse(strPrice).ToString("N"));
                    inventory.AddItem(new Product { Name = name, Price = price });
                    Run();
                    break;
                case "3":
                    view.Delete();
                    inventory.ListItems();
                    int num = Convert.ToInt16(Console.ReadLine()) ;
                    if (num > inventory.ListCount)
                    {
                        inventory.DeleteItem(num - 1);
                        view.List();
                    }
                    else
                    {
                        view.Error();
                    }

                    Run();
                    break;
                case "4":
                    view.End();
                    break;
                default:
                    view.Error();
                    Run();
                    break;
            };
        }
    }
}
