using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Inventory
    {
        public List<Product> items { get; set; }

        public Inventory()
        {
             items = new List<Product>
            {
                new Product() {Name= "Container", Price = 0}
            };
        }


        public void AddItem(Product item)
        {
             items.Add(item);
        }

        public void DeleteItem(Product item)
        {
            items.Remove(item);
        }

        public void ListItems()
        {
            foreach(var item in this.items)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
            }
        }
    }
}
