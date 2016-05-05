using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SearchLibrary; //Forget not to import this namespace

namespace ConsoleSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#### Interface based Programming example");

            ISearch mySearch = new Search();
            List<string> results = mySearch.GetSearchResult("F");
            Console.WriteLine("Search results: ");
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}


namespace SearchLibrary
{
    interface ISearch
    {
        List<string> GetSearchResult(string searchPhrase);
    }
}