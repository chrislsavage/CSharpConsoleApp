using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SearchLibrary
{
    public class Search : ISearch
    {
        public List<string> GetSearchResult(string searchPhrase)
        {
            searchPhrase = searchPhrase.ToUpper();

            List<string> sports = new List<string> { "Football",
              "Volleyball", "Basketball", "Badminton", "Baseball",
              "Swimming", "Rugby", "American Football", "Hockey", "Cricket" };

            List<string> results = new List<string>();
            results = (from sport in sports
                       where sport.StartsWith(searchPhrase)
                       select sport).ToList();

            return results;
        }
    }
}