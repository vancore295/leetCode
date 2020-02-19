using Peoblems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LettCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vs = { 2, 7, 11, 15 };
            //int target = 9;
            //TwoSums twoSums = new TwoSums();
            //twoSums.TwoSum(vs, target);

            //int[] vs2 = { 1, 1, 0, 1, 1, 1 };
            //FindMaxConsecutive findMax = new FindMaxConsecutive();

            //findMax.FindMaxConsecutiveOnes(vs2);

            //int[][] vs3 =
            //    {
            //    new int[] { 5, 4 },
            //    new int[] { 6, 4 },
            //    new int[] { 6, 7 },
            //    new int[] { 2, 3 }
            //    };

            //int[][] vs3 =
            //    {
            //    new int[] { 4, 5 },
            //    new int[] { 6, 7 },
            //    new int[] { 2, 3 }
            //};

            //RussianDoll russianDoll = new RussianDoll();
            //russianDoll.MaxEnvelopes(vs3);

            //string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            //KeybaordRow keybaordRow = new KeybaordRow();

            //keybaordRow.FindWords(words);

            ReconstructItinerary reconstructItinerary = new ReconstructItinerary();
            IList<IList<string>> input = new List<IList<string>>();
            //input.Add(new List<string>(new string[] { "JFK", "SFO" }));
            input.Add(new List<string>(new string[] { "JFK", "ATL" }));
            input.Add(new List<string>(new string[] { "SFO", "ATL" }));
            input.Add(new List<string>(new string[] { "ATL", "JFK" }));
            input.Add(new List<string>(new string[] { "ATL", "SFO" }));
            input.Add(new List<string>(new string[] { "JFK", "SFO" }));

            reconstructItinerary.FindItinerary(input);
        }
    }
}
