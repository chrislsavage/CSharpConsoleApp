using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Inventory
    {
        private List<Product> Items;

        public Inventory()
        {
            Items = new List<Product>();
            Items.Add(new Product() { Name = "Container", Price = 0 });
        }
        public void AddItem(Product item)
        {
             Items.Add(item);
        }

        public void DeleteItem(int num)
        {
            Items.RemoveAt(num);
        }

        public void ListItems()
        {
            int counter = 1;
            foreach (var item in Items)
            {
                Console.WriteLine($"{counter}: Name: {item.Name}, Price: {item.Price}");
                counter += 1;
            }
        }

        public string ss = "ooo";

        public string s
        {
            get
            {

                return "x";
            }

            set
            {
            }
        }
    }
}
