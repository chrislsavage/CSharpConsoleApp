using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Inventory
    {
        public List<Product> Items { get; set; }

        public Inventory()
        {
             Items.Add(
                new Product() {Name= "Container", Price = 0}
            );
        }
        public void AddItem(Product item)
        {
             Items.Add(item);
        }

        public void DeleteItem(Product item)
        {
            Items.Remove(item);
        }

        public void ListItems()
        {
            foreach (var item in this.Items)
            {
                int counter = 1;
                Console.WriteLine($"{counter}: Name: {item.Name}, Price: {item.Price}");
                counter += 1;
            }
        }
    }
}
