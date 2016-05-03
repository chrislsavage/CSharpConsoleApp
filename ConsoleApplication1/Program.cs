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
        static void Main(string[] args)
        {
            Product bag = new Product();
            Console.WriteLine($"The Product's name is {bag.name}, and my price is {bag.price}" );
        }
    }
}

