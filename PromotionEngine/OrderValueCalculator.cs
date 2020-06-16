using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{    
    public class OrderValueCalculator : IOrderValueCalculator
    {
        public int Calculate(List<char> orderList)
        {
            int result = 0;
            if (orderList == null || orderList.Count() == 0)
                return result;

            var aggList = orderList.GroupBy(x => x).ToDictionary(k => k.Key, k => k.Count());

            // 3 of A's for 130
            var aCount = aggList.FirstOrDefault(x => x.Key == 'A').Value;
            int newCountOfA = aCount % 3;
            result = (aCount / 3) * 130;
            aggList['A'] = newCountOfA;

            // 2 of B's for 45
            var bCount = aggList.FirstOrDefault(x => x.Key == 'B').Value;
            result += (bCount / 2) * 45;
            int newCountOfB = bCount % 2;
            aggList['B'] = newCountOfB;

            // C & D for 30
            int cCount = aggList.FirstOrDefault(y => y.Key == 'C').Value;
            int dCount = aggList.FirstOrDefault(y => y.Key == 'D').Value;
            int offer = cCount > 0 && dCount > 0 ? cCount & dCount : 0;
            int diff = cCount ^ dCount;
            result += offer * 30;
            if (cCount > dCount)
            {
                aggList['C'] = diff;
                aggList['D'] = 0;
            }
            else if(dCount > cCount)
            {
                aggList['D'] = diff;
                aggList['C'] = 0;
            }
            else
            {   
                aggList['C'] = aggList['D'] = 0;
            }

            // Calculate individual SKU values
            result += aggList
                .Join(SKU.SKUTypes, k => k.Key, s => s.Key, (k, s) => new { k, s })
                .Sum(x => x.k.Value * x.s.Value);

            return result;
        }
    }
}
