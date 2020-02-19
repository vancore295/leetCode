using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Peoblems
{
    public class ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            List<string> itinerary = new List<string>();

            var firstStop = tickets.Where(l => l[0] == "JFK").ToList();
           
            foreach(var fs in firstStop)
            {
                var nextStop = FindNextStop(fs, tickets);
            }

            return itinerary;
        }

        private string[] FindNextStop(IList<string> firstStop, IList<IList<string>> tickets)
        {
            List<string> cities = new List<string>();
            cities.Add(firstStop[0]);

            var nextStop = tickets.Where(t => t[0] == firstStop[1]).FirstOrDefault();
            cities.Add(nextStop[0]);

            return cities.ToArray();
        }
    }
}
