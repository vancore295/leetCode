using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Peoblems
{
    public class RussianDoll
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            if (envelopes.Length == 1)
                return 1;
            if (envelopes.Length == 0)
                return 0;

            int maxCount = 0;
            int count = 1;
            envelopes = envelopes.OrderBy(inner => inner[0]).ToArray();

            for (int i = 0; i < envelopes.Length; i++)
            {
                int l_1 = envelopes[i][0];
                int w_1 = envelopes[i][1];

                for (int j = i; j < envelopes.Length; j++)
                {
                    int l_2 = envelopes[j][0];
                    int w_2 = envelopes[j][1];
                    if ((l_1 < l_2) && (w_1 < w_2))
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
                count = 0;
            }

            if (maxCount == 0)
                maxCount = 1;

            return maxCount;
        }
    }
}
